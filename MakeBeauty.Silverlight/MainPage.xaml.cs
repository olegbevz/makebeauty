namespace MakeBeauty.Silverlight
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel.DomainServices.Client;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    using MakeBeauty.Services.Web;
    using MakeBeauty.Services.Web.Models;

    public partial class MainPage
    {
        private IDictionary<int, string> hairStyleDictionary;

        public MainPage()
        {
            InitializeComponent();

            TaskDomainDataSource.AutoLoad = true;

            TaskDataGrid.DataContext = this;

            TaskDataGrid.ItemsSource = Data;
        }

        private TaskDomainContext DomainContext
        {
            get
            {
                return TaskDomainDataSource.DomainContext as TaskDomainContext;
            }
        }

        private TaskProxy ActiveTask
        {
            get
            {
                return TaskDataGrid.SelectedItem as TaskProxy;
            }
        }

        public IEnumerable Data
        {
            get
            {
                return TaskDomainDataSource.Data;
            }
        }

        public IDictionary<int, string> HairStyleDictionary
        {
            get
            {
                return hairStyleDictionary ?? 
                    (hairStyleDictionary = HairStyleDomainDataSource.Data.Cast<HairStyleProxy>().ToDictionary(
                    entity => entity.Id, entity => entity.Name));
            }
        }

        private void OnDomainDataSourceLoadedData(object sender, LoadedDataEventArgs e)
        {
            if (e.HasError)
            {
                Handle(e.Error);

                e.MarkErrorAsHandled();
            }
        }

        private void OnDeleteButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                DomainContext.TaskProxies.Remove(ActiveTask);

                DomainContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                Handle(ex);
            }
        }

        private void OnCreateButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var entities = DomainContext.Load(DomainContext.CreateQuery());

                entities.Completed += (o, args) =>
                    {
                        var operation = o as LoadOperation<TaskProxy>;

                        if (operation != null)
                        {
                            var task = operation.Entities.First();

                            DomainContext.TaskProxies.Detach(task);

                            DomainContext.TaskProxies.Add(task);

                            DomainContext.SubmitChanges().Completed += (s, ev) => TaskDomainDataSource.Load();
                        }
                    };
            }
            catch (Exception ex)
            {
                Handle(ex);
            }
        }

        private void OnDataGridCellEditEnded(object sender, DataGridCellEditEndedEventArgs e)
        {
            try
            {
                if (e.EditAction == DataGridEditAction.Commit)
                {
                    TaskDataGrid.CommitEdit();

                    DomainContext.SubmitChanges();
                }
                else
                {
                    TaskDataGrid.CancelEdit();

                    DomainContext.RejectChanges();
                }
            }
            catch (Exception ex)
            {
                Handle(ex);
            }
        }

        private void OnDescriptionTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                DomainContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                Handle(ex);
            }
        }
        
        private void Handle(Exception ex, string caption = "Silverlight Error")
        {
            MessageBox.Show(
                 ex.ToString(),
                 caption,
                 MessageBoxButton.OK);
        }

        private void OnComboBoxLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var combo = sender as ComboBox;

                if (combo != null)
                {
                    combo.ItemsSource = HairStyleDictionary;

                    var task = combo.DataContext as TaskProxy;

                    if (task != null)
                    {
                        combo.SelectedValue = task.HairStyleId;

                        combo.SelectionChanged += OnComboBoxSelectionChanged;
                    }
                }
            }
            catch (Exception ex)
            {
                Handle(ex);
            }
        }

        private void OnComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                 var combo = sender as ComboBox;

                 if (combo != null)
                 {
                     var task = combo.DataContext as TaskProxy;

                     if (task != null && task.HairStyleId != (int)combo.SelectedValue)
                     {
                         task.HairStyleId = (int)combo.SelectedValue;

                         TaskDataGrid.CommitEdit();

                         DomainContext.SubmitChanges();
                     }
                 }
            }
            catch (Exception ex)
            {
                Handle(ex);
            }
        }
    }
}
