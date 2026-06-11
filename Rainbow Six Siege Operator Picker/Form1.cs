using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Rainbow_Six_Siege_Operator_Picker
{
    public partial class Form1 : Form
    {
        private List<string> attackers = new List<string>();
        private List<string> defenders = new List<string>();
        private List<string> allowedAttackers = new List<string>();
        private List<string> allowedDefenders = new List<string>();

        private AppPaths paths;
        private OperatorPicker picker;
        private ImageLoader imageLoader;
        private HotkeyHandler hotkeyHandler;

        public Form1()
        {
            InitializeComponent();

            paths = new AppPaths();
            picker = new OperatorPicker();
            imageLoader = new ImageLoader(paths.FillerImagePath);

            LoadAppIcon();
            LoadOperators();

            hotkeyHandler = new HotkeyHandler();
            hotkeyHandler.AttackerHotkeyPressed += PickAttackerHotkey;
            hotkeyHandler.DefenderHotkeyPressed += PickDefenderHotkey;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            hotkeyHandler?.Dispose();
            base.OnFormClosing(e);
        }

        private void LoadAppIcon()
        {
            using var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Rainbow_Six_Siege_Operator_Picker.Images.appicon.ico");
            if (stream != null) Icon = new Icon(stream);
        }

        private void LoadOperators()
        {
            try
            {
                attackers = OperatorLoader.Load(Path.Combine(paths.DataFolder, "attackers.txt"));
                defenders = OperatorLoader.Load(Path.Combine(paths.DataFolder, "defenders.txt"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading operators: {ex.Message}");
            }
        }

        private void btnPickAttacker_Click(object sender, EventArgs e)
        {
            var list = allowedAttackers.Count > 0 ? allowedAttackers : attackers;
            PickAndDisplay(list, "Attacker", paths.AttackerImageFolder);
        }

        private void btnPickDefender_Click(object sender, EventArgs e)
        {
            var list = allowedDefenders.Count > 0 ? allowedDefenders : defenders;
            PickAndDisplay(list, "Defender", paths.DefenderImageFolder);
        }

        private void PickAttackerHotkey()
        {
            var list = allowedAttackers.Count > 0 ? allowedAttackers : attackers;
            PickAndDisplay(list, "Attacker", paths.AttackerImageFolder);
            ToastNotifier.ShowToast(lblResult.Text);
        }

        private void PickDefenderHotkey()
        {
            var list = allowedDefenders.Count > 0 ? allowedDefenders : defenders;
            PickAndDisplay(list, "Defender", paths.DefenderImageFolder);
            ToastNotifier.ShowToast(lblResult.Text);
        }

        private void PickAndDisplay(List<string> list, string type, string folder)
        {
            string selected = picker.Pick(list, type);

            if (selected == null)
            {
                lblResult.Text = $"No {type.ToLower()}s loaded!";
                pictureBox.Image = null;
                return;
            }

            lblResult.Text = $"{type}: {selected}";
            pictureBox.Image = imageLoader.LoadOperatorImage(selected, folder);
        }

        private void btnSelectOperators_Click(object sender, EventArgs e)
        {
            if (!hotkeyHandler.TryStartCooldown())
                return;

            hotkeyHandler.Enabled = false;
            this.Hide();

            using (var form = new SelectivePickerForm(allowedAttackers, allowedDefenders))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    allowedAttackers = form.SelectedAttackers;
                    allowedDefenders = form.SelectedDefenders;
                    picker.Reset();
                }
            }

            this.Show();
            hotkeyHandler.Enabled = true;
        }
    }
}
