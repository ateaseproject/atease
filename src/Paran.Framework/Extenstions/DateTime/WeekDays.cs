using System.ComponentModel.DataAnnotations;
using Paran.Framework.Resources;

namespace Paran.Framework.Extenstions.DateTime
{
    public enum WeekDays
    {
        [Display(Name = "WeekSunday", ResourceType = typeof(DisplayNameResource))]
        Sunday = 0,

        [Display(Name = "WeekMonday", ResourceType = typeof(DisplayNameResource))]
        Monday = 1,

        [Display(Name = "WeekTuesday", ResourceType = typeof(DisplayNameResource))]
        Tuesday = 2,

        [Display(Name = "WeekWednesday", ResourceType = typeof(DisplayNameResource))]
        Wednesday = 3,

        [Display(Name = "WeekThursday", ResourceType = typeof(DisplayNameResource))]
        Thursday = 4,

        [Display(Name = "WeekFriday", ResourceType = typeof(DisplayNameResource))]
        Friday = 5,

        [Display(Name = "WeekSaturday", ResourceType = typeof(DisplayNameResource))]
        Saturday = 6
    }
}