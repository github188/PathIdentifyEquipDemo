using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Util
{
    public static class FileIOUtil
    {
        public static void SaveFileByByteArray(string filenames, byte[] data)
        {
            FileStream fsImg = new FileStream(filenames, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryWriter wrImg = new BinaryWriter(fsImg);
            wrImg.Write(data);
            wrImg.Close();
            fsImg.Close();
        }
    }
}