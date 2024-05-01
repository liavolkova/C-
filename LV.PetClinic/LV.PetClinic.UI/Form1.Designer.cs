namespace LV.PetClinic.UI
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
            this.chkVisit = new System.Windows.Forms.CheckBox();
            this.chkGrooming = new System.Windows.Forms.CheckBox();
            this.chkWash = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkAllergy = new System.Windows.Forms.CheckBox();
            this.chkTeeth = new System.Windows.Forms.CheckBox();
            this.chkEar = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.chkVax = new System.Windows.Forms.CheckBox();
            this.chkBrushing = new System.Windows.Forms.CheckBox();
            this.lblVisit = new System.Windows.Forms.Label();
            this.lblBrushing = new System.Windows.Forms.Label();
            this.lblGrooming = new System.Windows.Forms.Label();
            this.lblAllergy = new System.Windows.Forms.Label();
            this.lblWash = new System.Windows.Forms.Label();
            this.lblTeeth = new System.Windows.Forms.Label();
            this.lblVax = new System.Windows.Forms.Label();
            this.lblEar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkVisit
            // 
            this.chkVisit.AutoSize = true;
            this.chkVisit.BackColor = System.Drawing.SystemColors.Control;
            this.chkVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisit.Location = new System.Drawing.Point(94, 86);
            this.chkVisit.Name = "chkVisit";
            this.chkVisit.Size = new System.Drawing.Size(127, 29);
            this.chkVisit.TabIndex = 0;
            this.chkVisit.Text = "Office Visit";
            this.chkVisit.UseVisualStyleBackColor = false;
            this.chkVisit.CheckedChanged += new System.EventHandler(this.chkVisit_CheckedChanged);
            // 
            // chkGrooming
            // 
            this.chkGrooming.AutoSize = true;
            this.chkGrooming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGrooming.Location = new System.Drawing.Point(94, 156);
            this.chkGrooming.Name = "chkGrooming";
            this.chkGrooming.Size = new System.Drawing.Size(119, 29);
            this.chkGrooming.TabIndex = 1;
            this.chkGrooming.Text = "Grooming";
            this.chkGrooming.UseVisualStyleBackColor = true;
            this.chkGrooming.CheckedChanged += new System.EventHandler(this.chkGrooming_CheckedChanged);
            // 
            // chkWash
            // 
            this.chkWash.AutoSize = true;
            this.chkWash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWash.Location = new System.Drawing.Point(94, 190);
            this.chkWash.Name = "chkWash";
            this.chkWash.Size = new System.Drawing.Size(86, 29);
            this.chkWash.TabIndex = 2;
            this.chkWash.Text = "Wash";
            this.chkWash.UseVisualStyleBackColor = true;
            this.chkWash.CheckedChanged += new System.EventHandler(this.chkWash_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(92, 382);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(270, 386);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(124, 22);
            this.txtTotal.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(115, 437);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(306, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkAllergy
            // 
            this.chkAllergy.AutoSize = true;
            this.chkAllergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllergy.Location = new System.Drawing.Point(94, 225);
            this.chkAllergy.Name = "chkAllergy";
            this.chkAllergy.Size = new System.Drawing.Size(138, 29);
            this.chkAllergy.TabIndex = 2;
            this.chkAllergy.Text = "Allergy Test";
            this.chkAllergy.UseVisualStyleBackColor = true;
            this.chkAllergy.CheckedChanged += new System.EventHandler(this.chkAllergy_CheckedChanged);
            // 
            // chkTeeth
            // 
            this.chkTeeth.AutoSize = true;
            this.chkTeeth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTeeth.Location = new System.Drawing.Point(94, 260);
            this.chkTeeth.Name = "chkTeeth";
            this.chkTeeth.Size = new System.Drawing.Size(168, 29);
            this.chkTeeth.TabIndex = 2;
            this.chkTeeth.Text = "Teeth Cleaning";
            this.chkTeeth.UseVisualStyleBackColor = true;
            this.chkTeeth.CheckedChanged += new System.EventHandler(this.chkTeeth_CheckedChanged);
            // 
            // chkEar
            // 
            this.chkEar.AutoSize = true;
            this.chkEar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEar.Location = new System.Drawing.Point(94, 295);
            this.chkEar.Name = "chkEar";
            this.chkEar.Size = new System.Drawing.Size(147, 29);
            this.chkEar.TabIndex = 2;
            this.chkEar.Text = "Ear Cleaning";
            this.chkEar.UseVisualStyleBackColor = true;
            this.chkEar.CheckedChanged += new System.EventHandler(this.chkEar_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(94, 330);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(86, 29);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Wash";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // chkVax
            // 
            this.chkVax.AutoSize = true;
            this.chkVax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVax.Location = new System.Drawing.Point(94, 330);
            this.chkVax.Name = "chkVax";
            this.chkVax.Size = new System.Drawing.Size(141, 29);
            this.chkVax.TabIndex = 2;
            this.chkVax.Text = "Vaccintation";
            this.chkVax.UseVisualStyleBackColor = true;
            this.chkVax.CheckedChanged += new System.EventHandler(this.chkVax_CheckedChanged);
            // 
            // chkBrushing
            // 
            this.chkBrushing.AutoSize = true;
            this.chkBrushing.BackColor = System.Drawing.SystemColors.Control;
            this.chkBrushing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrushing.Location = new System.Drawing.Point(94, 121);
            this.chkBrushing.Name = "chkBrushing";
            this.chkBrushing.Size = new System.Drawing.Size(188, 29);
            this.chkBrushing.TabIndex = 0;
            this.chkBrushing.Text = "Whisker Brushing";
            this.chkBrushing.UseVisualStyleBackColor = false;
            this.chkBrushing.CheckedChanged += new System.EventHandler(this.chkBrushing_CheckedChanged);
            // 
            // lblVisit
            // 
            this.lblVisit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVisit.Location = new System.Drawing.Point(286, 86);
            this.lblVisit.Name = "lblVisit";
            this.lblVisit.Size = new System.Drawing.Size(84, 28);
            this.lblVisit.TabIndex = 6;
            this.lblVisit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBrushing
            // 
            this.lblBrushing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBrushing.Location = new System.Drawing.Point(286, 121);
            this.lblBrushing.Name = "lblBrushing";
            this.lblBrushing.Size = new System.Drawing.Size(84, 28);
            this.lblBrushing.TabIndex = 6;
            this.lblBrushing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrooming
            // 
            this.lblGrooming.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGrooming.Location = new System.Drawing.Point(286, 157);
            this.lblGrooming.Name = "lblGrooming";
            this.lblGrooming.Size = new System.Drawing.Size(84, 28);
            this.lblGrooming.TabIndex = 6;
            this.lblGrooming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAllergy
            // 
            this.lblAllergy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAllergy.Location = new System.Drawing.Point(286, 226);
            this.lblAllergy.Name = "lblAllergy";
            this.lblAllergy.Size = new System.Drawing.Size(84, 28);
            this.lblAllergy.TabIndex = 6;
            this.lblAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWash
            // 
            this.lblWash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWash.Location = new System.Drawing.Point(286, 191);
            this.lblWash.Name = "lblWash";
            this.lblWash.Size = new System.Drawing.Size(84, 28);
            this.lblWash.TabIndex = 6;
            this.lblWash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTeeth
            // 
            this.lblTeeth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTeeth.Location = new System.Drawing.Point(286, 261);
            this.lblTeeth.Name = "lblTeeth";
            this.lblTeeth.Size = new System.Drawing.Size(84, 28);
            this.lblTeeth.TabIndex = 6;
            this.lblTeeth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVax
            // 
            this.lblVax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVax.Location = new System.Drawing.Point(286, 331);
            this.lblVax.Name = "lblVax";
            this.lblVax.Size = new System.Drawing.Size(84, 28);
            this.lblVax.TabIndex = 6;
            this.lblVax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEar
            // 
            this.lblEar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEar.Location = new System.Drawing.Point(286, 296);
            this.lblEar.Name = "lblEar";
            this.lblEar.Size = new System.Drawing.Size(84, 28);
            this.lblEar.TabIndex = 6;
            this.lblEar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 500);
            this.Controls.Add(this.lblWash);
            this.Controls.Add(this.lblEar);
            this.Controls.Add(this.lblVax);
            this.Controls.Add(this.lblTeeth);
            this.Controls.Add(this.lblAllergy);
            this.Controls.Add(this.lblGrooming);
            this.Controls.Add(this.lblBrushing);
            this.Controls.Add(this.lblVisit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.chkVax);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.chkEar);
            this.Controls.Add(this.chkTeeth);
            this.Controls.Add(this.chkAllergy);
            this.Controls.Add(this.chkWash);
            this.Controls.Add(this.chkGrooming);
            this.Controls.Add(this.chkBrushing);
            this.Controls.Add(this.chkVisit);
            this.Name = "Form1";
            this.Text = "Lions, Tigers and Bears Pet Clinic ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkVisit;
        private System.Windows.Forms.CheckBox chkGrooming;
        private System.Windows.Forms.CheckBox chkWash;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkAllergy;
        private System.Windows.Forms.CheckBox chkTeeth;
        private System.Windows.Forms.CheckBox chkEar;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox chkVax;
        private System.Windows.Forms.CheckBox chkBrushing;
        private System.Windows.Forms.Label lblVisit;
        private System.Windows.Forms.Label lblBrushing;
        private System.Windows.Forms.Label lblGrooming;
        private System.Windows.Forms.Label lblAllergy;
        private System.Windows.Forms.Label lblWash;
        private System.Windows.Forms.Label lblTeeth;
        private System.Windows.Forms.Label lblVax;
        private System.Windows.Forms.Label lblEar;
    }
}

