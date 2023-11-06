using _2labaFinal.Models.Machine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2labaFinal
{
    public partial class AddAutomat : Form
    {
        public WaterMachine CreatedMachine { get; set; }  = new WaterMachine();

        public AddAutomat()
        {
            InitializeComponent();
        }

        private void btnCreateAutomat_Click(object sender, EventArgs e)
        {
            try
            {
                var adress = textBoxAdress.Text;
                var stillWaterPrice = double.Parse(textBoxStillWater.Text);
                if (stillWaterPrice < 0)
                {
                    throw new Exception("Still Water Price must be more then zero");
                }
                var sodaWaterPrice = double.Parse(textBoxSodaWater.Text);
                if (sodaWaterPrice < 0)
                {
                    throw new Exception("Soda Water Price must be more then zero");
                }
                var tankVolume = int.Parse(textBoxTankVolume.Text);
                if (tankVolume < 0)
                {
                    throw new Exception("Tank volume must be more then zero");
                }
                var bottlesCount = int.Parse(textBoxBottleCount.Text);
                if (bottlesCount < 0)
                {
                    throw new Exception("Bottle count must be more then zero");
                }
                var address = textBoxAdress.Text.Trim();
                if (String.IsNullOrWhiteSpace(address))
                {
                    throw new Exception("Adress must be inputed");
                }
                CreatedMachine = new WaterMachine(stillWaterPrice, stillWaterPrice, tankVolume, bottlesCount, address);
                CreatedMachine.SellSoda = textBoxSodaWater.Enabled;
                CreatedMachine.SellBottles = textBoxBottleCount.Enabled;
                CreatedMachine.PayWithCard = label5.ForeColor.Equals(Color.DeepSkyBlue);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.ForeColor.Equals(Color.LightBlue))
            {
                label2.ForeColor = Color.DeepSkyBlue;
                textBoxSodaWater.Enabled = true;
            }
            else
            {
                label2.ForeColor = Color.LightBlue;
                textBoxSodaWater.Enabled = false;
                textBoxSodaWater.Text = "0";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.ForeColor.Equals(Color.LightBlue))
            {
                label4.ForeColor = Color.DeepSkyBlue;
                textBoxBottleCount.Enabled = true;
            }
            else
            {
                label4.ForeColor = Color.LightBlue;
                textBoxBottleCount.Enabled = false;
                textBoxBottleCount.Text = "0";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.ForeColor.Equals(Color.LightBlue))
            {
                label5.ForeColor = Color.DeepSkyBlue;
                textBoxBottleCount.Enabled = true;
            }
            else
            {
                label5.ForeColor = Color.LightBlue;
            }
        }
    }
}
