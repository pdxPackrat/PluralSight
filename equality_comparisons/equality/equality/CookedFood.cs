using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equality.Classes
{
    public sealed class CookedFood : Food   // sealed class, so nothing else can derive from it
    {
        public static bool operator ==(CookedFood x, CookedFood y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(CookedFood x, CookedFood y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj)) // if the base class Equals method returns false then the instances are NOT equal
                return false;

            // note:  I trust that a null object can't be passed through because the base class Equals method checks for this already

            // return true if base.Equals() returns true AND the derived type field is equal in this case
            CookedFood rhs = (CookedFood)obj;
            return this._cookingMethod == rhs._cookingMethod;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }

        private string _cookingMethod;

        public string CookingMethod {  get { return _cookingMethod;  } }
        public CookedFood(string cookingMethod, string name, FoodGroup group)
            : base(name, group)
        {
            this._cookingMethod = cookingMethod;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _cookingMethod, Name);
        }
    }
}
