using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equality.Classes
{
    public enum FoodGroup { Meat, Fruit, Vegetables, Sweets, Other }

    public class Food
    {

        public static bool operator ==(Food x, Food y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Food x, Food y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this)) // performance optimization
                return true;
            if (obj.GetType() != this.GetType())
                return false;

            Food rhs = obj as Food;  // force cast the object as a Food type at this point, having exhausted the other options
            return this._name == rhs._name && this._group == rhs._group;  // now make sure that BOTH name and group are equal
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this._group.GetHashCode();
        }

        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name {  get { return _name; } }
        public FoodGroup Group {  get { return _group;  } }

        public Food(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        public Food(string name)
        {
            this._name = name;
            this._group = FoodGroup.Other;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
