using Application.Interfaces;

namespace Shared
{
    public class DatetimeService : IDatetimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
