﻿// Todo #001: Times picker control.
// It is a html control. Look \Views\Task001\Index.cshtml for more info. 

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
        public ActionResult Index()
        {
            var model = new TimePickerModel { AvailableItemsList = PrepareTimeItems() };

            return View(model);
        }

        /// <summary>
        /// Submit selected datetime values.
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