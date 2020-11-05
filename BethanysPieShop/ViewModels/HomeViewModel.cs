using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
        {
            PiesOfTheWeek = piesOfTheWeek;
        }
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
