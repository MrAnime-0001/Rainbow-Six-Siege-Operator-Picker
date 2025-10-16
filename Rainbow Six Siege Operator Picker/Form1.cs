using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Rainbow_Six_Siege_Operator_Picker
{
    public partial class Form1 : Form
    {
        private List<string> attackers = new List<string>();
        private List<string> defenders = new List<string>();
        private Random rng = new Random();

        private string dataFolder;
        private string imageFolder;
        private string attackerImageFolder;
        private string defenderImageFolder;
        private string fillerImagePath;

        public Form1()
        {
            InitializeComponent();
            SetupPaths();
            LoadAppIcon();
            LoadOperators();
        }

        private void SetupPaths()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            dataFolder = Path.Combine(baseDir, "Data");
            imageFolder = Path.Combine(baseDir, "Images");
            attackerImageFolder = Path.Combine(imageFolder, "Attackers");
            defenderImageFolder = Path.Combine(imageFolder, "Defenders");
            fillerImagePath = Path.Combine(imageFolder, "no_image.png");

            // Create directories if they don't exist
            Directory.CreateDirectory(dataFolder);
            Directory.CreateDirectory(attackerImageFolder);
            Directory.CreateDirectory(defenderImageFolder);
        }

        private void LoadAppIcon()
        {
            string iconPath = Path.Combine(imageFolder, "appicon.ico");
            if (File.Exists(iconPath))
            {
                try
                {
                    Icon = new Icon(iconPath);
                }
                catch
                {
                    MessageBox.Show("Failed to load app icon (invalid format).");
                }
            }
        }

        private void LoadOperators()
        {
            try
            {
                string attackerPath = Path.Combine(dataFolder, "attackers.txt");
                string defenderPath = Path.Combine(dataFolder, "defenders.txt");

                if (File.Exists(attackerPath))
                    attackers = File.ReadAllLines(attackerPath).Where(l => !string.IsNullOrWhiteSpace(l)).ToList();
                else
                    MessageBox.Show("Missing file: Data/attackers.txt");

                if (File.Exists(defenderPath))
                    defenders = File.ReadAllLines(defenderPath).Where(l => !string.IsNullOrWhiteSpace(l)).ToList();
                else
                    MessageBox.Show("Missing file: Data/defenders.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading operators: {ex.Message}");
            }
        }

        private void btnPickAttacker_Click(object sender, EventArgs e)
        {
            PickOperator(attackers, "Attacker", attackerImageFolder);
        }

        private void btnPickDefender_Click(object sender, EventArgs e)
        {
            PickOperator(defenders, "Defender", defenderImageFolder);
        }

        private void PickOperator(List<string> list, string type, string folder)
        {
            if (list.Count == 0)
            {
                lblResult.Text = $"No {type.ToLower()}s loaded!";
                pictureBox.Image = null;
                return;
            }

            string selected = list[rng.Next(list.Count)];
            lblResult.Text = $"{type}: {selected}";
            LoadOperatorImage(selected, folder);
        }

        private void LoadOperatorImage(string operatorName, string folder)
        {
            pictureBox.Image = null;

            // Case-insensitive image lookup
            string[] possibleFiles = Directory.GetFiles(folder, "*.png", SearchOption.TopDirectoryOnly);

            // Try to find any file whose name matches (case-insensitive)
            string imagePath = possibleFiles
                .FirstOrDefault(f => string.Equals(
                    Path.GetFileNameWithoutExtension(f),
                    operatorName,
                    StringComparison.OrdinalIgnoreCase));

            if (imagePath != null && File.Exists(imagePath))
            {
                try
                {
                    using (var imgTemp = Image.FromFile(imagePath))
                    {
                        pictureBox.Image = new Bitmap(imgTemp);
                    }
                }
                catch
                {
                    LoadFillerImage();
                }
            }
            else
            {
                LoadFillerImage();
            }
        }

        private void LoadFillerImage()
        {
            if (File.Exists(fillerImagePath))
            {
                try
                {
                    using (var imgTemp = Image.FromFile(fillerImagePath))
                    {
                        pictureBox.Image = new Bitmap(imgTemp);
                    }
                }
                catch
                {
                    pictureBox.Image = null;
                }
            }
            else
            {
                pictureBox.Image = null;
            }
        }
    }
}
