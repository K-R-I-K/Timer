using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace timerc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        SoundPlayer sound = new SoundPlayer(@"C:\Users\Kyryl\FKNK_1\2\timerc\timerc\Jenix-Catch Fire.wav");
        List<int> Timers = new List<int>();
        List<DateTime> Alarm = new List<DateTime>();
        List<bool> typeOfTimer = new List<bool>();
        string tmpstring;
        bool flsort = true;
        //int tmptime, tmpday;
        //Tuple<int, int> tmppair;
        DateTime curTime;
        private string IntToStringTime(int time)
        {
            int hours = (time - (time % (3600))) / (3600);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 3600 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }

        int alarmCount, timerCount;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listOfTimers.Items.Count != 0)
            {
                alarmCount = 0;
                timerCount = 0;
                for (int i = 0; i < listOfTimers.Items.Count; ++i)
                {
                    if (typeOfTimer[i])
                    {
                        if (Timers[timerCount] == 0)
                        {
                            listOfTimers.Items.RemoveAt(i);
                            Timers.RemoveAt(timerCount);
                            typeOfTimer.RemoveAt(i);
                            sound.Play();
                            MessageBox.Show("Time of " + (timerCount + 1) + " Timer is out");
                            sound.Stop();
                            --i;
                        }
                        else
                        {
                            --Timers[timerCount];
                            if(flsort) listOfTimers.Items[i] = IntToStringTime(Timers[timerCount]);
                            ++timerCount;
                        }
                    }
                    else
                    {
                        curTime = DateTime.Now;
                        if (Alarm[alarmCount] <= curTime)
                        {
                            listOfTimers.Items.RemoveAt(i);
                            Alarm.RemoveAt(alarmCount);
                            typeOfTimer.RemoveAt(i);
                            sound.Play();
                            MessageBox.Show("Time of " + (alarmCount + 1) + " Alarm is out");
                            sound.Stop();
                            --i;
                        }
                        else
                            ++alarmCount;
                    }
                }


            }
        }

        private void ShowOnlyTimers()
        {
            for (int i = 0; i < Timers.Count; ++i)
            {
                listOfTimers.Items.Add(IntToStringTime(Timers[i]));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (timerMode.Checked)
            {
                typeOfTimer.Add(true);
                tmpstring = time.Value.TimeOfDay.ToString();
                listOfTimers.Items.Add(tmpstring);
                Timers.Add(3600 * time.Value.Hour + 60 * time.Value.Minute + time.Value.Second);
            }
            else
            {
                curTime = DateTime.Now;
                if (time.Value <= curTime)
                {
                    MessageBox.Show("enter time < current time");
                }
                else
                {
                    typeOfTimer.Add(false);
                    tmpstring = time.Value.ToString();
                    listOfTimers.Items.Add(tmpstring);
                    Alarm.Add(time.Value);
                }
            }
        }

        private void timerMode_CheckedChanged(object sender, EventArgs e)
        {
            time.Format = DateTimePickerFormat.Time;
            time.Value = DateTime.Now.Date;
        }        

        private void alarmMode_CheckedChanged(object sender, EventArgs e)
        {
            time.Format = DateTimePickerFormat.Custom;
            time.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            curTime = DateTime.Now;
            time.Value = curTime;
        }

        int index;

        private void listOfTimers_SelectedValueChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
            index = listOfTimers.SelectedIndex;
        }

        int count;
        bool fl;

        private void time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void time_KeyDown(object sender, KeyEventArgs e)
        {
            /*if(e.KeyCode == Keys.Tab)
            {
                buttonAdd_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }*/
        }

        private void listOfTimers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteButton_Click(sender, e);
            }
        }

        private void chronologicallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOfTimers.Items.Clear();
            timerCount = 0;
            alarmCount = 0;
            for(int i = 0; i < typeOfTimer.Count; ++i)
            {
                if(typeOfTimer[i])
                {
                    listOfTimers.Items.Add(IntToStringTime(Timers[timerCount]));
                    timerCount++;
                }
                else
                {
                    listOfTimers.Items.Add(Convert.ToString(Alarm[alarmCount]));
                    alarmCount++;
                }
            }
        }

        private void onlyTimersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flsort = true;
            listOfTimers.Items.Clear();
            for (int i = 0; i < Timers.Count; ++i)
            {
                listOfTimers.Items.Add(IntToStringTime(Timers[i]));
            }
        }

        private void onlyAlarmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flsort = false;
            listOfTimers.Items.Clear();
            for (int i = 0; i < Alarm.Count; ++i)
            {
                listOfTimers.Items.Add(Convert.ToString(Alarm[i]));
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            count = -1;
            fl = typeOfTimer[index];
            DateTime tmp = DateTime.Now.Date;
            for (int i = 0; i <= index; ++i)
                if (fl == typeOfTimer[i])
                    ++count;
            if (fl)
                Timers.RemoveAt(count);
            else
                Alarm.RemoveAt(count);
            typeOfTimer.RemoveAt(index);
            listOfTimers.Items.RemoveAt(index);
            deleteButton.Enabled = false;
        }
    }
}
