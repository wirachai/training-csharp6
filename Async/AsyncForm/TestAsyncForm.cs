using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncForm
{
    public partial class TestAsyncForm : Form
    {
        public TestAsyncForm()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Fetching...";
            using (var client = new HttpClient())
            {
                Task<string> task = client.GetStringAsync("https://www.google.com");
                string text = await task;   // actual run
                StatusLabel.Text = text.Length.ToString();
            }
        }
    }
}
