using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespacees
{
	class MainClass
	{
		public static void Main (string[] args)
		{





			// Uses System.net
			WebClient client = new WebClient ();
			string reply = client.DownloadString ("http://msdn.microsoft.com");

			Console.WriteLine (reply);

			// Uses System.IO
			File.WriteAllText(@"C:\Users\Matthew Bowyer\Desktop\TestWrite\test.txt", reply);
			Console.ReadLine ();
		}
	}
}
