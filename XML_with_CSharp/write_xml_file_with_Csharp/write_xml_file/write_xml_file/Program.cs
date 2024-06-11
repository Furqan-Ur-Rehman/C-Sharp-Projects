using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace write_xml_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "E:\\C#\\XML_with_CSharp\\write_xml_file_with_Csharp\\Employee.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument(); // This line of code starts xml declaration i.e. ( <?xml version="1.0" encoding="utf-8" ?> )
            xmlWriter.WriteComment("Creating an XML file using C#");
            xmlWriter.WriteStartElement("Employees"); // This line of code create root node in xml file
            for(int i=1; i<=3; i++)
            {
                xmlWriter.WriteStartElement("Employee"); // This line of code creates child node inside root node in xml file 
                Console.WriteLine("Enter the ID for Employee " + i);
                xmlWriter.WriteElementString("ID" , Console.ReadLine());

                Console.WriteLine("Enter the Name for Employee " + i);
                xmlWriter.WriteElementString("Name", Console.ReadLine());

                Console.WriteLine("Enter the Department for Employee " + i);
                xmlWriter.WriteElementString("Dept", Console.ReadLine());
                xmlWriter.WriteEndElement(); // This line of code close child node in xml file
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }
    }
}
