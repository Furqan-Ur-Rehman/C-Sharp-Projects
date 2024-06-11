using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml;
using System.Web;

namespace validate_xml_with_xsd_using_Csharp
{
    //Create Validations Class
    public class Validations
    {
        public string ValidateXMLUsingXSD()
        {
            try
            {
                string xml_path = @"E:\C#\XML_with_CSharp\validate_xml_schema_with_Csharp\validate_xml_with_xsd_using_Csharp\validate_xml_with_xsd_using_Csharp\books.xml";
                string xsd_path = @"E:\C#\XML_with_CSharp\validate_xml_schema_with_Csharp\validate_xml_with_xsd_using_Csharp\validate_xml_with_xsd_using_Csharp\books.xsd";

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas.Add(null, XmlReader.Create(xsd_path));

                XmlReader xmlreader = XmlReader.Create(xml_path, settings);
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(xmlreader);
                return string.Empty;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
            
        }
        
    }
}
