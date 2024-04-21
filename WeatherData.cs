using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherTask1
{
    public partial class WeatherData : Form
    {

        public WeatherData()
        {
            InitializeComponent();
            //hide the two panels that have controls for different data on data grid views
            pnlFilterRecords.Visible = true;
            //Reference: (C# Checked ListBox Control, n.d.)
            clbProvince.Items.AddRange(Province.province);
            //set minimum and maximum date to be selected
            dtpStart.MinDate = new DateTime(2010, 1, 31); // minimum date to display is 31 Jan 1994
            dtpEnd.MaxDate = new DateTime(2030, 12, 30);// maximum date to display is 30 Dec 2002
            //set date to be the min date
            dtpStart.Value = dtpStart.MinDate;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CaptureData cd = new CaptureData();
            cd.Show();
            this.Hide();
        }

        private void btnFilterData_Click(object sender, EventArgs e)
        {
            //create a data table to store the data
            DataTable dt = new DataTable();
            //create columns for for data table
            dt.Columns.Add("Province");
            dt.Columns.Add("City");
            dt.Columns.Add("Date");
            dt.Columns.Add("Maximum Temperature");
            dt.Columns.Add("Minimum Temperature");
            dt.Columns.Add("Humidity");
            dt.Columns.Add("Precipitation");
            dt.Columns.Add("Wind Speed");
            //read dates selected
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;
            string prov = Convert.ToString(clbProvince.Text);
            string cty = Convert.ToString(clbCity.Text);
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be later than end date");
            }
            else
            {
                //variable to store index number of weather object in List
                int i = -1;
                //go through the weather List objects and add data to the data table
                foreach (var stud in CaptureData.weatherList)
                {
                    //set index number of the stud object
                    i++;
                    foreach (var w1 in CaptureData.weatherList)
                    {
                        if (w1.Province == prov && w1.City == cty)
                        {
                            if (stud.Date.Date >= startDate.Date && stud.Date.Date <= endDate.Date)
                            {
                                //add the stud data to the data grid view 
                                //create a new row to store data from current weather object
                                DataRow dRow = dt.NewRow();
                                //add values from the current weather to the current new row
                                dRow["Province"] = CaptureData.weatherList[i].Province;
                                dRow["City"] = CaptureData.weatherList[i].City;
                                dRow["Date"] = CaptureData.weatherList[i].Date;
                                dRow["Maximum Temperature"] = CaptureData.weatherList[i].MaxTemp;
                                dRow["Minimum Temperature"] = CaptureData.weatherList[i].MinTemp;
                                dRow["Humidity"] = CaptureData.weatherList[i].Humidity;
                                dRow["Precipitation"] = CaptureData.weatherList[i].Precipitation;
                                dRow["Wind Speed"] = CaptureData.weatherList[i].WindSpeed;
                                //Add the row to the datatable dt
                                dt.Rows.Add(dRow);
                            }
                        }
                    }
                    //make the source of data for the data grid view to be the data table
                    dgvFilter.DataSource = dt;
                }
            }
        }

        //button to go to the Report Form
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            Report rt = new Report();
            rt.receiveData(CaptureData.weatherList);
            this.Hide();
            rt.Show();
        }


        private void dgvFilter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //populating the city checklistbox
        private void clbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reference: (Sign In | SoloLearn: Learn to code for FREE!, n.d.) & (C# Checked ListBox Control, n.d.)

            switch (((CheckedListBox)sender).SelectedItem as string)
            {
                case "Eastern Cape":
                    clbCity.Items.AddRange(Province.EasternCape);
                    break;
                case "Free State":
                    clbCity.Items.AddRange(Province.FreeState);
                    break;
                case "Gauteng":
                    clbCity.Items.AddRange(Province.Gauteng);
                    break;
                case "KwaZulu-Natal":
                    clbCity.Items.AddRange(Province.KwaZuluNatal);
                    break;
                case "Limpopo":
                    clbCity.Items.AddRange(Province.Limpopo);
                    break;
                case "Mpumalanga":
                    clbCity.Items.AddRange(Province.Mpumalanga);
                    break;
                case "Northern Cape":
                    clbCity.Items.AddRange(Province.NorthernCape);
                    break;
                case "North West":
                    clbCity.Items.AddRange(Province.NorthWest);
                    break;
            }
        }

    }
}
