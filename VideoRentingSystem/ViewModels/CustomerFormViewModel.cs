using System.Collections.Generic;
using VideoRentingSystem.Models;

namespace VideoRentingSystem.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}