using System;

namespace EmployeeWageProblem
{
    public class EmpAttendance
    {
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

        }
    }
}
