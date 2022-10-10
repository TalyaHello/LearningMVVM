using LearningMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMVVM.ViewModels
{
    public class AdditionVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private int _number1;
        public int Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                OnPropertyChanged("Result");
            }
        }
        private int _number2;
        public int Number2
        {
            get { return _number2; }
            set
            {
                _number2 = value;
                OnPropertyChanged("Result");
            }
        }
        public int Result
        {
            get
            {
                return MathFuncs.GetSumOf(Number1, Number2);
            }
        }
    }
}
