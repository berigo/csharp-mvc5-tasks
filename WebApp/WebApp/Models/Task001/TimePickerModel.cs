using System.Collections.Generic;

namespace WebApp.Models.Task001
{
    public class TimePickerModel
    {
        public bool InstantSelection { get; set; }

        public List<TimeSlotItem> AvailableItemsList { get; set; }
    }
}