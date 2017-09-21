using System.Collections.Generic;
using VideoRentingSystem.Models;

namespace VideoRentingSystem.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}