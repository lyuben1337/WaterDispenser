using _2labaFinal.Models;
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
    public partial class AddCompany : Form
    {
        public WaterProvider CreatedCompany = null;

        public AddCompany()
        {
            InitializeComponent();
        }

        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textBoxCompanyName.Text;
                if (String.IsNullOrEmpty(name))
                {
                    throw new Exception("Name must be not empty!");
                }
                var address = textBoxCompanyAddress.Text;
                if (String.IsNullOrEmpty(address))
                {
                    throw new Exception("Address must be not empty!");
                }
                var id = textBoxCompanyID.Text;
                if (String.IsNullOrEmpty(id))
                {
                    throw new Exception("EDRPOU Number must be not empty!");
                }
                var tankCount = int.Parse(textBoxTankCount.Text);
                if (tankCount <= 0)
                {
                    throw new Exception("Count of tanks must be more then zero!");
                }
                var tankVolume = int.Parse(textBoxTankVolume.Text);
                if (tankVolume <= 0)
                {
                    throw new Exception("Tank volume must be more then zero!");
                }

                var waterTanks = new List<WaterTank>();
                for (int i = 0; i < tankCount; i++)
                {
                    waterTanks.Add(new WaterTank(tankVolume));
                }
                CreatedCompany = new WaterProvider(name, address, id, waterTanks);
                this.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
            
    }
}
