
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;


namespace CarGA
{
    class Program
    {
        static void Main(string[] args)
        {
            string imagen = "C:\\Users\\alumno\\Pictures\\Valentin-Elizalde.jpg";

            Image<Bgr, byte> img = new Image<Bgr, byte>(imagen);
            CvInvoke.Imshow("Imagen", img);

            CvInvoke.WaitKey(0);


        }
    }
}
