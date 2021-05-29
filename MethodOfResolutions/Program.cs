using System;
using System.Collections.Generic;

namespace L1_calc
{
		class Program
		{
				static void Main(string[] args)
				{
						Console.WriteLine("Алфавит: + * ! >");
						Console.WriteLine("Введите количество посылок:");
						int n_pos = Convert.ToInt32(Console.ReadLine());
						var knf = new List<List<string>>();

						for (int i_pos = 0; i_pos < n_pos + 1; i_pos++)
						{
								string input = "";

								if (i_pos == n_pos)//посылки закончились, надо ввести следствие
								{
										Console.WriteLine("Введите следствие:");
										input = Console.ReadLine();
										input = "!(" + input + ")";
								}
								else
								{
										input = Console.ReadLine();
								}

								List<char> listvar = new List<char>();
								foreach (char ch in input)
								{
										if (!Oper.isOperation(ch) && ch != ' ' && ch != '(' && ch != ')' && !listvar.Contains(ch))
										{
												listvar.Add(ch);
										}
								}

								int n = listvar.Count;
								var x = new int[n];//вектор возможных значений, от 00..0 до 11..1
								int m = 1 << n;


								///COMPUT
								if (CompValueOfLogicFunc(input, listvar, x) == 0)
								{
										var disun = new List<string>();
										for (int variab = 0; variab < listvar.Count; variab++)
										{
												if (x[variab] == 1)
												{
														disun.Add("!" + Convert.ToString(listvar[variab]));
												}
												if (x[variab] == 0)
												{
														disun.Add(Convert.ToString(listvar[variab]));
												}
										}
										knf.Add(disun);
								}
								///COMPUT_END

								for (int i = 0; i < m - 1; i++)
								{
										for (int j = 0; j < n; j++)
										{
												if ((i + 1) % (1 << (n - (j + 1))) == 0)
												{
														x[j] = (x[j] - 1) * (x[j] - 1);//!x[j]
												}
										}
										///COMPUT
										if (CompValueOfLogicFunc(input, listvar, x) == 0)
										{
												var disun = new List<string>();
												for (int variab = 0; variab < listvar.Count; variab++)
												{
														if (x[variab] == 1)
														{
																disun.Add("!" + Convert.ToString(listvar[variab]));
														}
														if (x[variab] == 0)
														{
																disun.Add(Convert.ToString(listvar[variab]));
														}
												}
												knf.Add(disun);
										}
										///COMPUT_END
								}
						}

						var knfN = knf.Count;
						for (int jjj = 0; jjj < 100; jjj++)
						{
								for (int i = 0; i < knfN; i++)
								{
										knf.Add(knf[i]);
								}
						}

						start_check_knf:
						for (int i = 0; i < knf.Count; i++)
						{
								for (int j = 0; j < knf[i].Count; j++)
								{
										//knf[i][j]  // [!A]+B+!C      ...         ...
										for (int ii = i + 1; ii < knf.Count; ii++)
										{
												for (int jj = 0; jj < knf[ii].Count; jj++)
												{
														if (knf[i][j].Length == 2 && knf[i][j].Substring(1) == knf[ii][jj]
																|| knf[i][j].Length == 1 && knf[ii][jj].Length == 2 && knf[i][j] == knf[ii][jj].Substring(1))
														{
																if (!CompareTerms(knf[i], knf[ii]))
																{
																		break;
																}


																if (knf[i].Count == 1 && knf[ii].Count == 1)//
																{
																		Console.WriteLine("OK");
																		Console.ReadKey();
																		return;
																}
																else
																{
																		knf[i].RemoveAt(j);
																		knf[ii].RemoveAt(jj);
																		knf[i].AddRange(knf[ii]);
																		knf.RemoveAt(ii);

																		//убираем тавтологии:
																		checkTavtolog:
																		for (int iter = 0; iter < knf[i].Count; iter++)
																		{
																				for (int jter = iter + 1; jter < knf[i].Count; jter++)
																				{
																						if (knf[i][iter] == knf[i][jter])
																						{
																								knf[i].RemoveAt(jter);
																								goto checkTavtolog;
																						}
																				}
																		}
																		goto start_check_knf;
																}
														}
												}
										}
								}//конец терма
						}

						Console.WriteLine("NOT OK");
						Console.ReadKey();
				}


				/// <param name="a"></param>
				/// <param name="b"></param>
				/// <returns>
				/// Возвращает true, если два терма содержат ровно по одному противоположному элементу. 
				/// Пример {A+!B+C} и {!A+!B} возвращает true
				/// </returns>
				public static bool CompareTerms(List<string> a, List<string> b)
				{
						int cntDif = 0;
						for (int j = 0; j < a.Count; j++)
						{
								{
										for (int jj = 0; jj < b.Count; jj++)
										{
												if (a[j].Length == 2 && a[j].Substring(1) == b[jj]
														|| a[j].Length == 1 && b[jj].Length == 2 && a[j] == b[jj].Substring(1))
												{
														cntDif++;
												}
										}
								}
						}

						return cntDif == 1;
				}


