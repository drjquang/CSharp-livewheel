using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;


namespace livewheel
{
    public partial class Form1 : Form
    {
        // Declare variables
        private int countdown;
        private int countdownMax;
        private bool isCountingDown;

        public Form1()
        {
            InitializeComponent();
            // Initialize extension
            isCountingDown = false;
            handleCountdown(isCountingDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Read the parameters from config.ini
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("config.ini");

            // Assign to global variables
            string value_countdown = data["Settings"]["Countdown"];
            countdownMax = int.Parse(value_countdown);
            countdown = countdownMax;
            cpb_Countdown.Minimum = 0;
            cpb_Countdown.Maximum = countdownMax;
            cpb_Countdown.Value = countdown;
            cpb_Countdown.Text = countdown.ToString();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            isCountingDown = !isCountingDown;
            handleCountdown(isCountingDown);
        }

        private void handleCountdown(bool isStarted) 
        {
            if (isStarted)
            {
                btn_Start.Text = "Stop";
                tmr_Countdown.Start();
            }
            else 
            {
                btn_Start.Text = "Start";
                tmr_Countdown.Stop();
            }
        }

        private void tmr_Countdown_Tick(object sender, EventArgs e)
        {            
            if (countdown == 0)
            {
                countdown = countdownMax;
                isCountingDown = false;
                handleCountdown(isCountingDown);
                cpb_Countdown.Hide();
                tmr_showVideo.Start();
            }
            countdown--;
            updateProgress(countdown);
        }

        private void updateProgress(int progressValue) 
        {
            cpb_Countdown.Value = progressValue;
            cpb_Countdown.Text = progressValue.ToString();
        }

        private void tmr_showVideo_Tick(object sender, EventArgs e)
        {
            tmr_showVideo.Stop();
            isCountingDown = true;
            handleCountdown(isCountingDown);
            cpb_Countdown.Show();
        }
    }
}
