using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Program
    {
        static void Main(string[] args)
        {   
           EmpAttendance empWage = new EmpAttendance();
           empWage.Attendance();
           Console.ReadLine();
        }
    }
}
