using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_assignment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "even" in both code and config file together.
    public class even : Ieven
    {
        public int sum(int a,int b)
        {
            while(a<=5)
            {
                b += a;
                a++;
            }
            return b;
        }

    }
}
