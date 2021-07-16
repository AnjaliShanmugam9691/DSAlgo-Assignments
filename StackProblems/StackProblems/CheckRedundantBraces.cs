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
            int n = s.Length;
            for(int i =0; i<n; i++)
            {
                if(s[i] == '(' || s[i] == '+' || s[i] == '-' || s[i] == '/' || s[i] == '*')
                {
                    st.Push(s[i]);
                }
                else if (s[i] == ')')
                {
                    char top = st.Peek();
                    if(top == '(')
                    {
                        return true;     // redundant
                    }
                    //this below lines will work for (a+(b+c+c)) case
                    while(st.Peek() != '(')
                    {
                        st.Pop();
                    }
                    st.Pop();
                }
            }
            return false;                // valid
            //char[] str = s.ToCharArray();
            //foreach(char ch in str)
            //{
            //    if(ch == ')')
            //    {
            //        char top = st.Peek();
            //        st.Pop();
            //        bool flag = true;
            //        while(top != '(')
            //        {
            //            if(top == '+' || top == '-' || top == '*' || top == '/')
            //            {
            //                flag = false;
            //            }
            //            top = st.Peek();
            //            st.Pop();
            //        }
            //        if (flag == true)
            //        {
            //            return true;
            //        }
            //    }
            //    else
            //    {
            //        st.Push(ch);
            //    }                
            //}           
        }
    }
}
