using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DebtBookAssignment
{
    
    public class DBModel : INotifyPropertyChanged
    {
        public List<string> editedValues;


        public List<string> EditedValues
        {
            get
            {
                return editedValues;
            }
            set
            {
                if (editedValues != value)
                {
                    editedValues = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public void addToEdited(string value)
        {
            editedValues.Add(value);
        }



        string _value;
        string _name;

        public DBModel()
        {
            editedValues = new List<string>();
        }

        public DBModel(string value, string aName)
        {
            editedValues = new List<string>();
            _value = value;
            _name = aName;
        }

        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }



        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

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
