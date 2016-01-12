using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormApplication.ServiceAddTwoNumbers;
using MyWindowsFormApplication.ServiceReference1;

namespace MyWindowsFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWeather_Click(object sender, EventArgs e)
        {
            WeatherSoapClient client = new WeatherSoapClient();
            labelWeather.Text = client.HelloWorld();
        }

        private void twoNumberBtn_Click(object sender, EventArgs e)
        {
            AddTwoNumbersSoapClient twoNumberClient = new AddTwoNumbersSoapClient();
            twoNumberResult.Text = twoNumberClient.AddTwoNumber(numberOne.Value, numberTwo.Value).ToString();
        }
    }
}
