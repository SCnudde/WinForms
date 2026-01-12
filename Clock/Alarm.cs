using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clock
{
    public partial class Alarm : Form
    {
        System.Timers.Timer timer1;
        System.Timers.Timer timer2;
        System.Timers.Timer timer3;
        
        static SoundPlayer SoundAlarm = new SoundPlayer(@"C:\Users\HP\Desktop\С#\WinForms\Clock\SoundAlarm.wav");
        static SoundPlayer SmokeAlarm = new SoundPlayer(@"C:\Users\HP\Desktop\С#\WinForms\Clock\SmokeAlarm.wav");
        static SoundPlayer GongAlarm = new SoundPlayer(@"C:\Users\HP\Desktop\С#\WinForms\Clock\Gong.wav");

        static int SelectedSound;

        SoundPlayer[] Sounds = new SoundPlayer[]
        {
            SoundAlarm, SmokeAlarm, GongAlarm
        };     
        
        public Alarm()
        {
            InitializeComponent();
        }

        public Alarm(Form form)
        {
            InitializeComponent();
            form.BackColor = Color.Beige;
        }            

        private void Alarm_Load(object sender, EventArgs e)
        {
            timer1 = new System.Timers.Timer();
            timer1.Interval = 1000;
            timer1.Elapsed += Timer_Elapsed;

            timer2 = new System.Timers.Timer();
            timer2.Interval = 1000;
            timer2.Elapsed += Timer_Elapsed;

            timer3 = new System.Timers.Timer();
            timer3.Interval = 1000;
            timer3.Elapsed += Timer_Elapsed;

            comboBoxSound1.Items.AddRange(new object[] { "SoundAlarm", "SmokeAlarm", "GongAlarm" });
            comboBoxSound2.Items.AddRange(new object[] { "SoundAlarm", "SmokeAlarm", "GongAlarm" });
            comboBoxSound3.Items.AddRange(new object[] { "SoundAlarm", "SmokeAlarm", "GongAlarm" });
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
           DateTime currentTime = DateTime.Now;
           DateTime userTime_1  = dateTimePicker_1.Value;
            if(currentTime.Hour == userTime_1.Hour && currentTime.Minute == userTime_1.Minute)
            {
                timer1.Stop();                     

                Sounds[SelectedSound].Play();

                MessageBox.Show("Гудок заводской, на работу пора!","Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }

            DateTime userTime_2 = dateTimePicker_2.Value;
            if (currentTime.Hour == userTime_2.Hour && currentTime.Minute == userTime_2.Minute)
            {
                timer2.Stop();

                Sounds[SelectedSound].Play();

                MessageBox.Show("Гудок заводской, на работу пора!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DateTime userTime_3 = dateTimePicker_3.Value;
            if (currentTime.Hour == userTime_3.Hour && currentTime.Minute == userTime_3.Minute)
            {
                timer3.Stop();

                Sounds[SelectedSound].Play();

                MessageBox.Show("Гудок заводской, на работу пора!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toggle_buttons1_CheckedChanged(object sender, EventArgs e)
        {                        
            if (toggle_buttons1.Checked == true)
            {
                timer1.Start();
                lblStatus.Text = "Alarm 1 turned on!";               
            }           
            else
            {
                timer1.Stop();
                lblStatus.Text = "Alarm is off";               
            }
        }

        private void toggle_buttons2_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_buttons2.Checked == true)
            {
                timer2.Start();
                lblStatus.Text = "Alarm 2 turned on!";
            }
            else
            {
                timer2.Stop();
                lblStatus.Text = "Alarm is off";
            }
        }

        private void toggle_buttons3_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_buttons3.Checked == true)
            {
                timer3.Start();
                lblStatus.Text = "Alarm 3 turned on!";
            }
            else
            {
                timer3.Stop();
                lblStatus.Text = "Alarm is off";
            }
        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            SelectedSound = comboBoxSound1.SelectedIndex;

            if (comboBoxSound1.SelectedIndex == comboBoxSound1.Items.IndexOf("SmokeAlarm"))
            {
                SmokeAlarm.Play();
            }
            else if (comboBoxSound1.SelectedIndex == comboBoxSound1.Items.IndexOf("SoundAlarm"))
            {
                SoundAlarm.Play();
            }
            else if (comboBoxSound1.SelectedIndex == comboBoxSound1.Items.IndexOf("GongAlarm"))
            {
                GongAlarm.Play();
            }
        }

        private void comboBoxSound2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSound = comboBoxSound2.SelectedIndex;

            if (comboBoxSound2.SelectedIndex == comboBoxSound2.Items.IndexOf("SmokeAlarm"))
            {
                SmokeAlarm.Play();
            }
            else if (comboBoxSound2.SelectedIndex == comboBoxSound2.Items.IndexOf("SoundAlarm"))
            {
                SoundAlarm.Play();
            }
            else if (comboBoxSound2.SelectedIndex == comboBoxSound2.Items.IndexOf("GongAlarm"))
            {
                GongAlarm.Play();
            }
        }

        private void comboBoxSound3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SelectedSound = comboBoxSound3.SelectedIndex;

            if (comboBoxSound3.SelectedIndex == comboBoxSound3.Items.IndexOf("SmokeAlarm"))
            {
                SmokeAlarm.Play();
            }
            else if (comboBoxSound3.SelectedIndex == comboBoxSound3.Items.IndexOf("SoundAlarm"))
            {
                SoundAlarm.Play();
            }
            else if (comboBoxSound3.SelectedIndex == comboBoxSound3.Items.IndexOf("GongAlarm"))
            {
                GongAlarm.Play();
            }
        }
    }
}
