using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BioLabTimerInterfaces;

namespace BioLabTimer.Observables
{
    internal class TimerTaskViewModel : ObservableObject, ITimerRunnable
    {
        private readonly ITimer _timer;

        public TimerTaskViewModel(ITimer timer)
        {
            FlipCommand = new RelayCommand(FlipCommandImpl);
            CancelCommand = new RelayCommand(CancelCommandImpl);
            EditCommand = new RelayCommand(EditCommandImpl);
            DeleteCommand = new RelayCommand(DeleteCommandImpl);

            _timer = timer;
            ResetTimer();
        }

        private void ResetTimer()
        {
            if (_cancellationSource != null) 
                _cancellationSource.Cancel();

            Title = _timer.Title;
            Hours = _timer.Hours;
            Minutes = _timer.Minutes;
            Seconds = _timer.Seconds;
            StartTime = default(DateTime?);
            EndTime = default(DateTime?);
            RunnableStatus = TimerStatuses.Stopped;

            _target = 3600 * Hours + 60 * Minutes + Seconds;
        }

        private int _hours;
        public int Hours
        {
            get => _hours;
            set
            {
                SetProperty(ref _hours, value);
                OnPropertyChanged(nameof(TimeRemaining));
            }
        }

        private int _minutes;
        public int Minutes
        {
            get => _minutes;
            set
            {
                SetProperty(ref _minutes, value);
                OnPropertyChanged(nameof(TimeRemaining));
            }
        }

        private int _seconds;
        public int Seconds
        {
            get => _seconds;
            set
            {
                SetProperty(ref _seconds, value);
                OnPropertyChanged(nameof(TimeRemaining));
            }
        }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private TimerStatuses _runnableStatus;
        public TimerStatuses RunnableStatus
        {
            get => _runnableStatus;
            set
            {
                SetProperty(ref _runnableStatus, value);
                FlipText = value == TimerStatuses.Stopped
                ? "Start"
                : "Pause";
            }
        }

        private DateTime? _startTime;
        public DateTime? StartTime
        {
            get => _startTime;
            set => SetProperty(ref _startTime, value);
        }

        private DateTime? _endTime;
        public DateTime? EndTime
        {
            get => _endTime;
            set => SetProperty(ref _endTime, value);
        }

        public string TimeRemaining => $"{_hours}:{_minutes}:{_seconds}";

        private string _flipText;
        public string FlipText
        {
            get => _flipText;
            set => SetProperty(ref _flipText, value);
        }

        #region Commands
        public RelayCommand FlipCommand { get; }

        private void FlipCommandImpl()
        {
            RunnableStatus = _runnableStatus == TimerStatuses.Stopped
                ? TimerStatuses.Running
                : TimerStatuses.Stopped;

            if (RunnableStatus == TimerStatuses.Running && Target > 0)
                StartTimer();
        }

        public RelayCommand CancelCommand { get; }

        private void CancelCommandImpl()
        {
            ResetTimer();
        }
        public RelayCommand EditCommand { get; }

        private void EditCommandImpl()
        {
            //TODO: Popup the TimerDetails
        }

        public RelayCommand DeleteCommand { get; }

        private void DeleteCommandImpl()
        {
            //TODO: Delete the timer
        }


        #endregion

        #region Timer
        private int _target;

        private int Target { get => _target;
            set
            {
                SetProperty(ref _target, value);
                Hours = _target / 3600;
                Minutes = (_target - (Hours * 3600)) / 60;
                Seconds = _target - (Hours * 3600) - (Minutes*60);
            }
        }

        CancellationTokenSource _cancellationSource = new CancellationTokenSource();
        private void StartTimer()
        {
            _cancellationSource = new CancellationTokenSource();
            var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            var task = new Task(async () =>
            {
                // create a timer which will call back in 1 second
                var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

                // wait for call back
                while (await timer.WaitForNextTickAsync())
                { 
                    if(_cancellationSource.IsCancellationRequested)
                    {
                        timer.Dispose();
                        break;
                    }

                    if (Target > 0)
                        Target--;
                    else
                        timer.Dispose();
                }
            }, _cancellationSource.Token);

            task.Start();
        }

        #endregion
    }
}
