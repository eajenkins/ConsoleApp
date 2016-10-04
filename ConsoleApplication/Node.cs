﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
	public class Node
	{
		public string Description { get; set; }
		public int Value { get; set; }

		public Node Left { get; set; }

		public Node Right { get; set; }

		public Node(int value, string description)
		{
			Value = value;
			Description = description;
			Left = null;
			Right = null;
		}
	}
}
