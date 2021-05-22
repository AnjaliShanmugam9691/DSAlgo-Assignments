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

            //Assignmet 2 - Redundant Braces
            string rb = "((a+b))";
            CheckRedundantBraces crb = new CheckRedundantBraces();
            bool rbResult = crb.CheckRedundancy(rb);
            Console.WriteLine(rbResult);
            string rb2 = "(a+(a+b))";            
            bool rbResult2 = crb.CheckRedundancy(rb2);
            Console.WriteLine(rbResult2);

            //Assignment 3 - Decode String
            string ds1 = "3[a]2[bc]";                         //output -> aaabcbc
            DecodeString dec = new DecodeString();
            string dsres = dec.DecodingString(ds1);
            Console.WriteLine(dsres);

            string ds2 = "3[a2[c]]";                          //output -> accaccacc
            string dsres2 = dec.DecodingString(ds2);
            Console.WriteLine(dsres2);

            string ds3 = "100[leetcode]";                          //output -> accaccacc
            string dsres3 = dec.DecodingString(ds3);
            Console.WriteLine(dsres3);

            //Assignment 4 - Simplify Directory Path
            string sdp = "/home/";                                    //output -> /home
            SimplifyDirectoryPath sp = new SimplifyDirectoryPath();
            string dirPathres = sp.SimplifyDirPath(sdp);
            Console.WriteLine(dirPathres);

            string sdp2 = "/a/./b/../../c/";                          //output -> /c
            string dirPathres2 = sp.SimplifyDirPath(sdp2);
            Console.WriteLine(dirPathres2);

            //Assignment 5 - Basic Calculator
            string bc1 = "(1+(4+5+2)-3+(6+8)";               //output -> 23
            BasicCalculator cal = new BasicCalculator();
            int bcres1 = cal.BasicCalculatorFn(bc1);
            Console.WriteLine(bcres1);

            string bc2 = "2-1 + 2";                          //output -> 3
            int bcres2 = cal.BasicCalculatorFn(bc2);
            Console.WriteLine(bcres2);

            string bc3 = "123456";                          //output -> 123456
            int bcres3 = cal.BasicCalculatorFn(bc3);
            Console.WriteLine(bcres3);

            string bc4 = "1 - (+1+1)";                      //output -> -1
            int bcres4 = cal.BasicCalculatorFn(bc4);
            Console.WriteLine(bcres4);

            //Assignment 6 - Balanced Parantheses
            string bp1 = "(()())";                          //output -> 1
            BalancedParantheses bal = new BalancedParantheses();
            int bpres1 = bal.BalanceParanthese(bp1);
            Console.WriteLine(bpres1);

            string bp2 = "))((";                          //output -> 0
            int bpres2 = bal.BalanceParanthese(bp2);
            Console.WriteLine(bpres2);

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
