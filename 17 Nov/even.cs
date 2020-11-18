using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "even" in both code and config file together.
	public class even : Ieven
	{
		public string Even(int n)
		{
			if (n % 2 == 0)
			{
				return "even";
			}
			else
			{
				return "odd";
			}
		}


	}
}