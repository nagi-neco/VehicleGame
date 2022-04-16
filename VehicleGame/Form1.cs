using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleGame
{
    public partial class Form1 : Form
    {
        private Helicopter helicopter;
        private Ambulance ambulance;
        private Motorcycle motorcycle;
        private Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            const int MotorcycleSpeed = 10;
            const int AmbulanceSpeed = 15;
            const int HelicopterSpeed = 30;
            const int HelicopterMaxHigh = 30;

            int x = pictureBoxMotorcycle.Location.X;
            int y = pictureBoxMotorcycle.Location.Y;
            int distanceW = formSizeW - pictureBoxMotorcycle.Size.Width;
            motorcycle = new Motorcycle(x, y, MotorcycleSpeed, distanceW, pictureBoxMotorcycle);

            x = pictureBoxAmbulance.Location.X;
            y = pictureBoxAmbulance.Location.Y;
            distanceW = formSizeW - pictureBoxAmbulance.Size.Width;
            ambulance = new Ambulance(x, y, AmbulanceSpeed, distanceW, pictureBoxAmbulance);

            x = pictureBoxHelicopter.Location.X;
            y = pictureBoxHelicopter.Location.Y;
            distanceW = formSizeW - pictureBoxHelicopter.Size.Width;
            helicopter = new Helicopter(x, y, HelicopterSpeed, distanceW, pictureBoxHelicopter, HelicopterMaxHigh, y);

            random = new Random();

            labelNotice.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MoveVehicle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveVehicle();

            int r = random.Next(100);
            if (r == 0)
            {
                ambulance.TraficJam();
                labelNotice.Text += " 渋滞発生";
            }
            else if (r == 50)
            {
                helicopter.Storm();
                labelNotice.Text += " 嵐発生";
            }

        }
        private void MoveVehicle()
        {
            bool rc1 = motorcycle.Run(out int x1, out int y1);
            bool rc2 = ambulance.Run(out int x2, out int y2);
            bool rc3 = helicopter.Run(out int x3, out int y3);

            motorcycle.PictureMove(x1, y1);
            ambulance.PictureMove(x2, y2);
            helicopter.PictureMove(x3, y3);

            if (rc1 == false && rc2 == false && rc3 == false)
            {
                timer1.Stop();
                labelNotice.Text = "終了";
            }
        }
    }
}
