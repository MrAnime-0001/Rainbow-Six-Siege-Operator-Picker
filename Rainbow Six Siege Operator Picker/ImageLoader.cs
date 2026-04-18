using System.Drawing;
using System.IO;
using System.Linq;

namespace Rainbow_Six_Siege_Operator_Picker
{
    internal class ImageLoader
    {
        private readonly string fillerImagePath;

        public ImageLoader(string fillerImagePath)
        {
            this.fillerImagePath = fillerImagePath;
        }

        public Image LoadOperatorImage(string operatorName, string folder)
        {
            string[] files = Directory.GetFiles(folder, "*.png", SearchOption.TopDirectoryOnly);
            string match = files.FirstOrDefault(f =>
                string.Equals(Path.GetFileNameWithoutExtension(f), operatorName, System.StringComparison.OrdinalIgnoreCase));

            if (match != null && File.Exists(match))
            {
                try
                {
                    using (var tmp = Image.FromFile(match))
                        return new Bitmap(tmp);
                }
                catch { }
            }

            return LoadFillerImage();
        }

        public Image LoadFillerImage()
        {
            if (!File.Exists(fillerImagePath))
                return null;

            try
            {
                using (var tmp = Image.FromFile(fillerImagePath))
                    return new Bitmap(tmp);
            }
            catch
            {
                return null;
            }
        }
    }
}
