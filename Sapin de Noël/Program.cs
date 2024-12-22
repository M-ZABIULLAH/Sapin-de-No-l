using System;

class Program
    {
        static void Main()
        {
            Console.Write("Entrez la hauteur du sapin: ");
            int height = int.Parse(Console.ReadLine());

        
            for (int i = 1; i <= height; i++)
            {
               
                Console.Write(new string(' ', height - i));
             
                Console.WriteLine(new string('*', 2 * i - 1));
            }

         
            for (int i = 0; i < height / 3; i++)
            {
                Console.Write(new string(' ', height - 1));
                Console.WriteLine("|||");
            }
        }
    }

