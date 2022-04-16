using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGame
{
    internal class Ambulance : Vehicle
    {
        private const int MinSpeed = 5;

        public Ambulance(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
           : base(positionX, positionY, speed, distanceX, picture)
        {
        }

        public int TraficJam()
        {
            Speed /= 2;
            if (Speed < MinSpeed)
            {
                Speed = MinSpeed;
            }

            return Speed;
        }
    }
}
