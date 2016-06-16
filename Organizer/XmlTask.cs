using System;

namespace Organizer
{
    public class XmlTask
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Title { get; set; }

        public ulong Id { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public byte A { get; set; }
            
        public byte R { get; set; }
         
        public byte G { get; set; }
 
        public byte B { get; set; }

        public XmlTask() { }

        public XmlTask(TaskItem task)
        {
            StartTime = task.StartTime;
            EndTime = task.EndTime;
            Title = task.Title;
            Id = task.Id;
            ShortDescription = task.ShortDescription;
            FullDescription = task.FullDescription;
            A = task.A;
            R = task.R;
            G = task.G;
            B = task.B;
        }
    }
}
