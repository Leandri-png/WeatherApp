namespace WeatherTask1
{
    partial class CaptureData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.txtWindSpeed = new System.Windows.Forms.TextBox();
            this.txtPrecipitation = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblprecipitation = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboProvince);
            this.groupBox1.Controls.Add(this.cboCity);
            this.groupBox1.Controls.Add(this.txtWindSpeed);
            this.groupBox1.Controls.Add(this.txtPrecipitation);
            this.groupBox1.Controls.Add(this.txtHumidity);
            this.groupBox1.Controls.Add(this.txtMinTemp);
            this.groupBox1.Controls.Add(this.txtMaxTemp);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblWindSpeed);
            this.groupBox1.Controls.Add(this.lblprecipitation);
            this.groupBox1.Controls.Add(this.lblHumidity);
            this.groupBox1.Controls.Add(this.lblMinTemp);
            this.groupBox1.Controls.Add(this.lblMaxTemp);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblProvince);
            this.groupBox1.Location = new System.Drawing.Point(66, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(226, 53);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(234, 24);
            this.cboProvince.TabIndex = 22;
            this.cboProvince.SelectedIndexChanged += new System.EventHandler(this.cboProvince_SelectedIndexChanged_1);
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(226, 93);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(234, 24);
            this.cboCity.TabIndex = 21;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // txtWindSpeed
            // 
            this.txtWindSpeed.Location = new System.Drawing.Point(226, 354);
            this.txtWindSpeed.Name = "txtWindSpeed";
            this.txtWindSpeed.Size = new System.Drawing.Size(234, 22);
            this.txtWindSpeed.TabIndex = 18;
            // 
            // txtPrecipitation
            // 
            this.txtPrecipitation.Location = new System.Drawing.Point(226, 310);
            this.txtPrecipitation.Name = "txtPrecipitation";
            this.txtPrecipitation.Size = new System.Drawing.Size(234, 22);
            this.txtPrecipitation.TabIndex = 17;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(226, 263);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(234, 22);
            this.txtHumidity.TabIndex = 16;
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(226, 221);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(234, 22);
            this.txtMinTemp.TabIndex = 15;
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(226, 183);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(234, 22);
            this.txtMaxTemp.TabIndex = 14;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(226, 141);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(234, 22);
            this.dtpDate.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(298, 409);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 33);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWindSpeed.Location = new System.Drawing.Point(47, 354);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(105, 17);
            this.lblWindSpeed.TabIndex = 8;
            this.lblWindSpeed.Text = "Wind Speed: ";
            // 
            // lblprecipitation
            // 
            this.lblprecipitation.AutoSize = true;
            this.lblprecipitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecipitation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblprecipitation.Location = new System.Drawing.Point(47, 310);
            this.lblprecipitation.Name = "lblprecipitation";
            this.lblprecipitation.Size = new System.Drawing.Size(109, 17);
            this.lblprecipitation.TabIndex = 7;
            this.lblprecipitation.Text = "Precipitation: ";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHumidity.Location = new System.Drawing.Point(47, 263);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(80, 17);
            this.lblHumidity.TabIndex = 6;
            this.lblHumidity.Text = "Humidity: ";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMinTemp.Location = new System.Drawing.Point(47, 221);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(178, 17);
            this.lblMinTemp.TabIndex = 5;
            this.lblMinTemp.Text = "Minimum Temperature: ";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaxTemp.Location = new System.Drawing.Point(47, 183);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(181, 17);
            this.lblMaxTemp.TabIndex = 4;
            this.lblMaxTemp.Text = "Maximum Temperature: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(47, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date: ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCity.Location = new System.Drawing.Point(47, 100);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 17);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City: ";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProvince.Location = new System.Drawing.Point(47, 60);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(81, 17);
            this.lblProvince.TabIndex = 1;
            this.lblProvince.Text = "Province: ";
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(206, 507);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(105, 40);
            this.btnViewData.TabIndex = 1;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(527, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CaptureData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 569);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.groupBox1);
            this.Name = "CaptureData";
            this.Text = "Capture Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWindSpeed;
        private System.Windows.Forms.TextBox txtPrecipitation;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblprecipitation;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.ComboBox cboCity;
    }
}

