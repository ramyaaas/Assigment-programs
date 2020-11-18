using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcfpalindrome
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "palindrome" in both code and config file together.
    public class palindrome : IPalindrome
    {
        public string pal(string s1,string rev)
        {
            for(int i=s1.Length-1;i>=0;i--)
            {
                rev += s1[i];
            }
            if(s1==rev)
            {
                return "palindrome";
            }
            else
            {
                return "not palindrome";
            }
        }
    }
}
