namespace Organizer.Logic
{
  partial class AllTasksForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tasksDataGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // tasksDataGridView
      // 
      this.tasksDataGridView.AllowUserToAddRows = false;
      this.tasksDataGridView.AllowUserToDeleteRows = false;
      this.tasksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tasksDataGridView.Location = new System.Drawing.Point(2, 0);
      this.tasksDataGridView.Name = "tasksDataGridView";
      this.tasksDataGridView.ReadOnly = true;
      this.tasksDataGridView.Size = new System.Drawing.Size(727, 471);
      this.tasksDataGridView.TabIndex = 0;
      // 
      // AllTasksForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(727, 468);
      this.Controls.Add(this.tasksDataGridView);
      this.Name = "AllTasksForm";
      this.Text = "AllTasksForm";
      ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView tasksDataGridView;
  }
}