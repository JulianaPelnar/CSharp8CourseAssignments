using System;

namespace CSharp8CourseAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 8 ; i++ )
            {
                for(int j = 1; j <= 10 ; j++)
                {
                    if(i < 3)
                    {
                        if(j > 4 && j < 7)
                        {
                            continue;
                        }
                        Console.Write(j + " ");
                    } else if (i < 7)
                    {
                        if(i == 5 && j > 8)
                        {
                            continue;
                        }
                        int a = 11 - j;
                        Console.Write(a + " ");
                    } else
                    {
                        if(j == 8)
                        {
                            continue;
                        }
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}