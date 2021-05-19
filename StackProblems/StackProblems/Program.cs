using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 0 - Delete Consecutive Words
            List<string> inputStr = new List<string>() { "tom", "jerry", "jerry", "tom" };
            int outputStr = DeleteConsecutiveWords(inputStr);
            Console.WriteLine(outputStr);

            //Assignment 1 - Minimum remove to make valid parantheses
            string s = "(a(b(c)d)";
            string resultStr = MinimumRemoveToMakeValidParantheses(s);
            Console.WriteLine(resultStr);
        }

        //Assignement 0 - Delete Consecutive Words
        public static int DeleteConsecutiveWords(List<string> s)
        {
            Stack<string> st = new Stack<string>();
            int n = s.Count();
            for (int i=0; i<n; i++)
            {
                if(st.Count() == 0)
                {
                    st.Push(s[i]);
                }
                else
                {
                    if(st.Peek() == s[i])
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(s[i]);
                    }
                }
            }
            return st.Count();
        }

        //Assignment 1 - Minimum remove to make valid parantheses
        public static string MinimumRemoveToMakeValidParantheses(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            Stack<int> st = new Stack<int>();
            for (int i=0; i<s.Length; i++)
            {
                if (s[i] == '(')
                {
                    st.Push(i);
                }
                else if (s[i] == ')')
                {
                    if(st.Count() > 0 && s[st.Peek()] == '(')
                    {
                        st.Pop();
                    }
                    else
                    {
                        sb.Remove(i, 1);
                    }
                }
            }
            while(st.Count() > 0)
            {
                sb.Remove(st.Peek(), 1);
                st.Pop();
            }
            return sb.ToString();
        }
    }
}
