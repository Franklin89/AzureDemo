using System;

namespace AzureDemo.ViewModels
{
    public class HomeViewModel
    {
        public DateTime NextShowDateUtc { get; set; }

        public string Title { get; set; }

        public HomeViewModel()
        {
            Title = "Shupi Countdown";
            NextShowDateUtc = new DateTime(2017, 08, 18, 17, 37, 0, DateTimeKind.Utc);
        }
    }
}
