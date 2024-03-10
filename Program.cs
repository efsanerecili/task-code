
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
	static void Main()
	{

		int say = 5;

		int faktorial = 1;
		for (int i = 1; i <= say; i++)
		{
			faktorial *= i;
		}

		Console.WriteLine("ededin faktoriali:" + faktorial);
	}
}


using System;

class Program
{
	static void Main()
	{

		int n = 123;

		int hasil = 1;
		for (int i = 1; i <= n; i++)

		{
			int reqem = n % 10;
			hasil *= reqem;
			n /= 10;

		}

		Console.WriteLine("ededin reqemlerinin hasili:" + hasil);
	}
}



using System;

class Program
{
	static void Main()
	{
		int n = 122;
		int firstNum = n;
		int secondNum = 0;
		int qaliq = 0;

		while (n > 0)
		{
			qaliq n = n % 10;
			secondNum = secondNum * 10 + qaliq;
			n /= 10;
		}
		if (firstNum == secondNum)
		{
			Console.WriteLine(''polindromdur");

		}
		else
		{

			Console.WriteLine("polindrom deyil");
		}


		using System;

class Program
	{
		static void Main()
		{
			if (number <= 1)
				return false;
			if (number <= 3)
				return true;

			if (number % 2 = || = 0 number % 3 == 0)
				return false;
			for (int i = 5; i * i <= number; i += 6)
			{
				if (number %== 0 || number % (i + 2) == 0)
					return false;

			}
			return true;
		}
		static void Main(string[] args)
		{
			int number = 17;
			if (IsPrime(number))
				Console.WriteLine(number + "sade ededdir");
			else
				Console.WriteLine(number + "murekkeb ededdir");
		}