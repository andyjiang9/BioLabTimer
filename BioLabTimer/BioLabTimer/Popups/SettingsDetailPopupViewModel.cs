using BioLabTimerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioLabTimerServices;


namespace BioLabTimer.Popups
{
    public class SettingsDetailPopupViewModel
    {
        public string Path { get; set; } = String.Empty;

        public void Save()
        {
            var service = new SettingsService();


            service.SaveFilePath(new Settings
            {
                FilePath = this.Path
            }); ;
        }
    }
}
