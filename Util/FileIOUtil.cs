using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Util
{
    public static class FileIOUtil
    {
        /// <summary>
        /// 根据Byte数组保存为文件
        /// </summary>
        /// <param name="filenames">完整文件路径和文件名</param>
        /// <param name="data">文件字节数组</param>
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