using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validate_xml_with_xsd_using_Csharp;

namespace validate_xml_with_xsd_using_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create object of Validations class which is included in above(using validate_xml_with_xsd_using_Csharp.Service)namespace
            Validations validations = new Validations();
            string isValidate = validations.ValidateXMLUsingXSD();
            if(isValidate == string.Empty)
            {
                Console.WriteLine(isValidate);
                Console.WriteLine("Congratulations! XML is Well Formed according to XSD using C#.");
            }
            else
            {
                Console.WriteLine(isValidate);
                Console.WriteLine("Sorry! XML is not Well Formed according to XSD using C#.");
            }
            Console.ReadLine();

        }
    }
}
