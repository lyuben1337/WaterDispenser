namespace View
{
    partial class Company
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
            this.labelEDRPOU = new System.Windows.Forms.Label();
            this.labelCompanyAdress = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelMaxTankVolume = new System.Windows.Forms.Label();
            this.comboBoxTanks = new System.Windows.Forms.ComboBox();
            this.labelAddWaterToTanks = new System.Windows.Forms.Label();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.btnSaveCompany = new System.Windows.Forms.Button();
            this.btnSaveLogs = new System.Windows.Forms.Button();
            this.textBoxTankVolume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarWater = new System.Windows.Forms.ProgressBar();
            this.labelIncome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEDRPOU
            // 
            this.labelEDRPOU.AutoSize = true;
            this.labelEDRPOU.Font = new System.Drawing.Font("Impact", 20F);
            this.labelEDRPOU.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelEDRPOU.Location = new System.Drawing.Point(12, 110);
            this.labelEDRPOU.Name = "labelEDRPOU";
            this.labelEDRPOU.Size = new System.Drawing.Size(110, 34);
            this.labelEDRPOU.TabIndex = 40;
            this.labelEDRPOU.Text = "EDRPOU: ";
            // 
            // labelCompanyAdress
            // 
            this.labelCompanyAdress.AutoSize = true;
            this.labelCompanyAdress.Font = new System.Drawing.Font("Impact", 20F);
            this.labelCompanyAdress.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelCompanyAdress.Location = new System.Drawing.Point(12, 61);
            this.labelCompanyAdress.Name = "labelCompanyAdress";
            this.labelCompanyAdress.Size = new System.Drawing.Size(117, 34);
            this.labelCompanyAdress.TabIndex = 39;
            this.labelCompanyAdress.Text = "Address: ";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Impact", 20F);
            this.labelCompanyName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 9);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(89, 34);
            this.labelCompanyName.TabIndex = 38;
            this.labelCompanyName.Text = "Name: ";
            // 
            // labelMaxTankVolume
            // 
            this.labelMaxTankVolume.AutoSize = true;
            this.labelMaxTankVolume.Font = new System.Drawing.Font("Impact", 20F);
            this.labelMaxTankVolume.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelMaxTankVolume.Location = new System.Drawing.Point(12, 157);
            this.labelMaxTankVolume.Name = "labelMaxTankVolume";
            this.labelMaxTankVolume.Size = new System.Drawing.Size(215, 34);
            this.labelMaxTankVolume.TabIndex = 41;
            this.labelMaxTankVolume.Text = "Max Tank Volume: ";
            // 
            // comboBoxTanks
            // 
            this.comboBoxTanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTanks.Font = new System.Drawing.Font("Impact", 18.25F);
            this.comboBoxTanks.ForeColor = System.Drawing.Color.SlateGray;
            this.comboBoxTanks.FormattingEnabled = true;
            this.comboBoxTanks.Location = new System.Drawing.Point(106, 286);
            this.comboBoxTanks.Name = "comboBoxTanks";
            this.comboBoxTanks.Size = new System.Drawing.Size(53, 37);
            this.comboBoxTanks.TabIndex = 42;
            this.comboBoxTanks.SelectedIndexChanged += new System.EventHandler(this.comboBoxTanks_SelectedIndexChanged);
            // 
            // labelAddWaterToTanks
            // 
            this.labelAddWaterToTanks.AutoSize = true;
            this.labelAddWaterToTanks.Font = new System.Drawing.Font("Impact", 20F);
            this.labelAddWaterToTanks.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelAddWaterToTanks.Location = new System.Drawing.Point(106, 241);
            this.labelAddWaterToTanks.Name = "labelAddWaterToTanks";
            this.labelAddWaterToTanks.Size = new System.Drawing.Size(130, 34);
            this.labelAddWaterToTanks.TabIndex = 43;
            this.labelAddWaterToTanks.Text = "Add Water";
            // 
            // btnAddWater
            // 
            this.btnAddWater.Enabled = false;
            this.btnAddWater.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnAddWater.ForeColor = System.Drawing.Color.SlateGray;
            this.btnAddWater.Location = new System.Drawing.Point(263, 286);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(52, 37);
            this.btnAddWater.TabIndex = 44;
            this.btnAddWater.Text = "Add";
            this.btnAddWater.UseVisualStyleBackColor = true;
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnSaveCompany.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSaveCompany.Location = new System.Drawing.Point(72, 362);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(209, 37);
            this.btnSaveCompany.TabIndex = 45;
            this.btnSaveCompany.Text = "Save Company";
            this.btnSaveCompany.UseVisualStyleBackColor = true;
            this.btnSaveCompany.Click += new System.EventHandler(this.btnSaveCompany_Click);
            // 
            // btnSaveLogs
            // 
            this.btnSaveLogs.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnSaveLogs.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSaveLogs.Location = new System.Drawing.Point(72, 405);
            this.btnSaveLogs.Name = "btnSaveLogs";
            this.btnSaveLogs.Size = new System.Drawing.Size(209, 37);
            this.btnSaveLogs.TabIndex = 46;
            this.btnSaveLogs.Text = "Save Logs";
            this.btnSaveLogs.UseVisualStyleBackColor = true;
            this.btnSaveLogs.Click += new System.EventHandler(this.btnSaveLogs_Click);
            // 
            // textBoxTankVolume
            // 
            this.textBoxTankVolume.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTankVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTankVolume.Font = new System.Drawing.Font("Impact", 18.25F);
            this.textBoxTankVolume.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxTankVolume.Location = new System.Drawing.Point(165, 286);
            this.textBoxTankVolume.MaxLength = 6;
            this.textBoxTankVolume.Name = "textBoxTankVolume";
            this.textBoxTankVolume.Size = new System.Drawing.Size(95, 37);
            this.textBoxTankVolume.TabIndex = 47;
            this.textBoxTankVolume.Text = "500";
            this.textBoxTankVolume.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20F);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(35, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 34);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tank:";
            // 
            // progressBarWater
            // 
            this.progressBarWater.Location = new System.Drawing.Point(41, 329);
            this.progressBarWater.Name = "progressBarWater";
            this.progressBarWater.Size = new System.Drawing.Size(274, 27);
            this.progressBarWater.TabIndex = 49;
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelIncome.Font = new System.Drawing.Font("Impact", 20F);
            this.labelIncome.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelIncome.Location = new System.Drawing.Point(12, 201);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(169, 34);
            this.labelIncome.TabIndex = 50;
            this.labelIncome.Text = "Total Income: ";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 453);
            this.Controls.Add(this.labelIncome);
            this.Controls.Add(this.progressBarWater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTankVolume);
            this.Controls.Add(this.btnSaveLogs);
            this.Controls.Add(this.btnSaveCompany);
            this.Controls.Add(this.btnAddWater);
            this.Controls.Add(this.labelAddWaterToTanks);
            this.Controls.Add(this.comboBoxTanks);
            this.Controls.Add(this.labelMaxTankVolume);
            this.Controls.Add(this.labelEDRPOU);
            this.Controls.Add(this.labelCompanyAdress);
            this.Controls.Add(this.labelCompanyName);
            this.Name = "Company";
            this.Text = "Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEDRPOU;
        private System.Windows.Forms.Label labelCompanyAdress;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelMaxTankVolume;
        private System.Windows.Forms.ComboBox comboBoxTanks;
        private System.Windows.Forms.Label labelAddWaterToTanks;
        private System.Windows.Forms.Button btnAddWater;
        private System.Windows.Forms.Button btnSaveCompany;
        private System.Windows.Forms.Button btnSaveLogs;
        private System.Windows.Forms.TextBox textBoxTankVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarWater;
        private System.Windows.Forms.Label labelIncome;
    }
}