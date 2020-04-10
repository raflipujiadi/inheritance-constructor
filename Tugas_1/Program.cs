using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Eve",18);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Triton",35,190302,"Math","Dosen@teacher.amikom.ac.id");
            teacher.GetNameAndAge();
            
            Student student = new Student("Deny",18,2685,"deny.prasetyo@student.amikom.ac.id");
            student.GetNameAndAge();
        }
    }
}
