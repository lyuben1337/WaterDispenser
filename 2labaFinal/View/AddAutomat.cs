using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class AddAutomat : Form
    {
        private int _companyID = 0;
        private List<WaterProvider> _companies = CompanyRepository.Instance.WaterProviders;
        public WaterMachine CreatedMachine { get; set; }  = new WaterMachine();

        public AddAutomat(int companyID)
        {

            InitializeComponent();
            _companyID = companyID;
        }

        private void btnCreateAutomat_Click(object sender, EventArgs e)
        {
            try
            {
                var adress = textBoxAdress.Text;
                if (String.IsNullOrEmpty(adress))
                {
                    throw new Exception("Adress must be not empty!");
                }
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
                _companies[_companyID].TakeWater(tankVolume);
                CreatedMachine = new WaterMachine(stillWaterPrice, sodaWaterPrice, tankVolume, bottlesCount, address, _companyID);
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
