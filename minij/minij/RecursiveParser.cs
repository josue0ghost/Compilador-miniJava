using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minij
{
    class RecursiveParser
    {
        public List<KeyValuePair<string, string>> tokens;
        public List<KeyValuePair<string, string>> stack;
        KeyValuePair<string, string> actual;
        List<string> error = new List<string>();

        public RecursiveParser() { }

        public RecursiveParser(List<KeyValuePair<string, string>> input)
        {
            tokens = input;
            stack = new List<KeyValuePair<string, string>>();
            actual = tokens.First();
            tokens.Remove(actual);
        }

        public string Parse() 
        {
            Program();
            return string.Join("\n", error.ToArray()); 
        }

        public void GetNextToken()
        {
            if (tokens.Count > 0)
            {
                actual = tokens.First();
                tokens.Remove(actual);
            }
        }

        public void Revert()
        {
            int size = stack.Count();
            for (int i = 0; i < size; i++)
            {
                tokens.Insert(0, stack.Last());
                error.RemoveAt(error.Count - 1);
                stack.RemoveAt(stack.Count - 1);
            }
        }

        public void Match(string expected)
        {
            if (actual.Value.Equals(expected) || actual.Key.Equals(expected))
            {
                stack.Add(actual);
                GetNextToken();
            }
            else
            {
                Error(expected);
                GetNextToken();
            }
        }

        public void Error(string expected)
        {
            error.Add($"SYNTAX ERROR: TOKEN: {actual.Key}, expected {expected}, got {actual.Value}");
        }

        public void Program()
        {
            Decl();
        }

        public void Decl()
        {
            if (Declaration().Equals(false)) // true indica que la derivación corresponde a esta producción
            {
                error.RemoveAt(error.Count - 1);
            }
            
            if (Method().Equals(false))
            {
                error.RemoveAt(error.Count - 1);
            }
        }

        public bool Declaration()
        {
            if (actual.Value.Equals("T_ValueType"))
            {
                Type();
                Match("Token_Identifier");

                if (actual.Value.Equals(";"))
                {
                    Match(";");                   
                }
                else if (actual.Value.Equals("("))
                {
                    Match("(");
                    Formals();
                    Match(")");
                }
                else if (actual.Value.Equals("()"))
                {
                    Match("()");
                }

                return true;
            }
            else
            {
                Error("T_ValueType");
                return false; 
            }
        }

        public bool Method() 
        {
            if (actual.Value.Equals("T_void"))
            {
                Match("T_void");
                Match("Token_Identifier");

                if (actual.Value.Equals("("))
                {
                    Match("(");
                    Formals();
                    Match(")");
                }
                else if (actual.Value.Equals("()"))
                {
                    Match("()");
                }

                return true;
            }
            else
            {
                Error("T_ValueType");
                return false;
            }
        }

        public bool Formals()
        { 

            return false;  
        } 

        public bool FunctionDecl() 
        {
            if (actual.Value.Equals("T_ValueType"))
            {
                Type();
                Match("Token_Identifier");
                Match("(");

                // Formals es nullable
                if (!tokens.First().Value.Equals(")"))
                {
                    Formals();
                }                
                Match(")");
                Stmt();

                return true;
            }
            else if (actual.Value.Equals("T_void"))
            {
                Match("void");
                Match("Token_Identifier");
                Match("(");

                // Formals es nullable
                if (!tokens.First().Value.Equals(")"))
                {
                    Formals();
                }
                Match(")");
                Stmt();

                return true;
            }
            return false; 
        }


        public void Type() 
        {
            if (actual.Value.Equals("T_ValueType"))
            {
                if (tokens.First().Value.Equals("[]"))
                {
                    Match("T_ValueType"); // array
                    Match("[]");
                }
                else
                {
                    Match("T_ValueType"); // type normal
                }
            }
            else 
            {
                Error("T_ValueType");
            }

        }


        public void Stmt()
        {
            if (WhileStmt() && error.Count > 0)
            {
                error.Remove(error.Last());
            }
            else if (ReturnStmt() && error.Count > 0)
            {
                error.Remove(error.Last());
            }
        }

        public bool WhileStmt() 
        {
            if (actual.Value.Equals("T_KeyWord"))
            {
                Match("while");
                Match("(");
                MatchExpr();
                Match(")");
                Stmt();
                return true; 
            }
            else
            {
                Error("T_ValueType");
                return false;
            }
        }

        public bool ReturnStmt() 
        {
            if (actual.Value.Equals("T_KeyWord"))
            {
                Match("return");
                
                if (!tokens.First().Value.Equals(";"))
                {
                    MatchExpr();
                }
                Match(";");
            }
            return false; 
        }
 

        public bool MatchConstant(string sConst)
        {
            if (Regex.Match(sConst, RegularExpressions.intPattern).Success)
            {
                // es int
                return true;
            }
            else if (Regex.Match(sConst, RegularExpressions.doublePattern).Success)
            {
                // double
                return true;
            }
            else if (Regex.Match(sConst, RegularExpressions.boolean).Success)
            {
                // bool
                return true;
            }
            else if (Regex.Match(sConst, RegularExpressions.strPattern).Success)
            {
                // string
                return true;
            }
            else if (sConst == "null")
            {
                // null
                return true;
            }
            return false;
        }

        public bool MatchLValue(string token, string lookahead = "")
        {
            if (MatchIdent(token))
            {
                // id
                return true;
            }
            else if (true) // MatchExpr()
            {
                if (lookahead == ".")
                {
                    // MatchIdent
                    return true;
                }
                else if (lookahead == "[")
                {
                    // MatchExpr()
                    // if continues with "]" return correct
                    return true;
                }
            }
            return false;
        }

        public bool MatchIdent(string sConst)
        {
            return Regex.Match(sConst, RegularExpressions.idPattern).Success;
        }

        public void MatchExpr()
        {
            //MatchI();
            // MatchExpr_
        }

        public void MatchExpr_(string token)
        {
            if (token == "&&" || token == "||")
            {
                //MatchI
                //MatchExpr_
            }
            else // epsilon
            {

            }
        }

        public void MatchI()
        {
            //MatchH
            //MatchI_
        }

        public void MatchI_(string token)
        {
            if (token == "==" || token == "!=")
            {
                //MatchH
                //MatchI_
            }
            else // epsilon
            {

            }
        }

        public void MatchH()
        {
            //MatchG
            //MatchH_
        }

        public void MatchH_(string token)
        {
            if (token == "<" || token == ">" || token == "<=" || token == ">=")
            {
                //MatchG
                //MatchH_
            }
            else // epsilon
            {

            }
        }

        public void MatchG()
        {
            //MatchT
            //MatchG_
        }

        public void MatchG_(string token)
        {
            if (token == "+" || token == "-")
            {
                //MatchT
                //MatchG_
            }
            else // epsilon
            {

            }
        }

        public void MatchT()
        {
            //MatchF
            //MatchT_
        }

        public void MatchT_(string token)
        {
            if (token == "*" || token == "/" || token == "%")
            {
                //MatchF
                //MatchT_
            }
            else // epsilon
            {

            }
        }

        public void MatchF(string token, string lookahead)
        {
            if (token == "(") // (Expr)
            {
                MatchExpr();
                if (lookahead == ")")
                {
                    // todo nice
                }
            }
            else if (token == "this")
            {
                // this
            }
            else if (token == "-") // -Expr
            {
                // MatchExpr()
            }
            else if (token == "New(")
            {
                MatchIdent(lookahead);
                // if continues ")" then nice
            }
            else if (MatchConstant(token)) // MatchConstant()
            {

            }
            else if (MatchLValue(token))
            {
                if (lookahead == "=") // LValue = Expr
                {
                    // MatchExpr(lookahead2)
                }
                // LValue
            }

        }

    }
}