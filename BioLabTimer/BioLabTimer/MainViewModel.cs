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
                    Hours = 0, 
                    Minutes = 0, 
                    Seconds = 3,
                }),
                new TimerTaskViewModel(new Timer()
                {
                    Title = "Testing 2",
                    Hours = 0,
                    Minutes = 0,
                    Seconds = 5,
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