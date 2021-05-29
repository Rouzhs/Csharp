using System;
using System.Collections.Generic;

namespace L1_calc
{
		public class Tree<T>
		{
				public Tree<T> parent, left, right;
				public T op;
				public string str;

				public Tree(string str, Tree<T> parent)
				{
						this.str = str;
						this.parent = parent;
				}
		}
}

