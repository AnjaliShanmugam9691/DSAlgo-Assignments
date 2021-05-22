using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class BasicCalculator
    {
        public int BasicCalculatorFn(string s)
        {
            int n = s.Length;
            Stack<int> st = new Stack<int>();
            int sign = 1;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                //for every '(' we should push the result with sign 
                if (s[i] == '(')
                {
                    st.Push(result);
                    st.Push(sign);
                    result = 0;
                    sign = 1;
                }
                else if (s[i] == ')')
                {
                    result = st.Pop() * result;
                    result += st.Pop();
                }
                else if (s[i] == '+' || s[i] == '-')
                {
                    sign = s[i] == '+' ? 1 : -1;
                }
                else if (Char.IsDigit(s[i]))
                {
                    int num = 0;
                    // we can have 1 or 11 or 111 like this. so we should iterate till the next is not digit
                    while (i < n && Char.IsDigit(s[i]))
                    {
                        num = num * 10 + int.Parse(s[i].ToString());
                        i++;
                    }
                    result += num * sign;
                    i--;
                }
            }
            return result;
        }
    }
}
