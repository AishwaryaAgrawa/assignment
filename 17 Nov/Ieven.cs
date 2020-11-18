using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex1
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ieven" in both code and config file together.
	[ServiceContract]
	public interface Ieven
	{
		[OperationContract]
		string Even(int n);
	}
	
	}

[DataContract]

public class CompositeType
{
	bool boolvalue = true;
	String stringvalue = "Hello world";

	[DataMember]
	public bool Boolvalue
	{
		get { return boolvalue; }
		set { boolvalue = value; }
	}
	[DataMember]
	public string StringValue
	{
		get { return StringValue; }
		set { StringValue = value; }
	}

}
