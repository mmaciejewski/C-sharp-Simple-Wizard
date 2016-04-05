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
    public partial class dataInput : Form
    {
        public dataInput()
        {
            InitializeComponent();
        }

        
        public static class Globals
        {
            public static string name = "";
            public static string surname = "";
            public static string address = "";
            public static int phoneNumber;
            public static int pageCounter = 0;

        }

        //saves input to Globals variables
        void save()
        {
            switch (Globals.pageCounter)
            {
                case 0: Globals.name = data_input.Text; break;
                case 1: Globals.surname = data_input.Text; break;
                case 2: Globals.address = data_input.Text; break;
                case 3: int.TryParse(data_input.Text, out Globals.phoneNumber); break;
                
            }
        }

        //transitions between pages
        void transition()
        {
            switch (Globals.pageCounter)
            {
                case 0: label.Text = "Imie:";
                    data_input.Text = Globals.name;  break;
                case 1: label.Text = "Nazwisko:";
                    data_input.Text = Globals.surname;
                    data_input.Height = 16; break;
                case 2: label.Text = "Adres:";
                    data_input.Text = Globals.address;
                    data_input.Height = 51; break;
                case 3: label.Text = "Numer tel.";
                    data_input.Text = Globals.phoneNumber.ToString();
                    data_input.Height = 16; break;
                case 4: this.Hide();
                        Output output = new Output();
                        output.ShowDialog();
                        this.Close();
                        break;

            }
            
            if (Globals.pageCounter == 0)
            {
                prev_button.Enabled = false;
            } else {
                prev_button.Enabled = true;
            }
        }

        private void dataInput_Load(object sender, EventArgs e)
        {
            prev_button.Enabled = false;
        }

        //button events
        private void next_button_Click(object sender, EventArgs e)
        {
            save();
            Globals.pageCounter++;
            transition();
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            save();
            Globals.pageCounter--;
            transition();
        }

        //ensures proper input type for phone number
        private void data_input_TextChanged(object sender, EventArgs e)
        {
                if (Globals.pageCounter == 3)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(data_input.Text, "^[0-9]{9}$"))
                    {
                        next_button.Enabled = true;
                        prev_button.Enabled = true;
                        error_text.Hide();

                    } else {
                        error_text.Show();
                        next_button.Enabled = false;
                        prev_button.Enabled = false;
                    }
                }
        }
    }
}
