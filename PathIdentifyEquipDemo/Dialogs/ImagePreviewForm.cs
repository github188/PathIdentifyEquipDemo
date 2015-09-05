using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathIdentifyEquipDemo.Dialogs
{
    public partial class ImagePreviewForm : Form
    {
        public ImagePreviewForm(Image image, PictureBoxSizeMode sizeMode = PictureBoxSizeMode.StretchImage)
        {
            InitializeComponent();

            picImage.Image = image;
            picImage.SizeMode = sizeMode;
            // picImage.im
        }

        private void picImage_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}