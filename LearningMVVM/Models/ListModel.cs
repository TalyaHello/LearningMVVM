using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMVVM.Models
{
    public class ListModel : BindableBase
    {
        private readonly ObservableCollection<int> _listValues = new ObservableCollection<int>();
        public readonly  ReadOnlyObservableCollection<int> ListPublicValues;
        public ListModel()
        {
            ListPublicValues = new ReadOnlyObservableCollection<int>(_listValues);
        }

        // adding number in collection and amount change notification
        public void AddValue(int value) {
            _listValues.Add(value);
            RaisePropertyChanged("Sum");
        }

        // validity check, deleting from collection and amount change notification
        public void RemoveValue(int index) {
            // deleting validity check
            if (index >= 0 && index < _listValues.Count) _listValues.RemoveAt(index);
            RaisePropertyChanged("Sum");
        }
        public int Sum => ListPublicValues.Sum();
    }
}
