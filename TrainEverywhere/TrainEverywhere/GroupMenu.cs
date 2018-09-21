using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TrainEverywhere
{
    //public class GroupMenu : ObservableCollection<MainPageMenuItem>, INotifyPropertyChanged
    //{
    //    private bool _expanded;

    //    public string Header { get; set; }

    //    public int Count { get; set; }

    //    public string TitleWithItemCount
    //    {
    //        get
    //        {
    //            return string.Format("{0} ({1})", Header, Count);
    //        }
    //    }

    //    public bool Expanded
    //    {
    //        get => _expanded;

    //        set
    //        {
    //            if (_expanded != value)
    //            {
    //                _expanded = value;
    //            }
    //        }
    //    }

    //    public GroupMenu(string title, bool expanded = true)
    //    {
    //        Header = title;
    //        Expanded = expanded;
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected void OnPropertyChanged([CallerMemberName]string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //}
}
