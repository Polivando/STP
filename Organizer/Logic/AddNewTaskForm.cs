using System;
using System.Linq;
using System.Windows.Forms;
using static Organizer.Context;

namespace Organizer
{
    public partial class EditTaskForm : Form
    {
        private TaskItem _task;
        public EditTaskForm(ref TaskItem task)
        {
            InitializeComponent();
            if (task != null)
            {
                TitleTextBox.Text = task.Title;
                ShortDescriptionTextBox.Text = task.ShortDescription;
                DescriptionRichTextBox.Text = task.FullDescription;
                StartDateTimePicker.Value = task.StartTime;
                EndDateTimePicker.Value = task.EndTime;
            }
            else
            {
                StartDateTimePicker.Value = DateTime.Now;
                EndDateTimePicker.Value = DateTime.Now.AddMinutes(30);
            }
            _task = task;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _task.Title = TitleTextBox.Text;
            _task.ShortDescription = ShortDescriptionTextBox.Text;
            _task.FullDescription = DescriptionRichTextBox.Text;
            _task.StartTime = StartDateTimePicker.Value;
            _task.EndTime = EndDateTimePicker.Value;

            if (!_items.Select(i => i.Id).Contains(_task.Id))
                _items.Add(_task);
            else if (_items.Remove(_items.First(i => i.Id == _task.Id)))
                _items.Add(_task);
                    else throw new Exception("Error on rewriting the task");
            MessageBox.Show("Successfully saved");
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        public void AddNewTaskForm_FormClosing(object sender, EventArgs e) => _task = null;
    }
}
