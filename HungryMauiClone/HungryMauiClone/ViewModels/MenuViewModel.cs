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
            new MenuCategory { Name = "Big Bacon Burger", Image = "Big_Bacon_Burger.jpg", Price = 49.99 },
            new MenuCategory { Name = "Whopper", Image = "whopper.png", Price = 69.49 },
            new MenuCategory { Name = "Ribs and Chips", Image = "Ribs_and_Chips.jpg", Price = 59.99 },
            new MenuCategory { Name = "Full Chicken", Image = "Full_Chicken.jpg", Price = 149.99 },
            new MenuCategory { Name = "Beef Burger", Image = "Beef_Burger.jpg", Price = 89.99 }
        };
    }
}