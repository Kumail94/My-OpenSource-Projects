using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Office_Mangement_Systems.Images
{
    public class ImageManipulation
    {
        public static byte[]GetPhoto(PictureBox picture)
        {
            MemoryStream ms = new MemoryStream();
            picture.Image.Save(ms, picture.Image.RawFormat);
            return ms.GetBuffer();
        }

        public static Image PutPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
    }
}
