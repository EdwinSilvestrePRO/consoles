public class Objects
{
	abstract class Times 
	{
		public abstract string[] data ();
	}

	class Hours : Times 
	{
		public override string[] data ()
		{
			return new string[] {"12:58:00", "21:20:11", "12:13:15"};
		}

	}

	static void Main (string[] Arguments)
	{
		string[] all;
		System.Collections.ArrayList list = new System.Collections.ArrayList(1);
		list.Add(new Hours());

		foreach (Times h in list)
		{
			all = h.data();
		System.Console.WriteLine(all);
		System.Console.ReadLine();



		break;
		}
	}
}