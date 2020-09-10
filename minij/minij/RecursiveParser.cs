using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace minij
{
    class RecursiveParser
    {
        public List<KeyValuePair<string, string>> tokens = new List<KeyValuePair<string, string>>();
        KeyValuePair<string, string> actual;
        List<string> error = new List<string>();

        public RecursiveParser() { }

        public RecursiveParser(List<KeyValuePair<string, string>> input)
        {
            tokens = input;
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

        public void Match(string expected)
        {
            if (actual.Value.Equals(expected))
            {
                GetNextToken();
            }
            else
            {
                Error(expected);
            }
        }

        public void Error(string expected)
        {
            error.Add($"SYNTAX ERROR: expected {expected}, got {actual.Value}");
        }

        public void Program()
        {
            Decl();
        }

        public void Decl()
        {
            if (VariableDecl() && error.Count > 0)
            {
                error.Remove(error.Last());
            }
            else if (FunctionDecl() && error.Count > 0)
            {
                error.Remove(error.Last());
            }
        }

        public bool VariableDecl()
        {
            bool flag = Variable();
            Match(";");
            return flag;
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

        public bool Variable() 
        {
            if (actual.Value.Equals("T_ValueType"))
            {
                Type();
                Match("Token_Identifier");               
                return true; 
            }
            else
            {
                Error("T_ValueType");
                return false; 
            }

        }

        public void Type() 
        {
            if (actual.Value.Equals("T_ValueType"))
            {
                Match("T_ValueType");
            }
            else if (tokens.First().Key.Equals("[]")) // array 
            {
                Match("T_ValueType");
                Match("[]");
            }
            else // variable
            {
                Error("T_ValueType");
            }

        }

        public void Formals()
        {
            Variable();

            if (tokens.First().Value.Equals(","))
            {
                Match(",");
            }

            if (tokens.First().Value.Equals("T_ValueType"))
            {
                Formals();
            }
        }

        public void Stmt()
        { 

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