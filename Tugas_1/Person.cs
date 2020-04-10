using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    public class Person
    {
        private string Nama;
        private int Umur;
        public void GetNameAndAge() => Console.WriteLine("---Person--- \nNama: {0} \nUmur: {1} \n------\n ", Nama, Umur);
        public Person(string Nama, int Umur)
        {
            this.Nama = Nama;
            this.Umur = Umur;
        }
    }
}
