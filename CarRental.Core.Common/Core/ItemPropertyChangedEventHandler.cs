using System.ComponentModel;

namespace Core.Common.Core
{
    public delegate void ItemPropertyChangedEventHandler<T>(object sender, ItemPropertyChangedEventArgs<T> e)
            where T : INotifyPropertyChanged;
}
