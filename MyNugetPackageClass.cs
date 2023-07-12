using System;

namespace DemoPackage
{
	public static class MyNugetPackageClass
	{
		public static string GetMyNugetPackageString()
		{
			return Get1();
		}

		private static string Get1()
		{
            return Get2();
		}

		public static string Get2()
		{
			return Get3();
		}

		public static string Get3()
		{
			return "This string is retrieved from my published nuget package.";
		}
	}
}