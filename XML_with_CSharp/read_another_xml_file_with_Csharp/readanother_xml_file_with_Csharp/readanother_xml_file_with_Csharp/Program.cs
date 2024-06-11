using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace readanother_xml_file_with_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\C#\XML_with_CSharp\read_another_xml_file_with_Csharp\readanother_xml_file_with_Csharp\readanother_xml_file_with_Csharp\XMLFile1.xml");

            XmlNodeList nodes = doc.SelectNodes("//Books/Book");
            int count = 0;
            foreach (XmlNode node in nodes)
            {
                XmlNode title = node.SelectSingleNode("title");
                if (title != null)
                {
                    Console.WriteLine("Title is: " + title.InnerText);
                }

                XmlNode author = node.SelectSingleNode("author");
                if (author != null)
                {
                    Console.WriteLine("Author is: " + author.InnerText);
                }
                count++;
                if(count == 2)
                {
                    break;
                }
                Console.WriteLine("---------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
