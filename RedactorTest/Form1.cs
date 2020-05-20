using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Xml2CSharp;

namespace RedactorTest
{
    public partial class Form1 : Form
    {
        private Tests tests;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            tests = new Tests();
            tests.Test = new List<Test>();

            bindingSource.DataSource = tests.Test;
            listBox.DataSource = bindingSource;
        }
       
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Tests));
                    tests = (Tests)serializer.Deserialize(stream);

                    bindingSource.DataSource = tests.Test;
                    listBox.DataSource = bindingSource;

                    Text = openFileDialog.FileName;

                }
            }
        }
    }
}
