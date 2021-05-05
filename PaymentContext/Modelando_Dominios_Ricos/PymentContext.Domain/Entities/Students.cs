using System;
using System.Collections.Generic;
using System.Text;

namespace PymentContext.Domain.Entities
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<Subscription> Subscriptions { get; set; }
    }
}
