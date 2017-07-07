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
            NextShowDateUtc = new DateTime(2017, 07, 14, 21, 40, 0, DateTimeKind.Local).ToUniversalTime();
        }
    }
}