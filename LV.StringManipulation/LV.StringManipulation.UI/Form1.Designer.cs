namespace LV.StringManipulation.UI
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
            this.lblTrim = new System.Windows.Forms.Label();
            this.lblBlank = new System.Windows.Forms.Label();
            this.lblContains = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtTrim = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.txtSubstring = new System.Windows.Forms.TextBox();
            this.lblExercise = new System.Windows.Forms.Label();
            this.txtExercise = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrim.Location = new System.Drawing.Point(118, 79);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(38, 18);
            this.lblTrim.TabIndex = 0;
            this.lblTrim.Text = "Trim";
            // 
            // lblBlank
            // 
            this.lblBlank.AutoSize = true;
            this.lblBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlank.Location = new System.Drawing.Point(118, 108);
            this.lblBlank.Name = "lblBlank";
            this.lblBlank.Size = new System.Drawing.Size(52, 18);
            this.lblBlank.TabIndex = 0;
            this.lblBlank.Text = "Length";
            // 
            // lblContains
            // 
            this.lblContains.AutoSize = true;
            this.lblContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContains.Location = new System.Drawing.Point(118, 137);
            this.lblContains.Name = "lblContains";
            this.lblContains.Size = new System.Drawing.Size(67, 18);
            this.lblContains.TabIndex = 0;
            this.lblContains.Text = "Contains";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.Location = new System.Drawing.Point(118, 166);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(66, 18);
            this.lblUpper.TabIndex = 0;
            this.lblUpper.Text = "ToUpper";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.Location = new System.Drawing.Point(118, 195);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(67, 18);
            this.lblLower.TabIndex = 0;
            this.lblLower.Text = "ToLower";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(121, 39);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(215, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtTrim
            // 
            this.txtTrim.Location = new System.Drawing.Point(253, 79);
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(207, 20);
            this.txtTrim.TabIndex = 2;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(253, 107);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(207, 20);
            this.txtLength.TabIndex = 2;
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(253, 135);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(207, 20);
            this.txtContains.TabIndex = 2;
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(253, 163);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(207, 20);
            this.txtUpper.TabIndex = 2;
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(253, 191);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(207, 20);
            this.txtLower.TabIndex = 2;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(118, 221);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(58, 18);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "IndexOf";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(253, 217);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(207, 20);
            this.txtIndex.TabIndex = 2;
            // 
            // lblSubstring
            // 
            this.lblSubstring.AutoSize = true;
            this.lblSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubstring.Location = new System.Drawing.Point(118, 247);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(70, 18);
            this.lblSubstring.TabIndex = 0;
            this.lblSubstring.Text = "Substring";
            // 
            // txtSubstring
            // 
            this.txtSubstring.Location = new System.Drawing.Point(253, 243);
            this.txtSubstring.Name = "txtSubstring";
            this.txtSubstring.Size = new System.Drawing.Size(207, 20);
            this.txtSubstring.TabIndex = 2;
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercise.Location = new System.Drawing.Point(118, 273);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(65, 18);
            this.lblExercise.TabIndex = 0;
            this.lblExercise.Text = "Exercise";
            // 
            // txtExercise
            // 
            this.txtExercise.Location = new System.Drawing.Point(253, 269);
            this.txtExercise.Name = "txtExercise";
            this.txtExercise.Size = new System.Drawing.Size(207, 20);
            this.txtExercise.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 421);
            this.Controls.Add(this.txtExercise);
            this.Controls.Add(this.txtSubstring);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.txtContains);
            this.Controls.Add(this.lblExercise);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.txtTrim);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.lblContains);
            this.Controls.Add(this.lblBlank);
            this.Controls.Add(this.lblTrim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Label lblBlank;
        private System.Windows.Forms.Label lblContains;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtTrim;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtContains;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.TextBox txtSubstring;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.TextBox txtExercise;
    }
}

