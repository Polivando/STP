using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace Organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calendar1.MaximumFullDays = 7;
            comboBox1.DataSource = new List<string> {"Day", "Week", "Month"};
            comboBox1.SelectedItem = "Month";
            calendar1.ViewStart = DateTime.Today.AddDays(1-DateTime.Today.Day);
            calendar1.ViewEnd = DateTime.Today.AddDays(1 - DateTime.Today.Day).AddMonths(1).AddDays(-1);
        }
    }
}
