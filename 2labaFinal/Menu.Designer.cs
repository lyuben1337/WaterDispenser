namespace _2labaFinal
{
    partial class Menu
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
            this.btnNewAutomat = new System.Windows.Forms.Button();
            this.listBoxAutomats = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNewAutomat
            // 
            this.btnNewAutomat.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnNewAutomat.ForeColor = System.Drawing.Color.SlateGray;
            this.btnNewAutomat.Location = new System.Drawing.Point(12, 242);
            this.btnNewAutomat.Name = "btnNewAutomat";
            this.btnNewAutomat.Size = new System.Drawing.Size(221, 42);
            this.btnNewAutomat.TabIndex = 33;
            this.btnNewAutomat.Text = "New Automat";
            this.btnNewAutomat.UseVisualStyleBackColor = true;
            this.btnNewAutomat.Click += new System.EventHandler(this.btnNewAutomat_Click);
            // 
            // listBoxAutomats
            // 
            this.listBoxAutomats.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAutomats.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.listBoxAutomats.FormattingEnabled = true;
            this.listBoxAutomats.ItemHeight = 21;
            this.listBoxAutomats.Location = new System.Drawing.Point(12, 12);
            this.listBoxAutomats.Name = "listBoxAutomats";
            this.listBoxAutomats.Size = new System.Drawing.Size(221, 214);
            this.listBoxAutomats.TabIndex = 34;
            this.listBoxAutomats.DoubleClick += new System.EventHandler(this.listBoxAutomats_DoubleClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(249, 293);
            this.Controls.Add(this.listBoxAutomats);
            this.Controls.Add(this.btnNewAutomat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewAutomat;
        private System.Windows.Forms.ListBox listBoxAutomats;
    }
}