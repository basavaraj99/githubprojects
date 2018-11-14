using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAXI2
{
    public partial class Form1 : Form
    {
        int km;
       double fare;
        int hr;
        double totalfare;
        
       
        public Form1()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_valuechanger(DataObjectMethodType sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(rbam.Checked)
                {
                TbTime.Text = TbTime.Text + Cbhour.Text + ":" + Cbmin.Text;
                TbTime.Text = TbTime.Text + "AM";
            }
            else if(rbpm.Checked)
            {
                TbTime.Text = TbTime.Text + Cbhour.Text + ":" + Cbmin.Text;
                TbTime.Text = TbTime.Text + "PM";
            }
            else
            {
                MessageBox.Show("Please  check the time");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

      

        private void Fare_Click(object sender, EventArgs e)
        {

            km = Convert.ToInt32(tbkilometers.Text);
            if (km <= 3)
            {
                fare = 50;
                tbfareamount.Text = Convert.ToString(fare);
            }
            else
            {
                fare = 50 + ((km - 3) * 20);
                tbfareamount.Text = Convert.ToString(fare);
            }
            fare = Convert.ToInt16(fare);
            if (rbam.Checked)
            {
                hr = Convert.ToInt16(Cbhour.Text);
                if ((hr >= 7) && (hr < 9))
                {
                    totalfare = fare * 1.5;
                    tbfareamount.Text = Convert.ToString(totalfare);
                    MessageBox.Show("total fare is" + totalfare);

                }
                else
                {
                    totalfare = fare;
                    tbfareamount.Text = Convert.ToString(totalfare);
                    MessageBox.Show("total fare is" + totalfare);
                }
            }
            else if (rbpm.Checked)
            {
                hr = Convert.ToInt16(Cbhour.Text);
                if ((hr >= 6) && (hr < 8))
                {
                    totalfare = fare * 1.5;
                    tbfareamount.Text = Convert.ToString(totalfare);
                    MessageBox.Show("total fare is" + totalfare);

                }
                else
                {
                    totalfare = fare;
                    tbfareamount.Text = Convert.ToString(totalfare);
                    MessageBox.Show("total fare is" + totalfare);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbkilometers_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cbhour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
