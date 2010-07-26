using System;

namespace nothinbutdotnetprep.utility
{
    public class Where<ItemToFilter>
    {
        public static CriteriaFactory<ItemToFilter, PropertyType> has_a<PropertyType>(Func<ItemToFilter, PropertyType> property_accessor)
        {
            return new CriteriaFactory<ItemToFilter, PropertyType>(property_accessor);
        }

    }
}