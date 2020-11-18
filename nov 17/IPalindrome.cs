using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcfpalindrome
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ipalindrome" in both code and config file together.
    [ServiceContract]
    public interface Ipalindrome
    {
        [OperationContract]
        // void DoWork();
        string pal(string s1, string rev);
    }
}

public class pal
{
    [DataMember]
    public string s1;
}
