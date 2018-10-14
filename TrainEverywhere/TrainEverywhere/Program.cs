using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TrainEverywhere
{
    public class Program : INotifyPropertyChanged
    {
        public string ProgramName { get; set; }
        public User user { get; set; }
        private float raiting;
        public float Raiting
        {
            get => raiting;
            set
            {
                raiting = value;
                this.OnPropertyChanged();
            }
        }
        public Dictionary<string, ObservableCollection<Exercise>> ExerciseList { get; set; }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
