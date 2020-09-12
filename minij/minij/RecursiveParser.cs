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
        public List<Lexeme> tokens;
        //public List<KeyValuePair<string, string>> stack;
        Lexeme actual;
        List<string> error = new List<string>();

        public RecursiveParser() { }

        public RecursiveParser(List<Lexeme> input)
        {
            tokens = input;
            //stack = new List<KeyValuePair<string, string>>();
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

            if (actual.token.Value.Equals("{") || actual.token.Value.Equals("}"))
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

        //public void Revert()
        //{
        //    int size = stack.Count();
        //    for (int i = 0; i < size; i++)
        //    {
        //        tokens.Insert(0, stack.Last());
        //        error.RemoveAt(error.Count - 1);
        //        stack.RemoveAt(stack.Count - 1);
        //    }
        //}

        public void Match(string expected)
        {
            if (actual.token.Value.Equals(expected) || actual.token.Key.Equals(expected))
            {
                //stack.Add(actual);
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
            error.Add($"SYNTAX ERROR: Expected '{expected}', got '{actual.token.Value}', line {actual.cont}.");
        }

        public void Program()
        {
            Decl();

            if (actual.token.Value.Equals("T_ValueType") || actual.token.Value.Equals("T_void"))
            {
                Program();
            }
        }

        public void Decl()
        {
            Declaration();
        }

        public void Declaration()
        {
            if (actual.token.Value.Equals("T_ValueType"))
            {
                Type();
                Match("Token_Identifier");

                if (actual.token.Value.Equals(";"))
                {
                    Match(";");                   
                }
                else if (actual.token.Value.Equals("("))
                {
                    Match("(");
                    Formals();
                    Match(")");
                    Stmt();
                }
                else if (actual.token.Value.Equals("()"))
                {
                    Match("()");
                    Stmt();
                }
            }
            else if (actual.token.Value.Equals("T_void"))
            {
                Match("T_void");
                Match("Token_Identifier");

                if (actual.token.Value.Equals("("))
                {
                    Match("(");
                    Formals();
                    Match(")");
                    Stmt();
                }
                else if (actual.token.Value.Equals("()"))
                {
                    Match("()");
                    Stmt();
                }
            }
            else
            {
                Error(actual.token.Value);
            }
        }


        public void Formals()
        {
            if (actual.token.Value.Equals("T_ValueType"))
            {
                Type();
                Match("Token_Identifier");
                
                if (actual.token.Value.Equals(","))
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
            if (actual.token.Value.Equals("T_ValueType"))
            {
                if (tokens.First().token.Value.Equals("[]"))
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
            if (actual.token.Key.Equals("while"))
            {
                WhileStmt();
                Stmt();
            }
            else if (actual.token.Key.Equals("return"))
            {
                ReturnStmt();
                Stmt();
            }
            else if // deriva Expr
                (
                actual.token.Value.Equals("(") || actual.token.Value.Equals("Token_Identifier") || actual.token.Value.Equals("T_IntConstant") ||
                actual.token.Value.Equals("Token_Double") || actual.token.Value.Equals("T_BooleanConstant") || actual.token.Value.Equals("T_StringConstant") ||
                actual.token.Key.Equals("null") || actual.token.Key.Equals("this") || actual.token.Key.Equals("New") || actual.token.Value.Equals("-")
                )
            {
                MatchExpr();
                Match(";");
                Stmt();
            }
            else // si ninguno de los anteriores está stmt no viene. 
            {
                //GetNextToken();
                // Stmt();
                return; 
            }
        }

        public void WhileStmt() 
        {
            if (actual.token.Value.Equals("T_KeyWord"))
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
            if (actual.token.Value.Equals("return"))
            {
                Match("return");
                
                if (!actual.token.Value.Equals(";")) //&& !actual.Key.Equals("while") && !actual.Key.Equals("return"))
                {
                    MatchExpr();
                }

                if (actual.token.Value.Equals(";"))
                {
                    Match(";");
                }
                else
                {
                    Error(";");
                }
            }
        }
 

        public void Constant(out bool match)
        {
            if (actual.token.Value.Equals("T_IntConstant") || actual.token.Value.Equals("Token_Double") || 
                actual.token.Value.Equals("T_BooleanConstant") || actual.token.Value.Equals("T_StringConstant") || 
                actual.token.Value.Equals("null"))
            {
                match = true;
            }
            else
            {
                match = false;
            }
        }

        public void MatchLValue()
        {
            if (actual.token.Value.Equals("Token_Identifier"))
            {
                GetNextToken();
                return;
            }
            else if // deriva Expr
                (
                actual.token.Value.Equals("(") || actual.token.Value.Equals("Token_Identifier") || actual.token.Value.Equals("T_IntConstant") ||
                actual.token.Value.Equals("Token_Double") || actual.token.Value.Equals("T_BooleanConstant") || actual.token.Value.Equals("T_StringConstant") ||
                actual.token.Key.Equals("null") || actual.token.Key.Equals("this") || actual.token.Key.Equals("New") || actual.token.Value.Equals("-")
                )
            {
                GetNextToken();
                MatchExpr();
                if (actual.token.Value.Equals("."))
                {
                    GetNextToken();
                    Match("Token_Identifier");
                }
                else if (actual.token.Value.Equals("["))
                {
                    GetNextToken();
                    MatchExpr();
                    Match("]");
                    GetNextToken();
                }
            }
            else
            {
                Error("Expression");
            }
        }

        public void MatchExpr()
        {
            MatchI();
            MatchExpr_();
        }

        public void MatchExpr_()
        {
            if (actual.token.Value.Equals("&&") || actual.token.Value.Equals("||"))
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
            if (actual.token.Value.Equals("==") || actual.token.Value.Equals("!="))
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
            if (actual.token.Value.Equals("<") || actual.token.Value.Equals(">") || actual.token.Value.Equals("<=") || actual.token.Value.Equals(">="))
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
            if (actual.token.Value.Equals("+") || actual.token.Value.Equals("-"))
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
            if (actual.token.Value.Equals("*") || actual.token.Value.Equals("/") || actual.token.Value.Equals("%"))
            {
                GetNextToken();
                MatchF();
                MatchT_();
            }
        }

        public void MatchF()
        {
            bool MatchedPrev = false;
            if (actual.token.Value.Equals("(")) // (Expr)
            {
                GetNextToken();
                MatchExpr();
                Match(")");
                MatchedPrev = true;
            }
            else if (actual.token.Value.Equals("T_ReferenceType"))
            {
                GetNextToken();
                MatchedPrev = true;
            }
            else if (actual.token.Value.Equals("-")) // -Expr
            {
                GetNextToken();
                MatchExpr();
                MatchedPrev = true;
            }
            else if (actual.token.Key.Equals("null"))
            {
                GetNextToken();
                Match("(");
                Match("Token_Identifier");
                Match(")");
                MatchedPrev = true;
            }
            
            if (!MatchedPrev) {
                Constant(out bool Match);
                if (Match)
                {
                    GetNextToken();
                    MatchedPrev = true;
                }
                else if (actual.token.Value.Equals("(") || actual.token.Value.Equals("Token_Identifier") ||
                actual.token.Value.Equals("T_IntConstant") || actual.token.Value.Equals("Token_Double") ||
                actual.token.Value.Equals("T_BooleanConstant") || actual.token.Value.Equals("T_StringConstant") ||
                actual.token.Key.Equals("null") || actual.token.Key.Equals("this") || actual.token.Key.Equals("New") || actual.token.Value.Equals("-"))
                    {
                    MatchLValue();
                    if (actual.token.Value.Equals("="))
                    {
                        GetNextToken();
                        MatchExpr();
                        MatchedPrev = true;
                    } // | eps
                }
                else
                {
                    Error("Constant or LValue");
                }
            }
        }
    }
}