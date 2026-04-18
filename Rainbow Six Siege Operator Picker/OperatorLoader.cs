using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Rainbow_Six_Siege_Operator_Picker
{
    internal static class OperatorLoader
    {
        public static List<string> Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Missing file: {filePath}");
                return new List<string>();
            }

            return File.ReadAllLines(filePath)
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .ToList();
        }
    }
}
