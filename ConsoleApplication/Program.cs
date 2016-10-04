using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
	class Program
	{
		class Foo
		{
			public int Bar { get; set; }
			public string Bam { get; set; }

			public Foo(int bar, string bam)
			{
				Bar = bar;
				Bam = bam;
			}
		}

		static void Main(string[] args)
		{
			string[] sarray = new string[0];

			//Console.WriteLine("1: {0}", TestSwitch(1));
			//Console.WriteLine("2: {0}", TestSwitch(2));
			//Console.WriteLine("0: {0}", TestSwitch(0));
			//Console.WriteLine("99: {0}", TestSwitch(99));

			List<Foo> foos = new List<Foo> { new Foo(1, "Help"), new Foo(2, "Boo") };

			Node root = new Node(1, "Hello");
			Node[] nodes = new Node[] { new Node(2, "Cloud"), new Node (3, "Piano"),
			new Node(4, "Syntax"), new Node(5, "Nucleus"), new Node(6, "Ship"), new Node(7, "DNA") };

			foreach (var node in nodes)
			{
				Insert(root, node);
			}

			Console.Write("Root: ");
			Print(root, 0);

			foos.ForEach(x => Console.WriteLine($"Bar = {x.Bar}, Bam = {x.Bam}"));

			Foo simple = new Foo(3, "blah");

			string myFoo = String.Format($"Bar = {simple.Bar}, Bam = {simple.Bam}");

			Console.WriteLine("{0}", myFoo);

			Console.ReadKey();
		}

		static Node Insert(Node root, Node toBeInserted)
		{
			Node newRoot = root;
			int comp = String.CompareOrdinal(root.Description, toBeInserted.Description);
			if (comp < 0) // toBeInserted is larger than roo
			{
				if (root.Right == null)
					root.Right = toBeInserted;
				else
					Insert(root.Right, toBeInserted);
			}
			else if (comp >= 0) // toBeInserted is smaller than root
			{
				if (root.Left == null)
					root.Left = toBeInserted;
				else
					Insert(root.Left, toBeInserted);
			}
	
			return newRoot;
		}

		static void Print(Node root, int depth)
		{
			Console.WriteLine($"{root.Description}-{depth}");
			if (root.Left != null)
			{
				Console.Write("Left: ");
				Print(root.Left, depth + 1);
			}

			if (root.Right != null)
			{
				Console.Write("Right: ");
				Print(root.Right, depth + 1);
			}
		}

		static string TestSwitch(int val)
		{
			switch (val)
			{
				case 1:
					return "one";
				case 2:
					return "two";
				case 0:
				default:
					return "none";
			}
		}
	}
}
