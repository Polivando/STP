using System;

namespace Organizer
{
    public class XmlTask
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Title { get; set; }

        public long Id { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public int A { get; set; }

        public int R { get; set; }

        public int G { get; set; }

        public int B { get; set; }

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
