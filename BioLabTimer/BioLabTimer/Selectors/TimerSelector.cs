using BioLabTimerInterfaces;

namespace BioLabTimer.Selectors
{
    public class TimerSelector : DataTemplateSelector
    {
        public DataTemplate TimerStoppedTemplate { get; set; }
        public DataTemplate TimerRunningTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var timer = (ITimerRunnable) item;

            return timer.RunnableStatus switch
            {
                TimerStatuses.Stopped => TimerStoppedTemplate,
                TimerStatuses.Running => TimerRunningTemplate,
                _ => TimerStoppedTemplate
            };
        }
    }
}
