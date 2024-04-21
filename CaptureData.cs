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
    public partial class CaptureData : Form
    {
        //Reference: (Carney, n.d.)
        public ArrayList weathList = new ArrayList(); //array list of weather objects
        public static List<Weather> weatherList = new List<Weather>(); //list of weather objects
        public static List<DateTime> availDates = new List<DateTime>(); //list for available dates
        public CaptureData()
        {
            InitializeComponent();
            //Reference: (Carney, n.d.)
            //set date format
            dtpDate.CustomFormat = "MMMM dd yy";//  dd/mm/yyyy and HH:mm:ss              
            //set minimum and maximum date to be selected
            dtpDate.MinDate = new DateTime(2010, 1, 31); // minimum date to display is 31 Jan 1994
            dtpDate.MaxDate = new DateTime(2030, 12, 30);// maximum date to display is 30 Dec 2002
            //set date to be the min date
            dtpDate.Value = dtpDate.MinDate;
            //deactivate the submit button until provinces are added
            btnSubmit.Enabled = true;
            //adding the values in the array to the combo box
            cboProvince.DataSource = Province.province;
            //de-selecting the combobox so no value is selected
            cboProvince.SelectedIndex = -1;
            cboCity.SelectedIndex = -1;
            //deactivating typing in the combo box
            cboProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCity.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Reference: (Doyle, 2016)
            //creating a weather object
            Weather w1 = new Weather();
            //assigning values to the weather object
            w1.Province = cboProvince.SelectedItem.ToString();
            w1.City = cboCity.SelectedItem.ToString();
            w1.Date = dtpDate.Value.Date;
            w1.MaxTemp = int.Parse(txtMaxTemp.Text);
            w1.MinTemp = int.Parse(txtMinTemp.Text);
            w1.Precipitation = int.Parse(txtPrecipitation.Text);
            w1.Humidity = int.Parse(txtHumidity.Text);
            w1.WindSpeed = int.Parse(txtWindSpeed.Text);
            //add the weather object to the List
            weatherList.Add(w1);
           
            //access each object in the list and show the values of name attributes for each object
            foreach (var st in weatherList)
            {
                /*
             * dtpDOB.Value.Date will output date in the format : 2020/03/12 00:00:00 depending on system time
             * dtpDOB.Value.toString() will output the string format : 2020/03/12 15:45:12 etc depending on the system time and formating on the date before printing
             * dtpDOB.Value.ToLongDateString() will output the date in the string format : Thursday , 12 March 2020
             * dtpDOB.Value.ToShortDateString() will output the date in the string format : 2020/03/12
             */
                MessageBox.Show("Province: " + st.Province + "\nCity: " + st.City + "\nDate: " + st.Date.ToLongDateString() + "\nMaximum Temperature: " + st.MaxTemp + "\nMinimum Temperature: " + st.MinTemp  + "\nHumidity: " + st.Humidity + "\nPrecipitation: " + st.Precipitation + "\nWind Speed: " + st.WindSpeed );
            }
            //de-selecting the combobox so no value is selected
            cboProvince.SelectedIndex = -1;
            cboCity.SelectedIndex = -1;
            //clear all the input fields for the next input
            txtMaxTemp.Text = "";
            txtMinTemp.Text = "";
            txtPrecipitation.Text = "";
            txtHumidity.Text = "";
            txtWindSpeed.Text = "";
            //set date to be the min date
            dtpDate.Value = dtpDate.MinDate;

        }

        //button to go the WeatherData form
        private void btnViewData_Click(object sender, EventArgs e)
        {
            //Reference: (Carney, n.d.)
            WeatherData wd = new WeatherData();
            wd.Show();
            this.Hide();
        }

        //button to exit the application
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //populating the city ComboBox
        private void cboProvince_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Reference: (Sign In | SoloLearn: Learn to code for FREE!, n.d.)
            switch (((ComboBox)sender).SelectedItem as string)
            {
                case "Eastern Cape":
                    cboCity.DataSource = Province.EasternCape;
                    break;
                case "Free State":
                    cboCity.DataSource = Province.FreeState;
                    break;
                case "Gauteng":
                    cboCity.DataSource = Province.Gauteng;
                    break;
                case "KwaZulu-Natal":
                    cboCity.DataSource = Province.KwaZuluNatal;
                    break;
                case "Limpopo":
                    cboCity.DataSource = Province.Limpopo;
                    break;
                case "Mpumalanga":
                    cboCity.DataSource = Province.Mpumalanga;
                    break;
                case "Northern Cape":
                    cboCity.DataSource = Province.NorthernCape;
                    break;
                case "North West":
                    cboCity.DataSource = Province.NorthWest;
                    break;
            }
        }
    }
}
