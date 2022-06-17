using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_of_Thieves_helper
{
    public static class AdditionalFunctions
    {
        public static Rectangle PlusRects(this Rectangle a, Rectangle b)=> new Rectangle(a.X + b.X, a.Y + b.Y, a.Width + b.Width, a.Height + b.Height);
    }
}
