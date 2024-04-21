namespace WeatherTask1
{
    partial class WeatherData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherData));
            this.pnlFilterRecords = new System.Windows.Forms.Panel();
            this.dgvFilter = new System.Windows.Forms.DataGridView();
            this.btnFilterData = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.clbProvince = new System.Windows.Forms.CheckedListBox();
            this.clbCity = new System.Windows.Forms.CheckedListBox();
            this.pnlFilterRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilterRecords
            // 
            this.pnlFilterRecords.BackColor = System.Drawing.Color.Transparent;
            this.pnlFilterRecords.Controls.Add(this.clbCity);
            this.pnlFilterRecords.Controls.Add(this.clbProvince);
            this.pnlFilterRecords.Controls.Add(this.dgvFilter);
            this.pnlFilterRecords.Controls.Add(this.btnFilterData);
            this.pnlFilterRecords.Controls.Add(this.dtpEnd);
            this.pnlFilterRecords.Controls.Add(this.dtpStart);
            this.pnlFilterRecords.Controls.Add(this.lblEnd);
            this.pnlFilterRecords.Controls.Add(this.lblStart);
            this.pnlFilterRecords.Controls.Add(this.lblCity);
            this.pnlFilterRecords.Controls.Add(this.lblProvince);
            this.pnlFilterRecords.Location = new System.Drawing.Point(142, 30);
            this.pnlFilterRecords.Name = "pnlFilterRecords";
            this.pnlFilterRecords.Size = new System.Drawing.Size(788, 444);
            this.pnlFilterRecords.TabIndex = 0;
            // 
            // dgvFilter
            // 
            this.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilter.Location = new System.Drawing.Point(34, 188);
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.RowHeadersWidth = 51;
            this.dgvFilter.RowTemplate.Height = 24;
            this.dgvFilter.Size = new System.Drawing.Size(719, 242);
            this.dgvFilter.TabIndex = 9;
            this.dgvFilter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilter_CellContentClick);
            // 
            // btnFilterData
            // 
            this.btnFilterData.Location = new System.Drawing.Point(572, 147);
            this.btnFilterData.Name = "btnFilterData";
            this.btnFilterData.Size = new System.Drawing.Size(160, 32);
            this.btnFilterData.TabIndex = 8;
            this.btnFilterData.Text = "Filter Data";
            this.btnFilterData.UseVisualStyleBackColor = true;
            this.btnFilterData.Click += new System.EventHandler(this.btnFilterData_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(253, 157);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(257, 22);
            this.dtpEnd.TabIndex = 7;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(253, 110);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(257, 22);
            this.dtpStart.TabIndex = 6;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnd.Location = new System.Drawing.Point(118, 157);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(80, 17);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End Date:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStart.Location = new System.Drawing.Point(118, 110);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(87, 17);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start Date:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCity.Location = new System.Drawing.Point(421, 27);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 17);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProvince.Location = new System.Drawing.Point(31, 27);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(76, 17);
            this.lblProvince.TabIndex = 0;
            this.lblProvince.Text = "Province:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(587, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 44);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(299, 505);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(121, 44);
            this.btnViewReport.TabIndex = 4;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // clbProvince
            // 
            this.clbProvince.FormattingEnabled = true;
            this.clbProvince.Location = new System.Drawing.Point(132, 27);
            this.clbProvince.Name = "clbProvince";
            this.clbProvince.Size = new System.Drawing.Size(227, 72);
            this.clbProvince.TabIndex = 10;
            this.clbProvince.SelectedIndexChanged += new System.EventHandler(this.clbProvince_SelectedIndexChanged);
            // 
            // clbCity
            // 
            this.clbCity.FormattingEnabled = true;
            this.clbCity.Location = new System.Drawing.Point(486, 27);
            this.clbCity.Name = "clbCity";
            this.clbCity.Size = new System.Drawing.Size(227, 72);
            this.clbCity.TabIndex = 11;
            // 
            // WeatherData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 605);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.pnlFilterRecords);
            this.Controls.Add(this.btnBack);
            this.Name = "WeatherData";
            this.Text = "Weather Report";
            this.pnlFilterRecords.ResumeLayout(false);
            this.pnlFilterRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFilterRecords;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvFilter;
        private System.Windows.Forms.Button btnFilterData;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.CheckedListBox clbCity;
        private System.Windows.Forms.CheckedListBox clbProvince;
    }
}