using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex3
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPrime" in both code and config file together.
	[ServiceContract]
	public interface IPrime
	{
		[OperationContract]
		string prime(int n, int a ,int i);
	}
}
[DataContract]

public class prime
{
	[DataMember]
	public int n;
	[DataMember]
	public int i;
	[DataMember]
	public int a;
}