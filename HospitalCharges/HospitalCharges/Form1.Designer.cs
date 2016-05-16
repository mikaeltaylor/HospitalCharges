namespace HospitalCharges
{
    partial class HospitalCharges
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
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDaysInput = new System.Windows.Forms.TextBox();
            this.lblMedCharges = new System.Windows.Forms.Label();
            this.txtMedInput = new System.Windows.Forms.TextBox();
            this.lblSurgicalCharges = new System.Windows.Forms.Label();
            this.txtSurgicalInput = new System.Windows.Forms.TextBox();
            this.lblRehabCharges = new System.Windows.Forms.Label();
            this.txtRehabInput = new System.Windows.Forms.TextBox();
            this.lblLabFees = new System.Windows.Forms.Label();
            this.txtLabInput = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtDateInput = new System.Windows.Forms.TextBox();
            this.txtTimeInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(57, 31);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(180, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "How many days did the patient stay?";
            // 
            // txtDaysInput
            // 
            this.txtDaysInput.Location = new System.Drawing.Point(244, 28);
            this.txtDaysInput.Name = "txtDaysInput";
            this.txtDaysInput.Size = new System.Drawing.Size(100, 20);
            this.txtDaysInput.TabIndex = 1;
            this.txtDaysInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDaysInput_KeyPress);
            // 
            // lblMedCharges
            // 
            this.lblMedCharges.AutoSize = true;
            this.lblMedCharges.Location = new System.Drawing.Point(74, 61);
            this.lblMedCharges.Name = "lblMedCharges";
            this.lblMedCharges.Size = new System.Drawing.Size(163, 13);
            this.lblMedCharges.TabIndex = 2;
            this.lblMedCharges.Text = "What were the medical charges?";
            // 
            // txtMedInput
            // 
            this.txtMedInput.Location = new System.Drawing.Point(244, 58);
            this.txtMedInput.Name = "txtMedInput";
            this.txtMedInput.Size = new System.Drawing.Size(100, 20);
            this.txtMedInput.TabIndex = 3;
            this.txtMedInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedInput_KeyPress);
            // 
            // lblSurgicalCharges
            // 
            this.lblSurgicalCharges.AutoSize = true;
            this.lblSurgicalCharges.Location = new System.Drawing.Point(74, 88);
            this.lblSurgicalCharges.Name = "lblSurgicalCharges";
            this.lblSurgicalCharges.Size = new System.Drawing.Size(163, 13);
            this.lblSurgicalCharges.TabIndex = 4;
            this.lblSurgicalCharges.Text = "What were the surgical charges?";
            // 
            // txtSurgicalInput
            // 
            this.txtSurgicalInput.Location = new System.Drawing.Point(244, 85);
            this.txtSurgicalInput.Name = "txtSurgicalInput";
            this.txtSurgicalInput.Size = new System.Drawing.Size(100, 20);
            this.txtSurgicalInput.TabIndex = 5;
            this.txtSurgicalInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurgicalInput_KeyPress);
            // 
            // lblRehabCharges
            // 
            this.lblRehabCharges.AutoSize = true;
            this.lblRehabCharges.Location = new System.Drawing.Point(11, 114);
            this.lblRehabCharges.Name = "lblRehabCharges";
            this.lblRehabCharges.Size = new System.Drawing.Size(227, 13);
            this.lblRehabCharges.TabIndex = 6;
            this.lblRehabCharges.Text = "What were the physical rehabilitation charges?";
            // 
            // txtRehabInput
            // 
            this.txtRehabInput.Location = new System.Drawing.Point(244, 111);
            this.txtRehabInput.Name = "txtRehabInput";
            this.txtRehabInput.Size = new System.Drawing.Size(100, 20);
            this.txtRehabInput.TabIndex = 7;
            this.txtRehabInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRehabInput_KeyPress);
            // 
            // lblLabFees
            // 
            this.lblLabFees.AutoSize = true;
            this.lblLabFees.Location = new System.Drawing.Point(115, 144);
            this.lblLabFees.Name = "lblLabFees";
            this.lblLabFees.Size = new System.Drawing.Size(123, 13);
            this.lblLabFees.TabIndex = 8;
            this.lblLabFees.Text = "What were the lab fees?";
            // 
            // txtLabInput
            // 
            this.txtLabInput.Location = new System.Drawing.Point(243, 141);
            this.txtLabInput.Name = "txtLabInput";
            this.txtLabInput.Size = new System.Drawing.Size(100, 20);
            this.txtLabInput.TabIndex = 9;
            this.txtLabInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLabInput_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(205, 171);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(204, 198);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time:";
            // 
            // txtDateInput
            // 
            this.txtDateInput.Location = new System.Drawing.Point(243, 168);
            this.txtDateInput.Name = "txtDateInput";
            this.txtDateInput.Size = new System.Drawing.Size(100, 20);
            this.txtDateInput.TabIndex = 12;
            // 
            // txtTimeInput
            // 
            this.txtTimeInput.Location = new System.Drawing.Point(244, 195);
            this.txtTimeInput.Name = "txtTimeInput";
            this.txtTimeInput.Size = new System.Drawing.Size(100, 20);
            this.txtTimeInput.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(194, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // HospitalCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 261);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTimeInput);
            this.Controls.Add(this.txtDateInput);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtLabInput);
            this.Controls.Add(this.lblLabFees);
            this.Controls.Add(this.txtRehabInput);
            this.Controls.Add(this.lblRehabCharges);
            this.Controls.Add(this.txtSurgicalInput);
            this.Controls.Add(this.lblSurgicalCharges);
            this.Controls.Add(this.txtMedInput);
            this.Controls.Add(this.lblMedCharges);
            this.Controls.Add(this.txtDaysInput);
            this.Controls.Add(this.lblDays);
            this.Name = "HospitalCharges";
            this.Text = "Hospital Charges v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDaysInput;
        private System.Windows.Forms.Label lblMedCharges;
        private System.Windows.Forms.TextBox txtMedInput;
        private System.Windows.Forms.Label lblSurgicalCharges;
        private System.Windows.Forms.TextBox txtSurgicalInput;
        private System.Windows.Forms.Label lblRehabCharges;
        private System.Windows.Forms.TextBox txtRehabInput;
        private System.Windows.Forms.Label lblLabFees;
        private System.Windows.Forms.TextBox txtLabInput;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtDateInput;
        private System.Windows.Forms.TextBox txtTimeInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

