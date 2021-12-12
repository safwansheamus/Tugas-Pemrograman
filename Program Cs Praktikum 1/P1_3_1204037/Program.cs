using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1204037
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Nilai:  ");
            int nilai = Convert.ToInt16(Console.ReadLine());
            String[] Nilai = {"1", "2","3", "4","5", "6", "7", "8", "9", "10" };
            Console.WriteLine();

            if (nilai >=1 )
            {
                Console.Write("Anak Ayam Turun 10");
                Console.WriteLine("");
                for (int i = 10; i > 1; i = i - 1)
                {
                    Console.WriteLine("Anak ayam turunlah " + Convert.ToString(i) + "Mati satu tinggallah " + Convert.ToString(i = i - 1)); 
                }
                Console.Write("Anak ayam turunlah 1, mati satu tinggallah induknya");
            }
           
         }
                
            }
        }

