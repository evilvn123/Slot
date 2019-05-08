namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblRequired = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(572, 13);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(35, 13);
            this.lblRequired.TabIndex = 14;
            this.lblRequired.Text = "label1";
            this.lblRequired.Visible = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(1, 1);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 15;
            this.btnSetting.Text = "<<Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pnlLabel
            // 
            this.pnlLabel.AutoSize = true;
            this.pnlLabel.Location = new System.Drawing.Point(12, 42);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(230, 245);
            this.pnlLabel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(255, 301);
            this.Controls.Add(this.pnlLabel);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lblRequired);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel pnlLabel;
    }
}

