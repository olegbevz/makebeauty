// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DateTimePicker.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DateTimePicker type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.Silverlight.Controls
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    public partial class DateTimePicker
    {
        public DateTimePicker()
        {
            try
            {
                InitializeComponent();

                DatePicker.SelectedDateChanged += OnDateChanged;
                TimePicker.ValueChanged += this.OnTimeChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region SelectedDateTime dependency property

        public DateTime? DateTime
        {
            get
            {
                return (DateTime?)GetValue(DateTimeProperty);
            }
            set
            {
                SetValue(DateTimeProperty, value);
            }
        }

        public static readonly DependencyProperty DateTimeProperty =
            DependencyProperty.Register("DateTime",
            typeof(DateTime?),
            typeof(DateTimePicker),
            new PropertyMetadata(null, DateTimeChanged));

        private static void DateTimeChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                var me = sender as DateTimePicker;

                if (me != null)
                {
                    me.DatePicker.SelectedDate = (DateTime?)e.NewValue;
                    me.TimePicker.Value = (DateTime?)e.NewValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void OnTimeChanged(object sender, RoutedPropertyChangedEventArgs<DateTime?> e)
        {
            try
            {
                if (DatePicker.SelectedDate != TimePicker.Value)
                {
                    DatePicker.SelectedDate = TimePicker.Value;
                }

                if (DateTime != TimePicker.Value)
                {
                    DateTime = TimePicker.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnDateChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                // correct the new date picker date by the time picker's time
                if (DatePicker.SelectedDate.HasValue && TimePicker.Value.HasValue)
                {
                    // get both values
                    DateTime datePickerDate = DatePicker.SelectedDate.Value;
                    DateTime timePickerDate = TimePicker.Value.Value;

                    // compare relevant parts manually
                    if (datePickerDate.Hour != timePickerDate.Hour
                        || datePickerDate.Minute != timePickerDate.Minute
                        || datePickerDate.Second != timePickerDate.Second)
                    {
                        // correct the date picker value
                        DatePicker.SelectedDate = new DateTime(datePickerDate.Year,
                            datePickerDate.Month,
                            datePickerDate.Day,
                            timePickerDate.Hour,
                            timePickerDate.Minute,
                            timePickerDate.Second);

                        // return, because this event handler will be executed a second time
                        return;
                    }
                }

                // now transfer the date picker's value to the time picker
                // and dependency property
                if (TimePicker.Value != DatePicker.SelectedDate)
                {
                    TimePicker.Value = DatePicker.SelectedDate;
                }

                if (DateTime != DatePicker.SelectedDate)
                {
                    DateTime = DatePicker.SelectedDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
