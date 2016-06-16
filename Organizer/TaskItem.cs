using System;
using System.Windows.Forms.Calendar;
using Organizer.Helpers;

namespace Organizer
{
    public class TaskItem
    {
        public DateTime StartTime
        {
            get { return CalendarItem.StartDate; }
            set { CalendarItem.StartDate = value; }
        }

        public DateTime EndTime
        {
            get { return CalendarItem.EndDate; }
            set { CalendarItem.EndDate = value; }
        }

        public string Title
        {
            get { return CalendarItem.Text; } 
            set { CalendarItem.Text = value; } 
        }

        public ulong Id { get; private set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public byte A
        {
          get { return CalendarItem.BackgroundColor.A; }
          set {
              CalendarItem.ApplyColor(System.Drawing.Color.FromArgb(
                value, 
                CalendarItem.BackgroundColor.R, 
                CalendarItem.BackgroundColor.G,
                CalendarItem.BackgroundColor.B));
              }
        }
        public byte R 
        {
          get { return CalendarItem.BackgroundColor.R; }
          set {
              CalendarItem.ApplyColor(System.Drawing.Color.FromArgb( 
                CalendarItem.BackgroundColor.A, 
                value,
                CalendarItem.BackgroundColor.G,
                CalendarItem.BackgroundColor.B));
              }
        }
        public byte G 
        {
          get { return CalendarItem.BackgroundColor.G; }
          set {
              CalendarItem.ApplyColor(System.Drawing.Color.FromArgb(
                CalendarItem.BackgroundColor.A, 
                CalendarItem.BackgroundColor.R,
                value, 
                CalendarItem.BackgroundColor.B));
              }
        }
        public byte B
        {
          get { return CalendarItem.BackgroundColor.B; }
          set {
              CalendarItem.ApplyColor(System.Drawing.Color.FromArgb(
                CalendarItem.BackgroundColor.A,
                CalendarItem.BackgroundColor.R, 
                CalendarItem.BackgroundColor.G,
                value));
              }
        }
        
        public CalendarItem CalendarItem { get; set; }
        
        public TaskItem(Calendar calendar)
        {
            Id = SequenceGenerator.GenerateNextValue();
            CalendarItem = new CalendarItem(calendar, DateTime.Now, DateTime.Now.AddMinutes(30), "");
            A = 255;
            R = 135;
            G = 189;
            B = 201;
        }

        public TaskItem(CalendarItem calendarItem)
        {
            Id = SequenceGenerator.GenerateNextValue();
            CalendarItem = calendarItem;
            A = 255;
            R = 135;
            G = 189;
            B = 201;
        }

        public TaskItem(Calendar calendar, XmlTask task)
        {
            Id = task.Id;
            CalendarItem = new CalendarItem(calendar, task.StartTime, task.EndTime, task.Title);
            ShortDescription = task.ShortDescription;
            FullDescription = task.FullDescription;
            A = task.A;
            R = task.R;
            G = task.G;
            B = task.B;
        }
    }
}
