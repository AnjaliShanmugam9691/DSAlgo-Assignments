using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class CheckRedundantBraces
    {
        public bool CheckRedundancy(string s)
        {
            Stack<char> st = new Stack<char>();
            char[] str = s.ToCharArray();
            foreach(char ch in str)
            {
                if(ch == ')')
                {
                    char top = st.Peek();
                    st.Pop();
                    bool flag = true;
                    while(top != '(')
                    {
                        if(top == '+' || top == '-' || top == '*' || top == '/')
                        {
                            flag = false;
                        }
                        top = st.Peek();
                        st.Pop();
                    }
                    if (flag == true)
                    {
                        return true;
                    }
                }
                else
                {
                    st.Push(ch);
                }                
            }
            return false;
        }
    }
}
