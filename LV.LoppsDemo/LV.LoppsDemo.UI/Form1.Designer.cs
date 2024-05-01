namespace LV.LoppsDemo.UI
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
            this.lstReps = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.nudReps = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudReps)).BeginInit();
            this.SuspendLayout();
            // 
            // lstReps
            // 
            this.lstReps.FormattingEnabled = true;
            this.lstReps.Location = new System.Drawing.Point(82, 93);
            this.lstReps.Name = "lstReps";
            this.lstReps.Size = new System.Drawing.Size(182, 173);
            this.lstReps.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(372, 105);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(133, 31);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // nudReps
            // 
            this.nudReps.Location = new System.Drawing.Point(372, 168);
            this.nudReps.Name = "nudReps";
            this.nudReps.Size = new System.Drawing.Size(133, 20);
            this.nudReps.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudReps);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstReps);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudReps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReps;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.NumericUpDown nudReps;
    }
}

