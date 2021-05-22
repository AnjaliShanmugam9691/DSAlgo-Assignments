using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class BalancedParantheses
    {
        public int BalanceParanthese(string s)
        {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    st.Push(s[i]);
                }
                else
                {
                    if (st.Count() > 0)
                    {
                        st.Pop();
                    }
                    else
                    {
                        return 0;
                    }                    
                }
            }
            return st.Count() == 0 ? 1 : 0;
        }
    }
}
