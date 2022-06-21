using System;

namespace task123
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //int[] myNum = { 4, 3, -1, 2, 1, 5 };
            int[] myNum = new int[6];
            for(int i=0; i < myNum.Length; i++)
            {
                Console.Write("Please insert" +( i + 1) + ".index");
                myNum[i] = Convert.ToInt32(Console.ReadLine());

            }

            int count = 0;
            //Console.WriteLine(count);
            if (myNum[0] == -1)
            {
                
                Console.WriteLine(count);

            }

            else if (myNum[myNum[0]] == -1)
            {
                count = 1;
                Console.WriteLine(count);
            }
            else if (myNum[myNum[myNum[0]]] == -1)
            {
                count = 2;
                Console.WriteLine(count);


            }else if (myNum[myNum[myNum[myNum[0]]]] == -1){
                count = 3;
                Console.WriteLine(count);

            }
            else if(myNum[myNum[myNum[myNum[myNum[0]]]]] ==-1)
            {
                count = 4;
                Console.WriteLine(count);
            }
            else if(myNum[myNum[myNum[myNum[myNum[myNum[0]]]]]] ==- 1)
            {
                count = 5;
                Console.WriteLine(count);
            }
        }

    }
}
