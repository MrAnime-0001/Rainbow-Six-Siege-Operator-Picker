using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Rainbow_Six_Siege_Operator_Picker
{
    public partial class SelectivePickerForm : Form
    {
        private string presetFile = Path.Combine(Application.StartupPath, "SelectivePickerPreset.txt");

        public List<string> SelectedAttackers { get; private set; } = new List<string>();
        public List<string> SelectedDefenders { get; private set; } = new List<string>();

        private string attackerFile = Path.Combine(Application.StartupPath, "Data", "attackers.txt");
        private string defenderFile = Path.Combine(Application.StartupPath, "Data", "defenders.txt");

        public SelectivePickerForm(List<string> currentAttackers, List<string> currentDefenders)
        {
            InitializeComponent();
            LoadAllOperators(currentAttackers, currentDefenders);
            CheckAllOperators();
        }

        private void LoadAllOperators(List<string> currentAttackers, List<string> currentDefenders)
        {
            // Attackers
            flowAttackers.Controls.Clear();
            if (File.Exists(attackerFile))
            {
                foreach (var op in File.ReadAllLines(attackerFile).Where(l => !string.IsNullOrWhiteSpace(l)))
                {
                    var cb = new CheckBox
                    {
                        Text = op.Trim(),
                        Checked = currentAttackers.Any(a => string.Equals(a, op.Trim(), StringComparison.OrdinalIgnoreCase)),
                        AutoSize = true
                    };
                    flowAttackers.Controls.Add(cb);
                }
            }

            // Defenders
            flowDefenders.Controls.Clear();
            if (File.Exists(defenderFile))
            {
                foreach (var op in File.ReadAllLines(defenderFile).Where(l => !string.IsNullOrWhiteSpace(l)))
                {
                    var cb = new CheckBox
                    {
                        Text = op.Trim(),
                        Checked = currentDefenders.Any(d => string.Equals(d, op.Trim(), StringComparison.OrdinalIgnoreCase)),
                        AutoSize = true
                    };
                    flowDefenders.Controls.Add(cb);
                }
            }
        }

        private void SetAllCheckboxes(FlowLayoutPanel panel, bool check)
        {
            foreach (var cb in panel.Controls.OfType<CheckBox>())
                cb.Checked = check;
        }

        private void CheckAllOperators()
        {
            foreach (var cb in flowAttackers.Controls.OfType<CheckBox>())
                cb.Checked = true;

            foreach (var cb in flowDefenders.Controls.OfType<CheckBox>())
                cb.Checked = true;
        }

        // Accept / Cancel
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Gather selected items
            SelectedAttackers = flowAttackers.Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToList();

            SelectedDefenders = flowDefenders.Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToList();

            // Check if any side is completely unchecked
            bool attackersEmpty = SelectedAttackers.Count == 0;
            bool defendersEmpty = SelectedDefenders.Count == 0;

            if (attackersEmpty || defendersEmpty)
            {
                string msg = "";

                if (attackersEmpty && defendersEmpty)
                {
                    msg = "No attackers or defenders were selected. All attackers and defenders will be set as selected.";
                }
                else if (attackersEmpty)
                {
                    msg = "No attackers were selected. All attackers will be set as selected.";
                }
                else if (defendersEmpty)
                {
                    msg = "No defenders were selected. All defenders will be set as selected.";
                }

                // Show message
                MessageBox.Show(msg, "Selection Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Set all checkboxes on the empty sides
                if (attackersEmpty) SetAllCheckboxes(flowAttackers, true);
                if (defendersEmpty) SetAllCheckboxes(flowDefenders, true);

                // Refresh SelectedAttackers and SelectedDefenders lists
                SelectedAttackers = flowAttackers.Controls.OfType<CheckBox>()
                    .Where(cb => cb.Checked)
                    .Select(cb => cb.Text)
                    .ToList();

                SelectedDefenders = flowDefenders.Controls.OfType<CheckBox>()
                    .Where(cb => cb.Checked)
                    .Select(cb => cb.Text)
                    .ToList();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelectAllAttackers_Click(object sender, EventArgs e)
        {
            SetAllCheckboxes(flowAttackers, true);
        }

        private void btnDeselectAllAttackers_Click(object sender, EventArgs e)
        {
            SetAllCheckboxes(flowAttackers, false);
        }

        private void btnSelectAllDefenders_Click(object sender, EventArgs e)
        {
            SetAllCheckboxes(flowDefenders, true);
        }

        private void btnDeselectAllDefenders_Click(object sender, EventArgs e)
        {
            SetAllCheckboxes(flowDefenders, false);
        }

        // Save preset automatically in app folder
        private void SavePreset()
        {
            try
            {
                List<string> selected = flowAttackers.Controls.OfType<CheckBox>()
                                            .Where(cb => cb.Checked)
                                            .Select(cb => cb.Text)
                                            .Concat(
                                            flowDefenders.Controls.OfType<CheckBox>()
                                            .Where(cb => cb.Checked)
                                            .Select(cb => cb.Text))
                                            .ToList();

                File.WriteAllLines(presetFile, selected);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save preset: {ex.Message}");
            }
        }

        // Load preset automatically if exists
        private void LoadPreset()
        {
            if (!File.Exists(presetFile))
                return;

            try
            {
                HashSet<string> preset = new HashSet<string>(
                    File.ReadAllLines(presetFile).Select(l => l.Trim()), StringComparer.OrdinalIgnoreCase);

                foreach (var cb in flowAttackers.Controls.OfType<CheckBox>())
                    cb.Checked = preset.Contains(cb.Text);

                foreach (var cb in flowDefenders.Controls.OfType<CheckBox>())
                    cb.Checked = preset.Contains(cb.Text);
            }
            catch
            {
                // ignore errors
            }
        }

        // Manual Save / Load button handlers
        private void btnSavePreset_Click(object sender, EventArgs e)
        {
            SavePreset();
            MessageBox.Show("Preset saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadPreset_Click(object sender, EventArgs e)
        {
            LoadPreset();
            MessageBox.Show("Preset loaded successfully.", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
