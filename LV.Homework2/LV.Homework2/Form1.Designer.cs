namespace LV.Homework2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWI = new System.Windows.Forms.Button();
            this.btnMI = new System.Windows.Forms.Button();
            this.btnMN = new System.Windows.Forms.Button();
            this.btnIowa = new System.Windows.Forms.Button();
            this.btnIL = new System.Windows.Forms.Button();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblIs = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWI
            // 
            this.btnWI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWI.ForeColor = System.Drawing.Color.Green;
            this.btnWI.Location = new System.Drawing.Point(65, 94);
            this.btnWI.Name = "btnWI";
            this.btnWI.Size = new System.Drawing.Size(130, 33);
            this.btnWI.TabIndex = 0;
            this.btnWI.Text = "Wisconsin";
            this.btnWI.UseVisualStyleBackColor = true;
            this.btnWI.Click += new System.EventHandler(this.btnWI_Click);
            // 
            // btnMI
            // 
            this.btnMI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMI.ForeColor = System.Drawing.Color.Green;
            this.btnMI.Location = new System.Drawing.Point(65, 133);
            this.btnMI.Name = "btnMI";
            this.btnMI.Size = new System.Drawing.Size(130, 33);
            this.btnMI.TabIndex = 1;
            this.btnMI.Text = "Michigan";
            this.btnMI.UseVisualStyleBackColor = true;
            this.btnMI.Click += new System.EventHandler(this.btnMI_Click);
            // 
            // btnMN
            // 
            this.btnMN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMN.ForeColor = System.Drawing.Color.Green;
            this.btnMN.Location = new System.Drawing.Point(66, 172);
            this.btnMN.Name = "btnMN";
            this.btnMN.Size = new System.Drawing.Size(129, 31);
            this.btnMN.TabIndex = 2;
            this.btnMN.Text = "Minnesota";
            this.btnMN.UseVisualStyleBackColor = true;
            this.btnMN.Click += new System.EventHandler(this.btnMN_Click);
            // 
            // btnIowa
            // 
            this.btnIowa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIowa.ForeColor = System.Drawing.Color.Green;
            this.btnIowa.Location = new System.Drawing.Point(65, 209);
            this.btnIowa.Name = "btnIowa";
            this.btnIowa.Size = new System.Drawing.Size(129, 32);
            this.btnIowa.TabIndex = 3;
            this.btnIowa.Text = "Iowa";
            this.btnIowa.UseVisualStyleBackColor = true;
            this.btnIowa.Click += new System.EventHandler(this.btnIowa_Click);
            // 
            // btnIL
            // 
            this.btnIL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIL.ForeColor = System.Drawing.Color.Green;
            this.btnIL.Location = new System.Drawing.Point(65, 247);
            this.btnIL.Name = "btnIL";
            this.btnIL.Size = new System.Drawing.Size(129, 33);
            this.btnIL.TabIndex = 4;
            this.btnIL.Text = "Illimois";
            this.btnIL.UseVisualStyleBackColor = true;
            this.btnIL.Click += new System.EventHandler(this.btnIL_Click);
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(282, 133);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.ReadOnly = true;
            this.txtCapital.Size = new System.Drawing.Size(216, 23);
            this.txtCapital.TabIndex = 5;
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCapital.Location = new System.Drawing.Point(262, 94);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(102, 21);
            this.lblCapital.TabIndex = 6;
            this.lblCapital.Text = "The capital of";
            // 
            // lblIs
            // 
            this.lblIs.AutoSize = true;
            this.lblIs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIs.Location = new System.Drawing.Point(262, 188);
            this.lblIs.Name = "lblIs";
            this.lblIs.Size = new System.Drawing.Size(21, 21);
            this.lblIs.TabIndex = 7;
            this.lblIs.Text = "is";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(282, 217);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(216, 23);
            this.txtCity.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(273, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(412, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 29);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 379);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblIs);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.btnIL);
            this.Controls.Add(this.btnIowa);
            this.Controls.Add(this.btnMN);
            this.Controls.Add(this.btnMI);
            this.Controls.Add(this.btnWI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnWI;
        private Button btnMI;
        private Button btnMN;
        private Button btnIowa;
        private Button btnIL;
        private TextBox txtCapital;
        private Label lblCapital;
        private Label lblIs;
        private TextBox txtCity;
        private Button btnClear;
        private Button btnExit;
    }
}