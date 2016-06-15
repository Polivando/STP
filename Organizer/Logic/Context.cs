using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Calendar;

namespace Organizer
{
    public static class Context
    {
        public static List<TaskItem> _items = new List<TaskItem>();
        public static CalendarItem contextItem = null;
    }
}
