
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
            this.disturb = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chronologicallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyTimersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyAlarmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCount = new System.Windows.Forms.ToolStripTextBox();
            this.menuCountOfTimers = new System.Windows.Forms.ToolStripTextBox();
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
            this.listOfTimers.Location = new System.Drawing.Point(4, 136);
            this.listOfTimers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listOfTimers.Name = "listOfTimers";
            this.listOfTimers.Size = new System.Drawing.Size(536, 199);
            this.listOfTimers.TabIndex = 0;
            this.listOfTimers.SelectedValueChanged += new System.EventHandler(this.listOfTimers_SelectedValueChanged);
            this.listOfTimers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listOfTimers_KeyDown);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(7, 11);
            this.time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(254, 35);
            this.time.TabIndex = 1;
            this.time.Value = new System.DateTime(2021, 10, 23, 0, 0, 0, 0);
            this.time.KeyDown += new System.Windows.Forms.KeyEventHandler(this.time_KeyDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(4, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 33);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // timerMode
            // 
            this.timerMode.AutoSize = true;
            this.timerMode.Checked = true;
            this.timerMode.Location = new System.Drawing.Point(4, 8);
            this.timerMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timerMode.Name = "timerMode";
            this.timerMode.Size = new System.Drawing.Size(51, 17);
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
            this.alarmMode.Location = new System.Drawing.Point(475, 8);
            this.alarmMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alarmMode.Name = "alarmMode";
            this.alarmMode.Size = new System.Drawing.Size(51, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(-1, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(527, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.deleteButton);
            this.groupBox4.Controls.Add(this.buttonAdd);
            this.groupBox4.Location = new System.Drawing.Point(315, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(208, 38);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(112, 0);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 33);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.disturb);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.alarmMode);
            this.groupBox2.Controls.Add(this.timerMode);
            this.groupBox2.Location = new System.Drawing.Point(4, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(531, 84);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // disturb
            // 
            this.disturb.AutoSize = true;
            this.disturb.Location = new System.Drawing.Point(170, 12);
            this.disturb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disturb.Name = "disturb";
            this.disturb.Size = new System.Drawing.Size(92, 17);
            this.disturb.TabIndex = 12;
            this.disturb.Text = "Do not disturb";
            this.disturb.UseVisualStyleBackColor = true;
            this.disturb.CheckedChanged += new System.EventHandler(this.disturb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.listOfTimers);
            this.groupBox3.Controls.Add(this.menuStrip2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(544, 360);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(4, 340);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(531, 19);
            this.progressBar.TabIndex = 12;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Enabled = false;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuCount,
            this.menuCountOfTimers});
            this.menuStrip2.Location = new System.Drawing.Point(2, 15);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(540, 27);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chronologicallyToolStripMenuItem,
            this.onlyTimersToolStripMenuItem,
            this.onlyAlarmsToolStripMenuItem,
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 23);
            this.toolStripMenuItem1.Text = "Sort Timers";
            // 
            // chronologicallyToolStripMenuItem
            // 
            this.chronologicallyToolStripMenuItem.Checked = true;
            this.chronologicallyToolStripMenuItem.CheckOnClick = true;
            this.chronologicallyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chronologicallyToolStripMenuItem.Name = "chronologicallyToolStripMenuItem";
            this.chronologicallyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.chronologicallyToolStripMenuItem.Text = "chronologically";
            this.chronologicallyToolStripMenuItem.Click += new System.EventHandler(this.chronologicallyToolStripMenuItem_Click);
            // 
            // onlyTimersToolStripMenuItem
            // 
            this.onlyTimersToolStripMenuItem.CheckOnClick = true;
            this.onlyTimersToolStripMenuItem.Name = "onlyTimersToolStripMenuItem";
            this.onlyTimersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.onlyTimersToolStripMenuItem.Text = "only timers";
            this.onlyTimersToolStripMenuItem.Click += new System.EventHandler(this.onlyTimersToolStripMenuItem_Click);
            // 
            // onlyAlarmsToolStripMenuItem
            // 
            this.onlyAlarmsToolStripMenuItem.CheckOnClick = true;
            this.onlyAlarmsToolStripMenuItem.Name = "onlyAlarmsToolStripMenuItem";
            this.onlyAlarmsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.onlyAlarmsToolStripMenuItem.Text = "only alarms";
            this.onlyAlarmsToolStripMenuItem.Click += new System.EventHandler(this.onlyAlarmsToolStripMenuItem_Click);
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.CheckOnClick = true;
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ascendingToolStripMenuItem.Text = "ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.CheckOnClick = true;
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.descendingToolStripMenuItem.Text = "descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // menuCount
            // 
            this.menuCount.Enabled = false;
            this.menuCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuCount.Name = "menuCount";
            this.menuCount.Size = new System.Drawing.Size(76, 23);
            // 
            // menuCountOfTimers
            // 
            this.menuCountOfTimers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuCountOfTimers.Name = "menuCountOfTimers";
            this.menuCountOfTimers.Size = new System.Drawing.Size(114, 23);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 360);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chronologicallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyTimersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyAlarmsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox disturb;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripTextBox menuCount;
        private System.Windows.Forms.ToolStripTextBox menuCountOfTimers;
    }
}

