namespace MiniUppgiftF
{
    partial class ApartmentComplexCreator
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
            this.btnSave = new System.Windows.Forms.Button();
            this.radioStatus = new System.Windows.Forms.RadioButton();
            this.txtNumberOfRooms = new System.Windows.Forms.TextBox();
            this.lblApartmentNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 90);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radioStatus
            // 
            this.radioStatus.AutoSize = true;
            this.radioStatus.Location = new System.Drawing.Point(22, 58);
            this.radioStatus.Name = "radioStatus";
            this.radioStatus.Size = new System.Drawing.Size(178, 29);
            this.radioStatus.TabIndex = 1;
            this.radioStatus.TabStop = true;
            this.radioStatus.Text = "Occupied/Empty";
            this.radioStatus.UseVisualStyleBackColor = true;
            // 
            // txtNumberOfRooms
            // 
            this.txtNumberOfRooms.Location = new System.Drawing.Point(155, 32);
            this.txtNumberOfRooms.Name = "txtNumberOfRooms";
            this.txtNumberOfRooms.Size = new System.Drawing.Size(28, 30);
            this.txtNumberOfRooms.TabIndex = 2;
            // 
            // lblApartmentNumber
            // 
            this.lblApartmentNumber.AutoSize = true;
            this.lblApartmentNumber.Location = new System.Drawing.Point(18, 9);
            this.lblApartmentNumber.Name = "lblApartmentNumber";
            this.lblApartmentNumber.Size = new System.Drawing.Size(203, 25);
            this.lblApartmentNumber.TabIndex = 3;
            this.lblApartmentNumber.Text = "Apartment Number : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of rooms";
            // 
            // ApartmentComplexCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblApartmentNumber);
            this.Controls.Add(this.txtNumberOfRooms);
            this.Controls.Add(this.radioStatus);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ApartmentComplexCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApartmentComplexCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioStatus;
        private System.Windows.Forms.TextBox txtNumberOfRooms;
        private System.Windows.Forms.Label lblApartmentNumber;
        private System.Windows.Forms.Label label2;
    }
}