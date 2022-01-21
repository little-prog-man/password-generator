using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                string lowercase = "qwertyuiopasdfghjklzxcvbnm";
                string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
                string symbols = "!?@#$%^&*()[]{},.<>|\\/;:`~=+-";
                string numbers = "0123456789";
                string all = "";
                int amount = Convert.ToInt32(comboBox2.Text);
                int length = Convert.ToInt32(comboBox1.Text);
                Random r = new Random();

                if (checkBox1.Checked == true)
                {
                    all += lowercase;
                }
                if (checkBox2.Checked == true)
                {
                    all += uppercase;
                }
                if (checkBox3.Checked == true)
                {
                    all += numbers;
                }
                if (checkBox4.Checked == true)
                {
                    all += symbols;
                }
                if (length + amount >= 2)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        string password = "";
                        for (int j = 0; j < length; j++)
                        {
                            password += all[r.Next(0, all.Length)];
                        }
                        listBox1.Items.Add(password);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!. Try again!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!. Try again!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
