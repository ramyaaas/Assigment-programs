using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_assignment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ieven" in both code and config file together.
    [ServiceContract]
    public interface Ieven
    {
        [OperationContract]
        //  string Concat(string a, string b);

       
        int sum(int a,int b);
        

    }
   [ DataContract]
      public class value
    {
        [DataMember]
       public double a;
        [DataMember]
        public double b;


    }
}
