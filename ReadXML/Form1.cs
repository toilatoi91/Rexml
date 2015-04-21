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
using System.Xml.Serialization;

namespace ReadXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(Info));
            using (var reader = XmlReader.Create("locations.xml"))
            {
                Info info = (Info)serializer.Deserialize(reader);
                List<Location> locations = info.Locations;
                int a = 1;
                // do whatever you wanted to do with those locations
            }
        }
    }
}
