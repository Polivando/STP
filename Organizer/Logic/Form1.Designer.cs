﻿namespace Organizer
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
      System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
      System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
      System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
      System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
      System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.redTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.yellowTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.greenTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.blueTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.otherColorTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.patternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.diagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.timescaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.minutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.minutesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.minutesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.minutesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
      this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.label1 = new System.Windows.Forms.Label();
      this.TimeIntervalComboBox = new System.Windows.Forms.ComboBox();
      this.previousIntervalLinkLabel = new System.Windows.Forms.LinkLabel();
      this.nextIntervalLinkLabel = new System.Windows.Forms.LinkLabel();
      this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
      this.monthView1 = new System.Windows.Forms.Calendar.MonthView();
      this.AddTaskButton = new System.Windows.Forms.Button();
      this.viewTaskButton = new System.Windows.Forms.Button();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redTagToolStripMenuItem,
            this.yellowTagToolStripMenuItem,
            this.greenTagToolStripMenuItem,
            this.blueTagToolStripMenuItem,
            this.otherColorTagToolStripMenuItem,
            this.toolStripMenuItem1,
            this.patternToolStripMenuItem,
            this.timescaleToolStripMenuItem,
            this.toolStripMenuItem5,
            this.editItemToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(164, 192);
      this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
      // 
      // redTagToolStripMenuItem
      // 
      this.redTagToolStripMenuItem.Name = "redTagToolStripMenuItem";
      this.redTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.redTagToolStripMenuItem.Text = "Red tag";
      this.redTagToolStripMenuItem.Click += new System.EventHandler(this.redTagToolStripMenuItem_Click);
      // 
      // yellowTagToolStripMenuItem
      // 
      this.yellowTagToolStripMenuItem.Name = "yellowTagToolStripMenuItem";
      this.yellowTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.yellowTagToolStripMenuItem.Text = "Yellow tag";
      this.yellowTagToolStripMenuItem.Click += new System.EventHandler(this.yellowTagToolStripMenuItem_Click);
      // 
      // greenTagToolStripMenuItem
      // 
      this.greenTagToolStripMenuItem.Name = "greenTagToolStripMenuItem";
      this.greenTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.greenTagToolStripMenuItem.Text = "Green tag";
      this.greenTagToolStripMenuItem.Click += new System.EventHandler(this.greenTagToolStripMenuItem_Click);
      // 
      // blueTagToolStripMenuItem
      // 
      this.blueTagToolStripMenuItem.Name = "blueTagToolStripMenuItem";
      this.blueTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.blueTagToolStripMenuItem.Text = "Blue tag";
      this.blueTagToolStripMenuItem.Click += new System.EventHandler(this.blueTagToolStripMenuItem_Click);
      // 
      // otherColorTagToolStripMenuItem
      // 
      this.otherColorTagToolStripMenuItem.Name = "otherColorTagToolStripMenuItem";
      this.otherColorTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.otherColorTagToolStripMenuItem.Text = "Other color tag...";
      this.otherColorTagToolStripMenuItem.Click += new System.EventHandler(this.otherColorTagToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
      // 
      // patternToolStripMenuItem
      // 
      this.patternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagonalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.hatchToolStripMenuItem,
            this.toolStripMenuItem3,
            this.noneToolStripMenuItem});
      this.patternToolStripMenuItem.Name = "patternToolStripMenuItem";
      this.patternToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.patternToolStripMenuItem.Text = "Pattern";
      // 
      // diagonalToolStripMenuItem
      // 
      this.diagonalToolStripMenuItem.Name = "diagonalToolStripMenuItem";
      this.diagonalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.diagonalToolStripMenuItem.Text = "Diagonal";
      this.diagonalToolStripMenuItem.Click += new System.EventHandler(this.diagonalToolStripMenuItem_Click);
      // 
      // verticalToolStripMenuItem
      // 
      this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
      this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.verticalToolStripMenuItem.Text = "Vertical";
      this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
      // 
      // horizontalToolStripMenuItem
      // 
      this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
      this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.horizontalToolStripMenuItem.Text = "Horizontal";
      this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
      // 
      // hatchToolStripMenuItem
      // 
      this.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem";
      this.hatchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.hatchToolStripMenuItem.Text = "Cross";
      this.hatchToolStripMenuItem.Click += new System.EventHandler(this.hatchToolStripMenuItem_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 6);
      // 
      // noneToolStripMenuItem
      // 
      this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
      this.noneToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.noneToolStripMenuItem.Text = "None";
      this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
      // 
      // timescaleToolStripMenuItem
      // 
      this.timescaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hourToolStripMenuItem,
            this.minutesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.minutesToolStripMenuItem1,
            this.minutesToolStripMenuItem2,
            this.minutesToolStripMenuItem3});
      this.timescaleToolStripMenuItem.Name = "timescaleToolStripMenuItem";
      this.timescaleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.timescaleToolStripMenuItem.Text = "Timescale";
      // 
      // hourToolStripMenuItem
      // 
      this.hourToolStripMenuItem.Name = "hourToolStripMenuItem";
      this.hourToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
      this.hourToolStripMenuItem.Text = "1 hour";
      this.hourToolStripMenuItem.Click += new System.EventHandler(this.hourToolStripMenuItem_Click);
      // 
      // minutesToolStripMenuItem
      // 
      this.minutesToolStripMenuItem.Name = "minutesToolStripMenuItem";
      this.minutesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
      this.minutesToolStripMenuItem.Text = "30 minutes";
      this.minutesToolStripMenuItem.Click += new System.EventHandler(this.minutesToolStripMenuItem_Click);
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(132, 22);
      this.toolStripMenuItem4.Text = "15 minutes";
      this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
      // 
      // minutesToolStripMenuItem1
      // 
      this.minutesToolStripMenuItem1.Name = "minutesToolStripMenuItem1";
      this.minutesToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
      this.minutesToolStripMenuItem1.Text = "10 minutes";
      this.minutesToolStripMenuItem1.Click += new System.EventHandler(this.minutesToolStripMenuItem1_Click);
      // 
      // minutesToolStripMenuItem2
      // 
      this.minutesToolStripMenuItem2.Name = "minutesToolStripMenuItem2";
      this.minutesToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
      this.minutesToolStripMenuItem2.Text = "6 minutes";
      this.minutesToolStripMenuItem2.Click += new System.EventHandler(this.minutesToolStripMenuItem2_Click);
      // 
      // minutesToolStripMenuItem3
      // 
      this.minutesToolStripMenuItem3.Name = "minutesToolStripMenuItem3";
      this.minutesToolStripMenuItem3.Size = new System.Drawing.Size(132, 22);
      this.minutesToolStripMenuItem3.Text = "5 minutes";
      this.minutesToolStripMenuItem3.Click += new System.EventHandler(this.minutesToolStripMenuItem3_Click);
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(160, 6);
      // 
      // editItemToolStripMenuItem
      // 
      this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
      this.editItemToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
      this.editItemToolStripMenuItem.Text = "Edit item title";
      this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
      // 
      // splitter1
      // 
      this.splitter1.Location = new System.Drawing.Point(208, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(5, 661);
      this.splitter1.TabIndex = 4;
      this.splitter1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(220, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Selection method:";
      // 
      // TimeIntervalComboBox
      // 
      this.TimeIntervalComboBox.FormattingEnabled = true;
      this.TimeIntervalComboBox.Location = new System.Drawing.Point(318, 10);
      this.TimeIntervalComboBox.Name = "TimeIntervalComboBox";
      this.TimeIntervalComboBox.Size = new System.Drawing.Size(121, 21);
      this.TimeIntervalComboBox.TabIndex = 6;
      this.TimeIntervalComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeIntervalComboBox_SelectedIndexChanged);
      // 
      // previousIntervalLinkLabel
      // 
      this.previousIntervalLinkLabel.AutoSize = true;
      this.previousIntervalLinkLabel.Location = new System.Drawing.Point(445, 13);
      this.previousIntervalLinkLabel.Name = "previousIntervalLinkLabel";
      this.previousIntervalLinkLabel.Size = new System.Drawing.Size(68, 13);
      this.previousIntervalLinkLabel.TabIndex = 7;
      this.previousIntervalLinkLabel.TabStop = true;
      this.previousIntervalLinkLabel.Text = "Previous unit";
      this.previousIntervalLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.previousIntervalLinkLabel_LinkClicked);
      // 
      // nextIntervalLinkLabel
      // 
      this.nextIntervalLinkLabel.AutoSize = true;
      this.nextIntervalLinkLabel.Location = new System.Drawing.Point(519, 13);
      this.nextIntervalLinkLabel.Name = "nextIntervalLinkLabel";
      this.nextIntervalLinkLabel.Size = new System.Drawing.Size(49, 13);
      this.nextIntervalLinkLabel.TabIndex = 8;
      this.nextIntervalLinkLabel.TabStop = true;
      this.nextIntervalLinkLabel.Text = "Next unit";
      this.nextIntervalLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nextIntervalLinkLabel_LinkClicked);
      // 
      // calendar1
      // 
      this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.calendar1.ContextMenuStrip = this.contextMenuStrip1;
      this.calendar1.FirstDayOfWeek = System.DayOfWeek.Monday;
      this.calendar1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
      calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
      calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
      calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
      calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
      calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
      calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
      calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
      calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
      calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
      calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
      calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
      calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
      calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
      calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
      this.calendar1.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
      this.calendar1.ItemsTimeFormat = "HH:MM";
      this.calendar1.Location = new System.Drawing.Point(214, 37);
      this.calendar1.Name = "calendar1";
      this.calendar1.Size = new System.Drawing.Size(969, 624);
      this.calendar1.TabIndex = 2;
      this.calendar1.Text = "calendar1";
      this.calendar1.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems);
      this.calendar1.DayHeaderClick += new System.Windows.Forms.Calendar.Calendar.CalendarDayEventHandler(this.calendar1_DayHeaderClick);
      this.calendar1.ItemCreated += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.calendar1_ItemCreated);
      this.calendar1.ItemDeleted += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemDeleted);
      this.calendar1.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemDoubleClick);
      this.calendar1.ItemMouseHover += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemMouseHover);
      // 
      // monthView1
      // 
      this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
      this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
      this.monthView1.DayBackgroundColor = System.Drawing.Color.Empty;
      this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
      this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
      this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
      this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
      this.monthView1.Dock = System.Windows.Forms.DockStyle.Left;
      this.monthView1.FirstDayOfWeek = System.DayOfWeek.Monday;
      this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
      this.monthView1.Location = new System.Drawing.Point(0, 0);
      this.monthView1.MaxSelectionCount = 35;
      this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
      this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
      this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
      this.monthView1.Name = "monthView1";
      this.monthView1.SelectionMode = System.Windows.Forms.Calendar.MonthView.MonthViewSelection.Week;
      this.monthView1.Size = new System.Drawing.Size(208, 661);
      this.monthView1.TabIndex = 3;
      this.monthView1.Text = "monthView1";
      this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
      this.monthView1.SelectionChanged += new System.EventHandler(this.monthView1_SelectionChanged);
      // 
      // AddTaskButton
      // 
      this.AddTaskButton.Location = new System.Drawing.Point(574, 8);
      this.AddTaskButton.Name = "AddTaskButton";
      this.AddTaskButton.Size = new System.Drawing.Size(70, 23);
      this.AddTaskButton.TabIndex = 9;
      this.AddTaskButton.Text = "Add task";
      this.AddTaskButton.UseVisualStyleBackColor = true;
      this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
      // 
      // viewTaskButton
      // 
      this.viewTaskButton.Location = new System.Drawing.Point(650, 8);
      this.viewTaskButton.Name = "viewTaskButton";
      this.viewTaskButton.Size = new System.Drawing.Size(88, 23);
      this.viewTaskButton.TabIndex = 10;
      this.viewTaskButton.Text = "View all tasks";
      this.viewTaskButton.UseVisualStyleBackColor = true;
      this.viewTaskButton.Click += new System.EventHandler(this.viewTaskButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1184, 661);
      this.Controls.Add(this.viewTaskButton);
      this.Controls.Add(this.AddTaskButton);
      this.Controls.Add(this.nextIntervalLinkLabel);
      this.Controls.Add(this.previousIntervalLinkLabel);
      this.Controls.Add(this.TimeIntervalComboBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.calendar1);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.monthView1);
      this.Name = "Form1";
      this.Text = "Calendar Demo";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timescaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem otherColorTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.Calendar.MonthView monthView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TimeIntervalComboBox;
        private System.Windows.Forms.LinkLabel previousIntervalLinkLabel;
        private System.Windows.Forms.LinkLabel nextIntervalLinkLabel;
        private System.Windows.Forms.Button AddTaskButton;
    private System.Windows.Forms.Button viewTaskButton;
  }
}

