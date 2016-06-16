using System;

namespace Organizer
{
  class ViewTask
  {
    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string Title { get; set; }

    public string NotePlace { get; set; }

    public string Description { get; set; }

    public ViewTask() { }

    public ViewTask(TaskItem task)
    {
      StartTime = task.StartTime;
      EndTime = task.EndTime;
      Title = task.Title;
      NotePlace = task.ShortDescription;
      Description = task.FullDescription;
    }
  }
}
