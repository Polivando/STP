using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer.Logic
{
  public partial class AllTasksForm : Form
  {
    private List<ViewTask> _rows;

    public AllTasksForm()
    {
      InitializeComponent();
      _rows = new List<ViewTask>();
      foreach (var item in Context._items)
      {
        _rows.Add(new ViewTask(item));
      }
      _rows.Sort((lhs, rhs) => { return (lhs.StartTime > rhs.StartTime)? 1 : -1 ; } );
      tasksDataGridView.DataSource = _rows;
    }

    //private void _TasksChanged()//how to call it on some outer event?
    //{
    //  _rows = new List<ViewTask>();
    //  foreach (var item in Context._items)
    //  {
    //    _rows.Add(new ViewTask(item));
    //  }
    //  tasksDataGridView.DataSource = _rows;
    //}
  }
}
