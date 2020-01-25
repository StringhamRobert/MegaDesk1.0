using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote form1 = new AddQuote();
            form1.Tag = this;
            form1.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes form2 = new ViewAllQuotes();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuotes form3 = new SearchQuotes();
            form3.Tag = this;
            form3.Show(this);
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
