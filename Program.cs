using System;

namespace QuestionNo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myList = {1,2,3,4,5,6,7,8,9,10,11, 12};

            Console.WriteLine("Elements in odd positions in myList are: ");
            // by using i=i+2, we ensure the elements selected are 1st, 3rd, 5th, and so on...

            for (int i = 0; i < myList.Length; i = i + 2)
            { 
                Console.WriteLine(myList[i]);
            }
        }
    }
}
