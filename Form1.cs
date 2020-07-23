using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dice_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
     
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Win10-PC\\documents\\visual studio 2010\\Projects\\Dice_Game\\Dice_Game\\pictures\\dice.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        } 
      

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Load("C:\\Users\\Win10-PC\\documents\\visual studio 2010\\Projects\\Dice_Game\\Dice_Game\\pictures\\" + r.Next(1, 7) + ".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

       

       
        

         

           
    

        
    }
}
