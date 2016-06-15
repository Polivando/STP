namespace Organizer
{

    using System;
    using Constants;
    using System.Windows.Forms;
    using static System.Windows.Forms.Calendar.MonthView;
    public partial class Form1
    {
        private void EmulateMonthViewClick(DateTime day)
        {
            switch ((MonthViewSelection)TimeIntervalComboBox.SelectedItem)
            {
                case MonthViewSelection.Day:
                    monthView1.SelectDay(day.Date);
                    break;
                case MonthViewSelection.Week:
                    monthView1.SelectWeek(day.Date);
                    break;
                case MonthViewSelection.Month:
                    monthView1.SelectMonth(day.Date);
                    break;
            }

        }
        //private void SetCalendarViewTo(DateTime dayFrom, DateTime dayTo)
        //{
        //    if (calendar1.ViewEnd > dayFrom)
        //    {
        //        calendar1.ViewStart = dayFrom;
        //        calendar1.ViewEnd = dayTo;
        //    }
        //    else
        //    {
        //        calendar1.ViewEnd = dayTo;
        //        calendar1.ViewStart = dayFrom;
        //    }
        //}
        //private void DisplayPeriodWithDay(DateTime day, string period)
        //{
        //    switch (period)
        //    {
        //        case TimeIntervals.None:
        //            break;

        //        case TimeIntervals.Day:
        //            SetCalendarViewTo(day, day);
        //            break;

        //        case TimeIntervals.Week:
        //            var diff = day.DayOfWeek - calendar1.FirstDayOfWeek;
        //            SetCalendarViewTo(day.AddDays(-diff), day.AddDays(6-diff));
        //            break;

        //        case TimeIntervals.Month:
        //            SetCalendarViewTo(day.AddDays(1 - day.Day), day.AddDays(- day.Day).AddMonths(1));
        //            break;
        //    }
        //}

        //private void DisplayAdjacentPeriod(DateTime dayToDisplay, string period, bool next)
        //{
        //    int shifhDirection = (next) ? (1) : (-1);
        //    switch (period)
        //    {
        //        case TimeIntervals.None:
        //            return;
        //            break;

        //        case TimeIntervals.Day:
        //            dayToDisplay = calendar1.ViewStart.AddDays(shifhDirection * 1);
        //            break;

        //        case TimeIntervals.Week:
        //            dayToDisplay = calendar1.ViewStart.AddDays(shifhDirection * 7);
        //            break;

        //        case TimeIntervals.Month:
        //            dayToDisplay = calendar1.ViewStart.AddMonths(shifhDirection  * 1);
        //            break;
        //    }
        //    DisplayPeriodWithDay(dayToDisplay, TimeIntervalComboBox.SelectedItem.ToString());
        //}
    }
}
