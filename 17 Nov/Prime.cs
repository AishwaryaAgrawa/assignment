using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex3
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Prime" in both code and config file together.
	public class Prime : IPrime
	{
		public string prime(int n, int a, int i)
		{
			for (i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					a++;
				}
			}
			if (a == 2)
			{
				return "prime";
			}
			else
			{
				return "notprime";
			}
		}
	}
}