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

            if (actual.Value.Equals("{") || actual.Value.Equals("}"))
            {
                if (tokens.Count > 0)
                {
                    GetNextToken();
                }
                else
                {
                    return;
                }
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
            error.Add($"SYNTAX ERROR: TOKEN: {actual.Key}. Expected {expected}, got {actual.Value}");
        }

        public void Program()
        {
            Decl();
        }

        public void Decl()
        {
            Declaration();
        }

        public void Declaration()
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
                    Stmt();
                }
                else if (actual.Value.Equals("()"))
                {
                    Match("()");
                    Stmt();
                }
            }
            else if (actual.Value.Equals("T_void"))
            {
                Match("T_void");
                Match("Token_Identifier");

                if (actual.Value.Equals("("))
                {
                    Match("(");
                    Formals();
                    Match(")");
                    Stmt();
                }
                else if (actual.Value.Equals("()"))
                {
                    Match("()");
                    Stmt();
                }
            }
            else
            {
                Error(actual.Value);
            }
        }


        public void Formals()
        {
            if (actual.Value.Equals("T_ValueType"))
            {
                Type();
                Match("Token_Identifier");
                
                if (actual.Value.Equals(","))
                {
                    Match(",");
                    Formals();
                }
            }
            else
            {
                Error("T_ValueType");
            }
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
            if (actual.Key.Equals("while"))
            {
                WhileStmt();
                Stmt();
            }
            else if (actual.Key.Equals("return"))
            {
                ReturnStmt();
                Stmt();
            }
            else if (actual.Value.Equals("("))
            {
                MatchExpr();
                Stmt();
            }
            else if (actual.Value.Equals("Token_Identifier"))
            {
                MatchExpr();
                Stmt();
            }
            else if (actual.Value.Equals("T_IntConstant"))
            {
                MatchExpr();
                Stmt();
            }
            else if (actual.Value.Equals("Token_Double"))
            {
                MatchExpr();
                Stmt();
            }
            else if (actual.Value.Equals("T_BooleanConstant"))
            {
                MatchExpr();
                Stmt();
            }
            else if (actual.Value.Equals("T_StringConstant"))
            {
                MatchExpr();
                Stmt();
            }
            else if (actual.Key.Equals("null"))
            {
                MatchExpr();
                Stmt();
            }
            else if (actual.Key.Equals("this"))
            {
                MatchExpr();
                Stmt();
            }
            else if (actual.Key.Equals("New"))
            {
                MatchExpr();
                Stmt();
            }
            else if (actual.Value.Equals("-"))
            {
                MatchExpr();
                Stmt();
            }
            else // si ninguno de los anteriores está stmt no viene. 
            {
                return;
            }
        }

        public void WhileStmt() 
        {
            if (actual.Value.Equals("T_KeyWord"))
            {
                Match("while");
                Match("(");
                MatchExpr();
                Match(")");
                Stmt();
            }
            else
            {
                Error("T_KeyWord");
            }
        }

        public void ReturnStmt() 
        {
            if (actual.Value.Equals("T_KeyWord"))
            {
                Match("return");
                
                if (!actual.Value.Equals(";"))
                {
                    MatchExpr();
                }
                Match(";");
            }
        }
 

        public void Constant(out bool match, bool matching = true)
        {
            if (actual.Value.Equals("T_IntConstant"))
            {
                match = true;
            }
            else if (actual.Value.Equals("Token_Double"))
            {
                match = true;
            }
            else if (actual.Value.Equals("T_BooleanConstant"))
            {
                match = true;
            }
            else if (actual.Value.Equals("T_StringConstant"))
            {
                match = true;
            }
            else if (actual.Value.Equals("null"))
            {
                match = true;
            }
            else
            {
                if (matching) Error("T_Constant");
                match = false;
            }
        }

        public void MatchLValue()
        {
            if (actual.Value.Equals("Token_Identifier"))
            {
                GetNextToken();
                return;
            }
            else 
            {
                MatchExpr();
                if (actual.Value.Equals("."))
                {
                    GetNextToken();
                    Match("Token_Identifier");
                }
                else if (actual.Value.Equals("["))
                {
                    GetNextToken();
                    MatchExpr();
                    Match("]");
                    GetNextToken();
                }
            }
        }

        public void MatchExpr()
        {
            MatchI();
            MatchExpr_();
        }

        public void MatchExpr_()
        {
            if (actual.Value.Equals("&&") || actual.Value.Equals("||"))
            {
                GetNextToken();
                MatchI();
                MatchExpr_();
            }
        }

        public void MatchI()
        {
            MatchH();
            MatchI_();
        }

        public void MatchI_()
        {
            if (actual.Value.Equals("==") || actual.Value.Equals("!="))
            {
                GetNextToken();
                MatchH();
                MatchI_();
            }
        }

        public void MatchH()
        {
            MatchG();
            MatchH_();
        }

        public void MatchH_()
        {
            if (actual.Value.Equals("<") || actual.Value.Equals(">") || actual.Value.Equals("<=") || actual.Value.Equals(">="))
            {
                GetNextToken();
                MatchG();
                MatchH_();
            }
        }

        public void MatchG()
        {
            MatchT();
            MatchG_();
        }

        public void MatchG_()
        {
            if (actual.Value.Equals("+") || actual.Value.Equals("-"))
            {
                GetNextToken();
                MatchT();
                MatchG_();
            }
        }

        public void MatchT()
        {
            MatchF();
            MatchT_();
        }

        public void MatchT_()
        {
            if (actual.Value.Equals("*") || actual.Value.Equals("/") || actual.Value.Equals("%"))
            {
                GetNextToken();
                MatchF();
                MatchT_();
            }
        }

        public void MatchF()
        {
            if (actual.Value.Equals("(")) // (Expr)
            {
                MatchExpr();
                GetNextToken();
                Match(")");
            }
            else if (actual.Value.Equals("T_ReferenceType"))
            {
                GetNextToken();
            }
            else if (actual.Value.Equals("-")) // -Expr
            {
                MatchExpr();
                GetNextToken();
            }
            else if (actual.Value.Equals("T_KeyWord"))
            {
                GetNextToken();
                Match("(");
                Match("Token_Identifier");
                Match(")");
            }
            else
            {
                Constant(out bool Match, false);
                if (Match)
                {
                    GetNextToken();
                }
                else
                {
                    MatchLValue();
                    if (actual.Value.Equals("="))
                    {
                        GetNextToken();
                        MatchExpr();
                    } // | eps
                }
            }
        }
    }
}