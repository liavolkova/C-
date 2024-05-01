namespace LV.Population.UI
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
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblIncrease = new System.Windows.Forms.Label();
            this.txtIncrease = new System.Windows.Forms.TextBox();
            this.txtDecrease = new System.Windows.Forms.TextBox();
            this.lblDecrease = new System.Windows.Forms.Label();
            this.grpChange = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(108, 75);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(112, 112);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(205, 22);
            this.txtCity.TabIndex = 1;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(400, 75);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 16);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Location = new System.Drawing.Point(403, 112);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(205, 22);
            this.txtState.TabIndex = 2;
            this.txtState.TextChanged += new System.EventHandler(this.TxtAllInput_TextChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(108, 192);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(101, 16);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start Population";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(112, 229);
            this.txtStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(205, 22);
            this.txtStart.TabIndex = 3;
            this.txtStart.TextChanged += new System.EventHandler(this.TxtAllInput_TextChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(108, 293);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(98, 16);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "End Population";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(112, 330);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(205, 22);
            this.txtEnd.TabIndex = 4;
            this.txtEnd.TextChanged += new System.EventHandler(this.TxtAllInput_TextChanged);
            // 
            // lblIncrease
            // 
            this.lblIncrease.AutoSize = true;
            this.lblIncrease.Location = new System.Drawing.Point(16, 28);
            this.lblIncrease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncrease.Name = "lblIncrease";
            this.lblIncrease.Size = new System.Drawing.Size(108, 16);
            this.lblIncrease.TabIndex = 2;
            this.lblIncrease.Text = "Percent Increase";
            // 
            // txtIncrease
            // 
            this.txtIncrease.Location = new System.Drawing.Point(20, 66);
            this.txtIncrease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncrease.Name = "txtIncrease";
            this.txtIncrease.ReadOnly = true;
            this.txtIncrease.Size = new System.Drawing.Size(205, 22);
            this.txtIncrease.TabIndex = 5;
            // 
            // txtDecrease
            // 
            this.txtDecrease.Location = new System.Drawing.Point(15, 167);
            this.txtDecrease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDecrease.Name = "txtDecrease";
            this.txtDecrease.ReadOnly = true;
            this.txtDecrease.Size = new System.Drawing.Size(205, 22);
            this.txtDecrease.TabIndex = 6;
            // 
            // lblDecrease
            // 
            this.lblDecrease.AutoSize = true;
            this.lblDecrease.Location = new System.Drawing.Point(16, 130);
            this.lblDecrease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecrease.Name = "lblDecrease";
            this.lblDecrease.Size = new System.Drawing.Size(116, 16);
            this.lblDecrease.TabIndex = 2;
            this.lblDecrease.Text = "Percent Decrease";
            // 
            // grpChange
            // 
            this.grpChange.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpChange.Controls.Add(this.lblDecrease);
            this.grpChange.Controls.Add(this.lblIncrease);
            this.grpChange.Controls.Add(this.txtDecrease);
            this.grpChange.Controls.Add(this.txtIncrease);
            this.grpChange.Location = new System.Drawing.Point(433, 162);
            this.grpChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpChange.Name = "grpChange";
            this.grpChange.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpChange.Size = new System.Drawing.Size(277, 239);
            this.grpChange.TabIndex = 5;
            this.grpChange.TabStop = false;
            this.grpChange.Text = "Percent Change";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(121, 453);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(129, 36);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(272, 453);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(420, 453);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 546);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpChange);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Compare Population";
            this.grpChange.ResumeLayout(false);
            this.grpChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblIncrease;
        private System.Windows.Forms.TextBox txtIncrease;
        private System.Windows.Forms.TextBox txtDecrease;
        private System.Windows.Forms.Label lblDecrease;
        private System.Windows.Forms.GroupBox grpChange;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

