using System.Collections.Generic;
using System.Windows.Forms.Calendar;

namespace Organizer
{
    public static class Context
    {
        public static List<TaskItem> _items = new List<TaskItem>();
        public static CalendarItem contextItem = null;
    }
}
