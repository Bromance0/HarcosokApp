namespace HarcosokApplication
{
    partial class karakterLetrehozasForm
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
            this.letrehozButton = new System.Windows.Forms.Button();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.torlesButton = new System.Windows.Forms.Button();
            this.modositButton = new System.Windows.Forms.Button();
            this.harcosokNeveTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.harcosoGroupBox = new System.Windows.Forms.GroupBox();
            this.kepessegGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.kepessegLeirasTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.harcosoGroupBox.SuspendLayout();
            this.kepessegGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // letrehozButton
            // 
            this.letrehozButton.Location = new System.Drawing.Point(224, 30);
            this.letrehozButton.Name = "letrehozButton";
            this.letrehozButton.Size = new System.Drawing.Size(90, 23);
            this.letrehozButton.TabIndex = 0;
            this.letrehozButton.Text = "Létrehoz";
            this.letrehozButton.UseVisualStyleBackColor = true;
            this.letrehozButton.Click += new System.EventHandler(this.letrehozButton_Click);
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Location = new System.Drawing.Point(19, 108);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(94, 24);
            this.hozzaadButton.TabIndex = 1;
            this.hozzaadButton.Text = "Hozzáad";
            this.hozzaadButton.UseVisualStyleBackColor = true;
            this.hozzaadButton.Click += new System.EventHandler(this.hozzaadButton_Click);
            // 
            // torlesButton
            // 
            this.torlesButton.Location = new System.Drawing.Point(220, 511);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(129, 34);
            this.torlesButton.TabIndex = 3;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = true;
            this.torlesButton.Click += new System.EventHandler(this.torlesButton_Click);
            // 
            // modositButton
            // 
            this.modositButton.Location = new System.Drawing.Point(479, 468);
            this.modositButton.Name = "modositButton";
            this.modositButton.Size = new System.Drawing.Size(93, 37);
            this.modositButton.TabIndex = 4;
            this.modositButton.Text = "Módosítás";
            this.modositButton.UseVisualStyleBackColor = true;
            this.modositButton.Click += new System.EventHandler(this.modositButton_Click);
            // 
            // harcosokNeveTextBox
            // 
            this.harcosokNeveTextBox.Location = new System.Drawing.Point(82, 32);
            this.harcosokNeveTextBox.Name = "harcosokNeveTextBox";
            this.harcosokNeveTextBox.Size = new System.Drawing.Size(136, 20);
            this.harcosokNeveTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Név:";
            // 
            // harcosoGroupBox
            // 
            this.harcosoGroupBox.Controls.Add(this.label1);
            this.harcosoGroupBox.Controls.Add(this.harcosokNeveTextBox);
            this.harcosoGroupBox.Controls.Add(this.letrehozButton);
            this.harcosoGroupBox.Location = new System.Drawing.Point(35, 26);
            this.harcosoGroupBox.Name = "harcosoGroupBox";
            this.harcosoGroupBox.Size = new System.Drawing.Size(337, 73);
            this.harcosoGroupBox.TabIndex = 7;
            this.harcosoGroupBox.TabStop = false;
            this.harcosoGroupBox.Text = "Harcos létrehozása";
            // 
            // kepessegGroupBox
            // 
            this.kepessegGroupBox.Controls.Add(this.label4);
            this.kepessegGroupBox.Controls.Add(this.leirasTextBox);
            this.kepessegGroupBox.Controls.Add(this.kepessegNeveTextBox);
            this.kepessegGroupBox.Controls.Add(this.label3);
            this.kepessegGroupBox.Controls.Add(this.label2);
            this.kepessegGroupBox.Controls.Add(this.hasznaloComboBox);
            this.kepessegGroupBox.Controls.Add(this.hozzaadButton);
            this.kepessegGroupBox.Location = new System.Drawing.Point(35, 105);
            this.kepessegGroupBox.Name = "kepessegGroupBox";
            this.kepessegGroupBox.Size = new System.Drawing.Size(674, 146);
            this.kepessegGroupBox.TabIndex = 8;
            this.kepessegGroupBox.TabStop = false;
            this.kepessegGroupBox.Text = "Képesség hozzáadása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Leírás:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(390, 32);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(263, 63);
            this.leirasTextBox.TabIndex = 6;
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(82, 75);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(211, 20);
            this.kepessegNeveTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Használó:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(82, 32);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(211, 21);
            this.hasznaloComboBox.TabIndex = 2;
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Items.AddRange(new object[] {
            "harcosokListBox"});
            this.harcosokListBox.Location = new System.Drawing.Point(35, 280);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(160, 225);
            this.harcosokListBox.TabIndex = 9;
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Items.AddRange(new object[] {
            "képességekListBox"});
            this.kepessegekListBox.Location = new System.Drawing.Point(201, 280);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(160, 225);
            this.kepessegekListBox.TabIndex = 10;
            this.kepessegekListBox.SelectedIndexChanged += new System.EventHandler(this.kepessegekListBox_SelectedIndexChanged);
            // 
            // kepessegLeirasTextBox
            // 
            this.kepessegLeirasTextBox.Location = new System.Drawing.Point(367, 280);
            this.kepessegLeirasTextBox.Multiline = true;
            this.kepessegLeirasTextBox.Name = "kepessegLeirasTextBox";
            this.kepessegLeirasTextBox.Size = new System.Drawing.Size(321, 180);
            this.kepessegLeirasTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harcosok";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Képességei";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Képesség leírás";
            // 
            // karakterLetrehozasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 579);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kepessegLeirasTextBox);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.kepessegGroupBox);
            this.Controls.Add(this.harcosoGroupBox);
            this.Controls.Add(this.modositButton);
            this.Controls.Add(this.torlesButton);
            this.Name = "karakterLetrehozasForm";
            this.Text = "Form1";
            this.harcosoGroupBox.ResumeLayout(false);
            this.harcosoGroupBox.PerformLayout();
            this.kepessegGroupBox.ResumeLayout(false);
            this.kepessegGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button letrehozButton;
        private System.Windows.Forms.Button hozzaadButton;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.Button modositButton;
        private System.Windows.Forms.TextBox harcosokNeveTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox harcosoGroupBox;
        private System.Windows.Forms.GroupBox kepessegGroupBox;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.TextBox kepessegLeirasTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

