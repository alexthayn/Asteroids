using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Model
{
    public class GameObject
    {
        Point _position { get; set; }
        Point _deltaPosition { get; set; }
        double _heading { get; set; }
        double _size { get; set; }

    }
}
