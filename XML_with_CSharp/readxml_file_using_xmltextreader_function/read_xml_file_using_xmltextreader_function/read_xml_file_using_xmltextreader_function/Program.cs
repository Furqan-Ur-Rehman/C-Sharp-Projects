using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace read_xml_file_using_xmltextreader_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument xdoc = new XmlDocument();
            //xdoc.Load(@"E:\C#\XML_with_CSharp\xml_with_Csharp\xml_with_Csharp\MYXMLFile.xml");

            //xdoc.Save(Console.Out);
            //Console.ReadLine();

            XmlTextReader xtr = new XmlTextReader(@"E:\C#\XML_with_CSharp\xml_with_Csharp\xml_with_Csharp\MYXMLFile.xml");

            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "name")
                {
                    string s1 = xtr.ReadElementString();
                    Console.WriteLine("Name = " + s1);
                }

                if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "age")
                {
                    string s2 = xtr.ReadElementString();
                    Console.WriteLine("Age = " + s2);
                }

                if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "fees")
                {
                    string s3 = xtr.ReadElementString();
                    Console.WriteLine("Fees = " + s3);
                }
            }
            Console.ReadLine();
        }
    }
}
