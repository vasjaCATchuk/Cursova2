using DllTests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestsNew;

namespace TestServer
{
    public partial class Form1 : Form
    {
        private GenericUnitOfWork work;
        private List<Users> users;
        public Form1()
        {
            InitializeComponent();
            work = new GenericUnitOfWork(new ContextClass(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
            users = work.Repository<Users>().GetAll().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = users.FirstOrDefault(x => x.Login == textBox1.Text && x.Password == textBox2.Text);
            Form form = null;

            if (user != null)
            {
                switch (user.Groups.Title)
                {
                    default: MessageBox.Show("Refusal to access"); return;
                }
                form.ShowDialog();
            }
            else
                MessageBox.Show("Bad login or password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
