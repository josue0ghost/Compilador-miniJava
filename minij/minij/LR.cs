using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace minij
{
	class LR
	{
		public Stack<int> stack = new Stack<int>();
		public Stack<string> text = new Stack<string>();
		public List<string> input = new List<string>();

		public bool fooState0(bool afterReduce)
		{
			if (input[0] == "class")
			{
				stack.Push(12);
				text.Push("class");
				input.RemoveAt(0);
				return fooState12(false);
			}
			if (input[0] == "interface")
			{
				stack.Push(13);
				text.Push("interface");
				input.RemoveAt(0);
				return fooState13(false);
			}
			if (input[0] == "static")
			{
				stack.Push(11);
				text.Push("static");
				input.RemoveAt(0);
				return fooState11(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "void")
			{
				stack.Push(10);
				text.Push("void");
				input.RemoveAt(0);
				return fooState10(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "Program")
			{
				stack.Push(0);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Decl")
			{
				stack.Push(0);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "VariableDecl")
			{
				stack.Push(0);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(0);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "ConstDecl")
			{
				stack.Push(0);
				return fooState5(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(0);
				return fooState9(false);
			}
			if (afterReduce && text.Peek() == "FunctionDecl")
			{
				stack.Push(0);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "ClassDecl")
			{
				stack.Push(0);
				return fooState6(false);
			}
			if (afterReduce && text.Peek() == "InterfaceDecl")
			{
				stack.Push(0);
				return fooState7(false);
			}
			return false;
		}


		public bool fooState1(bool afterReduce)
		{
			if (input[0] == "$")
			{
				return true;
			}
			return false;
		}


		public bool fooState2(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 0
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Program");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState3(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 1
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState4(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 2
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState5(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 3
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState6(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 4
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState7(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 5
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState8(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(19);
				text.Push(";");
				input.RemoveAt(0);
				return fooState19(false);
			}
			return false;
		}


		public bool fooState9(bool afterReduce)
		{
			if (input[0] == "[ ]")
			{
				stack.Push(21);
				text.Push("[ ]");
				input.RemoveAt(0);
				return fooState21(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(20);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState20(false);
			}
			return false;
		}


		public bool fooState10(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(22);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState22(false);
			}
			return false;
		}


		public bool fooState11(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(24);
				text.Push("int");
				input.RemoveAt(0);
				return fooState24(false);
			}
			if (input[0] == "double")
			{
				stack.Push(25);
				text.Push("double");
				input.RemoveAt(0);
				return fooState25(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(26);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState26(false);
			}
			if (input[0] == "string")
			{
				stack.Push(27);
				text.Push("string");
				input.RemoveAt(0);
				return fooState27(false);
			}
			if (afterReduce && text.Peek() == "ConstType")
			{
				stack.Push(11);
				return fooState2(false);
			}
			return false;
		}


		public bool fooState12(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(28);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState28(false);
			}
			return false;
		}


		public bool fooState13(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(29);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState29(false);
			}
			return false;
		}


		public bool fooState14(bool afterReduce)
		{
			if (text.Peek() == "[ ]")
			{
				// reduccion por la produccion 13
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 13
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState15(bool afterReduce)
		{
			if (text.Peek() == "[ ]")
			{
				// reduccion por la produccion 14
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 14
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState16(bool afterReduce)
		{
			if (text.Peek() == "[ ]")
			{
				// reduccion por la produccion 15
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 15
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState17(bool afterReduce)
		{
			if (text.Peek() == "[ ]")
			{
				// reduccion por la produccion 16
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 16
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState18(bool afterReduce)
		{
			if (text.Peek() == "[ ]")
			{
				// reduccion por la produccion 17
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 17
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState19(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 6
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("VariableDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState20(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 7
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Variable");
				return irA(stack.Peek());
			}
			if (input[0] == "(")
			{
				stack.Push(30);
				text.Push("(");
				input.RemoveAt(0);
				return fooState30(false);
			}
			return false;
		}


		public bool fooState21(bool afterReduce)
		{
			if (text.Peek() == "[ ]")
			{
				// reduccion por la produccion 18
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 18
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState22(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(31);
				text.Push("(");
				input.RemoveAt(0);
				return fooState31(false);
			}
			return false;
		}


		public bool fooState23(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(32);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState32(false);
			}
			return false;
		}


		public bool fooState24(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 9
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState25(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 10
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState26(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 11
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState27(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 12
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState28(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(33);
				text.Push("(");
				input.RemoveAt(0);
				return fooState33(false);
			}
			return false;
		}


		public bool fooState29(bool afterReduce)
		{
			if (input[0] == "{")
			{
				stack.Push(34);
				text.Push("{");
				input.RemoveAt(0);
				return fooState34(false);
			}
			return false;
		}


		public bool fooState30(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(30);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(30);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Formals")
			{
				stack.Push(30);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState31(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(31);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(31);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Formals")
			{
				stack.Push(31);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState32(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(39);
				text.Push(";");
				input.RemoveAt(0);
				return fooState39(false);
			}
			return false;
		}


		public bool fooState33(bool afterReduce)
		{
			if (input[0] == "extends")
			{
				stack.Push(40);
				text.Push("extends");
				input.RemoveAt(0);
				return fooState40(false);
			}
			return false;
		}


		public bool fooState34(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "void")
			{
				stack.Push(43);
				text.Push("void");
				input.RemoveAt(0);
				return fooState43(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(34);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Prototype")
			{
				stack.Push(34);
				return fooState4(false);
			}
			return false;
		}


		public bool fooState35(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(44);
				text.Push(")");
				input.RemoveAt(0);
				return fooState44(false);
			}
			return false;
		}


		public bool fooState36(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 22
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Formals");
				return irA(stack.Peek());
			}
			if (input[0] == ",")
			{
				stack.Push(45);
				text.Push(",");
				input.RemoveAt(0);
				return fooState45(false);
			}
			return false;
		}


		public bool fooState37(bool afterReduce)
		{
			if (input[0] == "[ ]")
			{
				stack.Push(318);
				text.Push("[ ]");
				input.RemoveAt(0);
				return fooState318(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(46);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState46(false);
			}
			return false;
		}


		public bool fooState38(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(47);
				text.Push(")");
				input.RemoveAt(0);
				return fooState47(false);
			}
			return false;
		}


		public bool fooState39(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState40(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(48);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState48(false);
			}
			return false;
		}


		public bool fooState41(bool afterReduce)
		{
			if (input[0] == "}")
			{
				stack.Push(49);
				text.Push("}");
				input.RemoveAt(0);
				return fooState49(false);
			}
			return false;
		}


		public bool fooState42(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(50);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState50(false);
			}
			return false;
		}


		public bool fooState43(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(51);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState51(false);
			}
			return false;
		}


		public bool fooState44(bool afterReduce)
		{
			if (input[0] == "{")
			{
				stack.Push(53);
				text.Push("{");
				input.RemoveAt(0);
				return fooState53(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(44);
				return fooState5(false);
			}
			return false;
		}


		public bool fooState45(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(45);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(45);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Formals")
			{
				stack.Push(45);
				return fooState5(false);
			}
			return false;
		}


		public bool fooState46(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 7
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Variable");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 7
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Variable");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState47(bool afterReduce)
		{
			if (input[0] == "{")
			{
				stack.Push(53);
				text.Push("{");
				input.RemoveAt(0);
				return fooState53(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(47);
				return fooState5(false);
			}
			return false;
		}


		public bool fooState48(bool afterReduce)
		{
			if (input[0] == "implements")
			{
				stack.Push(56);
				text.Push("implements");
				input.RemoveAt(0);
				return fooState56(false);
			}
			return false;
		}


		public bool fooState49(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 27
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("InterfaceDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState50(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(57);
				text.Push("(");
				input.RemoveAt(0);
				return fooState57(false);
			}
			return false;
		}


		public bool fooState51(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(58);
				text.Push("(");
				input.RemoveAt(0);
				return fooState58(false);
			}
			return false;
		}


		public bool fooState52(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 19
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("FunctionDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState53(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "VariableDecl")
			{
				stack.Push(53);
				return fooState5(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(53);
				return fooState6(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(53);
				return fooState9(false);
			}
			return false;
		}


		public bool fooState54(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 21
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Formals");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState55(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 20
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("FunctionDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState56(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(61);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState61(false);
			}
			return false;
		}


		public bool fooState57(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(57);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(57);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Formals")
			{
				stack.Push(57);
				return fooState6(false);
			}
			return false;
		}


		public bool fooState58(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(58);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(58);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Formals")
			{
				stack.Push(58);
				return fooState6(false);
			}
			return false;
		}


		public bool fooState59(bool afterReduce)
		{
			if (input[0] == "static")
			{
				stack.Push(65);
				text.Push("static");
				input.RemoveAt(0);
				return fooState65(false);
			}
			if (afterReduce && text.Peek() == "ConstDecl")
			{
				stack.Push(59);
				return fooState6(false);
			}
			return false;
		}


		public bool fooState60(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(66);
				text.Push(";");
				input.RemoveAt(0);
				return fooState66(false);
			}
			return false;
		}


		public bool fooState61(bool afterReduce)
		{
			if (input[0] == ",")
			{
				stack.Push(67);
				text.Push(",");
				input.RemoveAt(0);
				return fooState67(false);
			}
			return false;
		}


		public bool fooState62(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(68);
				text.Push(")");
				input.RemoveAt(0);
				return fooState68(false);
			}
			return false;
		}


		public bool fooState63(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(69);
				text.Push(")");
				input.RemoveAt(0);
				return fooState69(false);
			}
			return false;
		}


		public bool fooState64(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState85(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(64);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(64);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(64);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(64);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(64);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(64);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(64);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(64);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(64);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(64);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(64);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(64);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState65(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(100);
				text.Push("int");
				input.RemoveAt(0);
				return fooState100(false);
			}
			if (input[0] == "double")
			{
				stack.Push(101);
				text.Push("double");
				input.RemoveAt(0);
				return fooState101(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(102);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState102(false);
			}
			if (input[0] == "string")
			{
				stack.Push(103);
				text.Push("string");
				input.RemoveAt(0);
				return fooState103(false);
			}
			if (afterReduce && text.Peek() == "ConstType")
			{
				stack.Push(65);
				return fooState9(false);
			}
			return false;
		}


		public bool fooState66(bool afterReduce)
		{
			if (text.Peek() == "static")
			{
				// reduccion por la produccion 6
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("VariableDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState67(bool afterReduce)
		{
			if (input[0] == "{")
			{
				stack.Push(104);
				text.Push("{");
				input.RemoveAt(0);
				return fooState104(false);
			}
			return false;
		}


		public bool fooState68(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(105);
				text.Push(";");
				input.RemoveAt(0);
				return fooState105(false);
			}
			return false;
		}


		public bool fooState69(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(106);
				text.Push(";");
				input.RemoveAt(0);
				return fooState106(false);
			}
			return false;
		}


		public bool fooState70(bool afterReduce)
		{
			if (input[0] == "}")
			{
				stack.Push(107);
				text.Push("}");
				input.RemoveAt(0);
				return fooState107(false);
			}
			return false;
		}


		public bool fooState71(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(108);
				text.Push(";");
				input.RemoveAt(0);
				return fooState108(false);
			}
			if (input[0] == "-")
			{
				stack.Push(109);
				text.Push("-");
				input.RemoveAt(0);
				return fooState109(false);
			}
			if (input[0] == "|")
			{
				stack.Push(110);
				text.Push("|");
				input.RemoveAt(0);
				return fooState110(false);
			}
			if (input[0] == "%")
			{
				stack.Push(111);
				text.Push("%");
				input.RemoveAt(0);
				return fooState111(false);
			}
			if (input[0] == ">")
			{
				stack.Push(112);
				text.Push(">");
				input.RemoveAt(0);
				return fooState112(false);
			}
			if (input[0] == ">=")
			{
				stack.Push(113);
				text.Push(">=");
				input.RemoveAt(0);
				return fooState113(false);
			}
			if (input[0] == "!=")
			{
				stack.Push(114);
				text.Push("!=");
				input.RemoveAt(0);
				return fooState114(false);
			}
			if (input[0] == "||")
			{
				stack.Push(115);
				text.Push("||");
				input.RemoveAt(0);
				return fooState115(false);
			}
			if (input[0] == ".")
			{
				stack.Push(116);
				text.Push(".");
				input.RemoveAt(0);
				return fooState116(false);
			}
			return false;
		}


		public bool fooState72(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 32
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState73(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 33
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState74(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 34
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState75(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 35
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState76(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 36
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState77(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 37
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState78(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 38
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState79(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "VariableDecl")
			{
				stack.Push(79);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(79);
				return fooState6(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(79);
				return fooState9(false);
			}
			return false;
		}


		public bool fooState80(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(118);
				text.Push("(");
				input.RemoveAt(0);
				return fooState118(false);
			}
			return false;
		}


		public bool fooState81(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(119);
				text.Push("(");
				input.RemoveAt(0);
				return fooState119(false);
			}
			return false;
		}


		public bool fooState82(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(120);
				text.Push("(");
				input.RemoveAt(0);
				return fooState120(false);
			}
			return false;
		}


		public bool fooState83(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(83);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(83);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(83);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState84(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(122);
				text.Push(";");
				input.RemoveAt(0);
				return fooState122(false);
			}
			return false;
		}


		public bool fooState85(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(123);
				text.Push("(");
				input.RemoveAt(0);
				return fooState123(false);
			}
			return false;
		}


		public bool fooState86(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (input[0] == "=")
			{
				stack.Push(124);
				text.Push("=");
				input.RemoveAt(0);
				return fooState124(false);
			}
			return false;
		}


		public bool fooState87(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState88(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState89(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(89);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(89);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(89);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState90(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(90);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(90);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(90);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState91(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(91);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(91);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(91);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState92(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(142);
				text.Push("(");
				input.RemoveAt(0);
				return fooState142(false);
			}
			return false;
		}


		public bool fooState93(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState94(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState95(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState96(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState97(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState98(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState99(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(143);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState143(false);
			}
			return false;
		}


		public bool fooState100(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 9
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState101(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 10
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState102(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 11
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState103(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 12
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState104(bool afterReduce)
		{
			if (input[0] == "static")
			{
				stack.Push(151);
				text.Push("static");
				input.RemoveAt(0);
				return fooState151(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "void")
			{
				stack.Push(150);
				text.Push("void");
				input.RemoveAt(0);
				return fooState150(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "VariableDecl")
			{
				stack.Push(104);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(104);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "ConstDecl")
			{
				stack.Push(104);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(104);
				return fooState9(false);
			}
			if (afterReduce && text.Peek() == "FunctionDecl")
			{
				stack.Push(104);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Field")
			{
				stack.Push(104);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState105(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 28
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Prototype");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState106(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 29
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Prototype");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState107(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 30
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("StmtBlock");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState108(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 31
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState109(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(109);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(109);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(109);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState110(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(110);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(110);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(110);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState111(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(111);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(111);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(111);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState112(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(112);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(112);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(112);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState113(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(113);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(113);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(113);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState114(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(114);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(114);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(114);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState115(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(115);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(115);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(115);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState116(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(159);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState159(false);
			}
			return false;
		}


		public bool fooState117(bool afterReduce)
		{
			if (input[0] == "static")
			{
				stack.Push(65);
				text.Push("static");
				input.RemoveAt(0);
				return fooState65(false);
			}
			if (afterReduce && text.Peek() == "ConstDecl")
			{
				stack.Push(117);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState118(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(118);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(118);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(118);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState119(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(119);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(119);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(119);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState120(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(120);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(120);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(120);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState121(bool afterReduce)
		{
			if (input[0] == "if")
			{
				stack.Push(164);
				text.Push("if");
				input.RemoveAt(0);
				return fooState164(false);
			}
			return false;
		}


		public bool fooState122(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 43
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("BreakStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState123(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(123);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(123);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(123);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState124(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(124);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(124);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(124);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState125(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(181);
				text.Push(")");
				input.RemoveAt(0);
				return fooState181(false);
			}
			return false;
		}


		public bool fooState126(bool afterReduce)
		{
			if (input[0] == "=")
			{
				stack.Push(182);
				text.Push("=");
				input.RemoveAt(0);
				return fooState182(false);
			}
			return false;
		}


		public bool fooState127(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState128(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState129(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(129);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(129);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(129);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState130(bool afterReduce)
		{
			if (input[0] == "-")
			{
				stack.Push(184);
				text.Push("-");
				input.RemoveAt(0);
				return fooState184(false);
			}
			if (input[0] == "|")
			{
				stack.Push(185);
				text.Push("|");
				input.RemoveAt(0);
				return fooState185(false);
			}
			if (input[0] == "%")
			{
				stack.Push(186);
				text.Push("%");
				input.RemoveAt(0);
				return fooState186(false);
			}
			if (input[0] == ">")
			{
				stack.Push(187);
				text.Push(">");
				input.RemoveAt(0);
				return fooState187(false);
			}
			if (input[0] == ">=")
			{
				stack.Push(188);
				text.Push(">=");
				input.RemoveAt(0);
				return fooState188(false);
			}
			if (input[0] == "!=")
			{
				stack.Push(189);
				text.Push("!=");
				input.RemoveAt(0);
				return fooState189(false);
			}
			if (input[0] == "||")
			{
				stack.Push(190);
				text.Push("||");
				input.RemoveAt(0);
				return fooState190(false);
			}
			if (input[0] == ".")
			{
				stack.Push(191);
				text.Push(".");
				input.RemoveAt(0);
				return fooState191(false);
			}
			return false;
		}


		public bool fooState131(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(131);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(131);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(131);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState132(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(132);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(132);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(132);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState133(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(194);
				text.Push("(");
				input.RemoveAt(0);
				return fooState194(false);
			}
			return false;
		}


		public bool fooState134(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState135(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState136(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState137(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState138(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState139(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState140(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState141(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState142(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(195);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState195(false);
			}
			return false;
		}


		public bool fooState143(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(196);
				text.Push(";");
				input.RemoveAt(0);
				return fooState196(false);
			}
			return false;
		}


		public bool fooState144(bool afterReduce)
		{
			if (input[0] == "}")
			{
				stack.Push(197);
				text.Push("}");
				input.RemoveAt(0);
				return fooState197(false);
			}
			return false;
		}


		public bool fooState145(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 24
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Field");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState146(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 25
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Field");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState147(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 26
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Field");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState148(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(198);
				text.Push(";");
				input.RemoveAt(0);
				return fooState198(false);
			}
			return false;
		}


		public bool fooState149(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(199);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState199(false);
			}
			return false;
		}


		public bool fooState150(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(200);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState200(false);
			}
			return false;
		}


		public bool fooState151(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(100);
				text.Push("int");
				input.RemoveAt(0);
				return fooState100(false);
			}
			if (input[0] == "double")
			{
				stack.Push(101);
				text.Push("double");
				input.RemoveAt(0);
				return fooState101(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(102);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState102(false);
			}
			if (input[0] == "string")
			{
				stack.Push(103);
				text.Push("string");
				input.RemoveAt(0);
				return fooState103(false);
			}
			if (afterReduce && text.Peek() == "ConstType")
			{
				stack.Push(151);
				return fooState2(false);
			}
			return false;
		}


		public bool fooState152(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState153(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState154(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState155(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState156(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState157(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState158(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState159(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(202);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState202(false);
			}
			return false;
		}


		public bool fooState160(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState85(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(160);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(160);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(160);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(160);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(160);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(160);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(160);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(160);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(160);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(160);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(160);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(160);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState161(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(204);
				text.Push(")");
				input.RemoveAt(0);
				return fooState204(false);
			}
			return false;
		}


		public bool fooState162(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(205);
				text.Push(")");
				input.RemoveAt(0);
				return fooState205(false);
			}
			return false;
		}


		public bool fooState163(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(206);
				text.Push(";");
				input.RemoveAt(0);
				return fooState206(false);
			}
			return false;
		}


		public bool fooState164(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 42
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ReturnStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState165(bool afterReduce)
		{
			if (input[0] == ",")
			{
				stack.Push(207);
				text.Push(",");
				input.RemoveAt(0);
				return fooState207(false);
			}
			return false;
		}


		public bool fooState166(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (input[0] == "=")
			{
				stack.Push(208);
				text.Push("=");
				input.RemoveAt(0);
				return fooState208(false);
			}
			return false;
		}


		public bool fooState167(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState168(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState169(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(169);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(169);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(169);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState170(bool afterReduce)
		{
			if (input[0] == "-")
			{
				stack.Push(210);
				text.Push("-");
				input.RemoveAt(0);
				return fooState210(false);
			}
			if (input[0] == "|")
			{
				stack.Push(211);
				text.Push("|");
				input.RemoveAt(0);
				return fooState211(false);
			}
			if (input[0] == "%")
			{
				stack.Push(212);
				text.Push("%");
				input.RemoveAt(0);
				return fooState212(false);
			}
			if (input[0] == ">")
			{
				stack.Push(213);
				text.Push(">");
				input.RemoveAt(0);
				return fooState213(false);
			}
			if (input[0] == ">=")
			{
				stack.Push(214);
				text.Push(">=");
				input.RemoveAt(0);
				return fooState214(false);
			}
			if (input[0] == "!=")
			{
				stack.Push(215);
				text.Push("!=");
				input.RemoveAt(0);
				return fooState215(false);
			}
			if (input[0] == "||")
			{
				stack.Push(216);
				text.Push("||");
				input.RemoveAt(0);
				return fooState216(false);
			}
			if (input[0] == ".")
			{
				stack.Push(217);
				text.Push(".");
				input.RemoveAt(0);
				return fooState217(false);
			}
			return false;
		}


		public bool fooState171(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(171);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(171);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(171);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState172(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(172);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(172);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(172);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState173(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(220);
				text.Push("(");
				input.RemoveAt(0);
				return fooState220(false);
			}
			return false;
		}


		public bool fooState174(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState175(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState176(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState177(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState178(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState179(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState180(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState181(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState182(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(182);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(182);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(182);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState183(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(317);
				text.Push(")");
				input.RemoveAt(0);
				return fooState317(false);
			}
			return false;
		}


		public bool fooState184(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(184);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(184);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(184);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState185(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(185);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(185);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(185);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState186(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(186);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(186);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(186);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState187(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(187);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(187);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(187);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState188(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(188);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(188);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(188);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState189(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(189);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(189);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(189);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState190(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(190);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(190);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(190);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState191(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(229);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState229(false);
			}
			return false;
		}


		public bool fooState192(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState193(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState194(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(230);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState230(false);
			}
			return false;
		}


		public bool fooState195(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(231);
				text.Push(")");
				input.RemoveAt(0);
				return fooState231(false);
			}
			return false;
		}


		public bool fooState196(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "{")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "if")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "while")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "for")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "return")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "break")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "System.out.println")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "intConstant")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "doubleConstant")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "booleanConstant")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "stringConstant")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "null")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "this")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "New")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState197(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				// reduccion por la produccion 23
				for (int i = 0; i < 10; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ClassDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState198(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 6
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("VariableDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState199(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(232);
				text.Push("(");
				input.RemoveAt(0);
				return fooState232(false);
			}
			return false;
		}


		public bool fooState200(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(233);
				text.Push("(");
				input.RemoveAt(0);
				return fooState233(false);
			}
			return false;
		}


		public bool fooState201(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(234);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState234(false);
			}
			return false;
		}


		public bool fooState202(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState203(bool afterReduce)
		{
			if (input[0] == "}")
			{
				stack.Push(235);
				text.Push("}");
				input.RemoveAt(0);
				return fooState235(false);
			}
			return false;
		}


		public bool fooState204(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(245);
				text.Push("{");
				input.RemoveAt(0);
				return fooState245(false);
			}
			if (input[0] == "if")
			{
				stack.Push(246);
				text.Push("if");
				input.RemoveAt(0);
				return fooState246(false);
			}
			if (input[0] == "while")
			{
				stack.Push(247);
				text.Push("while");
				input.RemoveAt(0);
				return fooState247(false);
			}
			if (input[0] == "for")
			{
				stack.Push(248);
				text.Push("for");
				input.RemoveAt(0);
				return fooState248(false);
			}
			if (input[0] == "return")
			{
				stack.Push(249);
				text.Push("return");
				input.RemoveAt(0);
				return fooState249(false);
			}
			if (input[0] == "break")
			{
				stack.Push(250);
				text.Push("break");
				input.RemoveAt(0);
				return fooState250(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(251);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState251(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(204);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(204);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(204);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(204);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(204);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(204);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(204);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(204);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(204);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(204);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(204);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(204);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState205(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState85(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(205);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(205);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(205);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(205);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(205);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(205);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(205);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(205);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(205);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(205);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(205);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(205);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState206(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(206);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(206);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(206);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState207(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(239);
				text.Push(")");
				input.RemoveAt(0);
				return fooState239(false);
			}
			return false;
		}


		public bool fooState208(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(208);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(208);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(208);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState209(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(241);
				text.Push(")");
				input.RemoveAt(0);
				return fooState241(false);
			}
			return false;
		}


		public bool fooState210(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(210);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(210);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(210);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState211(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(211);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(211);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(211);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState212(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(212);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(212);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(212);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState213(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(213);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(213);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(213);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState214(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(214);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(214);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(214);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState215(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(215);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(215);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(215);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState216(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(216);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(216);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(216);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState217(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(249);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState249(false);
			}
			return false;
		}


		public bool fooState218(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState219(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState220(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(250);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState250(false);
			}
			return false;
		}


		public bool fooState221(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState222(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState223(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState224(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState225(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState226(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState227(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState228(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState229(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState230(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(251);
				text.Push(")");
				input.RemoveAt(0);
				return fooState251(false);
			}
			return false;
		}


		public bool fooState231(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState232(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(232);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(232);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Formals")
			{
				stack.Push(232);
				return fooState2(false);
			}
			return false;
		}


		public bool fooState233(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(233);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(233);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Formals")
			{
				stack.Push(233);
				return fooState2(false);
			}
			return false;
		}


		public bool fooState234(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(254);
				text.Push(";");
				input.RemoveAt(0);
				return fooState254(false);
			}
			return false;
		}


		public bool fooState235(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 30
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("StmtBlock");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState236(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(255);
				text.Push("(");
				input.RemoveAt(0);
				return fooState255(false);
			}
			return false;
		}


		public bool fooState237(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 40
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("WhileStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState238(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(256);
				text.Push(";");
				input.RemoveAt(0);
				return fooState256(false);
			}
			return false;
		}


		public bool fooState239(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(257);
				text.Push(";");
				input.RemoveAt(0);
				return fooState257(false);
			}
			return false;
		}


		public bool fooState240(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState241(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState242(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState243(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState244(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState245(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState246(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState247(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState248(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState249(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState250(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(258);
				text.Push(")");
				input.RemoveAt(0);
				return fooState258(false);
			}
			return false;
		}


		public bool fooState251(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState252(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(259);
				text.Push(")");
				input.RemoveAt(0);
				return fooState259(false);
			}
			return false;
		}


		public bool fooState253(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(260);
				text.Push(")");
				input.RemoveAt(0);
				return fooState260(false);
			}
			return false;
		}


		public bool fooState254(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 8
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState255(bool afterReduce)
		{
			if (input[0] == "else")
			{
				stack.Push(261);
				text.Push("else");
				input.RemoveAt(0);
				return fooState261(false);
			}
			return false;
		}


		public bool fooState256(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(256);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(256);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(256);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState257(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 44
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("PrintStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState258(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState259(bool afterReduce)
		{
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				return fooState79(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(259);
				return fooState2(false);
			}
			return false;
		}


		public bool fooState260(bool afterReduce)
		{
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				return fooState79(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(260);
				return fooState2(false);
			}
			return false;
		}


		public bool fooState261(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(274);
				text.Push("{");
				input.RemoveAt(0);
				return fooState274(false);
			}
			if (input[0] == "if")
			{
				stack.Push(275);
				text.Push("if");
				input.RemoveAt(0);
				return fooState275(false);
			}
			if (input[0] == "while")
			{
				stack.Push(276);
				text.Push("while");
				input.RemoveAt(0);
				return fooState276(false);
			}
			if (input[0] == "for")
			{
				stack.Push(277);
				text.Push("for");
				input.RemoveAt(0);
				return fooState277(false);
			}
			if (input[0] == "return")
			{
				stack.Push(278);
				text.Push("return");
				input.RemoveAt(0);
				return fooState278(false);
			}
			if (input[0] == "break")
			{
				stack.Push(279);
				text.Push("break");
				input.RemoveAt(0);
				return fooState279(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(280);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState280(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(261);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(261);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(261);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(261);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(261);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(261);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(261);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(261);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(261);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(261);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(261);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(261);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState262(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(281);
				text.Push(")");
				input.RemoveAt(0);
				return fooState281(false);
			}
			return false;
		}


		public bool fooState263(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 19
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("FunctionDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState264(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 20
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("FunctionDecl");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState265(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(282);
				text.Push(")");
				input.RemoveAt(0);
				return fooState282(false);
			}
			return false;
		}


		public bool fooState266(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(283);
				text.Push(";");
				input.RemoveAt(0);
				return fooState283(false);
			}
			return false;
		}


		public bool fooState267(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 32
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState268(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 33
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState269(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 34
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState270(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 35
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState271(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 36
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState272(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 37
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState273(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 38
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState274(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "VariableDecl")
			{
				stack.Push(274);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(274);
				return fooState6(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(274);
				return fooState9(false);
			}
			return false;
		}


		public bool fooState275(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(285);
				text.Push("(");
				input.RemoveAt(0);
				return fooState285(false);
			}
			return false;
		}


		public bool fooState276(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(286);
				text.Push("(");
				input.RemoveAt(0);
				return fooState286(false);
			}
			return false;
		}


		public bool fooState277(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(287);
				text.Push("(");
				input.RemoveAt(0);
				return fooState287(false);
			}
			return false;
		}


		public bool fooState278(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(278);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(278);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(278);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState279(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(289);
				text.Push(";");
				input.RemoveAt(0);
				return fooState289(false);
			}
			return false;
		}


		public bool fooState280(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(290);
				text.Push("(");
				input.RemoveAt(0);
				return fooState290(false);
			}
			return false;
		}


		public bool fooState281(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState85(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(281);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(281);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(281);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(281);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(281);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(281);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(281);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(281);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(281);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(281);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(281);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(281);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState282(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 39
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("IfStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState283(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 31
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState284(bool afterReduce)
		{
			if (input[0] == "static")
			{
				stack.Push(65);
				text.Push("static");
				input.RemoveAt(0);
				return fooState65(false);
			}
			if (afterReduce && text.Peek() == "ConstDecl")
			{
				stack.Push(284);
				return fooState2(false);
			}
			return false;
		}


		public bool fooState285(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(285);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(285);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(285);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState286(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(286);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(286);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(286);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState287(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(287);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(287);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(287);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState288(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(296);
				text.Push(";");
				input.RemoveAt(0);
				return fooState296(false);
			}
			return false;
		}


		public bool fooState289(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 43
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("BreakStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState290(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(290);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(290);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(290);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState291(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 41
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ForStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState292(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState85(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(292);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(292);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(292);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(292);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(292);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(292);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(292);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(292);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(292);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(292);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(292);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(292);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState293(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(299);
				text.Push(")");
				input.RemoveAt(0);
				return fooState299(false);
			}
			return false;
		}


		public bool fooState294(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(300);
				text.Push(")");
				input.RemoveAt(0);
				return fooState300(false);
			}
			return false;
		}


		public bool fooState295(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(301);
				text.Push(";");
				input.RemoveAt(0);
				return fooState301(false);
			}
			return false;
		}


		public bool fooState296(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 42
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ReturnStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState297(bool afterReduce)
		{
			if (input[0] == ",")
			{
				stack.Push(302);
				text.Push(",");
				input.RemoveAt(0);
				return fooState302(false);
			}
			return false;
		}


		public bool fooState298(bool afterReduce)
		{
			if (input[0] == "}")
			{
				stack.Push(303);
				text.Push("}");
				input.RemoveAt(0);
				return fooState303(false);
			}
			return false;
		}


		public bool fooState299(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(329);
				text.Push("{");
				input.RemoveAt(0);
				return fooState329(false);
			}
			if (input[0] == "if")
			{
				stack.Push(330);
				text.Push("if");
				input.RemoveAt(0);
				return fooState330(false);
			}
			if (input[0] == "while")
			{
				stack.Push(331);
				text.Push("while");
				input.RemoveAt(0);
				return fooState331(false);
			}
			if (input[0] == "for")
			{
				stack.Push(332);
				text.Push("for");
				input.RemoveAt(0);
				return fooState332(false);
			}
			if (input[0] == "return")
			{
				stack.Push(333);
				text.Push("return");
				input.RemoveAt(0);
				return fooState333(false);
			}
			if (input[0] == "break")
			{
				stack.Push(334);
				text.Push("break");
				input.RemoveAt(0);
				return fooState334(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(335);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState335(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(299);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(299);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(299);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(299);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(299);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(299);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(299);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(299);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(299);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(299);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(299);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(299);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState300(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(274);
				text.Push("{");
				input.RemoveAt(0);
				return fooState274(false);
			}
			if (input[0] == "if")
			{
				stack.Push(275);
				text.Push("if");
				input.RemoveAt(0);
				return fooState275(false);
			}
			if (input[0] == "while")
			{
				stack.Push(276);
				text.Push("while");
				input.RemoveAt(0);
				return fooState276(false);
			}
			if (input[0] == "for")
			{
				stack.Push(277);
				text.Push("for");
				input.RemoveAt(0);
				return fooState277(false);
			}
			if (input[0] == "return")
			{
				stack.Push(278);
				text.Push("return");
				input.RemoveAt(0);
				return fooState278(false);
			}
			if (input[0] == "break")
			{
				stack.Push(279);
				text.Push("break");
				input.RemoveAt(0);
				return fooState279(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(280);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState280(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(300);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(300);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(300);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(300);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(300);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(300);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(300);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(300);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(300);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(300);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(300);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(300);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState301(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(301);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(301);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(301);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState302(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(307);
				text.Push(")");
				input.RemoveAt(0);
				return fooState307(false);
			}
			return false;
		}


		public bool fooState303(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 30
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("StmtBlock");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState304(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(308);
				text.Push("(");
				input.RemoveAt(0);
				return fooState308(false);
			}
			return false;
		}


		public bool fooState305(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 40
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("WhileStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState306(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(309);
				text.Push(";");
				input.RemoveAt(0);
				return fooState309(false);
			}
			return false;
		}


		public bool fooState307(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(310);
				text.Push(";");
				input.RemoveAt(0);
				return fooState310(false);
			}
			return false;
		}


		public bool fooState308(bool afterReduce)
		{
			if (input[0] == "else")
			{
				stack.Push(311);
				text.Push("else");
				input.RemoveAt(0);
				return fooState311(false);
			}
			return false;
		}


		public bool fooState309(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(309);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(309);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(309);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState310(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 44
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("PrintStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState311(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(274);
				text.Push("{");
				input.RemoveAt(0);
				return fooState274(false);
			}
			if (input[0] == "if")
			{
				stack.Push(275);
				text.Push("if");
				input.RemoveAt(0);
				return fooState275(false);
			}
			if (input[0] == "while")
			{
				stack.Push(276);
				text.Push("while");
				input.RemoveAt(0);
				return fooState276(false);
			}
			if (input[0] == "for")
			{
				stack.Push(277);
				text.Push("for");
				input.RemoveAt(0);
				return fooState277(false);
			}
			if (input[0] == "return")
			{
				stack.Push(278);
				text.Push("return");
				input.RemoveAt(0);
				return fooState278(false);
			}
			if (input[0] == "break")
			{
				stack.Push(279);
				text.Push("break");
				input.RemoveAt(0);
				return fooState279(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(280);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState280(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(311);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(311);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(311);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(311);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(311);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(311);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(311);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(311);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(311);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(311);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(311);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(311);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState312(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(314);
				text.Push(")");
				input.RemoveAt(0);
				return fooState314(false);
			}
			return false;
		}


		public bool fooState313(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(315);
				text.Push(")");
				input.RemoveAt(0);
				return fooState315(false);
			}
			return false;
		}


		public bool fooState314(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(274);
				text.Push("{");
				input.RemoveAt(0);
				return fooState274(false);
			}
			if (input[0] == "if")
			{
				stack.Push(275);
				text.Push("if");
				input.RemoveAt(0);
				return fooState275(false);
			}
			if (input[0] == "while")
			{
				stack.Push(276);
				text.Push("while");
				input.RemoveAt(0);
				return fooState276(false);
			}
			if (input[0] == "for")
			{
				stack.Push(277);
				text.Push("for");
				input.RemoveAt(0);
				return fooState277(false);
			}
			if (input[0] == "return")
			{
				stack.Push(278);
				text.Push("return");
				input.RemoveAt(0);
				return fooState278(false);
			}
			if (input[0] == "break")
			{
				stack.Push(279);
				text.Push("break");
				input.RemoveAt(0);
				return fooState279(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(280);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState280(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(314);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(314);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(314);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(314);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(314);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(314);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(314);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(314);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(314);
				return fooState2(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(314);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(314);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(314);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState315(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 39
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("IfStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState316(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 41
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ForStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState317(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState318(bool afterReduce)
		{
			if (text.Peek() == "[ ]")
			{
				// reduccion por la produccion 18
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			if (text.Peek() == "ident")
			{
				// reduccion por la produccion 18
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState319(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 31
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState320(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ".")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState321(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(336);
				text.Push(";");
				input.RemoveAt(0);
				return fooState336(false);
			}
			return false;
		}


		public bool fooState322(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 32
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState323(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 33
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState324(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 34
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState325(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 35
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState326(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 36
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState327(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 37
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState328(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 38
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState329(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				return fooState17(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState18(false);
			}
			if (afterReduce && text.Peek() == "VariableDecl")
			{
				stack.Push(329);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Variable")
			{
				stack.Push(329);
				return fooState6(false);
			}
			if (afterReduce && text.Peek() == "Type")
			{
				stack.Push(329);
				return fooState9(false);
			}
			return false;
		}


		public bool fooState330(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 39
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("IfStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState331(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(338);
				text.Push("(");
				input.RemoveAt(0);
				return fooState338(false);
			}
			return false;
		}


		public bool fooState332(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(339);
				text.Push("(");
				input.RemoveAt(0);
				return fooState339(false);
			}
			return false;
		}


		public bool fooState333(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(333);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(333);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(333);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState334(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(341);
				text.Push(";");
				input.RemoveAt(0);
				return fooState341(false);
			}
			return false;
		}


		public bool fooState335(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(342);
				text.Push("(");
				input.RemoveAt(0);
				return fooState342(false);
			}
			return false;
		}


		public bool fooState336(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 31
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState337(bool afterReduce)
		{
			if (input[0] == "static")
			{
				stack.Push(65);
				text.Push("static");
				input.RemoveAt(0);
				return fooState65(false);
			}
			if (afterReduce && text.Peek() == "ConstDecl")
			{
				stack.Push(337);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState338(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(338);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(338);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(338);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState339(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(339);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(339);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(339);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState340(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(346);
				text.Push(";");
				input.RemoveAt(0);
				return fooState346(false);
			}
			return false;
		}


		public bool fooState341(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 43
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("BreakStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState342(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				return fooState169(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState175(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState176(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState177(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				return fooState173(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState174(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(342);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(342);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(342);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState343(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState85(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(343);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(343);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(343);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(343);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(343);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(343);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(343);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(343);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(343);
				return fooState7(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(343);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(343);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(343);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState344(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(359);
				text.Push(")");
				input.RemoveAt(0);
				return fooState359(false);
			}
			return false;
		}


		public bool fooState345(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(349);
				text.Push(";");
				input.RemoveAt(0);
				return fooState349(false);
			}
			return false;
		}


		public bool fooState346(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 42
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ReturnStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState347(bool afterReduce)
		{
			if (input[0] == ",")
			{
				stack.Push(350);
				text.Push(",");
				input.RemoveAt(0);
				return fooState350(false);
			}
			return false;
		}


		public bool fooState348(bool afterReduce)
		{
			if (input[0] == "}")
			{
				stack.Push(351);
				text.Push("}");
				input.RemoveAt(0);
				return fooState351(false);
			}
			return false;
		}


		public bool fooState349(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(349);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(349);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(349);
				return fooState8(false);
			}
			return false;
		}


		public bool fooState350(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(353);
				text.Push(")");
				input.RemoveAt(0);
				return fooState353(false);
			}
			return false;
		}


		public bool fooState351(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 30
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("StmtBlock");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState352(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(354);
				text.Push(";");
				input.RemoveAt(0);
				return fooState354(false);
			}
			return false;
		}


		public bool fooState353(bool afterReduce)
		{
			if (input[0] == ";")
			{
				stack.Push(355);
				text.Push(";");
				input.RemoveAt(0);
				return fooState355(false);
			}
			return false;
		}


		public bool fooState354(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				return fooState129(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState135(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState136(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState137(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				return fooState133(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState134(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(354);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(354);
				return fooState1(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(354);
				return fooState1(false);
			}
			return false;
		}


		public bool fooState355(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 44
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("PrintStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState356(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(357);
				text.Push(")");
				input.RemoveAt(0);
				return fooState357(false);
			}
			return false;
		}


		public bool fooState357(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(329);
				text.Push("{");
				input.RemoveAt(0);
				return fooState329(false);
			}
			if (input[0] == "if")
			{
				stack.Push(330);
				text.Push("if");
				input.RemoveAt(0);
				return fooState330(false);
			}
			if (input[0] == "while")
			{
				stack.Push(331);
				text.Push("while");
				input.RemoveAt(0);
				return fooState331(false);
			}
			if (input[0] == "for")
			{
				stack.Push(332);
				text.Push("for");
				input.RemoveAt(0);
				return fooState332(false);
			}
			if (input[0] == "return")
			{
				stack.Push(333);
				text.Push("return");
				input.RemoveAt(0);
				return fooState333(false);
			}
			if (input[0] == "break")
			{
				stack.Push(334);
				text.Push("break");
				input.RemoveAt(0);
				return fooState334(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(335);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState335(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(357);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(357);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(357);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(357);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(357);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(357);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(357);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(357);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(357);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(357);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(357);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(357);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState358(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 41
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ForStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState359(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(329);
				text.Push("{");
				input.RemoveAt(0);
				return fooState329(false);
			}
			if (input[0] == "if")
			{
				stack.Push(330);
				text.Push("if");
				input.RemoveAt(0);
				return fooState330(false);
			}
			if (input[0] == "while")
			{
				stack.Push(331);
				text.Push("while");
				input.RemoveAt(0);
				return fooState331(false);
			}
			if (input[0] == "for")
			{
				stack.Push(332);
				text.Push("for");
				input.RemoveAt(0);
				return fooState332(false);
			}
			if (input[0] == "return")
			{
				stack.Push(333);
				text.Push("return");
				input.RemoveAt(0);
				return fooState333(false);
			}
			if (input[0] == "break")
			{
				stack.Push(334);
				text.Push("break");
				input.RemoveAt(0);
				return fooState334(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(335);
				text.Push("System.out.println");
				input.RemoveAt(0);
				return fooState335(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState94(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState95(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState96(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				return fooState92(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(364);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState364(false);
			}
			if (afterReduce && text.Peek() == "StmtBlock")
			{
				stack.Push(359);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Stmt")
			{
				stack.Push(359);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "IfStmt")
			{
				stack.Push(359);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "WhileStmt")
			{
				stack.Push(359);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "ForStmt")
			{
				stack.Push(359);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "ReturnStmt")
			{
				stack.Push(359);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "BreakStmt")
			{
				stack.Push(359);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "PrintStmt")
			{
				stack.Push(359);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(359);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(359);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(359);
				return fooState8(false);
			}
			if (afterReduce && text.Peek() == "CallStmt")
			{
				stack.Push(359);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState360(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 40
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("WhileStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState361(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 67
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState362(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				// reduccion por la produccion 67
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState363(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 67
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState364(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (input[0] == "(")
			{
				stack.Push(365);
				text.Push("(");
				input.RemoveAt(0);
				return fooState365(false);
			}
			if (text.Peek() == "-")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "|")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "%")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ">=")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "!=")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == "||")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (input[0] == ".")
			{
				stack.Push(366);
				text.Push(".");
				input.RemoveAt(0);
				return fooState366(false);
			}
			return false;
		}


		public bool fooState365(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(365);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(365);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(365);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Actuals")
			{
				stack.Push(365);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState366(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(383);
				text.Push("(");
				input.RemoveAt(0);
				return fooState383(false);
			}
			return false;
		}


		public bool fooState367(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(384);
				text.Push(")");
				input.RemoveAt(0);
				return fooState384(false);
			}
			return false;
		}


		public bool fooState368(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 71
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Actuals");
				return irA(stack.Peek());
			}
			if (input[0] == "-")
			{
				stack.Push(387);
				text.Push("-");
				input.RemoveAt(0);
				return fooState387(false);
			}
			if (input[0] == "|")
			{
				stack.Push(388);
				text.Push("|");
				input.RemoveAt(0);
				return fooState388(false);
			}
			if (input[0] == "%")
			{
				stack.Push(389);
				text.Push("%");
				input.RemoveAt(0);
				return fooState389(false);
			}
			if (input[0] == ">")
			{
				stack.Push(390);
				text.Push(">");
				input.RemoveAt(0);
				return fooState390(false);
			}
			if (input[0] == ">=")
			{
				stack.Push(391);
				text.Push(">=");
				input.RemoveAt(0);
				return fooState391(false);
			}
			if (input[0] == "!=")
			{
				stack.Push(392);
				text.Push("!=");
				input.RemoveAt(0);
				return fooState392(false);
			}
			if (input[0] == "||")
			{
				stack.Push(393);
				text.Push("||");
				input.RemoveAt(0);
				return fooState393(false);
			}
			if (input[0] == ".")
			{
				stack.Push(394);
				text.Push(".");
				input.RemoveAt(0);
				return fooState394(false);
			}
			if (input[0] == ",")
			{
				stack.Push(385);
				text.Push(",");
				input.RemoveAt(0);
				return fooState385(false);
			}
			return false;
		}


		public bool fooState369(bool afterReduce)
		{
			if (input[0] == "=")
			{
				stack.Push(395);
				text.Push("=");
				input.RemoveAt(0);
				return fooState395(false);
			}
			return false;
		}


		public bool fooState370(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 46
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState371(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 47
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState372(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 48
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState373(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(373);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(373);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(373);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState374(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(374);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(374);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(374);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState375(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(375);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(375);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(375);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState376(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(398);
				text.Push("(");
				input.RemoveAt(0);
				return fooState398(false);
			}
			return false;
		}


		public bool fooState377(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 60
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState378(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 62
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState379(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 63
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState380(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 64
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState381(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 65
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState382(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 66
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState383(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(383);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(383);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(383);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Actuals")
			{
				stack.Push(383);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState384(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 68
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("CallStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState385(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(385);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(385);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(385);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Actuals")
			{
				stack.Push(385);
				return fooState4(false);
			}
			return false;
		}


		public bool fooState386(bool afterReduce)
		{
			return false;
		}


		public bool fooState387(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(387);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(387);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(387);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState388(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(388);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(388);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(388);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState389(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(389);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(389);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(389);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState390(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(390);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(390);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(390);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState391(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(391);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(391);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(391);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState392(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(392);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(392);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(392);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState393(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(393);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(393);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(393);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState394(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(408);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState408(false);
			}
			return false;
		}


		public bool fooState395(bool afterReduce)
		{
			if (input[0] == "(")
			{
				stack.Push(373);
				text.Push("(");
				input.RemoveAt(0);
				return fooState373(false);
			}
			if (int.TryParse(input[0], out int x))
			{
				stack.Push(378);
				text.Push("intConstant");
				input.RemoveAt(0);
				return fooState378(false);
			}
			if (double.TryParse(input[0], out double y))
			{
				stack.Push(379);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				return fooState379(false);
			}
			if (bool.TryParse(input[0], out bool z))
			{
				stack.Push(380);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				return fooState380(false);
			}
			if (Regex.Match(input[0], @"""((\\[^\n]|[^""\n])*)""").Success)
			{
				stack.Push(381);
				text.Push("stringConstant");
				input.RemoveAt(0);
				return fooState381(false);
			}
			if (input[0] == "null")
			{
				stack.Push(382);
				text.Push("null");
				input.RemoveAt(0);
				return fooState382(false);
			}
			if (input[0] == "this")
			{
				stack.Push(372);
				text.Push("this");
				input.RemoveAt(0);
				return fooState372(false);
			}
			if (input[0] == "-")
			{
				stack.Push(374);
				text.Push("-");
				input.RemoveAt(0);
				return fooState374(false);
			}
			if (input[0] == "!")
			{
				stack.Push(375);
				text.Push("!");
				input.RemoveAt(0);
				return fooState375(false);
			}
			if (input[0] == "New")
			{
				stack.Push(376);
				text.Push("New");
				input.RemoveAt(0);
				return fooState376(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(377);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState377(false);
			}
			if (afterReduce && text.Peek() == "Expr")
			{
				stack.Push(395);
				return fooState4(false);
			}
			if (afterReduce && text.Peek() == "Lvalue")
			{
				stack.Push(395);
				return fooState3(false);
			}
			if (afterReduce && text.Peek() == "Constant")
			{
				stack.Push(395);
				return fooState3(false);
			}
			return false;
		}


		public bool fooState396(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 53
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState397(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 58
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState398(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(411);
				text.Push("ident");
				input.RemoveAt(0);
				return fooState411(false);
			}
			return false;
		}


		public bool fooState399(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(412);
				text.Push(")");
				input.RemoveAt(0);
				return fooState412(false);
			}
			return false;
		}


		public bool fooState400(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 70
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Actuals");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState401(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 50
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState402(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 51
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState403(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 52
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState404(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 54
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState405(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 55
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState406(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 56
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState407(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 57
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState408(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			if (text.Peek() == ",")
			{
				// reduccion por la produccion 61
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState409(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 45
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState410(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(413);
				text.Push(")");
				input.RemoveAt(0);
				return fooState413(false);
			}
			return false;
		}


		public bool fooState411(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(414);
				text.Push(")");
				input.RemoveAt(0);
				return fooState414(false);
			}
			return false;
		}


		public bool fooState412(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				// reduccion por la produccion 69
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("CallStmt");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState413(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 49
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool fooState414(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				// reduccion por la produccion 59
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return irA(stack.Peek());
			}
			return false;
		}


		public bool irA(int stackTop)
		{
			switch (stackTop)
			{
				case 0: return fooState0(true);
				case 1: return fooState1(true);
				case 2: return fooState2(true);
				case 3: return fooState3(true);
				case 4: return fooState4(true);
				case 5: return fooState5(true);
				case 6: return fooState6(true);
				case 7: return fooState7(true);
				case 8: return fooState8(true);
				case 9: return fooState9(true);
				case 10: return fooState10(true);
				case 11: return fooState11(true);
				case 12: return fooState12(true);
				case 13: return fooState13(true);
				case 14: return fooState14(true);
				case 15: return fooState15(true);
				case 16: return fooState16(true);
				case 17: return fooState17(true);
				case 18: return fooState18(true);
				case 19: return fooState19(true);
				case 20: return fooState20(true);
				case 21: return fooState21(true);
				case 22: return fooState22(true);
				case 23: return fooState23(true);
				case 24: return fooState24(true);
				case 25: return fooState25(true);
				case 26: return fooState26(true);
				case 27: return fooState27(true);
				case 28: return fooState28(true);
				case 29: return fooState29(true);
				case 30: return fooState30(true);
				case 31: return fooState31(true);
				case 32: return fooState32(true);
				case 33: return fooState33(true);
				case 34: return fooState34(true);
				case 35: return fooState35(true);
				case 36: return fooState36(true);
				case 37: return fooState37(true);
				case 38: return fooState38(true);
				case 39: return fooState39(true);
				case 40: return fooState40(true);
				case 41: return fooState41(true);
				case 42: return fooState42(true);
				case 43: return fooState43(true);
				case 44: return fooState44(true);
				case 45: return fooState45(true);
				case 46: return fooState46(true);
				case 47: return fooState47(true);
				case 48: return fooState48(true);
				case 49: return fooState49(true);
				case 50: return fooState50(true);
				case 51: return fooState51(true);
				case 52: return fooState52(true);
				case 53: return fooState53(true);
				case 54: return fooState54(true);
				case 55: return fooState55(true);
				case 56: return fooState56(true);
				case 57: return fooState57(true);
				case 58: return fooState58(true);
				case 59: return fooState59(true);
				case 60: return fooState60(true);
				case 61: return fooState61(true);
				case 62: return fooState62(true);
				case 63: return fooState63(true);
				case 64: return fooState64(true);
				case 65: return fooState65(true);
				case 66: return fooState66(true);
				case 67: return fooState67(true);
				case 68: return fooState68(true);
				case 69: return fooState69(true);
				case 70: return fooState70(true);
				case 71: return fooState71(true);
				case 72: return fooState72(true);
				case 73: return fooState73(true);
				case 74: return fooState74(true);
				case 75: return fooState75(true);
				case 76: return fooState76(true);
				case 77: return fooState77(true);
				case 78: return fooState78(true);
				case 79: return fooState79(true);
				case 80: return fooState80(true);
				case 81: return fooState81(true);
				case 82: return fooState82(true);
				case 83: return fooState83(true);
				case 84: return fooState84(true);
				case 85: return fooState85(true);
				case 86: return fooState86(true);
				case 87: return fooState87(true);
				case 88: return fooState88(true);
				case 89: return fooState89(true);
				case 90: return fooState90(true);
				case 91: return fooState91(true);
				case 92: return fooState92(true);
				case 93: return fooState93(true);
				case 94: return fooState94(true);
				case 95: return fooState95(true);
				case 96: return fooState96(true);
				case 97: return fooState97(true);
				case 98: return fooState98(true);
				case 99: return fooState99(true);
				case 100: return fooState100(true);
				case 101: return fooState101(true);
				case 102: return fooState102(true);
				case 103: return fooState103(true);
				case 104: return fooState104(true);
				case 105: return fooState105(true);
				case 106: return fooState106(true);
				case 107: return fooState107(true);
				case 108: return fooState108(true);
				case 109: return fooState109(true);
				case 110: return fooState110(true);
				case 111: return fooState111(true);
				case 112: return fooState112(true);
				case 113: return fooState113(true);
				case 114: return fooState114(true);
				case 115: return fooState115(true);
				case 116: return fooState116(true);
				case 117: return fooState117(true);
				case 118: return fooState118(true);
				case 119: return fooState119(true);
				case 120: return fooState120(true);
				case 121: return fooState121(true);
				case 122: return fooState122(true);
				case 123: return fooState123(true);
				case 124: return fooState124(true);
				case 125: return fooState125(true);
				case 126: return fooState126(true);
				case 127: return fooState127(true);
				case 128: return fooState128(true);
				case 129: return fooState129(true);
				case 130: return fooState130(true);
				case 131: return fooState131(true);
				case 132: return fooState132(true);
				case 133: return fooState133(true);
				case 134: return fooState134(true);
				case 135: return fooState135(true);
				case 136: return fooState136(true);
				case 137: return fooState137(true);
				case 138: return fooState138(true);
				case 139: return fooState139(true);
				case 140: return fooState140(true);
				case 141: return fooState141(true);
				case 142: return fooState142(true);
				case 143: return fooState143(true);
				case 144: return fooState144(true);
				case 145: return fooState145(true);
				case 146: return fooState146(true);
				case 147: return fooState147(true);
				case 148: return fooState148(true);
				case 149: return fooState149(true);
				case 150: return fooState150(true);
				case 151: return fooState151(true);
				case 152: return fooState152(true);
				case 153: return fooState153(true);
				case 154: return fooState154(true);
				case 155: return fooState155(true);
				case 156: return fooState156(true);
				case 157: return fooState157(true);
				case 158: return fooState158(true);
				case 159: return fooState159(true);
				case 160: return fooState160(true);
				case 161: return fooState161(true);
				case 162: return fooState162(true);
				case 163: return fooState163(true);
				case 164: return fooState164(true);
				case 165: return fooState165(true);
				case 166: return fooState166(true);
				case 167: return fooState167(true);
				case 168: return fooState168(true);
				case 169: return fooState169(true);
				case 170: return fooState170(true);
				case 171: return fooState171(true);
				case 172: return fooState172(true);
				case 173: return fooState173(true);
				case 174: return fooState174(true);
				case 175: return fooState175(true);
				case 176: return fooState176(true);
				case 177: return fooState177(true);
				case 178: return fooState178(true);
				case 179: return fooState179(true);
				case 180: return fooState180(true);
				case 181: return fooState181(true);
				case 182: return fooState182(true);
				case 183: return fooState183(true);
				case 184: return fooState184(true);
				case 185: return fooState185(true);
				case 186: return fooState186(true);
				case 187: return fooState187(true);
				case 188: return fooState188(true);
				case 189: return fooState189(true);
				case 190: return fooState190(true);
				case 191: return fooState191(true);
				case 192: return fooState192(true);
				case 193: return fooState193(true);
				case 194: return fooState194(true);
				case 195: return fooState195(true);
				case 196: return fooState196(true);
				case 197: return fooState197(true);
				case 198: return fooState198(true);
				case 199: return fooState199(true);
				case 200: return fooState200(true);
				case 201: return fooState201(true);
				case 202: return fooState202(true);
				case 203: return fooState203(true);
				case 204: return fooState204(true);
				case 205: return fooState205(true);
				case 206: return fooState206(true);
				case 207: return fooState207(true);
				case 208: return fooState208(true);
				case 209: return fooState209(true);
				case 210: return fooState210(true);
				case 211: return fooState211(true);
				case 212: return fooState212(true);
				case 213: return fooState213(true);
				case 214: return fooState214(true);
				case 215: return fooState215(true);
				case 216: return fooState216(true);
				case 217: return fooState217(true);
				case 218: return fooState218(true);
				case 219: return fooState219(true);
				case 220: return fooState220(true);
				case 221: return fooState221(true);
				case 222: return fooState222(true);
				case 223: return fooState223(true);
				case 224: return fooState224(true);
				case 225: return fooState225(true);
				case 226: return fooState226(true);
				case 227: return fooState227(true);
				case 228: return fooState228(true);
				case 229: return fooState229(true);
				case 230: return fooState230(true);
				case 231: return fooState231(true);
				case 232: return fooState232(true);
				case 233: return fooState233(true);
				case 234: return fooState234(true);
				case 235: return fooState235(true);
				case 236: return fooState236(true);
				case 237: return fooState237(true);
				case 238: return fooState238(true);
				case 239: return fooState239(true);
				case 240: return fooState240(true);
				case 241: return fooState241(true);
				case 242: return fooState242(true);
				case 243: return fooState243(true);
				case 244: return fooState244(true);
				case 245: return fooState245(true);
				case 246: return fooState246(true);
				case 247: return fooState247(true);
				case 248: return fooState248(true);
				case 249: return fooState249(true);
				case 250: return fooState250(true);
				case 251: return fooState251(true);
				case 252: return fooState252(true);
				case 253: return fooState253(true);
				case 254: return fooState254(true);
				case 255: return fooState255(true);
				case 256: return fooState256(true);
				case 257: return fooState257(true);
				case 258: return fooState258(true);
				case 259: return fooState259(true);
				case 260: return fooState260(true);
				case 261: return fooState261(true);
				case 262: return fooState262(true);
				case 263: return fooState263(true);
				case 264: return fooState264(true);
				case 265: return fooState265(true);
				case 266: return fooState266(true);
				case 267: return fooState267(true);
				case 268: return fooState268(true);
				case 269: return fooState269(true);
				case 270: return fooState270(true);
				case 271: return fooState271(true);
				case 272: return fooState272(true);
				case 273: return fooState273(true);
				case 274: return fooState274(true);
				case 275: return fooState275(true);
				case 276: return fooState276(true);
				case 277: return fooState277(true);
				case 278: return fooState278(true);
				case 279: return fooState279(true);
				case 280: return fooState280(true);
				case 281: return fooState281(true);
				case 282: return fooState282(true);
				case 283: return fooState283(true);
				case 284: return fooState284(true);
				case 285: return fooState285(true);
				case 286: return fooState286(true);
				case 287: return fooState287(true);
				case 288: return fooState288(true);
				case 289: return fooState289(true);
				case 290: return fooState290(true);
				case 291: return fooState291(true);
				case 292: return fooState292(true);
				case 293: return fooState293(true);
				case 294: return fooState294(true);
				case 295: return fooState295(true);
				case 296: return fooState296(true);
				case 297: return fooState297(true);
				case 298: return fooState298(true);
				case 299: return fooState299(true);
				case 300: return fooState300(true);
				case 301: return fooState301(true);
				case 302: return fooState302(true);
				case 303: return fooState303(true);
				case 304: return fooState304(true);
				case 305: return fooState305(true);
				case 306: return fooState306(true);
				case 307: return fooState307(true);
				case 308: return fooState308(true);
				case 309: return fooState309(true);
				case 310: return fooState310(true);
				case 311: return fooState311(true);
				case 312: return fooState312(true);
				case 313: return fooState313(true);
				case 314: return fooState314(true);
				case 315: return fooState315(true);
				case 316: return fooState316(true);
				case 317: return fooState317(true);
				case 318: return fooState318(true);
				case 319: return fooState319(true);
				case 320: return fooState320(true);
				case 321: return fooState321(true);
				case 322: return fooState322(true);
				case 323: return fooState323(true);
				case 324: return fooState324(true);
				case 325: return fooState325(true);
				case 326: return fooState326(true);
				case 327: return fooState327(true);
				case 328: return fooState328(true);
				case 329: return fooState329(true);
				case 330: return fooState330(true);
				case 331: return fooState331(true);
				case 332: return fooState332(true);
				case 333: return fooState333(true);
				case 334: return fooState334(true);
				case 335: return fooState335(true);
				case 336: return fooState336(true);
				case 337: return fooState337(true);
				case 338: return fooState338(true);
				case 339: return fooState339(true);
				case 340: return fooState340(true);
				case 341: return fooState341(true);
				case 342: return fooState342(true);
				case 343: return fooState343(true);
				case 344: return fooState344(true);
				case 345: return fooState345(true);
				case 346: return fooState346(true);
				case 347: return fooState347(true);
				case 348: return fooState348(true);
				case 349: return fooState349(true);
				case 350: return fooState350(true);
				case 351: return fooState351(true);
				case 352: return fooState352(true);
				case 353: return fooState353(true);
				case 354: return fooState354(true);
				case 355: return fooState355(true);
				case 356: return fooState356(true);
				case 357: return fooState357(true);
				case 358: return fooState358(true);
				case 359: return fooState359(true);
				case 360: return fooState360(true);
				case 361: return fooState361(true);
				case 362: return fooState362(true);
				case 363: return fooState363(true);
				case 364: return fooState364(true);
				case 365: return fooState365(true);
				case 366: return fooState366(true);
				case 367: return fooState367(true);
				case 368: return fooState368(true);
				case 369: return fooState369(true);
				case 370: return fooState370(true);
				case 371: return fooState371(true);
				case 372: return fooState372(true);
				case 373: return fooState373(true);
				case 374: return fooState374(true);
				case 375: return fooState375(true);
				case 376: return fooState376(true);
				case 377: return fooState377(true);
				case 378: return fooState378(true);
				case 379: return fooState379(true);
				case 380: return fooState380(true);
				case 381: return fooState381(true);
				case 382: return fooState382(true);
				case 383: return fooState383(true);
				case 384: return fooState384(true);
				case 385: return fooState385(true);
				case 386: return fooState386(true);
				case 387: return fooState387(true);
				case 388: return fooState388(true);
				case 389: return fooState389(true);
				case 390: return fooState390(true);
				case 391: return fooState391(true);
				case 392: return fooState392(true);
				case 393: return fooState393(true);
				case 394: return fooState394(true);
				case 395: return fooState395(true);
				case 396: return fooState396(true);
				case 397: return fooState397(true);
				case 398: return fooState398(true);
				case 399: return fooState399(true);
				case 400: return fooState400(true);
				case 401: return fooState401(true);
				case 402: return fooState402(true);
				case 403: return fooState403(true);
				case 404: return fooState404(true);
				case 405: return fooState405(true);
				case 406: return fooState406(true);
				case 407: return fooState407(true);
				case 408: return fooState408(true);
				case 409: return fooState409(true);
				case 410: return fooState410(true);
				case 411: return fooState411(true);
				case 412: return fooState412(true);
				case 413: return fooState413(true);
				case 414: return fooState414(true);
				default: return false;
			}
		}






	}
}