using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Threading;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        public void getData()
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=getlightswitches&username=dGVzdA==&password=dGVzdA==");
            WebResponse webResponse = request.GetResponse();
            var responseText = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            dynamic valueJson = JValue.Parse(responseText);
            //JObject jobject = JObject.parse(responseText);
            var resultOne = valueJson["result"][1]["idx"].ToString();
            label1.Text = resultOne;
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

        private void GetSwitchesInfo_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void PutLightOff_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=switchlight&idx=2&switchcmd=Off&username=dGVzdA==&password=dGVzdA==");
            WebResponse webResponse = request.GetResponse();
            var responseText = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            dynamic valueJson = JToken.Parse(responseText);
            var resultOne = valueJson["status"].ToString();
            label1.Text = resultOne;
        }

        private void PutLightOn_Click(object sender, EventArgs e)
        {
            putLightsOn();
            RunRoute();
        }

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
        }

        private void putLightsOn()
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=switchlight&idx=24&switchcmd=On&username=dGVzdA==&password=dGVzdA==");
            WebResponse webResponse = request.GetResponse();
            var responseText = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            dynamic valueJson = JToken.Parse(responseText);
            var resultOne = valueJson["status"].ToString();
                label1.Text = resultOne;
        }

        private void putLightsOff()
        {
            HttpWebRequest request = GetRequest("http://localhost:8080/json.htm?type=command&param=switchlight&idx=24&switchcmd=Off&username=dGVzdA==&password=dGVzdA==");
            WebResponse webResponse = request.GetResponse();
            var responseText = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            dynamic valueJson = JToken.Parse(responseText);
            var resultOne = valueJson["status"].ToString();
            label1.Text = resultOne;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                putLightsOn();

                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Step = 10;

                for (int i = 0; i < 100; i++)
                {
                    progressBar1.PerformStep();
                }
            }
            else
            {
                putLightsOff();

                progressBar1.Value = 100;

                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(5);
                    progressBar1.Value -= 1;


                }

            }


        }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
