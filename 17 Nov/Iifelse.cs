using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicestringconcat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iifelse" in both code and config file together.
    [ServiceContract]
    public interface Iifelse
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int greater(int n,int m);

        [OperationContract]
        int lesser(int n,int m);

        [OperationContract]
        string equals(int n);
    }
}