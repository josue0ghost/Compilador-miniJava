using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minij
{
    class LRanalysis
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
				stack.Push(0);
				return fooState12(false);
			}
			if (input[0] == "interface")
			{
				stack.Push(13);
				text.Push("interface");
				input.RemoveAt(0);
				stack.Push(0);
				return fooState13(false);
			}
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(0);
				return fooState18(false);
			}
			if (input[0] == "static")
			{
				stack.Push(11);
				text.Push("static");
				input.RemoveAt(0);
				stack.Push(0);
				return fooState11(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(0);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(0);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(0);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(0);
				return fooState17(false);
			}
			if (input[0] == "void")
			{
				stack.Push(10);
				text.Push("void");
				input.RemoveAt(0);
				stack.Push(0);
				return fooState10(false);
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
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Program");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState3(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState4(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState5(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState6(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState7(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Decl");
				return fooStateCAMBIAR();
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
				stack.Push(8);
				return fooState19(false);
			}
			return false;
		}


		public bool fooState9(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(20);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(9);
				return fooState20(false);
			}
			if (input[0] == "[ ]")
			{
				stack.Push(21);
				text.Push("[ ]");
				input.RemoveAt(0);
				stack.Push(9);
				return fooState21(false);
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
				stack.Push(10);
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
				stack.Push(11);
				return fooState24(false);
			}
			if (input[0] == "double")
			{
				stack.Push(25);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(11);
				return fooState25(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(26);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(11);
				return fooState26(false);
			}
			if (input[0] == "string")
			{
				stack.Push(27);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(11);
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
				stack.Push(12);
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
				stack.Push(13);
				return fooState29(false);
			}
			return false;
		}


		public bool fooState14(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "[ ]")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState15(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "[ ]")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState16(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "[ ]")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState17(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "[ ]")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState18(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "[ ]")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState19(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("VariableDecl");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState20(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Variable");
				return fooStateCAMBIAR();
			}
			if (input[0] == "(")
			{
				stack.Push(30);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(20);
				return fooState30(false);
			}
			return false;
		}


		public bool fooState21(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "[ ]")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
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
				stack.Push(22);
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
				stack.Push(23);
				return fooState32(false);
			}
			return false;
		}


		public bool fooState24(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState25(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState26(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState27(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return fooStateCAMBIAR();
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
				stack.Push(28);
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
				stack.Push(29);
				return fooState34(false);
			}
			return false;
		}


		public bool fooState30(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(30);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(30);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(30);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(30);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(30);
				return fooState17(false);
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
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(31);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(31);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(31);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(31);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(31);
				return fooState17(false);
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
				stack.Push(32);
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
				stack.Push(33);
				return fooState40(false);
			}
			return false;
		}


		public bool fooState34(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(34);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(34);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(34);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(34);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(34);
				return fooState17(false);
			}
			if (input[0] == "void")
			{
				stack.Push(43);
				text.Push("void");
				input.RemoveAt(0);
				stack.Push(34);
				return fooState43(false);
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
				stack.Push(35);
				return fooState44(false);
			}
			return false;
		}


		public bool fooState36(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Formals");
				return fooStateCAMBIAR();
			}
			if (input[0] == ",")
			{
				stack.Push(45);
				text.Push(",");
				input.RemoveAt(0);
				stack.Push(36);
				return fooState45(false);
			}
			return false;
		}


		public bool fooState37(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(46);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(37);
				return fooState46(false);
			}
			if (input[0] == "[ ]")
			{
				stack.Push(318);
				text.Push("[ ]");
				input.RemoveAt(0);
				stack.Push(37);
				return fooState318(false);
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
				stack.Push(38);
				return fooState47(false);
			}
			return false;
		}


		public bool fooState39(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
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
				stack.Push(40);
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
				stack.Push(41);
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
				stack.Push(42);
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
				stack.Push(43);
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
				stack.Push(44);
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
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(45);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(45);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(45);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(45);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(45);
				return fooState17(false);
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
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Variable");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Variable");
				return fooStateCAMBIAR();
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
				stack.Push(47);
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
				stack.Push(48);
				return fooState56(false);
			}
			return false;
		}


		public bool fooState49(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("InterfaceDecl");
				return fooStateCAMBIAR();
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
				stack.Push(50);
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
				stack.Push(51);
				return fooState58(false);
			}
			return false;
		}


		public bool fooState52(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("FunctionDecl");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState53(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(53);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(53);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(53);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(53);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(53);
				return fooState17(false);
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
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Formals");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState55(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("FunctionDecl");
				return fooStateCAMBIAR();
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
				stack.Push(56);
				return fooState61(false);
			}
			return false;
		}


		public bool fooState57(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(57);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(57);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(57);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(57);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(57);
				return fooState17(false);
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
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(58);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(58);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(58);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(58);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(58);
				return fooState17(false);
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
				stack.Push(59);
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
				stack.Push(60);
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
				stack.Push(61);
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
				stack.Push(62);
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
				stack.Push(63);
				return fooState69(false);
			}
			return false;
		}


		public bool fooState64(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState85(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(64);
				return fooState92(false);
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
			return false;
		}


		public bool fooState65(bool afterReduce)
		{
			if (input[0] == "int")
			{
				stack.Push(100);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(65);
				return fooState100(false);
			}
			if (input[0] == "double")
			{
				stack.Push(101);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(65);
				return fooState101(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(102);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(65);
				return fooState102(false);
			}
			if (input[0] == "string")
			{
				stack.Push(103);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(65);
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
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("VariableDecl");
				return fooStateCAMBIAR();
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
				stack.Push(67);
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
				stack.Push(68);
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
				stack.Push(69);
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
				stack.Push(70);
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
				stack.Push(71);
				return fooState108(false);
			}
			if (input[0] == "-")
			{
				stack.Push(109);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(71);
				return fooState109(false);
			}
			if (input[0] == "|")
			{
				stack.Push(110);
				text.Push("|");
				input.RemoveAt(0);
				stack.Push(71);
				return fooState110(false);
			}
			if (input[0] == "%")
			{
				stack.Push(111);
				text.Push("%");
				input.RemoveAt(0);
				stack.Push(71);
				return fooState111(false);
			}
			if (input[0] == ">")
			{
				stack.Push(112);
				text.Push(">");
				input.RemoveAt(0);
				stack.Push(71);
				return fooState112(false);
			}
			if (input[0] == ">=")
			{
				stack.Push(113);
				text.Push(">=");
				input.RemoveAt(0);
				stack.Push(71);
				return fooState113(false);
			}
			if (input[0] == "!=")
			{
				stack.Push(114);
				text.Push("!=");
				input.RemoveAt(0);
				stack.Push(71);
				return fooState114(false);
			}
			if (input[0] == "||")
			{
				stack.Push(115);
				text.Push("||");
				input.RemoveAt(0);
				stack.Push(71);
				return fooState115(false);
			}
			if (input[0] == ".")
			{
				stack.Push(116);
				text.Push(".");
				input.RemoveAt(0);
				stack.Push(71);
				return fooState116(false);
			}
			return false;
		}


		public bool fooState72(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState73(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState74(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState75(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState76(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState77(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState78(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState79(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(79);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(79);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(79);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(79);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(79);
				return fooState17(false);
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
				stack.Push(80);
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
				stack.Push(81);
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
				stack.Push(82);
				return fooState120(false);
			}
			return false;
		}


		public bool fooState83(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(83);
				return fooState92(false);
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
				stack.Push(84);
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
				stack.Push(85);
				return fooState123(false);
			}
			return false;
		}


		public bool fooState86(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (input[0] == "=")
			{
				stack.Push(124);
				text.Push("=");
				input.RemoveAt(0);
				stack.Push(86);
				return fooState124(false);
			}
			return false;
		}


		public bool fooState87(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState88(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState89(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(89);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(90);
				return fooState92(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(91);
				return fooState92(false);
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
				stack.Push(92);
				return fooState142(false);
			}
			return false;
		}


		public bool fooState93(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState94(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState95(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState96(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState97(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState98(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
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
				stack.Push(99);
				return fooState143(false);
			}
			return false;
		}


		public bool fooState100(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState101(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState102(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState103(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstType");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState104(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(104);
				return fooState18(false);
			}
			if (input[0] == "static")
			{
				stack.Push(151);
				text.Push("static");
				input.RemoveAt(0);
				stack.Push(104);
				return fooState151(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(104);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(104);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(104);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(104);
				return fooState17(false);
			}
			if (input[0] == "void")
			{
				stack.Push(150);
				text.Push("void");
				input.RemoveAt(0);
				stack.Push(104);
				return fooState150(false);
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
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Prototype");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState106(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Prototype");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState107(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("StmtBlock");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState108(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState109(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(109);
				return fooState92(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(110);
				return fooState92(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(111);
				return fooState92(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(112);
				return fooState92(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(113);
				return fooState92(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(114);
				return fooState92(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(115);
				return fooState92(false);
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
				stack.Push(116);
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
				stack.Push(117);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(118);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(119);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(120);
				return fooState92(false);
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
				stack.Push(121);
				return fooState164(false);
			}
			return false;
		}


		public bool fooState122(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("BreakStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState123(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(123);
				return fooState173(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(124);
				return fooState92(false);
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
				stack.Push(125);
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
				stack.Push(126);
				return fooState182(false);
			}
			return false;
		}


		public bool fooState127(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState128(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState129(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(129);
				return fooState133(false);
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
				stack.Push(130);
				return fooState184(false);
			}
			if (input[0] == "|")
			{
				stack.Push(185);
				text.Push("|");
				input.RemoveAt(0);
				stack.Push(130);
				return fooState185(false);
			}
			if (input[0] == "%")
			{
				stack.Push(186);
				text.Push("%");
				input.RemoveAt(0);
				stack.Push(130);
				return fooState186(false);
			}
			if (input[0] == ">")
			{
				stack.Push(187);
				text.Push(">");
				input.RemoveAt(0);
				stack.Push(130);
				return fooState187(false);
			}
			if (input[0] == ">=")
			{
				stack.Push(188);
				text.Push(">=");
				input.RemoveAt(0);
				stack.Push(130);
				return fooState188(false);
			}
			if (input[0] == "!=")
			{
				stack.Push(189);
				text.Push("!=");
				input.RemoveAt(0);
				stack.Push(130);
				return fooState189(false);
			}
			if (input[0] == "||")
			{
				stack.Push(190);
				text.Push("||");
				input.RemoveAt(0);
				stack.Push(130);
				return fooState190(false);
			}
			if (input[0] == ".")
			{
				stack.Push(191);
				text.Push(".");
				input.RemoveAt(0);
				stack.Push(130);
				return fooState191(false);
			}
			return false;
		}


		public bool fooState131(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(131);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(132);
				return fooState133(false);
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
				stack.Push(133);
				return fooState194(false);
			}
			return false;
		}


		public bool fooState134(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState135(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState136(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState137(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState138(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState139(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState140(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState141(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
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
				stack.Push(142);
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
				stack.Push(143);
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
				stack.Push(144);
				return fooState197(false);
			}
			return false;
		}


		public bool fooState145(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Field");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState146(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Field");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState147(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Field");
				return fooStateCAMBIAR();
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
				stack.Push(148);
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
				stack.Push(149);
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
				stack.Push(150);
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
				stack.Push(151);
				return fooState100(false);
			}
			if (input[0] == "double")
			{
				stack.Push(101);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(151);
				return fooState101(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(102);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(151);
				return fooState102(false);
			}
			if (input[0] == "string")
			{
				stack.Push(103);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(151);
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
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState153(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState154(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState155(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState156(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState157(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState158(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
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
				stack.Push(159);
				return fooState202(false);
			}
			return false;
		}


		public bool fooState160(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState85(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(160);
				return fooState92(false);
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
			return false;
		}


		public bool fooState161(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(204);
				text.Push(")");
				input.RemoveAt(0);
				stack.Push(161);
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
				stack.Push(162);
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
				stack.Push(163);
				return fooState206(false);
			}
			return false;
		}


		public bool fooState164(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ReturnStmt");
				return fooStateCAMBIAR();
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
				stack.Push(165);
				return fooState207(false);
			}
			return false;
		}


		public bool fooState166(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (input[0] == "=")
			{
				stack.Push(208);
				text.Push("=");
				input.RemoveAt(0);
				stack.Push(166);
				return fooState208(false);
			}
			return false;
		}


		public bool fooState167(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState168(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState169(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(169);
				return fooState133(false);
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
				stack.Push(170);
				return fooState210(false);
			}
			if (input[0] == "|")
			{
				stack.Push(211);
				text.Push("|");
				input.RemoveAt(0);
				stack.Push(170);
				return fooState211(false);
			}
			if (input[0] == "%")
			{
				stack.Push(212);
				text.Push("%");
				input.RemoveAt(0);
				stack.Push(170);
				return fooState212(false);
			}
			if (input[0] == ">")
			{
				stack.Push(213);
				text.Push(">");
				input.RemoveAt(0);
				stack.Push(170);
				return fooState213(false);
			}
			if (input[0] == ">=")
			{
				stack.Push(214);
				text.Push(">=");
				input.RemoveAt(0);
				stack.Push(170);
				return fooState214(false);
			}
			if (input[0] == "!=")
			{
				stack.Push(215);
				text.Push("!=");
				input.RemoveAt(0);
				stack.Push(170);
				return fooState215(false);
			}
			if (input[0] == "||")
			{
				stack.Push(216);
				text.Push("||");
				input.RemoveAt(0);
				stack.Push(170);
				return fooState216(false);
			}
			if (input[0] == ".")
			{
				stack.Push(217);
				text.Push(".");
				input.RemoveAt(0);
				stack.Push(170);
				return fooState217(false);
			}
			return false;
		}


		public bool fooState171(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(171);
				return fooState173(false);
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
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(172);
				return fooState173(false);
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
				stack.Push(173);
				return fooState220(false);
			}
			return false;
		}


		public bool fooState174(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState175(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState176(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState177(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState178(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState179(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Constant");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState180(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState181(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState182(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(182);
				return fooState133(false);
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
				stack.Push(183);
				return fooState317(false);
			}
			return false;
		}


		public bool fooState184(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(184);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(185);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(186);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(187);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(188);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(189);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(190);
				return fooState133(false);
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
				stack.Push(191);
				return fooState229(false);
			}
			return false;
		}


		public bool fooState192(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState193(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
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
				stack.Push(194);
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
				stack.Push(195);
				return fooState231(false);
			}
			return false;
		}


		public bool fooState196(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "{")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "if")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "while")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "for")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "return")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "break")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "System.out.println")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "intConstant")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "doubleConstant")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "booleanConstant")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "stringConstant")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "null")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "this")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "New")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState197(bool afterReduce)
		{
			if (text.Peek() == "$")
			{
				for (int i = 0; i < 10; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ClassDecl");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState198(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("VariableDecl");
				return fooStateCAMBIAR();
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
				stack.Push(199);
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
				stack.Push(200);
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
				stack.Push(201);
				return fooState234(false);
			}
			return false;
		}


		public bool fooState202(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
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
				stack.Push(203);
				return fooState235(false);
			}
			return false;
		}


		public bool fooState204(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(245);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState245(false);
			}
			if (input[0] == "if")
			{
				stack.Push(246);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState246(false);
			}
			if (input[0] == "while")
			{
				stack.Push(247);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState247(false);
			}
			if (input[0] == "for")
			{
				stack.Push(248);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState248(false);
			}
			if (input[0] == "return")
			{
				stack.Push(249);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState249(false);
			}
			if (input[0] == "break")
			{
				stack.Push(250);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState250(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(251);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState251(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(204);
				return fooState92(false);
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
			return false;
		}


		public bool fooState205(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState85(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(205);
				return fooState92(false);
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
			return false;
		}


		public bool fooState206(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(206);
				return fooState92(false);
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
				stack.Push(207);
				return fooState239(false);
			}
			return false;
		}


		public bool fooState208(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(208);
				return fooState173(false);
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
				stack.Push(209);
				return fooState241(false);
			}
			return false;
		}


		public bool fooState210(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(210);
				return fooState173(false);
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
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(211);
				return fooState173(false);
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
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(212);
				return fooState173(false);
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
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(213);
				return fooState173(false);
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
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(214);
				return fooState173(false);
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
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(215);
				return fooState173(false);
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
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(216);
				return fooState173(false);
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
				stack.Push(217);
				return fooState249(false);
			}
			return false;
		}


		public bool fooState218(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState219(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
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
				stack.Push(220);
				return fooState250(false);
			}
			return false;
		}


		public bool fooState221(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState222(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState223(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState224(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState225(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState226(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState227(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState228(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState229(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
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
				stack.Push(230);
				return fooState251(false);
			}
			return false;
		}


		public bool fooState231(bool afterReduce)
		{
			if (text.Peek() == ";")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState232(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(232);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(232);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(232);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(232);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(232);
				return fooState17(false);
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
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(233);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(233);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(233);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(233);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(233);
				return fooState17(false);
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
				stack.Push(234);
				return fooState254(false);
			}
			return false;
		}


		public bool fooState235(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("StmtBlock");
				return fooStateCAMBIAR();
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
				stack.Push(236);
				return fooState255(false);
			}
			return false;
		}


		public bool fooState237(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("WhileStmt");
				return fooStateCAMBIAR();
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
				stack.Push(238);
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
				stack.Push(239);
				return fooState257(false);
			}
			return false;
		}


		public bool fooState240(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState241(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState242(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState243(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState244(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState245(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState246(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState247(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState248(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState249(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("LValue");
				return fooStateCAMBIAR();
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
				stack.Push(250);
				return fooState258(false);
			}
			return false;
		}


		public bool fooState251(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
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
				stack.Push(252);
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
				stack.Push(253);
				return fooState260(false);
			}
			return false;
		}


		public bool fooState254(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ConstDecl");
				return fooStateCAMBIAR();
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
				stack.Push(255);
				return fooState261(false);
			}
			return false;
		}


		public bool fooState256(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(256);
				return fooState133(false);
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
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("PrintStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState258(bool afterReduce)
		{
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ",")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
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
				stack.Push(259);
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
				stack.Push(260);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(274);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState274(false);
			}
			if (input[0] == "if")
			{
				stack.Push(275);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState275(false);
			}
			if (input[0] == "while")
			{
				stack.Push(276);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState276(false);
			}
			if (input[0] == "for")
			{
				stack.Push(277);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState277(false);
			}
			if (input[0] == "return")
			{
				stack.Push(278);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState278(false);
			}
			if (input[0] == "break")
			{
				stack.Push(279);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState279(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(280);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState280(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(261);
				return fooState92(false);
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
			return false;
		}


		public bool fooState262(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(281);
				text.Push(")");
				input.RemoveAt(0);
				stack.Push(262);
				return fooState281(false);
			}
			return false;
		}


		public bool fooState263(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("FunctionDecl");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState264(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("FunctionDecl");
				return fooStateCAMBIAR();
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
				stack.Push(265);
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
				stack.Push(266);
				return fooState283(false);
			}
			return false;
		}


		public bool fooState267(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState268(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState269(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState270(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState271(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState272(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState273(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState274(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(274);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(274);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(274);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(274);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(274);
				return fooState17(false);
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
				stack.Push(275);
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
				stack.Push(276);
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
				stack.Push(277);
				return fooState287(false);
			}
			return false;
		}


		public bool fooState278(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(278);
				return fooState92(false);
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
				stack.Push(279);
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
				stack.Push(280);
				return fooState290(false);
			}
			return false;
		}


		public bool fooState281(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState85(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(281);
				return fooState92(false);
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
			return false;
		}


		public bool fooState282(bool afterReduce)
		{
			if (text.Peek() == "}")
			{
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("IfStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState283(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
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
				stack.Push(284);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(285);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(286);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(287);
				return fooState92(false);
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
				stack.Push(288);
				return fooState296(false);
			}
			return false;
		}


		public bool fooState289(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("BreakStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState290(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(290);
				return fooState173(false);
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
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ForStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState292(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState85(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(292);
				return fooState92(false);
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
			return false;
		}


		public bool fooState293(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(299);
				text.Push(")");
				input.RemoveAt(0);
				stack.Push(293);
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
				stack.Push(294);
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
				stack.Push(295);
				return fooState301(false);
			}
			return false;
		}


		public bool fooState296(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ReturnStmt");
				return fooStateCAMBIAR();
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
				stack.Push(297);
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
				stack.Push(298);
				return fooState303(false);
			}
			return false;
		}


		public bool fooState299(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(329);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState329(false);
			}
			if (input[0] == "if")
			{
				stack.Push(330);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState330(false);
			}
			if (input[0] == "while")
			{
				stack.Push(331);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState331(false);
			}
			if (input[0] == "for")
			{
				stack.Push(332);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState332(false);
			}
			if (input[0] == "return")
			{
				stack.Push(333);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState333(false);
			}
			if (input[0] == "break")
			{
				stack.Push(334);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState334(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(335);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState335(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(299);
				return fooState92(false);
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
			return false;
		}


		public bool fooState300(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(274);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState274(false);
			}
			if (input[0] == "if")
			{
				stack.Push(275);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState275(false);
			}
			if (input[0] == "while")
			{
				stack.Push(276);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState276(false);
			}
			if (input[0] == "for")
			{
				stack.Push(277);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState277(false);
			}
			if (input[0] == "return")
			{
				stack.Push(278);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState278(false);
			}
			if (input[0] == "break")
			{
				stack.Push(279);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState279(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(280);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState280(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(300);
				return fooState92(false);
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
			return false;
		}


		public bool fooState301(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(301);
				return fooState92(false);
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
				stack.Push(302);
				return fooState307(false);
			}
			return false;
		}


		public bool fooState303(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("StmtBlock");
				return fooStateCAMBIAR();
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
				stack.Push(304);
				return fooState308(false);
			}
			return false;
		}


		public bool fooState305(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("WhileStmt");
				return fooStateCAMBIAR();
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
				stack.Push(306);
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
				stack.Push(307);
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
				stack.Push(308);
				return fooState311(false);
			}
			return false;
		}


		public bool fooState309(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(309);
				return fooState133(false);
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
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("PrintStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState311(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(274);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState274(false);
			}
			if (input[0] == "if")
			{
				stack.Push(275);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState275(false);
			}
			if (input[0] == "while")
			{
				stack.Push(276);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState276(false);
			}
			if (input[0] == "for")
			{
				stack.Push(277);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState277(false);
			}
			if (input[0] == "return")
			{
				stack.Push(278);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState278(false);
			}
			if (input[0] == "break")
			{
				stack.Push(279);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState279(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(280);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState280(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(311);
				return fooState92(false);
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
			return false;
		}


		public bool fooState312(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(314);
				text.Push(")");
				input.RemoveAt(0);
				stack.Push(312);
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
				stack.Push(313);
				return fooState315(false);
			}
			return false;
		}


		public bool fooState314(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(274);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState274(false);
			}
			if (input[0] == "if")
			{
				stack.Push(275);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState275(false);
			}
			if (input[0] == "while")
			{
				stack.Push(276);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState276(false);
			}
			if (input[0] == "for")
			{
				stack.Push(277);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState277(false);
			}
			if (input[0] == "return")
			{
				stack.Push(278);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState278(false);
			}
			if (input[0] == "break")
			{
				stack.Push(279);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState279(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(280);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState280(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(314);
				return fooState92(false);
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
			return false;
		}


		public bool fooState315(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("IfStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState316(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ForStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState317(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState318(bool afterReduce)
		{
			if (text.Peek() == "ident")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "[ ]")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Type");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState319(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState320(bool afterReduce)
		{
			if (text.Peek() == ")")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "-")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "|")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "%")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ">=")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "!=")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == "||")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
			}
			if (text.Peek() == ".")
			{
				for (int i = 0; i < 4; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Expr");
				return fooStateCAMBIAR();
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
				stack.Push(321);
				return fooState336(false);
			}
			return false;
		}


		public bool fooState322(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState323(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState324(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState325(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState326(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState327(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState328(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 1; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState329(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(18);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(329);
				return fooState18(false);
			}
			if (input[0] == "int")
			{
				stack.Push(14);
				text.Push("int");
				input.RemoveAt(0);
				stack.Push(329);
				return fooState14(false);
			}
			if (input[0] == "double")
			{
				stack.Push(15);
				text.Push("double");
				input.RemoveAt(0);
				stack.Push(329);
				return fooState15(false);
			}
			if (input[0] == "boolean")
			{
				stack.Push(16);
				text.Push("boolean");
				input.RemoveAt(0);
				stack.Push(329);
				return fooState16(false);
			}
			if (input[0] == "string")
			{
				stack.Push(17);
				text.Push("string");
				input.RemoveAt(0);
				stack.Push(329);
				return fooState17(false);
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
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("IfStmt");
				return fooStateCAMBIAR();
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
				stack.Push(331);
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
				stack.Push(332);
				return fooState339(false);
			}
			return false;
		}


		public bool fooState333(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(333);
				return fooState92(false);
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
				stack.Push(334);
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
				stack.Push(335);
				return fooState342(false);
			}
			return false;
		}


		public bool fooState336(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("Stmt");
				return fooStateCAMBIAR();
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
				stack.Push(337);
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
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(338);
				return fooState133(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(339);
				return fooState92(false);
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
				stack.Push(340);
				return fooState346(false);
			}
			return false;
		}


		public bool fooState341(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 2; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("BreakStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState342(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(174);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState174(false);
			}
			if (input[0] == "(")
			{
				stack.Push(169);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState169(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(175);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState175(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(176);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState176(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(177);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState177(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(178);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState178(false);
			}
			if (input[0] == "null")
			{
				stack.Push(179);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState179(false);
			}
			if (input[0] == "this")
			{
				stack.Push(168);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState168(false);
			}
			if (input[0] == "-")
			{
				stack.Push(171);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState171(false);
			}
			if (input[0] == "!")
			{
				stack.Push(172);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState172(false);
			}
			if (input[0] == "New")
			{
				stack.Push(173);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(342);
				return fooState173(false);
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
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(79);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState79(false);
			}
			if (input[0] == "if")
			{
				stack.Push(80);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState80(false);
			}
			if (input[0] == "while")
			{
				stack.Push(81);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState81(false);
			}
			if (input[0] == "for")
			{
				stack.Push(82);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState82(false);
			}
			if (input[0] == "return")
			{
				stack.Push(83);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState83(false);
			}
			if (input[0] == "break")
			{
				stack.Push(84);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState84(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(85);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState85(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(343);
				return fooState92(false);
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
			return false;
		}


		public bool fooState344(bool afterReduce)
		{
			if (input[0] == ")")
			{
				stack.Push(359);
				text.Push(")");
				input.RemoveAt(0);
				stack.Push(344);
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
				stack.Push(345);
				return fooState349(false);
			}
			return false;
		}


		public bool fooState346(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 3; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ReturnStmt");
				return fooStateCAMBIAR();
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
				stack.Push(347);
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
				stack.Push(348);
				return fooState351(false);
			}
			return false;
		}


		public bool fooState349(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState89(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(349);
				return fooState92(false);
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
				stack.Push(350);
				return fooState353(false);
			}
			return false;
		}


		public bool fooState351(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("StmtBlock");
				return fooStateCAMBIAR();
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
				stack.Push(352);
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
				stack.Push(353);
				return fooState355(false);
			}
			return false;
		}


		public bool fooState354(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(134);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState134(false);
			}
			if (input[0] == "(")
			{
				stack.Push(129);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState129(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(135);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState135(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(136);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState136(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(137);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState137(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(138);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState138(false);
			}
			if (input[0] == "null")
			{
				stack.Push(139);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState139(false);
			}
			if (input[0] == "this")
			{
				stack.Push(128);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState128(false);
			}
			if (input[0] == "-")
			{
				stack.Push(131);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState131(false);
			}
			if (input[0] == "!")
			{
				stack.Push(132);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState132(false);
			}
			if (input[0] == "New")
			{
				stack.Push(133);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(354);
				return fooState133(false);
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
				for (int i = 0; i < 6; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("PrintStmt");
				return fooStateCAMBIAR();
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
				stack.Push(356);
				return fooState357(false);
			}
			return false;
		}


		public bool fooState357(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(329);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState329(false);
			}
			if (input[0] == "if")
			{
				stack.Push(330);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState330(false);
			}
			if (input[0] == "while")
			{
				stack.Push(331);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState331(false);
			}
			if (input[0] == "for")
			{
				stack.Push(332);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState332(false);
			}
			if (input[0] == "return")
			{
				stack.Push(333);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState333(false);
			}
			if (input[0] == "break")
			{
				stack.Push(334);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState334(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(335);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState335(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(357);
				return fooState92(false);
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
			return false;
		}


		public bool fooState358(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 9; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("ForStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState359(bool afterReduce)
		{
			if (input[0] == "ident")
			{
				stack.Push(93);
				text.Push("ident");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState93(false);
			}
			if (input[0] == "(")
			{
				stack.Push(89);
				text.Push("(");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState89(false);
			}
			if (input[0] == "{")
			{
				stack.Push(329);
				text.Push("{");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState329(false);
			}
			if (input[0] == "if")
			{
				stack.Push(330);
				text.Push("if");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState330(false);
			}
			if (input[0] == "while")
			{
				stack.Push(331);
				text.Push("while");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState331(false);
			}
			if (input[0] == "for")
			{
				stack.Push(332);
				text.Push("for");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState332(false);
			}
			if (input[0] == "return")
			{
				stack.Push(333);
				text.Push("return");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState333(false);
			}
			if (input[0] == "break")
			{
				stack.Push(334);
				text.Push("break");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState334(false);
			}
			if (input[0] == "System.out.println")
			{
				stack.Push(335);
				text.Push("System.out.println");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState335(false);
			}
			if (input[0] == "intConstant")
			{
				stack.Push(94);
				text.Push("intConstant");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState94(false);
			}
			if (input[0] == "doubleConstant")
			{
				stack.Push(95);
				text.Push("doubleConstant");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState95(false);
			}
			if (input[0] == "booleanConstant")
			{
				stack.Push(96);
				text.Push("booleanConstant");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState96(false);
			}
			if (input[0] == "stringConstant")
			{
				stack.Push(97);
				text.Push("stringConstant");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState97(false);
			}
			if (input[0] == "null")
			{
				stack.Push(98);
				text.Push("null");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState98(false);
			}
			if (input[0] == "this")
			{
				stack.Push(88);
				text.Push("this");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState88(false);
			}
			if (input[0] == "-")
			{
				stack.Push(90);
				text.Push("-");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState90(false);
			}
			if (input[0] == "!")
			{
				stack.Push(91);
				text.Push("!");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState91(false);
			}
			if (input[0] == "New")
			{
				stack.Push(92);
				text.Push("New");
				input.RemoveAt(0);
				stack.Push(359);
				return fooState92(false);
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
			return false;
		}


		public bool fooState360(bool afterReduce)
		{
			if (text.Peek() == "(")
			{
				for (int i = 0; i < 5; i++)
				{
					stack.Pop();
					text.Pop();
				}
				text.Push("WhileStmt");
				return fooStateCAMBIAR();
			}
			return false;
		}


		public bool fooState361(bool afterReduce)
		{
			return false;
		}


		public bool fooState362(bool afterReduce)
		{
			return false;
		}
	}
}
