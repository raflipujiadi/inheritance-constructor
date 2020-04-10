using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    public class Teacher 
    {
        private string Nama;
        private int Umur;
        private int Id;
        private string Email;

        private string Matkul;

        public void GetNameAndAge() => Console.WriteLine("---Teacher--- \nNama: {0} \nUmur: {1} \nID: {2} \nMatkul: {3} \nEmail: {4} \n---------\n", Nama, Umur, Id, Matkul, Email);
        public Teacher(string Nama, int Umur, int Id, string Matkul, string Email)
        {
            this.Nama   = Nama;
            this.Umur   = Umur;
            this.Id     = Id;
            this.Matkul = Matkul;
            this.Email  = Email;
        }
    }
}
