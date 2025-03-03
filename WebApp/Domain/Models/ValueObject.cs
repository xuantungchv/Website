using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        // dùng dể gọi giá trị của các thuộc tính trong object, sử dụng trong việc so sánh 2 value object với nhau
        public abstract IEnumerable<object> GetEqualityComponent();
        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType()) 
            {
                return false;   
            }
            var valueObject = (ValueObject)obj;
            return GetEqualityComponent().SequenceEqual(valueObject.GetEqualityComponent());  
        }
        public static bool operator ==(ValueObject left, ValueObject right) 
        {
            return Equals(left,right);  
        }

        public static bool operator !=(ValueObject left, ValueObject right)
        {
            return !Equals(left, right);
        }
        public override int GetHashCode() 
        {
            return GetEqualityComponent().Select(x=>x?.GetHashCode() ?? 0).Aggregate((x,y) => x^y);
        }

        public bool Equals(ValueObject? other)
        {
            return Equals((object?)other); 
        }
    }
}
