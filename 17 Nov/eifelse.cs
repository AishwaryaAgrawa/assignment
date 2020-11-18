using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicestringconcat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ifelse" in both code and config file together.
    public class ifelse : Iifelse
    {
        public void DoWork()
        {
        }
        public int greater(int n,int m)
        {
            if(n > m)
                
                return n + m;
            
            else
                return n - m;
            
        }
        public int lesser(int n, int m)
        {
            if (n < m)

                return n + m;

            else
                return n - m;

        }
        public string equals(int n)
        {
            if (n == 1)
                return "n is equal to 1 ";
            else
                return "n is equal to 0";
        }
    }
}