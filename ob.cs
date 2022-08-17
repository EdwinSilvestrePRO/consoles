public class Objects
{
	interface Group
	{
		void Action();
		int Sum(int n1, int n2);

	}

	struct Methods : Group
	{
		public void Action ()
		{
			System.Console.WriteLine("this is my method Action()");
		}
		public int Sum (int n1, int n2)
		{
		 return n1+n2;
		}
	}
	static void Main (string[] Args)
	{
		
	System.Console.WriteLine("Tomorrow I Work with objects and class");
	System.Console.ReadLine();
	}
}