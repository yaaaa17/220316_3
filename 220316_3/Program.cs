using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220316_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double c = 999D; //設定絕對不可能出現的數
            char op; //加減乘除只有一個(char)字元

            Console.Write("Number1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operator(+, -, *, /):");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+':
                    c = Convert.ToDouble(a + b);
                    break;
                case '-':
                    c = Convert.ToDouble(a - b);
                    break;
                case '*':
                    c = Convert.ToDouble(a * b);
                    break;
                case '/':
                    c = Convert.ToDouble(a) / b; //改成double->取得浮點數
                    break;
                default:
                    Console.WriteLine("無法執行你要求的運算。");
                    break;
            }
            if (c != 999D) :
                    Console.WriteLine("計算結果：{0}", c);
            Console.ReadLine();
        }
    }
}
