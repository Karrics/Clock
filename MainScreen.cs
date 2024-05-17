using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainScreen : Form
    {
        List<Timer> timers = new List<Timer>();
        private Timer timer1 = new Timer();
        private Timer timer2 = new Timer();
        private Timer timer3 = new Timer();

        public MainScreen()
        {
            InitializeComponent();
            
        }


        private void Timer_Tick(Timer timer, DateTime alarmTime)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime.Hour == alarmTime.Hour && currentTime.Minute == alarmTime.Minute)
            {
                timer.Stop();
                MessageBox.Show($"Пора вставать! Время: {alarmTime.ToString("HH:mm")}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button4.Visible = false;
            DateTime.TryParse(maskedTextBox1.Text, out DateTime parsedTime);

            timer1.Interval = 1000;
            timer1.Tick += (s, args) => Timer_Tick(timer1, parsedTime);
            timer1.Start();
            timers.Add(timer1);

            MessageBox.Show($"установленное время: {parsedTime.ToString("HH:mm")}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            DateTime.TryParse(maskedTextBox2.Text, out DateTime parsedTime);

            timer2.Interval = 1000;
            timer2.Tick += (s, args) => Timer_Tick(timer2, parsedTime);
            timer2.Start();
            timers.Add(timer2);

            MessageBox.Show($"установленное время: {parsedTime.ToString("HH:mm")}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            DateTime.TryParse(maskedTextBox3.Text, out DateTime parsedTime);

            timer3.Interval = 1000;
            timer3.Tick += (s, args) => Timer_Tick(timer3, parsedTime);
            timer3.Start();
            timers.Add(timer3);

            MessageBox.Show($"установленное время: {parsedTime.ToString("HH:mm")}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            timer2.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            timer3.Stop();
        }
        private void addClick_Click(object sender, EventArgs e)
        {
            AddClock addClock = new AddClock();
            addClock.Show();
        }

        private void nameBox1_Click(object sender, EventArgs e)
        {
            nameBox1.Text = "";
        }

        private void nameBox2_Click(object sender, EventArgs e)
        {
            nameBox2.Text = "";
        }

        private void nameBox3_Click(object sender, EventArgs e)
        {
            nameBox3.Text = "";
        }
    }
}
