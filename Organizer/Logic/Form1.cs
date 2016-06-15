using Organizer.Helpers;

namespace Organizer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using System.Windows.Forms.Calendar;
    using System.Xml.Serialization;
    using Constants;
    using static System.Windows.Forms.Calendar.MonthView;
    using static Organizer.Context;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Monthview colors
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;
            TimeIntervalComboBox.DataSource = new[]
            {
                MonthViewSelection.Manual,
                MonthViewSelection.Day,
                MonthViewSelection.Week,
                MonthViewSelection.Month
            };
            //{
            //    TimeIntervals.None, TimeIntervals.Day, TimeIntervals.Week, TimeIntervals.Month
            //};
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataHelper.LoadItemsFromFile(calendar1);
            PlaceItems();
        }

        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems();
        }

        private void PlaceItems()
        {
            foreach (TaskItem item in _items)
            {
                if (calendar1.ViewIntersects(item.CalendarItem))
                {
                    calendar1.Items.Add(item.CalendarItem);
                }
            }
        }

        private void calendar1_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {
            var newTask = new TaskItem(e.Item);
            _items.Add(newTask);
        }

        private void calendar1_ItemMouseHover(object sender, CalendarItemEventArgs e)
        {
            Text = e.Item.Text;
        }

        private void calendar1_ItemClick(object sender, CalendarItemEventArgs e)
        {
            
        }

        private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            if (_items.Count(i => i.CalendarItem == e.Item)>0)
            {
                var task = _items.First(i => i.CalendarItem == e.Item);
                var editTaskForm = new EditTaskForm(ref task);
                editTaskForm.ShowDialog();
                RefreshCalendar();
            }
        }

#region toolstrip
        private void hourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixtyMinutes;
        }

        private void minutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.ThirtyMinutes;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FifteenMinutes;
        }

        private void minutesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixMinutes;
        }

        private void minutesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.TenMinutes;
        }

        private void minutesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FiveMinutes;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextItem = calendar1.ItemAt(contextMenuStrip1.Bounds.Location);
        }

        private void redTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Red);
                calendar1.Invalidate(item);
            }
        }

        private void yellowTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Gold);
                calendar1.Invalidate(item);
            }
        }

        private void greenTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Green);
                calendar1.Invalidate(item);
            }
        }

        private void blueTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.DarkBlue);
                calendar1.Invalidate(item);
            }
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.ActivateEditMode();
        }

    #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataHelper.SaveItemsToFile();
        }
#region calendar event handlers
        private void otherColorTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (CalendarItem item in calendar1.GetSelectedItems())
                    {
                        item.ApplyColor(dlg.Color);
                        calendar1.Invalidate(item);
                    }
                }
            }
        }
        
        private void calendar1_ItemDeleted(object sender, CalendarItemEventArgs e)
        {
            var itemToDelete = _items.FirstOrDefault(i => i.CalendarItem == e.Item);
            _items.Remove(itemToDelete);
        }

        private void calendar1_DayHeaderClick(object sender, CalendarDayEventArgs e)
        {
            calendar1.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date);
        }

        private void diagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.Vertical;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.Horizontal;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Empty;
                calendar1.Invalidate(item);
            }
        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
        }
#endregion
        public void TimeIntervalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthView1.SelectionMode = (MonthViewSelection)TimeIntervalComboBox.SelectedItem;
            if ((MonthViewSelection)TimeIntervalComboBox.SelectedItem != MonthViewSelection.Manual)
            {
                EmulateMonthViewClick(calendar1.ViewStart);
            }
        }

        private void previousIntervalLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((MonthViewSelection)TimeIntervalComboBox.SelectedItem != MonthViewSelection.Manual)
            {
                EmulateMonthViewClick(calendar1.ViewStart.AddDays(-1));
            }
        }

        private void nextIntervalLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((MonthViewSelection)TimeIntervalComboBox.SelectedItem != MonthViewSelection.Manual)
            {
                EmulateMonthViewClick(calendar1.ViewEnd.Add(new TimeSpan(0, 0, 2)));
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            var newTask = new TaskItem(calendar1);
            var newTaskForm = new EditTaskForm(ref newTask);
            newTaskForm.ShowDialog();
            RefreshCalendar();
        }

        private void RefreshCalendar()
        {
            calendar1.ClearItems();
            PlaceItems();
        }
    }
}
