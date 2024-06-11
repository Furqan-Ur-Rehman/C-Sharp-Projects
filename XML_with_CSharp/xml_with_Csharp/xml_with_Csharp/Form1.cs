using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xml_with_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Please fill the required filed.");
                textBox1.Focus();
            }
            else
            {
                listBox1.Items.Clear();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("MYXMLFile.xml");

                foreach(XmlNode node in xmlDoc.DocumentElement)
                {
                    int id = Convert.ToInt32(node.Attributes["id"].Value);
                    if(id == Convert.ToInt32(textBox1.Text))
                    {
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            listBox1.Items.Add(childnode.InnerText);
                        }
                    }
                }
            }
        }
    }
}
