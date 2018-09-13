namespace MiniUppgiftF
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
            this.cbxApartmentComplex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxApartmens = new System.Windows.Forms.ListBox();
            this.lblApartmentNum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewApartmentComplex = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxApartmentComplex
            // 
            this.cbxApartmentComplex.FormattingEnabled = true;
            this.cbxApartmentComplex.Location = new System.Drawing.Point(13, 54);
            this.cbxApartmentComplex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxApartmentComplex.Name = "cbxApartmentComplex";
            this.cbxApartmentComplex.Size = new System.Drawing.Size(180, 33);
            this.cbxApartmentComplex.TabIndex = 0;
            this.cbxApartmentComplex.SelectedIndexChanged += new System.EventHandler(this.cbxApartmentComplex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apartment Complex";
            // 
            // lbxApartmens
            // 
            this.lbxApartmens.FormattingEnabled = true;
            this.lbxApartmens.ItemHeight = 25;
            this.lbxApartmens.Location = new System.Drawing.Point(12, 90);
            this.lbxApartmens.Name = "lbxApartmens";
            this.lbxApartmens.Size = new System.Drawing.Size(181, 154);
            this.lbxApartmens.TabIndex = 2;
            this.lbxApartmens.SelectedIndexChanged += new System.EventHandler(this.lbxApartmens_SelectedIndexChanged);
            // 
            // lblApartmentNum
            // 
            this.lblApartmentNum.AutoSize = true;
            this.lblApartmentNum.Location = new System.Drawing.Point(12, 247);
            this.lblApartmentNum.Name = "lblApartmentNum";
            this.lblApartmentNum.Size = new System.Drawing.Size(129, 25);
            this.lblApartmentNum.TabIndex = 4;
            this.lblApartmentNum.Text = "Apartment : 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(211, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewApartmentComplex});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem2.Text = "Options";
            // 
            // menuItemNewApartmentComplex
            // 
            this.menuItemNewApartmentComplex.Name = "menuItemNewApartmentComplex";
            this.menuItemNewApartmentComplex.Size = new System.Drawing.Size(252, 26);
            this.menuItemNewApartmentComplex.Text = "New Apartment Complex";
            this.menuItemNewApartmentComplex.Click += new System.EventHandler(this.menuItemNewApartmentComplex_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(12, 270);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(181, 29);
            this.btnChangeStatus.TabIndex = 9;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 311);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblApartmentNum);
            this.Controls.Add(this.lbxApartmens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxApartmentComplex);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartment Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxApartmentComplex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxApartmens;
        private System.Windows.Forms.Label lblApartmentNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewApartmentComplex;
        private System.Windows.Forms.Button btnChangeStatus;
    }
}

