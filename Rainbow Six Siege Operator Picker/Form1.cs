using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Gma.System.MouseKeyHook;

namespace Rainbow_Six_Siege_Operator_Picker
{
    public partial class Form1 : Form
    {
        private List<string> attackers = new List<string>();
        private List<string> defenders = new List<string>();
        private List<string> allowedAttackers = new List<string>();
        private List<string> allowedDefenders = new List<string>();
        private string lastAttacker = null;
        private string lastDefender = null;
        private Random rng = new Random();

        private string dataFolder;
        private string imageFolder;
        private string attackerImageFolder;
        private string defenderImageFolder;
        private string fillerImagePath;

        // MouseKeyHook Stuff
        private IKeyboardMouseEvents globalHook;
        private bool hotkeyOnCooldown = false;
        private bool hotkeysEnabled = true;
        private System.Windows.Forms.Timer hotkeyCooldownTimer;
        private int hotkeyCooldownDuration = 2000;

        public Form1()
        {
            InitializeComponent();
            SetupPaths();
            LoadAppIcon();
            LoadOperators();

            // Initialize global hook
            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += GlobalHook_KeyDown;

            // Setup cooldown timer
            hotkeyCooldownTimer = new System.Windows.Forms.Timer();
            hotkeyCooldownTimer.Interval = hotkeyCooldownDuration;
            hotkeyCooldownTimer.Tick += (s, e) =>
            {
                hotkeyOnCooldown = false;
                hotkeyCooldownTimer.Stop();
            };
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Dispose hook when closing
            globalHook?.Dispose();
            base.OnFormClosing(e);
        }

        // Handle global hotkeys
        private void GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (!hotkeysEnabled)
                return;

            // Check Ctrl + Alt
            if (e.Control && e.Alt)
            {
                if (e.KeyCode == Keys.NumPad1)
                    PickAttackerHotkey();
                else if (e.KeyCode == Keys.NumPad2)
                    PickDefenderHotkey();
            }
        }

        private void PickAttackerHotkey()
        {
            if (hotkeyOnCooldown)
                return;

            hotkeyOnCooldown = true;
            hotkeyCooldownTimer.Start();

            var list = allowedAttackers.Count > 0 ? allowedAttackers : attackers;
            PickOperator(list, "Attacker", attackerImageFolder);

            // Show toast using lblResult text
            ToastNotifier.ShowToast(lblResult.Text);
        }

        private void PickDefenderHotkey()
        {
            if (hotkeyOnCooldown)
                return;

            hotkeyOnCooldown = true;
            hotkeyCooldownTimer.Start();

            var list = allowedDefenders.Count > 0 ? allowedDefenders : defenders;
            PickOperator(list, "Defender", defenderImageFolder);

            // Show toast using lblResult text
            ToastNotifier.ShowToast(lblResult.Text);
        }

        private void SetupPaths()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            dataFolder = Path.Combine(baseDir, "Data");
            imageFolder = Path.Combine(baseDir, "Images");
            attackerImageFolder = Path.Combine(imageFolder, "Attackers");
            defenderImageFolder = Path.Combine(imageFolder, "Defenders");
            fillerImagePath = Path.Combine(imageFolder, "no_image.png");

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
                    attackers = File.ReadAllLines(attackerPath)
                        .Where(l => !string.IsNullOrWhiteSpace(l))
                        .ToList();
                else
                    MessageBox.Show("Missing file: Data/attackers.txt");

                if (File.Exists(defenderPath))
                    defenders = File.ReadAllLines(defenderPath)
                        .Where(l => !string.IsNullOrWhiteSpace(l))
                        .ToList();
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
            var list = allowedAttackers.Count > 0 ? allowedAttackers : attackers;
            PickOperator(list, "Attacker", attackerImageFolder);
        }

        private void btnPickDefender_Click(object sender, EventArgs e)
        {
            var list = allowedDefenders.Count > 0 ? allowedDefenders : defenders;
            PickOperator(list, "Defender", defenderImageFolder);
        }

        private void PickOperator(List<string> list, string type, string folder)
        {
            if (list.Count == 0)
            {
                lblResult.Text = $"No {type.ToLower()}s loaded!";
                pictureBox.Image = null;
                return;
            }

            // If only one operator is available, always pick that
            if (list.Count == 1)
            {
                string single = list[0];
                lblResult.Text = $"{type}: {single}";
                LoadOperatorImage(single, folder);

                // Update last picked
                if (type == "Attacker")
                    lastAttacker = single;
                else
                    lastDefender = single;

                return;
            }

            // Otherwise, avoid repeating the last one
            string selected;
            do
            {
                selected = list[rng.Next(list.Count)];
            }
            while ((type == "Attacker" && selected == lastAttacker) ||
                   (type == "Defender" && selected == lastDefender));

            lblResult.Text = $"{type}: {selected}";
            LoadOperatorImage(selected, folder);

            // Update last picked
            if (type == "Attacker")
                lastAttacker = selected;
            else
                lastDefender = selected;
        }

        private void LoadOperatorImage(string operatorName, string folder)
        {
            pictureBox.Image = null;

            string[] possibleFiles = Directory.GetFiles(folder, "*.png", SearchOption.TopDirectoryOnly);
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

        // Open Selective Picker Form
        private void btnSelectOperators_Click(object sender, EventArgs e)
        {
            // Respect the hotkey cooldown
            if (hotkeyOnCooldown)
                return;

            // Start the cooldown
            hotkeyOnCooldown = true;
            hotkeyCooldownTimer.Start();

            // Temporarily disable hotkeys
            hotkeysEnabled = false;

            // Hide the main form and show the picker
            this.Hide();

            using (var picker = new SelectivePickerForm(allowedAttackers, allowedDefenders))
            {
                var result = picker.ShowDialog();

                if (result == DialogResult.OK)
                {
                    allowedAttackers = picker.SelectedAttackers;
                    allowedDefenders = picker.SelectedDefenders;
                }
            }

            // Show the main form again
            this.Show();

            // Re-enable hotkeys after closing the picker
            hotkeysEnabled = true;
        }
    }
}
