namespace MainMenu2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SM_txt = new System.Windows.Forms.TextBox();
            this.CO2_txt = new System.Windows.Forms.TextBox();
            this.Humidity_txt = new System.Windows.Forms.TextBox();
            this.Temperature_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FormTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LED_chk = new System.Windows.Forms.CheckBox();
            this.disable_chk = new System.Windows.Forms.CheckBox();
            this.DesiredMaxHumid_txt = new System.Windows.Forms.TextBox();
            this.DesiredMinHumid_txt = new System.Windows.Forms.TextBox();
            this.DesiredMinCO2_txt = new System.Windows.Forms.TextBox();
            this.DesiredMaxCO2_txt = new System.Windows.Forms.TextBox();
            this.DesiredTemp_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Temperature_lb = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Receive1_txt = new System.Windows.Forms.RichTextBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Receive2_txt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MessageId_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MessageId_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SM_txt);
            this.groupBox1.Controls.Add(this.CO2_txt);
            this.groupBox1.Controls.Add(this.Humidity_txt);
            this.groupBox1.Controls.Add(this.Temperature_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reported Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soil Moisture";
            // 
            // SM_txt
            // 
            this.SM_txt.Location = new System.Drawing.Point(115, 200);
            this.SM_txt.Name = "SM_txt";
            this.SM_txt.ReadOnly = true;
            this.SM_txt.Size = new System.Drawing.Size(167, 27);
            this.SM_txt.TabIndex = 4;
            // 
            // CO2_txt
            // 
            this.CO2_txt.Location = new System.Drawing.Point(115, 159);
            this.CO2_txt.Name = "CO2_txt";
            this.CO2_txt.ReadOnly = true;
            this.CO2_txt.Size = new System.Drawing.Size(167, 27);
            this.CO2_txt.TabIndex = 4;
            // 
            // Humidity_txt
            // 
            this.Humidity_txt.Location = new System.Drawing.Point(115, 118);
            this.Humidity_txt.Name = "Humidity_txt";
            this.Humidity_txt.ReadOnly = true;
            this.Humidity_txt.Size = new System.Drawing.Size(167, 27);
            this.Humidity_txt.TabIndex = 6;
            // 
            // Temperature_txt
            // 
            this.Temperature_txt.Location = new System.Drawing.Point(115, 77);
            this.Temperature_txt.Name = "Temperature_txt";
            this.Temperature_txt.ReadOnly = true;
            this.Temperature_txt.Size = new System.Drawing.Size(167, 27);
            this.Temperature_txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Humidity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CO2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperature";
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormTitle.Location = new System.Drawing.Point(12, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(274, 40);
            this.FormTitle.TabIndex = 1;
            this.FormTitle.Text = "Laborious Forester";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.LED_chk);
            this.groupBox2.Controls.Add(this.disable_chk);
            this.groupBox2.Controls.Add(this.DesiredMaxHumid_txt);
            this.groupBox2.Controls.Add(this.DesiredMinHumid_txt);
            this.groupBox2.Controls.Add(this.DesiredMinCO2_txt);
            this.groupBox2.Controls.Add(this.DesiredMaxCO2_txt);
            this.groupBox2.Controls.Add(this.DesiredTemp_txt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Temperature_lb);
            this.groupBox2.Location = new System.Drawing.Point(19, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 315);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desired Data";
            // 
            // LED_chk
            // 
            this.LED_chk.AutoSize = true;
            this.LED_chk.Location = new System.Drawing.Point(171, 222);
            this.LED_chk.Name = "LED_chk";
            this.LED_chk.Size = new System.Drawing.Size(111, 24);
            this.LED_chk.TabIndex = 4;
            this.LED_chk.Text = "Turn on LED";
            this.LED_chk.UseVisualStyleBackColor = true;
            // 
            // disable_chk
            // 
            this.disable_chk.AutoSize = true;
            this.disable_chk.Location = new System.Drawing.Point(11, 222);
            this.disable_chk.Name = "disable_chk";
            this.disable_chk.Size = new System.Drawing.Size(130, 24);
            this.disable_chk.TabIndex = 10;
            this.disable_chk.Text = "Disable system";
            this.disable_chk.UseVisualStyleBackColor = true;
            // 
            // DesiredMaxHumid_txt
            // 
            this.DesiredMaxHumid_txt.Location = new System.Drawing.Point(115, 178);
            this.DesiredMaxHumid_txt.Name = "DesiredMaxHumid_txt";
            this.DesiredMaxHumid_txt.Size = new System.Drawing.Size(167, 27);
            this.DesiredMaxHumid_txt.TabIndex = 9;
            // 
            // DesiredMinHumid_txt
            // 
            this.DesiredMinHumid_txt.Location = new System.Drawing.Point(115, 142);
            this.DesiredMinHumid_txt.Name = "DesiredMinHumid_txt";
            this.DesiredMinHumid_txt.Size = new System.Drawing.Size(167, 27);
            this.DesiredMinHumid_txt.TabIndex = 8;
            // 
            // DesiredMinCO2_txt
            // 
            this.DesiredMinCO2_txt.Location = new System.Drawing.Point(115, 106);
            this.DesiredMinCO2_txt.Name = "DesiredMinCO2_txt";
            this.DesiredMinCO2_txt.Size = new System.Drawing.Size(167, 27);
            this.DesiredMinCO2_txt.TabIndex = 7;
            // 
            // DesiredMaxCO2_txt
            // 
            this.DesiredMaxCO2_txt.Location = new System.Drawing.Point(115, 70);
            this.DesiredMaxCO2_txt.Name = "DesiredMaxCO2_txt";
            this.DesiredMaxCO2_txt.Size = new System.Drawing.Size(167, 27);
            this.DesiredMaxCO2_txt.TabIndex = 6;
            // 
            // DesiredTemp_txt
            // 
            this.DesiredTemp_txt.Location = new System.Drawing.Point(115, 34);
            this.DesiredTemp_txt.Name = "DesiredTemp_txt";
            this.DesiredTemp_txt.Size = new System.Drawing.Size(167, 27);
            this.DesiredTemp_txt.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Max Humidity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Min Humidity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Min CO2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Max CO2";
            // 
            // Temperature_lb
            // 
            this.Temperature_lb.AutoSize = true;
            this.Temperature_lb.Location = new System.Drawing.Point(6, 37);
            this.Temperature_lb.Name = "Temperature_lb";
            this.Temperature_lb.Size = new System.Drawing.Size(93, 20);
            this.Temperature_lb.TabIndex = 4;
            this.Temperature_lb.Text = "Temperature";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(916, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(85, 20);
            this.StatusLabel.Text = "StatusLabel";
            // 
            // Receive1_txt
            // 
            this.Receive1_txt.Location = new System.Drawing.Point(411, 62);
            this.Receive1_txt.Name = "Receive1_txt";
            this.Receive1_txt.Size = new System.Drawing.Size(477, 143);
            this.Receive1_txt.TabIndex = 5;
            this.Receive1_txt.Text = "";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(794, 593);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(94, 29);
            this.Cancel_btn.TabIndex = 6;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Receive2_txt
            // 
            this.Receive2_txt.Location = new System.Drawing.Point(411, 315);
            this.Receive2_txt.Name = "Receive2_txt";
            this.Receive2_txt.Size = new System.Drawing.Size(477, 143);
            this.Receive2_txt.TabIndex = 8;
            this.Receive2_txt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Message Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MessageId_txt
            // 
            this.MessageId_txt.Location = new System.Drawing.Point(115, 36);
            this.MessageId_txt.Name = "MessageId_txt";
            this.MessageId_txt.ReadOnly = true;
            this.MessageId_txt.Size = new System.Drawing.Size(167, 27);
            this.MessageId_txt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 682);
            this.Controls.Add(this.Receive2_txt);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Receive1_txt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private TextBox SM_txt;
        private TextBox CO2_txt;
        private TextBox Humidity_txt;
        private TextBox Temperature_txt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label FormTitle;
        private GroupBox groupBox2;
        private StatusStrip statusStrip1;
        private CheckBox LED_chk;
        private CheckBox disable_chk;
        private TextBox DesiredMaxHumid_txt;
        private TextBox DesiredMinHumid_txt;
        private TextBox DesiredMinCO2_txt;
        private TextBox DesiredMaxCO2_txt;
        private TextBox DesiredTemp_txt;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label Temperature_lb;
        private RichTextBox Receive1_txt;
        private Button Cancel_btn;
        private RichTextBox Receive2_txt;
        private ToolStripStatusLabel StatusLabel;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox MessageId_txt;
    }
}