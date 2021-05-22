using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class DecodeString
    {
        public string DecodingString(string s)
        {
            int n = s.Length;
            Stack<string> st = new Stack<string>();
            string output = string.Empty;
            int multiplier = 0;
            for(int i =0; i<n; i++)
            {
                if (s[i] == ']')
                {
                    int num = int.Parse(st.Pop());
                    string prev = st.Pop();
                    output = prev + string.Concat(Enumerable.Repeat(output, num));
                }
                else if(s[i] == '[')
                {
                    st.Push(output);
                    st.Push(multiplier.ToString());
                    multiplier = 0;
                    output = "";
                }
                else if (char.IsDigit(s[i]))
                {
                    multiplier = multiplier * 10 + int.Parse(s[i].ToString());
                }
                else
                {
                    output += s[i];
                }
            }
            return output;
        }
    }
}
