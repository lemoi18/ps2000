namespace GUI
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
            this.Voltage_Textbox = new System.Windows.Forms.TextBox();
            this.Update_Voltage = new System.Windows.Forms.Button();
            this.Update_Current = new System.Windows.Forms.Button();
            this.Current_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Device_text = new System.Windows.Forms.TextBox();
            this.Serial_Text = new System.Windows.Forms.TextBox();
            this.Art_Text = new System.Windows.Forms.TextBox();
            this.Manu_Text = new System.Windows.Forms.TextBox();
            this.Software_Text = new System.Windows.Forms.TextBox();
            this.Voltage_Text = new System.Windows.Forms.TextBox();
            this.NomVolt_Text = new System.Windows.Forms.TextBox();
            this.NominalCurr_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Voltage_Textbox
            // 
            this.Voltage_Textbox.Location = new System.Drawing.Point(220, 216);
            this.Voltage_Textbox.Name = "Voltage_Textbox";
            this.Voltage_Textbox.Size = new System.Drawing.Size(100, 23);
            this.Voltage_Textbox.TabIndex = 0;
            // 
            // Update_Voltage
            // 
            this.Update_Voltage.Location = new System.Drawing.Point(102, 198);
            this.Update_Voltage.Name = "Update_Voltage";
            this.Update_Voltage.Size = new System.Drawing.Size(112, 57);
            this.Update_Voltage.TabIndex = 1;
            this.Update_Voltage.Text = "Update Voltage";
            this.Update_Voltage.UseVisualStyleBackColor = true;
            this.Update_Voltage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Current
            // 
            this.Update_Current.Location = new System.Drawing.Point(102, 353);
            this.Update_Current.Name = "Update_Current";
            this.Update_Current.Size = new System.Drawing.Size(112, 57);
            this.Update_Current.TabIndex = 2;
            this.Update_Current.Text = "Update Current";
            this.Update_Current.UseVisualStyleBackColor = true;
            // 
            // Current_TextBox
            // 
            this.Current_TextBox.Location = new System.Drawing.Point(220, 371);
            this.Current_TextBox.Name = "Current_TextBox";
            this.Current_TextBox.Size = new System.Drawing.Size(100, 23);
            this.Current_TextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remote Controll";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Device_text
            // 
            this.Device_text.Location = new System.Drawing.Point(580, 37);
            this.Device_text.Name = "Device_text";
            this.Device_text.Size = new System.Drawing.Size(100, 23);
            this.Device_text.TabIndex = 5;
            // 
            // Serial_Text
            // 
            this.Serial_Text.Location = new System.Drawing.Point(580, 57);
            this.Serial_Text.Name = "Serial_Text";
            this.Serial_Text.Size = new System.Drawing.Size(100, 23);
            this.Serial_Text.TabIndex = 6;
            this.Serial_Text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Art_Text
            // 
            this.Art_Text.Location = new System.Drawing.Point(580, 77);
            this.Art_Text.Name = "Art_Text";
            this.Art_Text.Size = new System.Drawing.Size(100, 23);
            this.Art_Text.TabIndex = 7;
            // 
            // Manu_Text
            // 
            this.Manu_Text.Location = new System.Drawing.Point(580, 97);
            this.Manu_Text.Name = "Manu_Text";
            this.Manu_Text.Size = new System.Drawing.Size(100, 23);
            this.Manu_Text.TabIndex = 8;
            this.Manu_Text.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Software_Text
            // 
            this.Software_Text.Location = new System.Drawing.Point(580, 116);
            this.Software_Text.Name = "Software_Text";
            this.Software_Text.Size = new System.Drawing.Size(100, 23);
            this.Software_Text.TabIndex = 9;
            // 
            // Voltage_Text
            // 
            this.Voltage_Text.Location = new System.Drawing.Point(580, 252);
            this.Voltage_Text.Name = "Voltage_Text";
            this.Voltage_Text.Size = new System.Drawing.Size(100, 23);
            this.Voltage_Text.TabIndex = 10;
            // 
            // NomVolt_Text
            // 
            this.NomVolt_Text.Location = new System.Drawing.Point(580, 273);
            this.NomVolt_Text.Name = "NomVolt_Text";
            this.NomVolt_Text.Size = new System.Drawing.Size(100, 23);
            this.NomVolt_Text.TabIndex = 11;
            // 
            // NominalCurr_Text
            // 
            this.NominalCurr_Text.Location = new System.Drawing.Point(580, 291);
            this.NominalCurr_Text.Name = "NominalCurr_Text";
            this.NominalCurr_Text.Size = new System.Drawing.Size(100, 23);
            this.NominalCurr_Text.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Device Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Serial Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Art nr:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Manufacturer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Software Version";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Voltage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nominal Voltage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nominal Current";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NominalCurr_Text);
            this.Controls.Add(this.NomVolt_Text);
            this.Controls.Add(this.Voltage_Text);
            this.Controls.Add(this.Software_Text);
            this.Controls.Add(this.Manu_Text);
            this.Controls.Add(this.Art_Text);
            this.Controls.Add(this.Serial_Text);
            this.Controls.Add(this.Device_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Current_TextBox);
            this.Controls.Add(this.Update_Current);
            this.Controls.Add(this.Update_Voltage);
            this.Controls.Add(this.Voltage_Textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Voltage_Textbox;
        private Button Update_Voltage;
        private Button Update_Current;
        private TextBox Current_TextBox;
        private Button button1;
        private TextBox Device_text;
        private TextBox Serial_Text;
        private TextBox Art_Text;
        private TextBox Manu_Text;
        private TextBox Software_Text;
        private TextBox Voltage_Text;
        private TextBox NomVolt_Text;
        private TextBox NominalCurr_Text;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}