using System;
namespace two_sum
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] num = { 3,3};
            int num1;
            for(int i=0; i<num.Length; i++)
            {
                for(int j=1;j<num.Length; j++)
                {
                    if (num[i] != num[j] || num[i] == num[j])
                    {
                        num1 = num[i] + num[j];
                        Console.WriteLine(num1);
                        
                    }
                    break;
                }
                break;
            }
            Console.ReadLine();
        }
    }
}