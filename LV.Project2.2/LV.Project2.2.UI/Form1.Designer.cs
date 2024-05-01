namespace LV.Project2._2.UI
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
            this.lblRyan = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRyan
            // 
            this.lblRyan.AutoSize = true;
            this.lblRyan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRyan.ForeColor = System.Drawing.Color.Green;
            this.lblRyan.Location = new System.Drawing.Point(141, 109);
            this.lblRyan.Name = "lblRyan";
            this.lblRyan.Size = new System.Drawing.Size(139, 21);
            this.lblRyan.TabIndex = 0;
            this.lblRyan.Text = "Ryan is the coolest";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblClass.Location = new System.Drawing.Point(141, 148);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(173, 32);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "C# is awesome";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(87, 262);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(93, 36);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(214, 262);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 35);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(368, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 388);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblRyan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRyan;
        private Label lblClass;
        private Button btnChange;
        private Button btnReset;
        private Button btnExit;
    }
}