using System;
using pelazem.util;

namespace Tester.NetFX
{
	class Program
	{
		static void Main(string[] args)
		{
			int foo = Converter.GetInt32("123");
			Console.WriteLine(foo);
			Console.WriteLine("Type any key to continue");
			Console.Read();
		}
	}
}
