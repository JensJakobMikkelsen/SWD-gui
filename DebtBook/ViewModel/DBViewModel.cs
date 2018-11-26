using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmFoundation.Wpf;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Media;
using System.Windows.Data;
using Microsoft.Win32;

namespace DebtBookAssignment
{

   
    public class DebtBook : ObservableCollection<DBModel>, INotifyPropertyChanged
    {
        const string AppTitle = "DebtBook, Group 9";
        bool dirty = false;


        public DebtBook()
        {

        
            if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {

                // In Design mode
                Add(new DBModel("30", "Mike"));
                Add(new DBModel("-10", "Jenzz"));
                Add(new DBModel("1000", "Jonas"));
                Title = "I4/E6SWD" + AppTitle;
            }
            Title = "I4/E6SWD " + AppTitle;
        }

        #region Commands

        ICommand _addCommand;
        public ICommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new RelayCommand(AddDebt)); }
        }

        private void AddDebt()
        {
            // Show Modal Dialog
            var dlg = new AddDebtWindow();
            dlg.Title = "Add New Debtor";
            DBModel newDebtor = new DBModel();
            dlg.DataContext = newDebtor;
            if (dlg.ShowDialog() == true)
            {
                Add(newDebtor);

                newDebtor.addToEdited(newDebtor.Value);
                CurrentDebtor = newDebtor;
                dirty = true;
            }

        }

        ICommand _editCommand;
        public ICommand EditCommand
        {
            get { return _editCommand ?? (_editCommand = new RelayCommand(EditDebtor, DeleteDebtor_CanExecute)); }
        }

        private void EditDebtor()
        {
            // Show Modal Dialog
            var dlg = new EditDebtWindow();
            dlg.Title = "Edit Debtor";
            // Need a temp debtor in case of cancel
            DBModel tempDebtor = new DBModel();
            tempDebtor.Value = CurrentDebtor.Value;
            tempDebtor.Name = currentDebtor.Name;
            tempDebtor.editedValues = currentDebtor.editedValues;

            dlg.DataContext = tempDebtor;
            if (dlg.ShowDialog() == true)
            {
                string temp_price = tempDebtor.Value;

                int x = 0;
                Int32.TryParse(temp_price, out x);

                string current_price = CurrentDebtor.Value;

                int y = 0;
                Int32.TryParse(current_price, out y);

                int z = x + y;

                string final = z.ToString();

                CurrentDebtor.Value = final;
                currentDebtor.Name = tempDebtor.Name;
                currentDebtor.addToEdited(temp_price);

                dirty = true;
            }

        }


        ICommand _deleteCommand;
        public ICommand DeleteCommand
        {
            get { return _deleteCommand ?? (_deleteCommand = new RelayCommand(DeleteDebtor, DeleteDebtor_CanExecute)); }
        }

        private void DeleteDebtor()
        {
            MessageBoxResult res = MessageBox.Show("Are you sure you want to delete this Debtor? " + CurrentDebtor.Name +
                "?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (res == MessageBoxResult.Yes)
            {
                Remove(CurrentDebtor);
                NotifyPropertyChanged("Count");
                dirty = true;
            }
        }

        private bool DeleteDebtor_CanExecute()
        {
            if (Count > 0 && CurrentIndex >= 0)
                return true;
            else
                return false;
        }
   

        ICommand _CloseAppCommand;
        public ICommand CloseAppCommand
        {
            get { return _CloseAppCommand ?? (_CloseAppCommand = new RelayCommand(CloseCommand_Execute)); }
        }

        private void CloseCommand_Execute()
        {
            bool regret = false;

            if (dirty)
            {
                MessageBoxResult res = MessageBox.Show("You have unsaved data. Are you sure you want to close the application without saving data first?",
                    "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                if (res == MessageBoxResult.No)
                {
                    regret = true;
                }
            }
            if (!regret)
                Application.Current.MainWindow.Close();
        }


        #endregion // Commands

        #region Properties

        int currentIndex = -1;

        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                if (currentIndex != value)
                {
                    currentIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }

        DBModel currentDebtor = null;

        public DBModel CurrentDebtor
        {
            get { return currentDebtor; }
            set
            {
                if (currentDebtor != value)
                {
                    currentDebtor = value;
                    NotifyPropertyChanged();
                }
            }
        }

     

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public new event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
