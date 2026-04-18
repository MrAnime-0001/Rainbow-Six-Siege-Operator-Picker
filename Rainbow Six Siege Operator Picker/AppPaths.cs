using System;
using System.IO;

namespace Rainbow_Six_Siege_Operator_Picker
{
    internal class AppPaths
    {
        public string DataFolder { get; }
        public string ImageFolder { get; }
        public string AttackerImageFolder { get; }
        public string DefenderImageFolder { get; }
        public string FillerImagePath { get; }

        public AppPaths()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            DataFolder = Path.Combine(baseDir, "Data");
            ImageFolder = Path.Combine(baseDir, "Images");
            AttackerImageFolder = Path.Combine(ImageFolder, "Attackers");
            DefenderImageFolder = Path.Combine(ImageFolder, "Defenders");
            FillerImagePath = Path.Combine(ImageFolder, "no_image.png");

            Directory.CreateDirectory(DataFolder);
            Directory.CreateDirectory(AttackerImageFolder);
            Directory.CreateDirectory(DefenderImageFolder);
        }
    }
}
