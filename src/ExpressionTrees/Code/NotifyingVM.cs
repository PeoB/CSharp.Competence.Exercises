using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace ExpressionTrees.Code
{
    public class NotifyingVM:INotifyPropertyChanged
    {
        private int _index;
        public event PropertyChangedEventHandler PropertyChanged;

        public int Index
        {
            get { return _index; }
            set { _index = value; 
                NotifyPropertyChanged(()=>Index);
            }
        }

        public virtual void NotifyPropertyChanged<T>(Expression<Func<T>> expression)
        {
            //This should call OnPropertyChanged with the name of the property in the func
            //Hint: http://msdn.microsoft.com/en-us/library/bb506649.aspx
            
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}