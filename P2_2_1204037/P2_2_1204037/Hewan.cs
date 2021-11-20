using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204037
{
    class Hewan
    {
        public string namaHewan;
        public int tinggiHewan;
        public string jenisHewan;

        public void tampilkannamahewan()
        {
            Console.WriteLine("nama hewan:  " + this.namaHewan);
        }

        public void tampilkanjenishewan()
        {
            Console.WriteLine("jenis hewan: " + this.jenisHewan);
        }

        public int tampilkantinggihewan()
        {
            int tinggiHewan = this.tinggiHewan;
            return tinggiHewan;
        }
    }
}
