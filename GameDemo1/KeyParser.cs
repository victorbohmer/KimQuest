using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GameDemo1
{
    class KeyParser
    {
        public static Direction Direction(Key keyDown)
        {
            int keyIndex = (int)keyDown;
            int directionIndex = 0;
            if (keyIndex >= 74 && keyIndex <= 83)
            {
                directionIndex = keyIndex - 74;
            }

            return (Direction)directionIndex;

        }
    }
}
