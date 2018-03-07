namespace Lab_01___Average_Units
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDayUnits = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(67, 13);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(31, 13);
            this.lblUnits.TabIndex = 0;
            this.lblUnits.Text = "&Units";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(104, 10);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(42, 20);
            this.txtUnits.TabIndex = 1;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(152, 13);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(35, 13);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Day 1";
            // 
            // lblDayUnits
            // 
            this.lblDayUnits.BackColor = System.Drawing.SystemColors.Window;
            this.lblDayUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDayUnits.Location = new System.Drawing.Point(67, 33);
            this.lblDayUnits.Name = "lblDayUnits";
            this.lblDayUnits.Size = new System.Drawing.Size(117, 94);
            this.lblDayUnits.TabIndex = 3;
            this.lblDayUnits.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnReset.Location = new System.Drawing.Point(88, 165);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.ForeColor = System.Drawing.Color.Green;
            this.btnEnter.Location = new System.Drawing.Point(7, 165);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(169, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(44, 131);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(163, 31);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "label4";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(251, 195);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDayUnits);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.lblUnits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Average Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDayUnits;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutput;
    }
}

