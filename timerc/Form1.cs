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
using System.IO;

namespace timerc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start();

            //string fullPath = Path.GetFullPath("JenixCatchFire.wav");
            //Console.WriteLine(fullPath);
            //sound.SoundLocation = fullPath;
            //sound.Load();
        }

        SoundPlayer sound = new SoundPlayer("JenixCatchFire.wav");  //(@"C:\Users\Kyryl\FKNK_1\2\timerc\timerc\JenixCatchFire.wav");

        List<int> Timers = new List<int>();
        List<int> constTimers = new List<int>();
        List<DateTime> Alarm = new List<DateTime>();
        List<bool> typeOfTimer = new List<bool>();
        string tmpstring;
        bool fldist = false, isChoose = false;
        int minTimer = 0, CountOfTimers = 0;
        DateTime curTime;
        private string IntToStringTime(int time, bool day = false)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            if (!day)
            {
                hours = (time - (time % (3600))) / (3600);
                minutes = (time - time % 60) / 60 - hours * 60;
                seconds = time - hours * 3600 - minutes * 60;
                return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
            }
            else
            {
                int days;
                days = (time - (time % (86400))) / 86400;
                hours = (time - (time % (3600))) / (3600) - days * 24;
                minutes = (time - time % 60) / 60 - hours * 3600 * 24;
                seconds = time - hours * 3600 - minutes * 60;
                return String.Format("{3:00}.{0:00}:{1:00}:{2:00}", hours, minutes, seconds, days);
            }
        }

        private int TimeSpanToInt(TimeSpan time)
        {
            return 86400 * time.Days + 3600 * time.Hours + 60 * time.Minutes + time.Seconds;
        }


        int alarmCount, timerCount;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (typeOfTimer.Count != 0)
            {
                alarmCount = 0;
                timerCount = 0;
                for (int i = 0; i < typeOfTimer.Count; ++i)
                {
                    if (typeOfTimer[i])
                    {
                        if (Timers[timerCount] == 0)
                        {
                            listOfTimers.Items.RemoveAt(i);
                            Timers.RemoveAt(timerCount);
                            typeOfTimer.RemoveAt(i);
                            constTimers.RemoveAt(i);
                            if (!fldist)
                            {
                                sound.Play();
                                MessageBox.Show("Time of " + (timerCount + 1) + " Timer is out");
                                sound.Stop();
                            }
                            --i;
                            --timerCount;
                            --CountOfTimers;
                        }
                        else
                        {
                            --Timers[timerCount];
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
                            constTimers.RemoveAt(i);
                            if (!fldist)
                            {
                                sound.Play();
                                MessageBox.Show("Time of " + (alarmCount + 1) + " Alarm is out");
                                sound.Stop();
                            }
                            --i;
                            --alarmCount;
                            --CountOfTimers;
                        }
                        else
                        {
                            ++alarmCount;
                            ++constTimers[i];
                        }
                    }
                }

                if (chronologicallyToolStripMenuItem.Checked)
                {
                    ShowAllTimers();
                }
                else if(onlyTimersToolStripMenuItem.Checked)
                {
                    ShowOnlyTimers();                   
                }
                else if(onlyAlarmsToolStripMenuItem.Checked)
                {
                    ShowOnlyAlarms();
                }
                else if(ascendingToolStripMenuItem.Checked)
                {
                    ShowADeScending(true);
                }
                else if(descendingToolStripMenuItem.Checked)
                {
                    ShowADeScending(false);
                }

                if (isChoose && index > -1)
                {
                    --progressBar.Value;
                }


                ShowADeScending(false, true);
                int tmpind = -1;
                bool t = true;
                for(int i = 0;i < Timers.Count; ++i)
                {
                    if(minTimer == Timers[i])
                    {
                        tmpind = i;
                        t = true;
                        break;
                    }
                }
                for (int i = 0; i < Alarm.Count; ++i)
                {
                    if (minTimer == TimeSpanToInt(getRemainingTime(Alarm[i])))
                    {
                        tmpind = i;
                        t = false;
                        break;
                    }
                }
                int tmpCount = -1;
                for(int i = 0; i < typeOfTimer.Count; ++i)
                {
                    if (typeOfTimer[i] == t)
                        ++tmpCount;
                    if(tmpCount == tmpind)
                    {
                        menuCount.Text = "Min timer: " + (i+1);
                        break;
                    }
                }

            }
            else
            {
                menuCount.Text = "No Timers";
            }

            if(index > -1 && listOfTimers.Items.Count > 0)
                listOfTimers.SetSelected(index, true);

            menuCountOfTimers.Text = "Count of Timers: " + CountOfTimers;
        }

        private void ShowOnlyTimers()
        {
            listOfTimers.Items.Clear();
            for (int i = 0; i < Timers.Count; ++i)
            {
                listOfTimers.Items.Add(IntToStringTime(Timers[i], false));
            }
        }

        private void ShowOnlyAlarms()
        {
            listOfTimers.Items.Clear();
            for (int i = 0; i < Alarm.Count; ++i)
            {
                listOfTimers.Items.Add(Convert.ToString(Alarm[i]) + " (" + getRemainingTime(Alarm[i]).ToString(@"dd\.hh\:mm\:ss") + ")");
            }
        }

        private void ShowAllTimers()
        {
            listOfTimers.Items.Clear();
            alarmCount = 0;
            timerCount = 0;
            for (int i = 0; i < typeOfTimer.Count; ++i)
            {
                if (typeOfTimer[i])
                {
                    listOfTimers.Items.Add(IntToStringTime(Timers[timerCount]));
                    ++timerCount;
                }
                else
                {
                    listOfTimers.Items.Add(Convert.ToString(Alarm[alarmCount]) + " (" + getRemainingTime(Alarm[alarmCount]).ToString(@"dd\.hh\:mm\:ss") + ")");
                    //Console.WriteLine(Convert.ToString(Alarm[alarmCount]) + " (" + getRemainingTime(Alarm[alarmCount]).ToString(@"dd\.hh\:mm\:ss") + ")");
                    ++alarmCount;
                }
            }
        }

        private void ShowADeScending(bool asc, bool flmin = false)
        {
            List<int> tmpSort = new List<int>();

            for (int i = 0; i < Timers.Count; ++i)
            {
                tmpSort.Add(Timers[i]);
            }

            for (int i = 0; i < Alarm.Count; ++i)
            {
                tmpSort.Add(TimeSpanToInt(getRemainingTime(Alarm[i])));
            }

            tmpSort.Sort();

            if(flmin)
            {
                if (tmpSort.Count != 0)
                    minTimer = tmpSort[0];
                else
                    minTimer = 0;
                return;
            }

            if (!asc) tmpSort.Reverse();

            listOfTimers.Items.Clear();
            bool flAl;
            for (int i = 0; i < tmpSort.Count; ++i)
            {
                flAl = true;

                for (int alarmCount = 0; alarmCount < Alarm.Count; ++alarmCount)
                {
                    Console.WriteLine(IntToStringTime(tmpSort[i], true).ToString() + " " + getRemainingTime(Alarm[alarmCount]).ToString(@"dd\.hh\:mm\:ss"));
                    if (IntToStringTime(tmpSort[i], true) == getRemainingTime(Alarm[alarmCount]).ToString(@"dd\.hh\:mm\:ss"))
                    {

                        listOfTimers.Items.Add(Convert.ToString(Alarm[alarmCount] + " (" + getRemainingTime(Alarm[alarmCount]).ToString(@"dd\.hh\:mm\:ss") + ")"));
                        flAl = false;
                        break;
                    }
                }
                if (flAl)
                    listOfTimers.Items.Add(Convert.ToString(IntToStringTime(tmpSort[i], false)));
            }
        }

        public TimeSpan getRemainingTime(DateTime value)
        {
            DateTime cur = DateTime.Now;

            TimeSpan t = value.Subtract(cur);
            return t; //.ToString(@"dd\.hh\:mm\:ss");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ++CountOfTimers;
            if (timerMode.Checked)
            {
                typeOfTimer.Add(true);
                tmpstring = time.Value.TimeOfDay.ToString();
                listOfTimers.Items.Add(tmpstring);
                Timers.Add(3600 * time.Value.Hour + 60 * time.Value.Minute + time.Value.Second);
                constTimers.Add(3600 * time.Value.Hour + 60 * time.Value.Minute + time.Value.Second);
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
                    listOfTimers.Items.Add(tmpstring + " (" + getRemainingTime(time.Value).ToString(@"dd\.hh\:mm\:ss") + ")");
                    Alarm.Add(time.Value);
                    TimeSpan tmpSpan = getRemainingTime(time.Value);
                    constTimers.Add(0);
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

        int index = -1;

        private void listOfTimers_SelectedValueChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
            isChoose = true; 
            index = listOfTimers.SelectedIndex;

            if (index > -1)
            {
                timerCount = -1;
                alarmCount = -1;
                for (int i = 0; i <= index; ++i)
                {
                    if (typeOfTimer[i])
                        ++timerCount;
                    else
                        ++alarmCount;
                }

                if (typeOfTimer[index])
                {
                    progressBar.Maximum = constTimers[index];
                    progressBar.Value = Timers[timerCount];
                }
                else
                {
                    TimeSpan tmpSpan = getRemainingTime(Alarm[alarmCount]);
                    int max = 86400 * tmpSpan.Days + 3600 * tmpSpan.Hours + 60 * tmpSpan.Minutes + tmpSpan.Seconds;
                    progressBar.Maximum = max;
                    progressBar.Value = max - constTimers[index];
                }
            }
        }

        int count;
        bool fl;

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
            chronologicallyToolStripMenuItem.Checked = true;
            onlyTimersToolStripMenuItem.Checked = false;
            onlyAlarmsToolStripMenuItem.Checked = false;
            ascendingToolStripMenuItem.Checked = false;
            descendingToolStripMenuItem.Checked = false;
        }

        private void onlyTimersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chronologicallyToolStripMenuItem.Checked = false;
            onlyTimersToolStripMenuItem.Checked = true;
            onlyAlarmsToolStripMenuItem.Checked = false;
            ascendingToolStripMenuItem.Checked = false;
            descendingToolStripMenuItem.Checked = false;

            /*listOfTimers.Items.Clear();
            for (int i = 0; i < Timers.Count; ++i)
            {
                listOfTimers.Items.Add(IntToStringTime(Timers[i], false));
            }*/
        }

        private void onlyAlarmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chronologicallyToolStripMenuItem.Checked = false;
            onlyTimersToolStripMenuItem.Checked = false;
            onlyAlarmsToolStripMenuItem.Checked = true;
            ascendingToolStripMenuItem.Checked = false;
            descendingToolStripMenuItem.Checked = false;

            /*listOfTimers.Items.Clear();
            for (int i = 0; i < Alarm.Count; ++i)
            {
                listOfTimers.Items.Add(Convert.ToString(Alarm[i]));
            }*/
        }

        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chronologicallyToolStripMenuItem.Checked = false;
            onlyTimersToolStripMenuItem.Checked = false;
            onlyAlarmsToolStripMenuItem.Checked = false;
            ascendingToolStripMenuItem.Checked = true;
            descendingToolStripMenuItem.Checked = false;
        }

        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chronologicallyToolStripMenuItem.Checked = false;
            onlyTimersToolStripMenuItem.Checked = false;
            onlyAlarmsToolStripMenuItem.Checked = false;
            ascendingToolStripMenuItem.Checked = false;
            descendingToolStripMenuItem.Checked = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            --CountOfTimers;
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
            constTimers.RemoveAt(index);
            listOfTimers.Items.RemoveAt(index);
            deleteButton.Enabled = false;
        }

        private void disturb_CheckedChanged(object sender, EventArgs e)
        {
            if (disturb.Checked)
            {
                fldist = true;
            }
            else
            {
                fldist = false;
            }
        }
    }
}
