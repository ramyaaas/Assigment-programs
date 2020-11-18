using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StringConcat" in both code and config file together.
    public class StringConcat : IStringConcat
    {
       
            public string Concat(string a, string b)
            {
                return a + b;
            }
        }
    }

