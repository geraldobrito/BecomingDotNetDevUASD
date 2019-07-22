﻿using System.Collections.Generic;
using System.Linq;
using EcCoach.Web.Models;

namespace EcCoach.Web.ViewModels
{
    public class EventsViewModel
    {
        public ICollection<Event> UpcomingEvents { get; set; }
        public bool ShowActions { get; set; }

        public string Heading { get; set; }
    }
}