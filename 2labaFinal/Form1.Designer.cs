namespace _2labaFinal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelWaterType = new System.Windows.Forms.Label();
            this.btnWaterTypeStill = new System.Windows.Forms.Button();
            this.btnWaterTypeSoda = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelOwnBottle = new System.Windows.Forms.Label();
            this.btnWithoutBottle = new System.Windows.Forms.Button();
            this.btnWithBottle = new System.Windows.Forms.Button();
            this.textBoxCountOfBottles = new System.Windows.Forms.TextBox();
            this.labelCountOfBottles = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.labelCountOfLiters = new System.Windows.Forms.Label();
            this.textBoxCountOfLiters = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelPayMehod = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnWithCard = new System.Windows.Forms.Button();
            this.labelWaterInMachine = new System.Windows.Forms.Label();
            this.labelCacheAmount = new System.Windows.Forms.Label();
            this.textBoxCashAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addBottlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.payWithCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canBuyBottlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAdressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBottlesCount = new System.Windows.Forms.Label();
            this.labelStillWaterPrice = new System.Windows.Forms.Label();
            this.labelSodaPrice = new System.Windows.Forms.Label();
            this.labelBottlePrice = new System.Windows.Forms.Label();
            this.labelPrices = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.textBoxWaterAdd = new System.Windows.Forms.TextBox();
            this.labelWaterAdd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxBottleAdd = new System.Windows.Forms.TextBox();
            this.labelBottleAdd = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWaterType
            // 
            this.labelWaterType.AutoSize = true;
            this.labelWaterType.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterType.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelWaterType.Location = new System.Drawing.Point(194, 241);
            this.labelWaterType.Name = "labelWaterType";
            this.labelWaterType.Size = new System.Drawing.Size(183, 43);
            this.labelWaterType.TabIndex = 2;
            this.labelWaterType.Text = "Water Type";
            // 
            // btnWaterTypeStill
            // 
            this.btnWaterTypeStill.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaterTypeStill.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWaterTypeStill.Location = new System.Drawing.Point(140, 305);
            this.btnWaterTypeStill.Name = "btnWaterTypeStill";
            this.btnWaterTypeStill.Size = new System.Drawing.Size(141, 42);
            this.btnWaterTypeStill.TabIndex = 4;
            this.btnWaterTypeStill.Text = "Still";
            this.btnWaterTypeStill.UseVisualStyleBackColor = true;
            this.btnWaterTypeStill.Click += new System.EventHandler(this.btnWaterTypeStill_Click);
            // 
            // btnWaterTypeSoda
            // 
            this.btnWaterTypeSoda.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaterTypeSoda.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWaterTypeSoda.Location = new System.Drawing.Point(287, 305);
            this.btnWaterTypeSoda.Name = "btnWaterTypeSoda";
            this.btnWaterTypeSoda.Size = new System.Drawing.Size(141, 42);
            this.btnWaterTypeSoda.TabIndex = 5;
            this.btnWaterTypeSoda.Text = "Soda";
            this.btnWaterTypeSoda.UseVisualStyleBackColor = true;
            this.btnWaterTypeSoda.Click += new System.EventHandler(this.btnWaterTypeSoda_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SlateGray;
            this.btnBack.Location = new System.Drawing.Point(38, 302);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 42);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<=";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelOwnBottle
            // 
            this.labelOwnBottle.AutoSize = true;
            this.labelOwnBottle.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwnBottle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelOwnBottle.Location = new System.Drawing.Point(68, 241);
            this.labelOwnBottle.Name = "labelOwnBottle";
            this.labelOwnBottle.Size = new System.Drawing.Size(432, 43);
            this.labelOwnBottle.TabIndex = 7;
            this.labelOwnBottle.Text = "Do you have your own bottle?";
            this.labelOwnBottle.Visible = false;
            // 
            // btnWithoutBottle
            // 
            this.btnWithoutBottle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithoutBottle.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWithoutBottle.Location = new System.Drawing.Point(140, 305);
            this.btnWithoutBottle.Name = "btnWithoutBottle";
            this.btnWithoutBottle.Size = new System.Drawing.Size(141, 42);
            this.btnWithoutBottle.TabIndex = 8;
            this.btnWithoutBottle.Text = "No";
            this.btnWithoutBottle.UseVisualStyleBackColor = true;
            this.btnWithoutBottle.Visible = false;
            this.btnWithoutBottle.Click += new System.EventHandler(this.btnWithoutBottle_Click);
            // 
            // btnWithBottle
            // 
            this.btnWithBottle.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnWithBottle.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWithBottle.Location = new System.Drawing.Point(287, 305);
            this.btnWithBottle.Name = "btnWithBottle";
            this.btnWithBottle.Size = new System.Drawing.Size(141, 42);
            this.btnWithBottle.TabIndex = 9;
            this.btnWithBottle.Text = "Yes";
            this.btnWithBottle.UseVisualStyleBackColor = true;
            this.btnWithBottle.Visible = false;
            this.btnWithBottle.Click += new System.EventHandler(this.btnWithBottle_Click);
            // 
            // textBoxCountOfBottles
            // 
            this.textBoxCountOfBottles.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCountOfBottles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCountOfBottles.Font = new System.Drawing.Font("Impact", 26.25F);
            this.textBoxCountOfBottles.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxCountOfBottles.Location = new System.Drawing.Point(416, 250);
            this.textBoxCountOfBottles.MaxLength = 2;
            this.textBoxCountOfBottles.Name = "textBoxCountOfBottles";
            this.textBoxCountOfBottles.Size = new System.Drawing.Size(42, 50);
            this.textBoxCountOfBottles.TabIndex = 10;
            this.textBoxCountOfBottles.Visible = false;
            // 
            // labelCountOfBottles
            // 
            this.labelCountOfBottles.AutoSize = true;
            this.labelCountOfBottles.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountOfBottles.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelCountOfBottles.Location = new System.Drawing.Point(100, 250);
            this.labelCountOfBottles.Name = "labelCountOfBottles";
            this.labelCountOfBottles.Size = new System.Drawing.Size(310, 43);
            this.labelCountOfBottles.TabIndex = 11;
            this.labelCountOfBottles.Text = "Count of bottles (2L):";
            this.labelCountOfBottles.Visible = false;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.SlateGray;
            this.btnBuy.Location = new System.Drawing.Point(217, 305);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(141, 42);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Visible = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // labelCountOfLiters
            // 
            this.labelCountOfLiters.AutoSize = true;
            this.labelCountOfLiters.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountOfLiters.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelCountOfLiters.Location = new System.Drawing.Point(132, 250);
            this.labelCountOfLiters.Name = "labelCountOfLiters";
            this.labelCountOfLiters.Size = new System.Drawing.Size(226, 43);
            this.labelCountOfLiters.TabIndex = 13;
            this.labelCountOfLiters.Text = "Count of liters:";
            this.labelCountOfLiters.Visible = false;
            // 
            // textBoxCountOfLiters
            // 
            this.textBoxCountOfLiters.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCountOfLiters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCountOfLiters.Font = new System.Drawing.Font("Impact", 26.25F);
            this.textBoxCountOfLiters.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxCountOfLiters.Location = new System.Drawing.Point(364, 250);
            this.textBoxCountOfLiters.MaxLength = 3;
            this.textBoxCountOfLiters.Name = "textBoxCountOfLiters";
            this.textBoxCountOfLiters.Size = new System.Drawing.Size(60, 50);
            this.textBoxCountOfLiters.TabIndex = 14;
            this.textBoxCountOfLiters.Visible = false;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelSum.Location = new System.Drawing.Point(91, 375);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(95, 43);
            this.labelSum.TabIndex = 15;
            this.labelSum.Text = "Sum: ";
            this.labelSum.Visible = false;
            // 
            // labelPayMehod
            // 
            this.labelPayMehod.AutoSize = true;
            this.labelPayMehod.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayMehod.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelPayMehod.Location = new System.Drawing.Point(190, 250);
            this.labelPayMehod.Name = "labelPayMehod";
            this.labelPayMehod.Size = new System.Drawing.Size(187, 43);
            this.labelPayMehod.TabIndex = 16;
            this.labelPayMehod.Text = "Pay method";
            this.labelPayMehod.Visible = false;
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCash.Location = new System.Drawing.Point(140, 305);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(141, 42);
            this.btnCash.TabIndex = 17;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Visible = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnWithCard
            // 
            this.btnWithCard.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnWithCard.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWithCard.Location = new System.Drawing.Point(287, 305);
            this.btnWithCard.Name = "btnWithCard";
            this.btnWithCard.Size = new System.Drawing.Size(141, 42);
            this.btnWithCard.TabIndex = 18;
            this.btnWithCard.Text = "With card";
            this.btnWithCard.UseVisualStyleBackColor = true;
            this.btnWithCard.Visible = false;
            this.btnWithCard.Click += new System.EventHandler(this.btnWithCard_Click);
            // 
            // labelWaterInMachine
            // 
            this.labelWaterInMachine.AutoSize = true;
            this.labelWaterInMachine.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterInMachine.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelWaterInMachine.Location = new System.Drawing.Point(91, 436);
            this.labelWaterInMachine.Name = "labelWaterInMachine";
            this.labelWaterInMachine.Size = new System.Drawing.Size(285, 43);
            this.labelWaterInMachine.TabIndex = 19;
            this.labelWaterInMachine.Text = "Water in machine: ";
            // 
            // labelCacheAmount
            // 
            this.labelCacheAmount.AutoSize = true;
            this.labelCacheAmount.Font = new System.Drawing.Font("Impact", 18.25F);
            this.labelCacheAmount.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelCacheAmount.Location = new System.Drawing.Point(93, 253);
            this.labelCacheAmount.Name = "labelCacheAmount";
            this.labelCacheAmount.Size = new System.Drawing.Size(243, 32);
            this.labelCacheAmount.TabIndex = 20;
            this.labelCacheAmount.Text = "How much do you pay?";
            this.labelCacheAmount.Visible = false;
            // 
            // textBoxCashAmount
            // 
            this.textBoxCashAmount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCashAmount.Font = new System.Drawing.Font("Impact", 18.25F);
            this.textBoxCashAmount.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxCashAmount.Location = new System.Drawing.Point(342, 255);
            this.textBoxCashAmount.MaxLength = 6;
            this.textBoxCashAmount.Name = "textBoxCashAmount";
            this.textBoxCashAmount.Size = new System.Drawing.Size(141, 37);
            this.textBoxCashAmount.TabIndex = 21;
            this.textBoxCashAmount.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.SlateGray;
            this.btnPay.Location = new System.Drawing.Point(217, 305);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 42);
            this.btnPay.TabIndex = 22;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBottlesToolStripMenuItem,
            this.getIncomeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.getAdressToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addBottlesToolStripMenuItem
            // 
            this.addBottlesToolStripMenuItem.Name = "addBottlesToolStripMenuItem";
            this.addBottlesToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addBottlesToolStripMenuItem.Text = "Add";
            this.addBottlesToolStripMenuItem.Click += new System.EventHandler(this.addBottlesToolStripMenuItem_Click);
            // 
            // getIncomeToolStripMenuItem
            // 
            this.getIncomeToolStripMenuItem.Name = "getIncomeToolStripMenuItem";
            this.getIncomeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.getIncomeToolStripMenuItem.Text = "Get Income";
            this.getIncomeToolStripMenuItem.Click += new System.EventHandler(this.getIncomeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payWithCardToolStripMenuItem,
            this.canBuyBottlesToolStripMenuItem,
            this.sodaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItem1.Text = "Params";
            // 
            // payWithCardToolStripMenuItem
            // 
            this.payWithCardToolStripMenuItem.Checked = true;
            this.payWithCardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.payWithCardToolStripMenuItem.Name = "payWithCardToolStripMenuItem";
            this.payWithCardToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.payWithCardToolStripMenuItem.Text = "Pay with card";
            this.payWithCardToolStripMenuItem.Click += new System.EventHandler(this.payWithCardToolStripMenuItem_Click);
            // 
            // canBuyBottlesToolStripMenuItem
            // 
            this.canBuyBottlesToolStripMenuItem.Checked = true;
            this.canBuyBottlesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.canBuyBottlesToolStripMenuItem.Name = "canBuyBottlesToolStripMenuItem";
            this.canBuyBottlesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.canBuyBottlesToolStripMenuItem.Text = "Bottle sale";
            this.canBuyBottlesToolStripMenuItem.Click += new System.EventHandler(this.canBuyBottlesToolStripMenuItem_Click);
            // 
            // sodaToolStripMenuItem
            // 
            this.sodaToolStripMenuItem.Checked = true;
            this.sodaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sodaToolStripMenuItem.Name = "sodaToolStripMenuItem";
            this.sodaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sodaToolStripMenuItem.Text = "Soda";
            this.sodaToolStripMenuItem.Click += new System.EventHandler(this.sodaToolStripMenuItem_Click);
            // 
            // getAdressToolStripMenuItem
            // 
            this.getAdressToolStripMenuItem.Name = "getAdressToolStripMenuItem";
            this.getAdressToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.getAdressToolStripMenuItem.Text = "Get Adress";
            this.getAdressToolStripMenuItem.Click += new System.EventHandler(this.getAdressToolStripMenuItem_Click);
            // 
            // labelBottlesCount
            // 
            this.labelBottlesCount.AutoSize = true;
            this.labelBottlesCount.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBottlesCount.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelBottlesCount.Location = new System.Drawing.Point(92, 490);
            this.labelBottlesCount.Name = "labelBottlesCount";
            this.labelBottlesCount.Size = new System.Drawing.Size(206, 43);
            this.labelBottlesCount.TabIndex = 25;
            this.labelBottlesCount.Text = "Bottle count: ";
            // 
            // labelStillWaterPrice
            // 
            this.labelStillWaterPrice.AutoSize = true;
            this.labelStillWaterPrice.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStillWaterPrice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStillWaterPrice.Location = new System.Drawing.Point(30, 78);
            this.labelStillWaterPrice.Name = "labelStillWaterPrice";
            this.labelStillWaterPrice.Size = new System.Drawing.Size(82, 43);
            this.labelStillWaterPrice.TabIndex = 26;
            this.labelStillWaterPrice.Text = "Still:";
            // 
            // labelSodaPrice
            // 
            this.labelSodaPrice.AutoSize = true;
            this.labelSodaPrice.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSodaPrice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelSodaPrice.Location = new System.Drawing.Point(30, 121);
            this.labelSodaPrice.Name = "labelSodaPrice";
            this.labelSodaPrice.Size = new System.Drawing.Size(98, 43);
            this.labelSodaPrice.TabIndex = 27;
            this.labelSodaPrice.Text = "Soda:";
            // 
            // labelBottlePrice
            // 
            this.labelBottlePrice.AutoSize = true;
            this.labelBottlePrice.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBottlePrice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelBottlePrice.Location = new System.Drawing.Point(30, 164);
            this.labelBottlePrice.Name = "labelBottlePrice";
            this.labelBottlePrice.Size = new System.Drawing.Size(171, 43);
            this.labelBottlePrice.TabIndex = 28;
            this.labelBottlePrice.Text = "Bottle (2L):";
            // 
            // labelPrices
            // 
            this.labelPrices.AutoSize = true;
            this.labelPrices.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrices.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelPrices.Location = new System.Drawing.Point(91, 35);
            this.labelPrices.Name = "labelPrices";
            this.labelPrices.Size = new System.Drawing.Size(110, 43);
            this.labelPrices.TabIndex = 29;
            this.labelPrices.Text = "Prices";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAddWater
            // 
            this.btnAddWater.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnAddWater.ForeColor = System.Drawing.Color.SlateGray;
            this.btnAddWater.Location = new System.Drawing.Point(234, 325);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(85, 37);
            this.btnAddWater.TabIndex = 32;
            this.btnAddWater.Text = "Add";
            this.btnAddWater.UseVisualStyleBackColor = true;
            this.btnAddWater.Visible = false;
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
            // 
            // textBoxWaterAdd
            // 
            this.textBoxWaterAdd.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWaterAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWaterAdd.Font = new System.Drawing.Font("Impact", 18.25F);
            this.textBoxWaterAdd.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxWaterAdd.Location = new System.Drawing.Point(287, 242);
            this.textBoxWaterAdd.MaxLength = 3;
            this.textBoxWaterAdd.Name = "textBoxWaterAdd";
            this.textBoxWaterAdd.Size = new System.Drawing.Size(85, 37);
            this.textBoxWaterAdd.TabIndex = 31;
            this.textBoxWaterAdd.Text = "0";
            this.textBoxWaterAdd.Visible = false;
            this.textBoxWaterAdd.WordWrap = false;
            // 
            // labelWaterAdd
            // 
            this.labelWaterAdd.AutoSize = true;
            this.labelWaterAdd.Font = new System.Drawing.Font("Impact", 18.25F);
            this.labelWaterAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelWaterAdd.Location = new System.Drawing.Point(156, 242);
            this.labelWaterAdd.Name = "labelWaterAdd";
            this.labelWaterAdd.Size = new System.Drawing.Size(125, 32);
            this.labelWaterAdd.TabIndex = 30;
            this.labelWaterAdd.Text = "Water add:";
            this.labelWaterAdd.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = global::_2labaFinal.Properties.Resources.logo_3731;
            this.pictureBox1.Location = new System.Drawing.Point(364, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxBottleAdd
            // 
            this.textBoxBottleAdd.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBottleAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBottleAdd.Font = new System.Drawing.Font("Impact", 18.25F);
            this.textBoxBottleAdd.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxBottleAdd.Location = new System.Drawing.Point(287, 282);
            this.textBoxBottleAdd.MaxLength = 3;
            this.textBoxBottleAdd.Name = "textBoxBottleAdd";
            this.textBoxBottleAdd.Size = new System.Drawing.Size(85, 37);
            this.textBoxBottleAdd.TabIndex = 34;
            this.textBoxBottleAdd.Text = "0";
            this.textBoxBottleAdd.Visible = false;
            this.textBoxBottleAdd.WordWrap = false;
            // 
            // labelBottleAdd
            // 
            this.labelBottleAdd.AutoSize = true;
            this.labelBottleAdd.Font = new System.Drawing.Font("Impact", 18.25F);
            this.labelBottleAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelBottleAdd.Location = new System.Drawing.Point(156, 285);
            this.labelBottleAdd.Name = "labelBottleAdd";
            this.labelBottleAdd.Size = new System.Drawing.Size(125, 32);
            this.labelBottleAdd.TabIndex = 33;
            this.labelBottleAdd.Text = "Bottle add:";
            this.labelBottleAdd.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 566);
            this.Controls.Add(this.textBoxBottleAdd);
            this.Controls.Add(this.labelBottleAdd);
            this.Controls.Add(this.btnAddWater);
            this.Controls.Add(this.textBoxWaterAdd);
            this.Controls.Add(this.labelWaterAdd);
            this.Controls.Add(this.labelPrices);
            this.Controls.Add(this.labelBottlePrice);
            this.Controls.Add(this.labelSodaPrice);
            this.Controls.Add(this.labelStillWaterPrice);
            this.Controls.Add(this.labelBottlesCount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.textBoxCashAmount);
            this.Controls.Add(this.labelCacheAmount);
            this.Controls.Add(this.labelWaterInMachine);
            this.Controls.Add(this.btnWithCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.labelPayMehod);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxCountOfLiters);
            this.Controls.Add(this.labelCountOfLiters);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.labelCountOfBottles);
            this.Controls.Add(this.textBoxCountOfBottles);
            this.Controls.Add(this.btnWithBottle);
            this.Controls.Add(this.btnWithoutBottle);
            this.Controls.Add(this.labelOwnBottle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnWaterTypeSoda);
            this.Controls.Add(this.btnWaterTypeStill);
            this.Controls.Add(this.labelWaterType);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bubun Sebeka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWaterType;
        private System.Windows.Forms.Button btnWaterTypeStill;
        private System.Windows.Forms.Button btnWaterTypeSoda;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelOwnBottle;
        private System.Windows.Forms.Button btnWithoutBottle;
        private System.Windows.Forms.Button btnWithBottle;
        private System.Windows.Forms.TextBox textBoxCountOfBottles;
        private System.Windows.Forms.Label labelCountOfBottles;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label labelCountOfLiters;
        private System.Windows.Forms.TextBox textBoxCountOfLiters;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelPayMehod;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnWithCard;
        private System.Windows.Forms.Label labelWaterInMachine;
        private System.Windows.Forms.Label labelCacheAmount;
        private System.Windows.Forms.TextBox textBoxCashAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addBottlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getIncomeToolStripMenuItem;
        private System.Windows.Forms.Label labelBottlesCount;
        private System.Windows.Forms.Label labelStillWaterPrice;
        private System.Windows.Forms.Label labelSodaPrice;
        private System.Windows.Forms.Label labelBottlePrice;
        private System.Windows.Forms.Label labelPrices;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem payWithCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canBuyBottlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAdressToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnAddWater;
        private System.Windows.Forms.TextBox textBoxWaterAdd;
        private System.Windows.Forms.Label labelWaterAdd;
        private System.Windows.Forms.TextBox textBoxBottleAdd;
        private System.Windows.Forms.Label labelBottleAdd;
    }
}

