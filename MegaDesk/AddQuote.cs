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
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
            // bind combobox with desktop surface enum
            desktop_surface_combo.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void delivery_option_Click(object sender, EventArgs e)
        {

        }

        private void deskwidthinput_Validating(object sender, CancelEventArgs e)
        {
            
            {
                Console.WriteLine("Please enter a number");
            }

        }

        private void getquote_btn_Click(object sender, EventArgs e)
        {

            Desk newdesk = new Desk(Convert.ToInt32(Math.Round(this.numericUpDown2.Value, 0)), Convert.ToInt32(Math.Round(this.numericUpDown1.Value, 0)), Convert.ToInt32(Math.Round(this.numericUpDown3.Value, 0)), this.desktop_surface_combo.Text);
            DeskQuote quote1 = new DeskQuote(newdesk, this.customerName.Text, this.comboBox1.Text);
            Label newquote = new Label();
            DisplayQuote form = new DisplayQuote();
            form.Show();
            form.newquote.Text = "$" + Convert.ToString(quote1.singleQuote());
          
        }
    }
}
