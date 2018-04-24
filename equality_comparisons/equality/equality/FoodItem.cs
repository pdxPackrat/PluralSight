using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equality.Struct
{
    public enum FoodType { Meat, Fruit, Vegetables, Sweets, Other }

    public struct FoodItem : IEquatable<FoodItem>
    {
        public static bool operator ==(FoodItem lhs, FoodItem rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(FoodItem lhs, FoodItem rhs)
        {
            return !lhs.Equals(rhs);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }

        public bool Equals(FoodItem other)
        {
            return this._name == other.Name && this._group == other._group;
        }

        public override bool Equals(object obj)
        {
            if (obj is FoodItem)
                return Equals((FoodItem)obj);
            else
                return false;
        }

        private readonly string _name;
        private readonly FoodType _group;

        public string Name { get { return _name; } }
        public FoodType Group { get { return _group; } }

        public FoodItem(string name, FoodType group)
        {
            this._name = name;
            this._group = group;
        }

        public FoodItem(string name)
        {
            this._name = name;
            this._group = FoodType.Other;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}