using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Ticket_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota :" + comboBox1.Text + " - " + comboBox2.Text +" /"+ "Date : " + dateTimePicker1.Text + " /" +
                "Time :" + maskedTextBox1+ " /"+ "Passanger İnformation :" + textBox1.Text + "/ " + "Identification Number :"
                + maskedTextBox3.Text + " /" + "Phone :" + maskedTextBox2.Text);
            MessageBox.Show("Passanger Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
