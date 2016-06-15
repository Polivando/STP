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
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        
        public CalendarItem CalendarItem { get; set; }
        
        public TaskItem(Calendar calendar)
        {
            Id = SequenceGenerator.GenerateNextValue();
            CalendarItem = new CalendarItem(calendar, DateTime.Now, DateTime.Now.AddMinutes(30), "");
        }

        public TaskItem(CalendarItem calendarItem)
        {
            Id = SequenceGenerator.GenerateNextValue();
            CalendarItem = calendarItem;
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
