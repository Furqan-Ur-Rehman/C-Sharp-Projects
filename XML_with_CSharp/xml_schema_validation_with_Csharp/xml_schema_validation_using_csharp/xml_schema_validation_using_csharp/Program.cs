using System;
using System.Xml.Linq;
using System.Xml.Schema;

namespace xml_schema_validation_using_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", @"E:\C#\XML_with_CSharp\xml_schema_validation_with_Csharp\xml_schema_validation_using_csharp\xml_schema_validation_using_csharp\persons.xsd");

            XDocument doc = XDocument.Load(@"E:\C#\XML_with_CSharp\xml_schema_validation_with_Csharp\xml_schema_validation_using_csharp\xml_schema_validation_using_csharp\persons.xml");

            bool validationErrors = false;
            doc.Validate(schema, (s, e) =>
            {
                Console.WriteLine(e.Message);
                validationErrors = true;
            });
            if (validationErrors)
            {
                Console.WriteLine("Validation failed");
            }
            else
            {
                Console.WriteLine("Validation Successful!");
            }
            Console.ReadLine();
        }
    }
}
