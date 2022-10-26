
namespace WeatherAppCV
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
            this.CityLab = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.D_Label = new System.Windows.Forms.Label();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.T_Label = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.W_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.H_Label = new System.Windows.Forms.Label();
            this.FL_Label = new System.Windows.Forms.Label();
            this.Tmax_Label = new System.Windows.Forms.Label();
            this.Tmin_Label = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.MinTempLabel = new System.Windows.Forms.Label();
            this.MaxTempLabel = new System.Windows.Forms.Label();
            this.FeelsLikeLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CityLab
            // 
            this.CityLab.AutoSize = true;
            this.CityLab.BackColor = System.Drawing.Color.Transparent;
            this.CityLab.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CityLab.Location = new System.Drawing.Point(12, 26);
            this.CityLab.Name = "CityLab";
            this.CityLab.Size = new System.Drawing.Size(51, 26);
            this.CityLab.TabIndex = 0;
            this.CityLab.Text = "City:";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SearchButton.Location = new System.Drawing.Point(258, 28);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 25);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CityBox
            // 
            this.CityBox.CausesValidation = false;
            this.CityBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CityBox.Location = new System.Drawing.Point(69, 30);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(183, 22);
            this.CityBox.TabIndex = 2;
            this.CityBox.Text = "Type the city name";
            this.CityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CityBox.Click += new System.EventHandler(this.CityBox_Click);
            // 
            // D_Label
            // 
            this.D_Label.AutoSize = true;
            this.D_Label.BackColor = System.Drawing.Color.Transparent;
            this.D_Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.D_Label.Location = new System.Drawing.Point(12, 181);
            this.D_Label.Name = "D_Label";
            this.D_Label.Size = new System.Drawing.Size(77, 26);
            this.D_Label.TabIndex = 3;
            this.D_Label.Text = "Details:";
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeatherLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WeatherLabel.Location = new System.Drawing.Point(111, 81);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(100, 26);
            this.WeatherLabel.TabIndex = 4;
            // 
            // T_Label
            // 
            this.T_Label.AutoSize = true;
            this.T_Label.BackColor = System.Drawing.Color.Transparent;
            this.T_Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.T_Label.Location = new System.Drawing.Point(12, 228);
            this.T_Label.Name = "T_Label";
            this.T_Label.Size = new System.Drawing.Size(129, 26);
            this.T_Label.TabIndex = 5;
            this.T_Label.Text = "Temperature:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 118);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(320, 26);
            this.DescriptionLabel.TabIndex = 6;
            // 
            // W_Label
            // 
            this.W_Label.AutoSize = true;
            this.W_Label.BackColor = System.Drawing.Color.Transparent;
            this.W_Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.W_Label.Location = new System.Drawing.Point(12, 81);
            this.W_Label.Name = "W_Label";
            this.W_Label.Size = new System.Drawing.Size(93, 26);
            this.W_Label.TabIndex = 8;
            this.W_Label.Text = "Weather:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(227, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 34);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // H_Label
            // 
            this.H_Label.AutoSize = true;
            this.H_Label.BackColor = System.Drawing.Color.Transparent;
            this.H_Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.H_Label.Location = new System.Drawing.Point(429, 264);
            this.H_Label.Name = "H_Label";
            this.H_Label.Size = new System.Drawing.Size(97, 26);
            this.H_Label.TabIndex = 11;
            this.H_Label.Text = "Humidity:";
            // 
            // FL_Label
            // 
            this.FL_Label.AutoSize = true;
            this.FL_Label.BackColor = System.Drawing.Color.Transparent;
            this.FL_Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FL_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FL_Label.Location = new System.Drawing.Point(429, 228);
            this.FL_Label.Name = "FL_Label";
            this.FL_Label.Size = new System.Drawing.Size(98, 26);
            this.FL_Label.TabIndex = 12;
            this.FL_Label.Text = "Feels like:";
            // 
            // Tmax_Label
            // 
            this.Tmax_Label.AutoSize = true;
            this.Tmax_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tmax_Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tmax_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tmax_Label.Location = new System.Drawing.Point(12, 302);
            this.Tmax_Label.Name = "Tmax_Label";
            this.Tmax_Label.Size = new System.Drawing.Size(221, 26);
            this.Tmax_Label.TabIndex = 13;
            this.Tmax_Label.Text = "Maximum temperature:";
            // 
            // Tmin_Label
            // 
            this.Tmin_Label.AutoSize = true;
            this.Tmin_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tmin_Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tmin_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tmin_Label.Location = new System.Drawing.Point(12, 264);
            this.Tmin_Label.Name = "Tmin_Label";
            this.Tmin_Label.Size = new System.Drawing.Size(217, 26);
            this.Tmin_Label.TabIndex = 14;
            this.Tmin_Label.Text = "Minimum temperature:";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TemperatureLabel.Location = new System.Drawing.Point(160, 228);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(73, 26);
            this.TemperatureLabel.TabIndex = 15;
            // 
            // MinTempLabel
            // 
            this.MinTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinTempLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTempLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinTempLabel.Location = new System.Drawing.Point(250, 264);
            this.MinTempLabel.Name = "MinTempLabel";
            this.MinTempLabel.Size = new System.Drawing.Size(83, 26);
            this.MinTempLabel.TabIndex = 16;
            // 
            // MaxTempLabel
            // 
            this.MaxTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaxTempLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTempLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaxTempLabel.Location = new System.Drawing.Point(250, 302);
            this.MaxTempLabel.Name = "MaxTempLabel";
            this.MaxTempLabel.Size = new System.Drawing.Size(83, 26);
            this.MaxTempLabel.TabIndex = 17;
            // 
            // FeelsLikeLabel
            // 
            this.FeelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeelsLikeLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeelsLikeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FeelsLikeLabel.Location = new System.Drawing.Point(549, 228);
            this.FeelsLikeLabel.Name = "FeelsLikeLabel";
            this.FeelsLikeLabel.Size = new System.Drawing.Size(98, 26);
            this.FeelsLikeLabel.TabIndex = 18;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumidityLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HumidityLabel.Location = new System.Drawing.Point(549, 264);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(98, 26);
            this.HumidityLabel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.FeelsLikeLabel);
            this.Controls.Add(this.MaxTempLabel);
            this.Controls.Add(this.MinTempLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.Tmin_Label);
            this.Controls.Add(this.Tmax_Label);
            this.Controls.Add(this.FL_Label);
            this.Controls.Add(this.H_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.W_Label);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.T_Label);
            this.Controls.Add(this.WeatherLabel);
            this.Controls.Add(this.D_Label);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CityLab);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CityLab;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label D_Label;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.Label T_Label;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label W_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label H_Label;
        private System.Windows.Forms.Label FL_Label;
        private System.Windows.Forms.Label Tmax_Label;
        private System.Windows.Forms.Label Tmin_Label;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label MinTempLabel;
        private System.Windows.Forms.Label MaxTempLabel;
        private System.Windows.Forms.Label FeelsLikeLabel;
        private System.Windows.Forms.Label HumidityLabel;
    }
}

