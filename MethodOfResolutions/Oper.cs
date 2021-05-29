using System;

namespace L1_calc
{
		public static class Oper
		{
				public static int Computation(int x, int y, char oper)
				{
						switch (oper)
						{
								case '+'://ИЛИ
										return x | y;
								case '!':// НЕ
										return x | ((y - 1) * (y - 1));
								case '*'://И
										return x & y;
								case '>'://->
										return ((x - 1) * (x - 1)) | y;// !X + Y
						}

						Console.WriteLine("Err");
						return 0;
				}

				public static bool isOperation(char ch)
				{
						return (ch == '+' || ch == '!' || ch == '*' || ch == '>');
				}
		}
}
