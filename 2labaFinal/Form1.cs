using _2labaFinal.Enums;
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
    public partial class Form1 : Form
    {
        private int _formStage = 0;
        private WaterMachine _waterMachine;

        public Form1()
        {
            _waterMachine = new WaterMachine(10, 12, 1000, 300, "Parashutystiv St, 6, Kharkiv, Kharkivs'ka oblast, Ukraine, 61000");
            InitializeComponent();
            redrawWindow();
        }
        
        private void redrawWindow()
        {


            labelWaterInMachine.Text = "Water in machine: " + _waterMachine.WaterTank.Volume.ToString();
            labelBottlesCount.Text = "Bottle count: " + _waterMachine.BottleCount.ToString();
            labelBottlePrice.Text = "Bottle price: 1,25";
            labelSodaPrice.Text = "Soda: " + _waterMachine._sodaWaterPrice.ToString();
            labelStillWaterPrice.Text = "Still: " + _waterMachine._stillWaterPrice.ToString();

            labelWaterAdd.Visible = false;
            labelBottleAdd.Visible = false;
            textBoxBottleAdd.Visible = false;
            textBoxWaterAdd.Visible = false;
            btnAddWater.Visible = false;
            btnBuy.Visible = false;
            labelCountOfLiters.Visible = false;
            textBoxCountOfLiters.Visible = false;
            btnWithBottle.Visible = false;
            btnBuy.Visible = false;
            labelCountOfBottles.Visible = false;
            textBoxCountOfBottles.Visible = false;
            btnWithoutBottle.Visible=false;
            labelOwnBottle.Visible = false;
            btnBack.Visible = false;
            btnWaterTypeSoda.Visible = false;
            btnWaterTypeStill.Visible = false;
            labelWaterType.Visible = false;
            btnCash.Visible = false;
            btnWithCard.Visible = false;
            labelPayMehod.Visible = false;
            labelSum.Visible = false;
            labelCacheAmount.Visible = false;
            textBoxCashAmount.Visible = false;
            btnPay.Visible = false;

            btnBack.Visible = true;
            switch (_formStage)
            {
                case 0:
                    btnBack.Visible = false;
                    btnWaterTypeSoda.Visible = true;
                    btnWaterTypeStill.Visible = true;
                    labelWaterType.Visible = true;
                    break;
                case 1:
                    btnWithBottle.Visible = true;
                    btnWithoutBottle.Visible = true;
                    labelOwnBottle.Visible = true;
                    break;
                case 2:
                    btnBuy.Visible = true;
                    labelCountOfBottles.Visible = true;
                    textBoxCountOfBottles.Visible = true;
                    break;
                case 3:

                    btnBuy.Visible = true;
                    labelCountOfLiters.Visible = true;
                    textBoxCountOfLiters.Visible = true;
                    break;
                case 4:
                    btnCash.Visible = true;
                    btnWithCard.Visible = true;
                    labelPayMehod.Visible = true;
                    labelSum.Visible = true;
                    break;
                case 5:
                    labelSum.Visible = true;
                    labelCacheAmount.Visible = true;
                    textBoxCashAmount.Visible = true;
                    btnPay.Visible = true;
                    break;

            }
        }

        private void btnWaterTypeSoda_Click(object sender, EventArgs e)
        {
            _formStage = 1;
            _waterMachine.SelectWater(WaterType.Soda);
            redrawWindow();
        }

        private void btnWaterTypeStill_Click(object sender, EventArgs e)
        {
            _formStage = 1;
            _waterMachine.SelectWater(WaterType.Still);
            redrawWindow();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_formStage == 2 || _formStage == 3)
            {
                _formStage = 1;
            } else
            {
                _formStage--;
            }

            redrawWindow();
        }

        private void btnWithoutBottle_Click(object sender, EventArgs e)
        {
            _formStage = 2;
            redrawWindow();
        }

        private void btnWithBottle_Click(object sender, EventArgs e)
        {
            _formStage = 3;
            redrawWindow();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (_formStage == 2)
                {
                    _waterMachine.BuyWithBottles(int.Parse(textBoxCountOfBottles.Text));
                }
                else
                {
                    _waterMachine.BuyWithVolume(int.Parse(textBoxCountOfLiters.Text));
                }
                labelSum.Text = "Sum: " + _waterMachine.GetCost().ToString();
                _formStage = 4;
                redrawWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            _formStage = 5;
            _waterMachine.SelectPaymentStrategy(Payment.Cash);
            redrawWindow();
        }

        private void btnWithCard_Click(object sender, EventArgs e)
        {
            _waterMachine.SelectPaymentStrategy(Payment.Card);
            _waterMachine.BuyWater();
            _formStage = 0;
            MessageBox.Show("You have bought water succesfully!");
            
            redrawWindow();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                _waterMachine.CashPaymentStrategy.PutCash(double.Parse(textBoxCashAmount.Text));
                _waterMachine.BuyWater();
                _formStage = 0;
                MessageBox.Show("You have bought water succesfully!");
                var change = _waterMachine.CashPaymentStrategy.TakeChange();
                if (change > 0)
                {
                    MessageBox.Show("Your change: " + change.ToString());
                }
                redrawWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void payWithCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(payWithCardToolStripMenuItem.Checked)
            {
                _waterMachine.PayWithCard = false;
                payWithCardToolStripMenuItem.Checked = false;
                btnWithCard.Enabled = false;
            } 
            else
            {
                _waterMachine.PayWithCard = true;
                payWithCardToolStripMenuItem.Checked = true;
                btnWithCard.Enabled = true;
            }
        }

        private void canBuyBottlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (canBuyBottlesToolStripMenuItem.Checked)
            {
                _waterMachine.SellBottles = false;
                canBuyBottlesToolStripMenuItem.Checked = false;
                btnWithoutBottle.Enabled = false;
            }
            else
            {
                _waterMachine.SellBottles = true;
                canBuyBottlesToolStripMenuItem.Checked = true;
                btnWithoutBottle.Enabled = true;
            }
        }

        private void sodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sodaToolStripMenuItem.Checked)
            {
                _waterMachine.SellSoda = false;
                sodaToolStripMenuItem.Checked = false;
                btnWaterTypeSoda.Enabled = false;
            }
            else
            {
                _waterMachine.SellSoda = true;
                sodaToolStripMenuItem.Checked = true;
                btnWaterTypeStill.Enabled = true;
            }
        }

        private void getAdressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_waterMachine.Address);
        }

        private void getIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_waterMachine.Income.ToString());
        }

        private void addWaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void addBottlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBuy.Visible = false;
            labelCountOfLiters.Visible = false;
            textBoxCountOfLiters.Visible = false;
            btnWithBottle.Visible = false;
            btnBuy.Visible = false;
            labelCountOfBottles.Visible = false;
            textBoxCountOfBottles.Visible = false;
            btnWithoutBottle.Visible = false;
            labelOwnBottle.Visible = false;
            btnBack.Visible = false;
            btnWaterTypeSoda.Visible = false;
            btnWaterTypeStill.Visible = false;
            labelWaterType.Visible = false;
            btnCash.Visible = false;
            btnWithCard.Visible = false;
            labelPayMehod.Visible = false;
            labelSum.Visible = false;
            labelCacheAmount.Visible = false;
            textBoxCashAmount.Visible = false;
            btnPay.Visible = false;

            labelWaterAdd.Visible = true;
            labelBottleAdd.Visible = true;
            textBoxBottleAdd.Visible = true;
            textBoxWaterAdd.Visible = true;
            btnAddWater.Visible = true;
        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            try
            {
                var addBottle = int.Parse(textBoxBottleAdd.Text);
                var addWater = int.Parse(textBoxWaterAdd.Text);
                if (addBottle < 0 || addWater < 0)
                {
                    throw new Exception("Add value must be positive!");
                }


                _waterMachine.BottleCount += addBottle;
                _waterMachine.WaterTank.Volume += addWater;
                redrawWindow();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
