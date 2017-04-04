using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employeeArray = new Employee[8];
            employeeArray[0] = new Trainee("Kyle");
            employeeArray[1] = new Trainee("Kevin");
            employeeArray[2] = new Trainee("Ken");
            employeeArray[3] = new Trainee("Karl");
            employeeArray[4] = new ProjectChief("Jim", employeeArray[0], employeeArray[1]);
            employeeArray[5] = new ProjectChief("John", employeeArray[1], employeeArray[4]);
            employeeArray[6] = new ProjectChief("James", employeeArray[1], employeeArray[4], employeeArray[5]);
            employeeArray[7] = new ProjectChief("Johnson", employeeArray[6], employeeArray[2], employeeArray[5]);

            Random rand = new Random();
            int work = rand.Next(0, 8);
            employeeArray[work].Works();
        }
    }
}
