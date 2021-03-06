﻿using System.Collections.Generic;
using System.Linq;

namespace Larkins.TimeFudger
{
    /// <summary>
    /// TODO: Make this implement IEnumerable or extend SortedList
    /// </summary>
    public class TimeSheet
    {
        public List<TimeEntry> TimeEntries { get; } = new List<TimeEntry>();

        /// <summary>
        /// Gets the time entries sorted by Start time.
        /// </summary>
        /// <returns></returns>
        public List<TimeEntry> GetSortedTimeEntries()
        {
            return TimeEntries.OrderBy(x => x.TimePeriod.Start).ToList();
        }
    }
}
