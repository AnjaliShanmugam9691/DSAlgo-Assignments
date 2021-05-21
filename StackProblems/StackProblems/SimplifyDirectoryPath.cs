using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class SimplifyDirectoryPath
    {
        public string SimplifyDirPath(string s)
        {
            //s.Replace("..","parent");   //replacing .. to parent --> this will go to the parent directory 
            //s.Replace(".", "ignore");   // we can ignore if we see single .
            string[] str = s.Split('/');
            LinkedList<string> st = new LinkedList<string>();    // We can use LinkedList(stack implementation as well (if we use stack we need to reverse the result array)
            for (int i=0; i<str.Count(); i++)
            {
                if(str[i] != "")
                {
                    if(str[i] == ".")
                    {
                        continue;
                    }
                    else if (str[i] == "..")
                    {
                        if(st.Count() > 0)
                        {
                            st.RemoveLast();
                        }
                        continue;
                    }
                    st.AddLast(str[i]);
                }               
            }
            return "/" + string.Join("/", st.ToArray());
        }
    }
}
