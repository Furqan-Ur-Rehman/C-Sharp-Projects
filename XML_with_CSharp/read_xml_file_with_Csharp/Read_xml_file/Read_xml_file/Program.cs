using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Read_xml_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read all xml Data from xml file below

            //XmlDocument xml_doc = new XmlDocument();
            //xml_doc.Load("E:\\C#\\XML_with_CSharp\\xml_with_Csharp\\xml_with_Csharp\\MYXMLFile.xml");
            //xml_doc.Save(Console.Out);
            //Console.ReadLine();

            XmlTextReader xtr = new XmlTextReader("E:\\C#\\XML_with_CSharp\\xml_with_Csharp\\xml_with_Csharp\\MYXMLFile.xml");

            while (xtr.Read())
            {
                if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "name")
                {
                    string s1 = xtr.ReadElementString();
                    Console.WriteLine("Name = " + s1);
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "age")
                {
                    string s2 = xtr.ReadElementString();
                    Console.WriteLine("Age = " + s2);
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fees")
                {
                    string s3 = xtr.ReadElementString();
                    Console.WriteLine("Fees = " + s3);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                
            }

            Console.ReadLine();
        }
    }
}
