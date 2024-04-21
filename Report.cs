using System;
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
    public partial class Report : Form
    {
       //variable to store date
        private DateTime dte;
        //get and set method for date vraiable
        public DateTime Dte
        {
            get { return dte; }
            set { dte = value; }
        }
        public Report()
        {
            InitializeComponent();

        }
        //creating new list to compare the viriables
        public void receiveData(List<Weather> weatherList)
        {
            compareList = weatherList;
        }
        List<Weather> compareList = new List<Weather>();
        
        //button to go back to Form 2
        private void btnBack_Click(object sender, EventArgs e)
        {
            WeatherData wd = new WeatherData();
            wd.Show();
            this.Hide();
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //button to display the data
        private void btnViewData_Click(object sender, EventArgs e)
        {
           LoadCompareData();
        }

        //method to load the data when the button is clicked
        public void LoadCompareData()
        {
            //creating new object for compare list and creating a new table and it's columns
            Weather d1 = new Weather();
            DataTable ct = new DataTable();
            ct.Columns.Add("Date");
            ct.Columns.Add("Max Maximum Temperature");
            ct.Columns.Add("Min Minimum Temperature");
            ct.Columns.Add("Max Precipitation");
            ct.Columns.Add("Max Humidity");
            ct.Columns.Add("Max Wind Speed");

            List<Int64> compList = new List<Int64>();
            //loop to check every object in the list
            foreach (Weather w1 in CaptureData.weatherList)
            {
                int index = -1;
                int maxTemp = 0;
                int minTemp = 0;
                int humid = 0;
                int precip = 0;
                int wndspd = 0;

                CaptureData.availDates.Add(w1.Date);

                if (CaptureData.availDates.Contains(w1.Date))
                {
                    CaptureData.availDates.Add(Dte);
                }

                foreach (Weather wObj in CaptureData.weatherList)
                {
                    //loop to check if the dates match and then compare every value for each object in the date range
                    if (w1.Date == Dte)
                    {
                        foreach (DateTime Dte in CaptureData.availDates)
                        {
                            //loop to assign the max value of the objects to a variable
                            if (w1.MaxTemp > maxTemp)
                            {
                                maxTemp = w1.MaxTemp;
                                compList.Add(maxTemp);
                            }
                        }
                        foreach (DateTime Dte in CaptureData.availDates)
                        {
                            if (w1.MinTemp > minTemp)
                            {
                                minTemp = w1.MinTemp;
                                compList.Add(minTemp);
                            }
                        }
                        foreach (DateTime Dte in CaptureData.availDates)
                        {
                            if (w1.Humidity > humid)
                            {
                                humid = w1.Humidity;
                                compList.Add(humid);
                            }
                        }
                        foreach (DateTime Dte in CaptureData.availDates)
                        {
                            if (w1.Precipitation > precip)
                            {
                                precip = w1.Precipitation;
                                compList.Add(precip);
                            }
                        }
                        foreach (DateTime Dte in CaptureData.availDates)
                        {
                            if (w1.WindSpeed > wndspd)
                            {
                                wndspd = w1.WindSpeed;
                                compList.Add(wndspd);
                            }
                        }
                    }
                }
                index++;
                //populating table rows with the values
                DataRow cRow = ct.NewRow();
                cRow["Date"] = CaptureData.availDates[index];
                cRow["Max Maximum Temperature"] = compareList[index].MaxTemp;
                cRow["Min Minimum Temperature"] = compareList[index].MinTemp;
                cRow["Max Precipitation"] = compareList[index].Precipitation;
                cRow["Max Humidity"] = compareList[index].Humidity;
                cRow["Max Wind Speed"] = compareList[index].WindSpeed;
                ct.Rows.Add(cRow);
            }
            dgvReport.DataSource = ct;

        }


    }
}
