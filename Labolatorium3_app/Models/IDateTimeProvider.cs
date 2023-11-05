using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3_app.Models
{
    public interface IDateTimeProvider
    {
        DateTime GetDateTime();
    }
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
