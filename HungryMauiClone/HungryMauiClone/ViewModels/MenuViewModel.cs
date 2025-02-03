using HungryMauiClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryMaui.ViewModels;

public class MenuViewModel
{
    public ObservableCollection<MenuCategory> Categories { get; set; }

    public MenuViewModel()
    {
        Categories = new ObservableCollection<MenuCategory>
        {
            new MenuCategory { Name = "Big Bacon Burger", Image = "Big_Bacon_Burger.jpg" },
            new MenuCategory { Name = "Whopper", Image = "whopper.png" },
            new MenuCategory { Name = "Ribs and Chips", Image = "Ribs_and_Chips.jpg" },
            new MenuCategory { Name = "Full Chicken", Image = "Full_Chicken.jpg" },
            new MenuCategory { Name = "Beef Burger", Image = "Beef_Burger.jpg" }
        };
    }
}