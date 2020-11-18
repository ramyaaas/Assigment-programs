using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iprime" in both code and config file together.
    [ServiceContract]
    public interface Iprime
    {
        [OperationContract]

        string prime(int n, int i, int a);

        
        
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