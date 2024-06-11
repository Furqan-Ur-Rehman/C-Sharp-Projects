using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_in_C_Sharp
{
    internal class SalaryDetails_Book_pg_288
    {
        private string _empName;

        public string EmpName
        {
            get
            {
                return _empName;
            }

            set
            {
                _empName = value;
            }
        }
        static void Main(string[] args)
        {
            SalaryDetails_Book_pg_288 objProperty = new SalaryDetails_Book_pg_288();
            objProperty.EmpName = "MFurqan";
            Console.WriteLine("Employee Name: " + objProperty.EmpName);

            Console.Read();
        }
    }
}