				public static int CompValueOfLogicFunc(string input, List<char> listvar, int[] x)
				{
						string strnum = input;//посылка, в которой переменные заменяются значениями
						for (int i = 0; i < listvar.Count; i++)
						{
								strnum = strnum.Replace(listvar[i], (x[i].ToString())[0]);
						}

						var firstNode = new Tree<char>(strnum, null);
						SplitCurrentNode(firstNode);
						int result = ResultOfCurrentNode(firstNode);

						return result;
				}


				public static int ResultOfCurrentNode(Tree<char> node)
				{
						if (node.left == null && node.right == null)
						{
								if (node.str == "")//этот узел является левым потомком отрицания '!'
								{
										return 0;
								}
								return Convert.ToInt32(node.str);
						}
						return (Oper.Computation(ResultOfCurrentNode(node.left), ResultOfCurrentNode(node.right), node.op));
				}


				public static void SplitCurrentNode(Tree<char> node)
				{
						int numberOpenBrakets = 0;    //проверка наличия скобок по краям и их зависимости между собой
						for (int i = 0; i < node.str.Length; i++)
						{
								if (node.str[i] == '(')
								{
										numberOpenBrakets++;
								}
						}

						int cntOpenBrakets = 0;
						for (int i = 0; i < node.str.Length; i++)
						{
								if (node.str[i] == '(')
								{
										cntOpenBrakets++;
								}
								if (node.str[i] == ')')
								{
										if (cntOpenBrakets == numberOpenBrakets)
										{
												if (node.str[0] == '(' && node.str[node.str.Length - 1] == ')')
												{
														node.str = node.str.Substring(1, node.str.Length - 2);
												}
										}
										else
										{
												break;
										}
								}
						}                           //проверка наличия скобок по краям и их зависимости между собой. Конец


						int cntBrackets = 0;

						for (int i = node.str.Length - 1; i >= 0; i--)//
						{
								if (node.str[i] == '(')
								{
										cntBrackets--;//
								}
								else if (node.str[i] == ')')
								{
										cntBrackets++;//
								}

								if ((node.str[i] == '>') && cntBrackets == 0)
								{
										node.op = node.str[i];

										node.left = new Tree<char>(node.str.Substring(0, i), node);
										node.right = new Tree<char>(node.str.Substring(i + 1), node);

										SplitCurrentNode(node.left);
										SplitCurrentNode(node.right);

										return;
								}
						}


						{
								cntBrackets = 0;
								for (int i = node.str.Length - 1; i >= 0; i--)
								{
										if (node.str[i] == '(')
										{
												cntBrackets--;//
										}
										else if (node.str[i] == ')')
										{
												cntBrackets++;//
										}

										if ((node.str[i] == '+') && cntBrackets == 0)
										{
												node.op = node.str[i];

												node.left = new Tree<char>(node.str.Substring(0, i), node);
												node.right = new Tree<char>(node.str.Substring(i + 1), node);

												SplitCurrentNode(node.left);
												SplitCurrentNode(node.right);

												return;
										}
								}
						}

						{
								cntBrackets = 0;
								for (int i = node.str.Length - 1; i >= 0; i--)
								{
										if (node.str[i] == '(')
										{
												cntBrackets--;//
										}
										else if (node.str[i] == ')')
										{
												cntBrackets++;//
										}

										if ((node.str[i] == '*') && cntBrackets == 0)
										{
												node.op = node.str[i];

												node.left = new Tree<char>(node.str.Substring(0, i), node);
												node.right = new Tree<char>(node.str.Substring(i + 1), node);

												SplitCurrentNode(node.left);
												SplitCurrentNode(node.right);

												return;
										}
								}
						}

						{
								cntBrackets = 0;
								for (int i = node.str.Length - 1; i >= 0; i--)
								{
										if (node.str[i] == '(')
										{
												cntBrackets--;//
										}
										else if (node.str[i] == ')')
										{
												cntBrackets++;//
										}

										if ((node.str[i] == '!') && cntBrackets == 0)
										{
												node.op = node.str[i];

												node.left = new Tree<char>(node.str.Substring(0, i), node);
												node.right = new Tree<char>(node.str.Substring(i + 1), node);

												SplitCurrentNode(node.left);
												SplitCurrentNode(node.right);

												return;
										}
								}
						}
				}
		}
}
