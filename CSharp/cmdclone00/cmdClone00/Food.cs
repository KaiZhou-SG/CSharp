using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace cmdClone00
{
    public class Food
    {
        #region "Private Member Variables"
        private string name;
        private decimal unitWeight;
        private decimal unitPrice;
        private EnumFoodCategory foodCategory;
        #endregion 

        #region "Public Properties"
        public string Name 
        {
            get {return name;}
            set { name = value; }
        }

        public decimal UnitWeight
        {
            get { return unitWeight; }
            set { unitWeight = value; }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public EnumFoodCategory FoodCategory
        {
            get { return foodCategory; }
            set { foodCategory = value; }
        }
        #endregion

        #region "Construcotrs"
        public Food()
        {
            name = String.Empty;
            unitWeight = 0m;
            unitPrice = 0m;
            foodCategory = EnumFoodCategory.MixEater;
        }

        public Food(string name, decimal unitWeight, decimal unitPrice, EnumFoodCategory foodCategory)
        {
            this.name = name;
            this.unitWeight = unitWeight;
            this.unitPrice = unitPrice;
            this.foodCategory = foodCategory;
        }
        #endregion

        #region "Methods"
        public List<Food> GetAllFoods()
        {
            return null;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    }
}
