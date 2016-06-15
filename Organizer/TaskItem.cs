using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.Calendar;
using System.Xml.Serialization;
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
        /*TODO: add smth*/
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        HatchStyle pattern { get; set; }
        Color patternColor { get; set; }
        //private string _title => CalendarItem.Text;
        //private DateTime _startDate => CalendarItem.StartDate;
        //private DateTime _endDateTime => CalendarItem.EndDate;

        [XmlIgnore]
        public CalendarItem CalendarItem { get; set; }

        public TaskItem() { }

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
