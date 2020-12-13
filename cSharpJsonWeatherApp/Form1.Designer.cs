namespace cSharpJsonWeatherApp
{
    partial class WeatherApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displJsonDataCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countriesComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jsonWeatherRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readBtn);
            this.groupBox1.Controls.Add(this.displJsonDataCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.countriesComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // displJsonDataCheckBox
            // 
            this.displJsonDataCheckBox.AutoSize = true;
            this.displJsonDataCheckBox.Checked = true;
            this.displJsonDataCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displJsonDataCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displJsonDataCheckBox.ForeColor = System.Drawing.Color.White;
            this.displJsonDataCheckBox.Location = new System.Drawing.Point(122, 48);
            this.displJsonDataCheckBox.Name = "displJsonDataCheckBox";
            this.displJsonDataCheckBox.Size = new System.Drawing.Size(183, 20);
            this.displJsonDataCheckBox.TabIndex = 0;
            this.displJsonDataCheckBox.Text = "Display Decode JSON";
            this.displJsonDataCheckBox.UseVisualStyleBackColor = true;
            this.displJsonDataCheckBox.CheckedChanged += new System.EventHandler(this.displJsonDataCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select City";
            // 
            // countriesComboBox
            // 
            this.countriesComboBox.BackColor = System.Drawing.Color.DimGray;
            this.countriesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countriesComboBox.ForeColor = System.Drawing.Color.White;
            this.countriesComboBox.FormattingEnabled = true;
            this.countriesComboBox.Location = new System.Drawing.Point(80, 14);
            this.countriesComboBox.Name = "countriesComboBox";
            this.countriesComboBox.Size = new System.Drawing.Size(225, 28);
            this.countriesComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jsonWeatherRichTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // jsonWeatherRichTxtBox
            // 
            this.jsonWeatherRichTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.jsonWeatherRichTxtBox.ForeColor = System.Drawing.Color.White;
            this.jsonWeatherRichTxtBox.Location = new System.Drawing.Point(6, 19);
            this.jsonWeatherRichTxtBox.Name = "jsonWeatherRichTxtBox";
            this.jsonWeatherRichTxtBox.Size = new System.Drawing.Size(497, 248);
            this.jsonWeatherRichTxtBox.TabIndex = 0;
            this.jsonWeatherRichTxtBox.Text = "";
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.readBtn.Location = new System.Drawing.Point(359, 14);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(147, 54);
            this.readBtn.TabIndex = 1;
            this.readBtn.Text = "Read Again";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // WeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(536, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WeatherApp";
            this.Text = "Weather Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countriesComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox displJsonDataCheckBox;
        private System.Windows.Forms.RichTextBox jsonWeatherRichTxtBox;
        private System.Windows.Forms.Button readBtn;
    }
}

