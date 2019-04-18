using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelFirstApproachEx
{
    public partial class Form1 : Form
    {
        FlightModelContainer flightContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flight[] filghts = new Flight[] 
            {
                new Flight {FlightNumber="A23451",DepartureDate="06/23/2016",Airline="Air India",Origin="Mumbai",Destination="New Delhi"},
                new Flight {FlightNumber="A9866",DepartureDate="06/11/2016",Airline="Air India",Origin="Mumbai",Destination="New York"},
                new Flight {FlightNumber="I78654",DepartureDate="06/25/2016",Airline="Indigo",Origin="New Delhi",Destination="Chennai"},
                new Flight{FlightNumber="A98745",DepartureDate="06/30/2016",Airline="Air India",Origin="Banagalore",Destination="Mumbai"}
            };

            flightContext.Flights.AddRange(filghts);
            flightContext.SaveChanges();
            MessageBox.Show("Records Added Successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flightContext = new FlightModelContainer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = flightContext.Flights.ToList();
        }
    }
}
