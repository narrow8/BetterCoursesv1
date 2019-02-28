using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterCourses
{
    class Person
    {
        public string faceId;
        public FaceRectangle facerectangle;
        public FaceAttributes faceAttributes;
        public Bitmap face;
        public string directionLooking;

        public Boolean getAttention()
        {
            if (directionLooking == "Atent")
                return true;
            return false;
        }
    }
}
