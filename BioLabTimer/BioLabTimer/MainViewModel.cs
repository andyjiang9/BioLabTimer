using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using BioLabTimer.Observables;
using BioLabTimerServices;
using Timer = BioLabTimerServices.Timer;

namespace BioLabTimer
{
    internal class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {
            _timers = new ObservableCollection<TimerTaskViewModel>
            {
                new TimerTaskViewModel(new Timer()
                {
                    Title = "Testing ", 
                    Hours = 1, 
                    Minutes =2, 
                    Seconds =3,
                })
            };
        }

        private ObservableCollection<TimerTaskViewModel> _timers;
        public ObservableCollection<TimerTaskViewModel> Timers
        {
            get => _timers;
            set => SetProperty(ref _timers, value);
        }   
    }
}