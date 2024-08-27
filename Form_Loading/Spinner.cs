//
// FORM ONE
// ========
// FormOne is a child of FormMain
//
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Form_Loading
{
    internal class Spinner
    {


        private Image[] imagenumber;
        private PictureBox pictureBox;

        private readonly int MAX_IMAGES = 3;
        private readonly int SLEEP_TIME = 20; //MILLISECONDS

        private Random random = new Random();
        private int randomIndex;




        //----------------------------------------------
        //The spinnerbox stores the images as an array
        //With intial letter p incrementing.
        //----------------------------------------------
        public Spinner(PictureBox picturebox)
        {
            imagenumber = new Image[MAX_IMAGES];

            for (int ptr = 0; ptr < MAX_IMAGES; ptr++)
            {
                imagenumber[ptr] = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + ptr.ToString());
            }
            this.pictureBox = picturebox;

        }



        //------------------------------------------------------------
        //In the LoadImages the images are loaded in the pictureboxes
        //randomly from the array.
        //-------------------------------------------------------------
        public void LoadImages()
        {

            {
             
                randomIndex = random.Next(0, MAX_IMAGES);
                pictureBox.Image = imagenumber[randomIndex];
                Application.DoEvents();
                Thread.Sleep(SLEEP_TIME);


            }


        }
        //------------------------------------------------------------
        //Boolean used in Form1 to check the similarity of the images.
        //-------------------------------------------------------------
        
    
}
}