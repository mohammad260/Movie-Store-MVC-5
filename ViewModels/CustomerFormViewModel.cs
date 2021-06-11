using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movie_Store_MVC_5.Models;

namespace Movie_Store_MVC_5.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable <MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}