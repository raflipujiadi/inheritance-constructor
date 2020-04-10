using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    public class Student
    {
        private string Nama;
        private int Umur;
        private int Nim;
        private string Email;

        public void GetNameAndAge() => Console.WriteLine("---Student--- \nNama: {0} \nUmur: {1} \nNIM: {2} \nEmail: {3} \n--------\n", Nama, Umur, Nim, Email);
        public Student(string Nama, int Umur, int Nim, string Email)
        {
            this.Nama   = Nama;
            this.Umur   = Umur;
            this.Nim    = Nim;
            this.Email  = Email;
        }
    }
}
