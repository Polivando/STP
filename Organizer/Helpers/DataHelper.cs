using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using System.Xml.Serialization;
using static Organizer.Context;

namespace Organizer.Helpers
{

    public static class DataHelper
    {
        public static FileInfo ItemsFile
        {
            get { return new FileInfo(Path.Combine(Application.StartupPath, "items.xml")); }
        }

        public static void LoadItemsFromFile(Calendar calendar)
        {
            if (ItemsFile.Exists)
            {
                List<XmlTask> lst = new List<XmlTask>();

                XmlSerializer xml = new XmlSerializer(lst.GetType());

                using (Stream s = ItemsFile.OpenRead())
                {
                    lst = xml.Deserialize(s) as List<XmlTask>;
                }

                foreach (XmlTask item in lst)
                {
                    TaskItem task = new TaskItem(calendar, item);

                    if (!(item.R == 0 && item.G == 0 && item.B == 0))
                    {
                        task.CalendarItem.ApplyColor(Color.FromArgb(item.A, item.R, item.G, item.B));
                    }

                    _items.Add(task);
                }
            }
        }

        public static void SaveItemsToFile()
        {
            List<XmlTask> lst = new List<XmlTask>();

            foreach (TaskItem item in _items)
            {
                lst.Add(new XmlTask(item));
            }

            XmlSerializer xmls = new XmlSerializer(lst.GetType());

            if (ItemsFile.Exists)
            {
                ItemsFile.Delete();
            }

            using (Stream s = ItemsFile.OpenWrite())
            {
                xmls.Serialize(s, lst);
                s.Close();
            }
        }
    }
}
