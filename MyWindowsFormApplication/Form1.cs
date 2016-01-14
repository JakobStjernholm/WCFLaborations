using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormApplication.ServiceAddingThree;
using MyWindowsFormApplication.ServiceAddTwoNumbers;
using MyWindowsFormApplication.ServiceAmerican;
using MyWindowsFormApplication.ServiceCandidates;
using MyWindowsFormApplication.ServiceNameDay;
using MyWindowsFormApplication.ServiceReference1;
using MyWindowsFormApplication.ServiceSubtract;

namespace MyWindowsFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CandidatesAmericaRepublicanSoapClient client = new CandidatesAmericaRepublicanSoapClient();
            foreach (var year in client.GetAllYears())
            {
                comboBoxFromYear.Items.Add(year);
                comboBoxToYear.Items.Add(year);
            }
            
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

        private void btnResultAddingThree_Click(object sender, EventArgs e)
        {
            AddingThreeNumbersSoapClient myClient = new AddingThreeNumbersSoapClient();
            resultAddingThree.Text = myClient.AddThreeNumbers(numericUpDown1.Value, numericUpDown2.Value,numericUpDown3.Value).ToString();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            SubtractTwoNumbersSoapClient newClient = new SubtractTwoNumbersSoapClient();
            resultSubtract.Text = newClient.SubtractNumbers(numericUpDown5.Value, numericUpDown4.Value).ToString();
        }
        private void btnGetDate_Click(object sender, EventArgs e)
        {
            GetNameDayServiceSoapClient nameDayClient = new GetNameDayServiceSoapClient();
            lblGetDate.Text = nameDayClient.GetName(txbTypeName.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AmericanSoapClient americanClient = new AmericanSoapClient();
            listView1.Items.Clear();
            var array = americanClient.CheckAmericanWar((string)comboBox1.SelectedItem);
            foreach (var a in array)
            {
                listView1.Items.Add(a);
            }
        }

        private void buttonGetCandidates_Click(object sender, EventArgs e)
        {
            CandidatesAmericaRepublicanSoapClient candidateClient = new CandidatesAmericaRepublicanSoapClient();
            listView2.Items.Clear();
            var array = candidateClient.GetAllCandidates((string) comboBoxFromYear.SelectedItem,
                (string) comboBoxToYear.SelectedItem);
            foreach (var item in array)
            {
                listView2.Items.Add(item);
            }
        }
    }
}
