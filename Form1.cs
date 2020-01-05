using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private HttpWebRequest GetRequest(string url, string httpMethod = "GET", bool allowAutoRedirect = true)
        {
            Uri uri = new Uri(url);
            HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";

            request.Timeout = Convert.ToInt32(new TimeSpan(0, 5, 0).TotalMilliseconds);
            request.Method = httpMethod;
            return request;
        }

        private string statusString;

        private async Task programStart()
        {
            while (checkBox2.Checked)
            {
                await Task.Delay(1000);
                getStatusTeddy();
                getStatusFriet();
                getStatusSuikerspin();
            }
        }


        private void getStatusTeddy()
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=getuservariable&idx=3");
            WebResponse webResponse = request.GetResponse();
            var responseText = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            dynamic valueJson = JToken.Parse(responseText);
            var resultOne = valueJson["status"][0]["Value"].ToString();
            statusString = "Teddyberen: " + resultOne;
            if (Convert.ToInt32(resultOne) <= 7 && checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                RunRoute();
            }
        }

        private void getStatusFriet()
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=getuservariable&idx=5");
            WebResponse webResponse = request.GetResponse();
            var responseText = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            dynamic valueJson = JToken.Parse(responseText);
            var resultOne = valueJson["status"][0]["Value"].ToString();
            statusString += "friet (kg): " + resultOne;
            if (Convert.ToInt32(resultOne) <= 10 && checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                RunRoute();
            }
        }

        private void getStatusSuikerspin()
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=getuservariable&idx=6");
            WebResponse webResponse = request.GetResponse();
            var responseText = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            dynamic valueJson = JToken.Parse(responseText);
            var resultOne = valueJson["status"][0]["Value"].ToString();
            statusString += "Suikerspin (kg): " + resultOne;
            label1.Text = statusString;
            if (Convert.ToInt32(resultOne) <= 3 && checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                RunRoute();
            }
        }

        private void resetFunction()
        {
            resetFriet();
            resetSuiker();
            resetTeddy();
        }

        private void resetSuiker()
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=switchlight&idx=31&switchcmd=On");
            WebResponse webResponse = request.GetResponse();
        }

        private void resetFriet()
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=switchlight&idx=24&switchcmd=On");
            WebResponse webResponse = request.GetResponse();
        }

        private void resetTeddy()
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=switchlight&idx=33&switchcmd=On");
            WebResponse webResponse = request.GetResponse();
        }


        #region route
        private async void RunRoute()
        {
            for (int i = 0; i < 213; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 512; i++)
            {
                await ChangePictureBoxLeft();
            }
            for (int i = 0; i < 165; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 72; i++)
            {
                await ChangePictureBoxLeft();
            }
            for (int i = 0; i < 172; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 72; i++)
            {
                await ChangePictureBoxRight();
            }
            for (int i = 0; i < 342; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 168; i++)
            {
                await ChangePictureBoxRight();
            }

            for (int i = 0; i < 85; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 145; i++)
            {
                await ChangePictureBoxRight();
            }
            for (int i = 0; i < 85; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 145; i++)
            {
                await ChangePictureBoxRight();
            }
            for (int i = 0; i < 220; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 295; i++)
            {
                await ChangePictureBoxLeft();
            }
            for (int i = 0; i < 70; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 70; i++)
            {
                await ChangePictureBoxRight();
            }
            for (int i = 0; i < 165; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 70; i++)
            {
                await ChangePictureBoxLeft();
            }
            for (int i = 0; i < 75; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 480; i++)
            {
                await ChangePictureBoxRight();
            }
            for (int i = 0; i < 245; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 80; i++)
            {
                await ChangePictureBoxLeft();
            }
            for (int i = 0; i < 200; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 80; i++)
            {
                await ChangePictureBoxRight();
            }
            for (int i = 0; i < 135; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 235; i++)
            {
                await ChangePictureBoxRight();
            }
            for (int i = 0; i < 80; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 165; i++)
            {
                await ChangePictureBoxRight();
            }
            for (int i = 0; i < 80; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 80; i++)
            {
                await ChangePictureBoxRight();
            }//tot hier gedaan

            for (int i = 0; i < 330; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 185; i++)
            {
                await ChangePictureBoxLeft();
            }
            for (int i = 0; i < 100; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 150; i++)
            {
                await ChangePictureBoxLeft();
            }
            for (int i = 0; i < 300; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 160; i++)
            {
                await ChangePictureBoxRight();
            }
            for (int i = 0; i < 90; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 155; i++)
            {
                await ChangePictureBoxRight();
            }

            for (int i = 0; i < 285; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 70; i++)
            {
                await ChangePictureBoxLeft();
            }
            for (int i = 0; i < 85; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 180; i++)
            {
                await ChangePictureBoxLeft();
            }

            for (int i = 0; i < 85; i++)
            {
                await ChangePictureBoxUp();
            }
            for (int i = 0; i < 315; i++)
            {
                await ChangePictureBoxLeft();
            }
            for (int i = 0; i < 215; i++)
            {
                await ChangePictureBoxBottom();
            }
            for (int i = 0; i < 25; i++)
            {
                await ChangePictureBoxLeft();
            }
            resetFunction();
        }
        #endregion route

        #region directions
        private async Task ChangePictureBoxUp()
        {
            await Task.Delay(1);
            pictureBox1.Top -= 1;
        }

        private async Task ChangePictureBoxLeft()
        {
            await Task.Delay(1);
            pictureBox1.Left -= 1;
        }

        private async Task ChangePictureBoxBottom()
        {
            await Task.Delay(1);
            pictureBox1.Top += 1;
        }

        private async Task ChangePictureBoxRight()
        {
            await Task.Delay(1);
            pictureBox1.Left += 1;
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Programma gestart";
            checkBox2.Checked = true;
            await programStart();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Programma beëindigd";
            checkBox2.Checked = false;
        }
    }
}
