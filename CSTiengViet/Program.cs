using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace CSTiengViet
{
  internal class Program
  {
        static void Main(string[] args)
        {
            var takeInfo = DriveInfo.GetDrives();
                foreach (var drive in takeInfo)
                {

                    Console.WriteLine($"Drive: {drive.Name}");
                    Console.WriteLine($"Drive Type: {drive.DriveType}");
                    Console.WriteLine($"Drive Label: {drive.VolumeLabel}");
                    Console.WriteLine($"Drive Format: {drive.DriveFormat}");
                    Console.WriteLine($"Drive Size: {drive.TotalSize}");
                    Console.WriteLine($"Drive Free Space: {drive.TotalFreeSpace}");
                }
        }
  }
}
