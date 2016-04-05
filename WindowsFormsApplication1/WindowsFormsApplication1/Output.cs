using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        private void Output_Load(object sender, EventArgs e)
        {
            name_output.Text = dataInput.Globals.name;
            surname_output.Text = dataInput.Globals.surname;
            address_output.Text = dataInput.Globals.address;
            phone_output.Text = dataInput.Globals.phoneNumber.ToString();
        }

        //resets application for testing purpose
        private void reset_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }
    }
}
