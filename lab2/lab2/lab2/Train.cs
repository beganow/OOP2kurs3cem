using System;

namespace lab2
{
    public partial class Train
    {

        public override Boolean Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            return true;
        }
    }
}
