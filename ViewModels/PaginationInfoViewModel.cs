using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicHub.ViewModels
{
    public class PaginationInfoViewModel
    {
        public int TotalItems { get;set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        //public int TotalPages { get;set; }


        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);

            }

        }
    }
}
