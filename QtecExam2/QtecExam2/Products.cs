using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QtecExam2
{
    public partial class Products
    {
        public int cost =0;
        public int coffee =0;
        public int milk =0;
        public int water =0;

        public bool Purchase(Storage _store)
        {
            if (_store.Coffee < this.coffee || _store.Water < this.water || _store.Milk < this.milk)
            {
                return false;
            }

            _store.Money += this.cost;
            _store.Coffee -= this.coffee;
            _store.Water -= this.water;
            _store.Milk -= this.milk;

            return true;
        }
    }

    public class Espresso : Products
    {
        public Espresso()
        {
            cost = 4000;
            coffee = 100;
            water = 30;
        }
    }

    public class Latte : Products
    {
        public Latte()
        {
            cost = 5000;
            coffee = 100;
            water = 70;
            milk = 30;
        }
    }

    public class Americano : Products
    {
        public Americano()
        {
            cost = 4500;
            coffee = 100;
            water = 100;
        }
    }
}
