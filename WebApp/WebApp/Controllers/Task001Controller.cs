// Todo #001: Time picker control.

using System;
using System.Collections.Generic;
using System.Web.Mvc;

using WebApp.Models.Task001;

namespace WebApp.Controllers
{
    /// <summary>
    /// See views for more details. 
    /// </summary>
    public class Task001Controller : Controller
    {
        // GET: Task001
        public ActionResult InstantSelection()
        {
            var model = new TimePickerModel { InstantSelection = true, AvailableItemsList = PrepareTimeItems() };

            return View(model);
        }

        public ActionResult MultipleSelection()
        {
            var model = new TimePickerModel { InstantSelection = false, AvailableItemsList = PrepareTimeItems() };

            return View(model);
        }

        /// <summary>
        /// Action is called when TimePicker is in InstantSelection = true mode.
        /// </summary>
        /// <param name="selectedTime">Selected date and time.</param>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult InstantBooking(DateTime selectedTime)
        {
            return View("Result", new List<DateTime>{selectedTime});
        }

        /// <summary>
        /// Action is called when TimePicker is in InstantSelection = false mode.
        /// </summary>
        /// <param name="selectedTimes">Selected dates and times.</param>
        /// <returns>Action result.</returns>
        [HttpPost]
        public ActionResult ConfirmTimes(IEnumerable<DateTime> selectedTimes)
        {
            return View("Result", selectedTimes);
        }

        /// <summary>
        /// Fake method for creating items for time picker.
        /// </summary>
        /// <returns>list of items.</returns>
        private List<TimeSlotItem> PrepareTimeItems()
        {
            var list = new List<TimeSlotItem>();
            DateTime timeVal = new DateTime(2014,12,1,08,00,00);
            for (int i=0; i<20; i++ )
            {
                  list.Add(new TimeSlotItem
                               {
                                    TimeText   = timeVal.ToShortTimeString(),
                                    DisplayText = Faker.Lorem.Sentence()
                               });
            }

            return list;
        }
    }
}