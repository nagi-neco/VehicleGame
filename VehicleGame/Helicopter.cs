using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGame
{
    internal class Helicopter : Vehicle
    {
        public Helicopter(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture, int maxHigh, int minHigh)
            : base(positionX, positionY, speed, distanceX, picture)
        {
            MaxHigh = maxHigh;
            MinHigh = minHigh;
        }
        
        public int MaxHigh { get; private set; }
        public int MinHigh { get; private set; }

        public override bool Run(out int x, out int y)
        {
            bool rc = true;
            PositionX += Speed;

            if (PositionX >= DistanceX)
            {
                PositionX = DistanceX;
                PositionY += Speed / 2;

                if (PositionY >= MinHigh)
                {
                    PositionY = MinHigh;
                    rc = false;
                }
            }
            else
            {
                PositionY -= Speed / 2;
                if (PositionY < MaxHigh)
                {
                    PositionY = MaxHigh;
                }
            }
            
            x = PositionX;
            y = PositionY;

            return rc;
        }

        public void Storm()
        {
            DistanceX = PositionX;
        }
    }
}
