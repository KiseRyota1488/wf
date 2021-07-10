using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        User user = new User();
        public Form1()
        {
            InitializeComponent();

            string[] countries = new[]
            {
                "Canada",
                "USA",
                "Ukraine",
                "Russia"
            };

            comboBox1.Items.AddRange(countries);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user.Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            user.Surname = textBox2.Text;
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            user.BirthDate = dateTimePicker1.Value;

            label4.Text = @"Age: " + (DateTime.Now.Year - user.BirthDate.Year).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.Country = comboBox1.Text;
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (sender as CheckBox);
            if (cb.Checked)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }    
        }

        private void SetGender(object sender, EventArgs e)
        {
            var rb = (sender as RadioButton);
            user.Gender = rb.Text;
            if (rb.Checked && rb.Text == "Male")
            {
                pictureBox1.Image = Image.FromFile(@"..\..\man.png");
            }
            else if (rb.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"..\..\woman.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(user != null)
            {
                var json = JsonConvert.SerializeObject(user, Formatting.Indented);
                File.WriteAllText("user.json", json);
            }
        }
    }
}
