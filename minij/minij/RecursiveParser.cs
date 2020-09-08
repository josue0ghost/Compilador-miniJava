using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace minij
{
    class RecursiveParser
    {
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
