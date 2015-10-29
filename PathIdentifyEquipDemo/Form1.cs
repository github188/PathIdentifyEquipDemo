using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathIdentifyEquipDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Stream s = File.OpenRead("E:\\BinVehiclePlatePhoto.jpg");
            byte[] buff = File.ReadAllBytes("E:\\BinVehiclePlatePhoto.jpg");
            //Bitmap bm = new Bitmap(100, 20);
            //Bitmap.
            Image bitmap = Image.FromStream(new MemoryStream(buff));
            pictureBox1.Image = bitmap;
        }
    }
}