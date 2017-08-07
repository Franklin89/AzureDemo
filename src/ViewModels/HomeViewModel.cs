using System;

namespace AzureDemo.ViewModels
{
    public class HomeViewModel
    {
        public DateTime NextVisitDateUtc { get; set; }
        public DateTime EndOfStayDateUtc => new DateTime(2017, 12, 22, 11, 0, 0, DateTimeKind.Utc);
        public string Title { get; set; }

        public HomeViewModel()
        {
            Title = "Shupi Countdown";
            NextVisitDateUtc = new DateTime(2017, 08, 18, 17, 37, 0, DateTimeKind.Utc);
        }
    }
}
