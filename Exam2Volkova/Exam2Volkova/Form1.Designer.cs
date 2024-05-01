namespace Exam2Volkova
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
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(72, 58);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(213, 13);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "Enter the number of books that are overdue";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(72, 110);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(167, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Enter the number of days overdue";
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(324, 55);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(156, 20);
            this.txtBooks.TabIndex = 0;
            this.txtBooks.TextChanged += new System.EventHandler(this.txtBooks_TextChanged);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(324, 103);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(156, 20);
            this.txtDays.TabIndex = 1;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(76, 170);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(126, 29);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(217, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 29);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(354, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.ForeColor = System.Drawing.Color.Brown;
            this.lblFine.Location = new System.Drawing.Point(99, 236);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(44, 20);
            this.lblFine.TabIndex = 0;
            this.lblFine.Text = "Fine";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(217, 237);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(151, 20);
            this.txtFine.TabIndex = 5;
            this.txtFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 317);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtBooks);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtFine;
    }
}

