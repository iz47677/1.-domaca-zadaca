using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            if (((a.X >= b.X && a.X <= (b.X + b.Width)) || (b.X >= a.X && b.X <= (a.X + a.Width)))
                && ((a.Y >= b.Y && a.Y <= (b.Y + b.Height)) || (b.Y >= a.Y && b.Y <= (a.Y + a.Height))))
                return true;
            return false;
        }
    }
}
