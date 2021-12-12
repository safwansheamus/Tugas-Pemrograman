using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204037
{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan jerapah = new Hewan();

            jerapah.namaHewan = "jerapah afrika";
            jerapah.jenisHewan = "jantan";
            jerapah.tinggiHewan = 10;

            jerapah.tampilkannamahewan();
            Console.WriteLine("Jenis kelamin: " + jerapah.jenisHewan);
            jerapah.tampilkantinggihewan();
            Console.Read();
        }
    }
}
