using System;
using System.ComponentModel;

namespace Core.Common.Core
{
    public class ItemPropertyChangedEventArgs<T> : EventArgs
           where T : INotifyPropertyChanged
    {
        public ItemPropertyChangedEventArgs(T item, string propertyName)
        {
            Item = item;
            PropertyName = propertyName;
        }

        public T Item { get; set; }
        public string PropertyName { get; set; }
    }
}
