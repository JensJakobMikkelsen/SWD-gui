using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DebtBookAssignment
{

    public class EditedDBModel : INotifyPropertyChanged
    {
        public List<string> editedDBModels_ { get; set; }


        public EditedDBModel()
        {
            editedDBModels_ = new List<string>();
        }

        public void AddTo(string changedData)
        {
            editedDBModels_.Add(changedData);
        }


        string _value;

        public EditedDBModel(string value)
        {
            _value = value;
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
