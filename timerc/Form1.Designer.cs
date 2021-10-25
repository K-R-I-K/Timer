
namespace timerc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listOfTimers = new System.Windows.Forms.ListBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.timerMode = new System.Windows.Forms.RadioButton();
            this.alarmMode = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chronologicallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyTimersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyAlarmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listOfTimers
            // 
            this.listOfTimers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfTimers.FormattingEnabled = true;
            this.listOfTimers.ItemHeight = 16;
            this.listOfTimers.Location = new System.Drawing.Point(6, 168);
            this.listOfTimers.Name = "listOfTimers";
            this.listOfTimers.Size = new System.Drawing.Size(713, 260);
            this.listOfTimers.TabIndex = 0;
            this.listOfTimers.SelectedValueChanged += new System.EventHandler(this.listOfTimers_SelectedValueChanged);
            this.listOfTimers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listOfTimers_KeyDown);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(9, 13);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(337, 41);
            this.time.TabIndex = 1;
            this.time.Value = new System.DateTime(2021, 10, 23, 0, 0, 0, 0);
            this.time.ValueChanged += new System.EventHandler(this.time_ValueChanged);
            this.time.KeyDown += new System.Windows.Forms.KeyEventHandler(this.time_KeyDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 41);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // timerMode
            // 
            this.timerMode.AutoSize = true;
            this.timerMode.Checked = true;
            this.timerMode.Location = new System.Drawing.Point(6, 10);
            this.timerMode.Name = "timerMode";
            this.timerMode.Size = new System.Drawing.Size(65, 21);
            this.timerMode.TabIndex = 6;
            this.timerMode.TabStop = true;
            this.timerMode.Text = "Timer";
            this.timerMode.UseVisualStyleBackColor = true;
            this.timerMode.CheckedChanged += new System.EventHandler(this.timerMode_CheckedChanged);
            // 
            // alarmMode
            // 
            this.alarmMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alarmMode.AutoSize = true;
            this.alarmMode.Location = new System.Drawing.Point(637, 10);
            this.alarmMode.Name = "alarmMode";
            this.alarmMode.Size = new System.Drawing.Size(65, 21);
            this.alarmMode.TabIndex = 7;
            this.alarmMode.Text = "Alarm";
            this.alarmMode.UseVisualStyleBackColor = true;
            this.alarmMode.CheckedChanged += new System.EventHandler(this.alarmMode_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Location = new System.Drawing.Point(-1, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.deleteButton);
            this.groupBox4.Controls.Add(this.buttonAdd);
            this.groupBox4.Location = new System.Drawing.Point(420, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 47);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(149, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 41);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.alarmMode);
            this.groupBox2.Controls.Add(this.timerMode);
            this.groupBox2.Location = new System.Drawing.Point(6, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 104);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.listOfTimers);
            this.groupBox3.Controls.Add(this.menuStrip1);
            this.groupBox3.Controls.Add(this.menuStrip2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 443);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(3, 46);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 18);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(719, 28);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chronologicallyToolStripMenuItem,
            this.onlyTimersToolStripMenuItem,
            this.onlyAlarmsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 24);
            this.toolStripMenuItem1.Text = "Sort Timers";
            // 
            // chronologicallyToolStripMenuItem
            // 
            this.chronologicallyToolStripMenuItem.Name = "chronologicallyToolStripMenuItem";
            this.chronologicallyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chronologicallyToolStripMenuItem.Text = "chronologically";
            this.chronologicallyToolStripMenuItem.Click += new System.EventHandler(this.chronologicallyToolStripMenuItem_Click);
            // 
            // onlyTimersToolStripMenuItem
            // 
            this.onlyTimersToolStripMenuItem.Name = "onlyTimersToolStripMenuItem";
            this.onlyTimersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.onlyTimersToolStripMenuItem.Text = "only timers";
            this.onlyTimersToolStripMenuItem.Click += new System.EventHandler(this.onlyTimersToolStripMenuItem_Click);
            // 
            // onlyAlarmsToolStripMenuItem
            // 
            this.onlyAlarmsToolStripMenuItem.Name = "onlyAlarmsToolStripMenuItem";
            this.onlyAlarmsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.onlyAlarmsToolStripMenuItem.Text = "only alarms";
            this.onlyAlarmsToolStripMenuItem.Click += new System.EventHandler(this.onlyAlarmsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 443);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listOfTimers;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton timerMode;
        private System.Windows.Forms.RadioButton alarmMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chronologicallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyTimersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyAlarmsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

