namespace Lab3b
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HairDresser = new System.Windows.Forms.GroupBox();
            this.Combo_HairDresser = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_Services = new System.Windows.Forms.ListBox();
            this.listBox_Items = new System.Windows.Forms.ListBox();
            this.listBox_Price = new System.Windows.Forms.ListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Total = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.HairDresser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HairDresser
            // 
            this.HairDresser.Controls.Add(this.Combo_HairDresser);
            this.HairDresser.Location = new System.Drawing.Point(12, 12);
            this.HairDresser.Name = "HairDresser";
            this.HairDresser.Size = new System.Drawing.Size(200, 100);
            this.HairDresser.TabIndex = 0;
            this.HairDresser.TabStop = false;
            this.HairDresser.Text = "Select a Hair Dresser";
            // 
            // Combo_HairDresser
            // 
            this.Combo_HairDresser.FormattingEnabled = true;
            this.Combo_HairDresser.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat ",
            "Ron ",
            "Sue ",
            "Laura "});
            this.Combo_HairDresser.Location = new System.Drawing.Point(7, 20);
            this.Combo_HairDresser.Name = "Combo_HairDresser";
            this.Combo_HairDresser.Size = new System.Drawing.Size(121, 21);
            this.Combo_HairDresser.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Services);
            this.groupBox1.Location = new System.Drawing.Point(239, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a service";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_Items);
            this.groupBox2.Location = new System.Drawing.Point(452, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Items";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_Price);
            this.groupBox3.Location = new System.Drawing.Point(685, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 208);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Price";
            // 
            // listBox_Services
            // 
            this.listBox_Services.FormattingEnabled = true;
            this.listBox_Services.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do "});
            this.listBox_Services.Location = new System.Drawing.Point(6, 13);
            this.listBox_Services.Name = "listBox_Services";
            this.listBox_Services.Size = new System.Drawing.Size(182, 134);
            this.listBox_Services.TabIndex = 0;
            this.listBox_Services.SelectedIndexChanged += new System.EventHandler(this.listBox_Services_SelectedIndexChanged);
            // 
            // listBox_Items
            // 
            this.listBox_Items.FormattingEnabled = true;
            this.listBox_Items.Location = new System.Drawing.Point(6, 13);
            this.listBox_Items.Name = "listBox_Items";
            this.listBox_Items.Size = new System.Drawing.Size(198, 134);
            this.listBox_Items.TabIndex = 0;
            // 
            // listBox_Price
            // 
            this.listBox_Price.FormattingEnabled = true;
            this.listBox_Price.Location = new System.Drawing.Point(6, 13);
            this.listBox_Price.Name = "listBox_Price";
            this.listBox_Price.Size = new System.Drawing.Size(105, 186);
            this.listBox_Price.TabIndex = 0;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(112, 296);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(113, 23);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Add Services";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Total
            // 
            this.button_Total.Location = new System.Drawing.Point(319, 296);
            this.button_Total.Name = "button_Total";
            this.button_Total.Size = new System.Drawing.Size(91, 23);
            this.button_Total.TabIndex = 5;
            this.button_Total.Text = "Caculate Total Price";
            this.button_Total.UseVisualStyleBackColor = true;
            this.button_Total.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(519, 296);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 6;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(691, 296);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Total
            // 
            this.textBox_Total.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox_Total.Location = new System.Drawing.Point(662, 247);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Total.Size = new System.Drawing.Size(100, 20);
            this.textBox_Total.TabIndex = 9;
            this.textBox_Total.TextChanged += new System.EventHandler(this.textBox_Total_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 362);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Total);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HairDresser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HairDresser.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox HairDresser;
        private System.Windows.Forms.ComboBox Combo_HairDresser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_Services;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_Items;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox_Price;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Total;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Total;
    }
}

