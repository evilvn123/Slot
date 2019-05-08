namespace WindowsFormsApplication1
{
    partial class Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.cbxBaud = new System.Windows.Forms.ComboBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbxColumn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRow = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comport:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate:";
            // 
            // cbxPort
            // 
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(184, 54);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(121, 21);
            this.cbxPort.TabIndex = 2;
            this.cbxPort.DropDown += new System.EventHandler(this.cbxPort_DropDown);
            // 
            // cbxBaud
            // 
            this.cbxBaud.FormattingEnabled = true;
            this.cbxBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbxBaud.Location = new System.Drawing.Point(184, 95);
            this.cbxBaud.Name = "cbxBaud";
            this.cbxBaud.Size = new System.Drawing.Size(121, 21);
            this.cbxBaud.TabIndex = 3;
            this.cbxBaud.Text = "9600";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(70, 208);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan Port";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(215, 208);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Column:";
            // 
            // cbxColumn
            // 
            this.cbxColumn.FormattingEnabled = true;
            this.cbxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbxColumn.Location = new System.Drawing.Point(184, 130);
            this.cbxColumn.Name = "cbxColumn";
            this.cbxColumn.Size = new System.Drawing.Size(121, 21);
            this.cbxColumn.TabIndex = 7;
            this.cbxColumn.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Row:";
            // 
            // cbxRow
            // 
            this.cbxRow.FormattingEnabled = true;
            this.cbxRow.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbxRow.Location = new System.Drawing.Point(184, 165);
            this.cbxRow.Name = "cbxRow";
            this.cbxRow.Size = new System.Drawing.Size(121, 21);
            this.cbxRow.TabIndex = 9;
            this.cbxRow.Text = "4";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 317);
            this.Controls.Add(this.cbxRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxColumn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.cbxBaud);
            this.Controls.Add(this.cbxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.ComboBox cbxBaud;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnStart;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRow;
    }
}