namespace Rainbow_Six_Siege_Operator_Picker
{
    partial class SelectivePickerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowAttackers;
        private System.Windows.Forms.FlowLayoutPanel flowDefenders;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAttackers;
        private System.Windows.Forms.Label lblDefenders;
        private System.Windows.Forms.Button btnSelectAllAttackers;
        private System.Windows.Forms.Button btnDeselectAllAttackers;
        private System.Windows.Forms.Button btnSelectAllDefenders;
        private System.Windows.Forms.Button btnDeselectAllDefenders;
        private System.Windows.Forms.Button btnSavePreset;
        private System.Windows.Forms.Button btnLoadPreset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            flowAttackers = new FlowLayoutPanel();
            flowDefenders = new FlowLayoutPanel();
            btnAccept = new Button();
            btnCancel = new Button();
            lblAttackers = new Label();
            lblDefenders = new Label();
            btnSelectAllAttackers = new Button();
            btnDeselectAllAttackers = new Button();
            btnSelectAllDefenders = new Button();
            btnDeselectAllDefenders = new Button();
            btnSavePreset = new Button();
            btnLoadPreset = new Button();
            SuspendLayout();

            // lblAttackers
            lblAttackers.AutoSize = false;
            lblAttackers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAttackers.ForeColor = Color.White;
            lblAttackers.Location = new Point(18, 12);
            lblAttackers.Name = "lblAttackers";
            lblAttackers.Size = new Size(330, 24);
            lblAttackers.TabIndex = 2;
            lblAttackers.Text = "Attackers";
            lblAttackers.TextAlign = ContentAlignment.MiddleCenter;

            // flowAttackers
            flowAttackers.AutoScroll = true;
            flowAttackers.BackColor = Color.FromArgb(38, 38, 42);
            flowAttackers.BorderStyle = BorderStyle.FixedSingle;
            flowAttackers.ForeColor = Color.White;
            flowAttackers.Location = new Point(18, 42);
            flowAttackers.Name = "flowAttackers";
            flowAttackers.Size = new Size(330, 460);
            flowAttackers.TabIndex = 0;

            // lblDefenders
            lblDefenders.AutoSize = false;
            lblDefenders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDefenders.ForeColor = Color.White;
            lblDefenders.Location = new Point(372, 12);
            lblDefenders.Name = "lblDefenders";
            lblDefenders.Size = new Size(330, 24);
            lblDefenders.TabIndex = 3;
            lblDefenders.Text = "Defenders";
            lblDefenders.TextAlign = ContentAlignment.MiddleCenter;

            // flowDefenders
            flowDefenders.AutoScroll = true;
            flowDefenders.BackColor = Color.FromArgb(38, 38, 42);
            flowDefenders.BorderStyle = BorderStyle.FixedSingle;
            flowDefenders.ForeColor = Color.White;
            flowDefenders.Location = new Point(372, 42);
            flowDefenders.Name = "flowDefenders";
            flowDefenders.Size = new Size(330, 460);
            flowDefenders.TabIndex = 1;

            // btnSelectAllAttackers
            btnSelectAllAttackers.Location = new Point(18, 510);
            btnSelectAllAttackers.Name = "btnSelectAllAttackers";
            btnSelectAllAttackers.Size = new Size(100, 26);
            btnSelectAllAttackers.TabIndex = 6;
            btnSelectAllAttackers.Text = "Select All";
            btnSelectAllAttackers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSelectAllAttackers.FlatStyle = FlatStyle.Flat;
            btnSelectAllAttackers.BackColor = Color.FromArgb(55, 55, 60);
            btnSelectAllAttackers.ForeColor = Color.White;
            btnSelectAllAttackers.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 82);
            btnSelectAllAttackers.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 78);
            btnSelectAllAttackers.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 46);
            btnSelectAllAttackers.UseVisualStyleBackColor = false;
            btnSelectAllAttackers.Click += btnSelectAllAttackers_Click;

            // btnDeselectAllAttackers
            btnDeselectAllAttackers.Location = new Point(124, 510);
            btnDeselectAllAttackers.Name = "btnDeselectAllAttackers";
            btnDeselectAllAttackers.Size = new Size(115, 26);
            btnDeselectAllAttackers.TabIndex = 7;
            btnDeselectAllAttackers.Text = "Deselect All";
            btnDeselectAllAttackers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeselectAllAttackers.FlatStyle = FlatStyle.Flat;
            btnDeselectAllAttackers.BackColor = Color.FromArgb(55, 55, 60);
            btnDeselectAllAttackers.ForeColor = Color.White;
            btnDeselectAllAttackers.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 82);
            btnDeselectAllAttackers.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 78);
            btnDeselectAllAttackers.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 46);
            btnDeselectAllAttackers.UseVisualStyleBackColor = false;
            btnDeselectAllAttackers.Click += btnDeselectAllAttackers_Click;

            // btnSelectAllDefenders
            btnSelectAllDefenders.Location = new Point(372, 510);
            btnSelectAllDefenders.Name = "btnSelectAllDefenders";
            btnSelectAllDefenders.Size = new Size(100, 26);
            btnSelectAllDefenders.TabIndex = 8;
            btnSelectAllDefenders.Text = "Select All";
            btnSelectAllDefenders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSelectAllDefenders.FlatStyle = FlatStyle.Flat;
            btnSelectAllDefenders.BackColor = Color.FromArgb(55, 55, 60);
            btnSelectAllDefenders.ForeColor = Color.White;
            btnSelectAllDefenders.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 82);
            btnSelectAllDefenders.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 78);
            btnSelectAllDefenders.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 46);
            btnSelectAllDefenders.UseVisualStyleBackColor = false;
            btnSelectAllDefenders.Click += btnSelectAllDefenders_Click;

            // btnDeselectAllDefenders
            btnDeselectAllDefenders.Location = new Point(478, 510);
            btnDeselectAllDefenders.Name = "btnDeselectAllDefenders";
            btnDeselectAllDefenders.Size = new Size(115, 26);
            btnDeselectAllDefenders.TabIndex = 9;
            btnDeselectAllDefenders.Text = "Deselect All";
            btnDeselectAllDefenders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeselectAllDefenders.FlatStyle = FlatStyle.Flat;
            btnDeselectAllDefenders.BackColor = Color.FromArgb(55, 55, 60);
            btnDeselectAllDefenders.ForeColor = Color.White;
            btnDeselectAllDefenders.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 82);
            btnDeselectAllDefenders.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 78);
            btnDeselectAllDefenders.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 46);
            btnDeselectAllDefenders.UseVisualStyleBackColor = false;
            btnDeselectAllDefenders.Click += btnDeselectAllDefenders_Click;

            // btnSavePreset
            btnSavePreset.Location = new Point(18, 548);
            btnSavePreset.Name = "btnSavePreset";
            btnSavePreset.Size = new Size(118, 30);
            btnSavePreset.TabIndex = 10;
            btnSavePreset.Text = "Save Preset";
            btnSavePreset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSavePreset.FlatStyle = FlatStyle.Flat;
            btnSavePreset.BackColor = Color.FromArgb(55, 55, 60);
            btnSavePreset.ForeColor = Color.White;
            btnSavePreset.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 82);
            btnSavePreset.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 78);
            btnSavePreset.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 46);
            btnSavePreset.UseVisualStyleBackColor = false;
            btnSavePreset.Click += btnSavePreset_Click;

            // btnLoadPreset
            btnLoadPreset.Location = new Point(144, 548);
            btnLoadPreset.Name = "btnLoadPreset";
            btnLoadPreset.Size = new Size(118, 30);
            btnLoadPreset.TabIndex = 11;
            btnLoadPreset.Text = "Load Preset";
            btnLoadPreset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLoadPreset.FlatStyle = FlatStyle.Flat;
            btnLoadPreset.BackColor = Color.FromArgb(55, 55, 60);
            btnLoadPreset.ForeColor = Color.White;
            btnLoadPreset.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 82);
            btnLoadPreset.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 78);
            btnLoadPreset.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 46);
            btnLoadPreset.UseVisualStyleBackColor = false;
            btnLoadPreset.Click += btnLoadPreset_Click;

            // btnAccept
            btnAccept.Location = new Point(472, 548);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(118, 30);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.BackColor = Color.FromArgb(35, 90, 55);
            btnAccept.ForeColor = Color.White;
            btnAccept.FlatAppearance.BorderColor = Color.FromArgb(50, 110, 70);
            btnAccept.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 110, 68);
            btnAccept.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 70, 40);
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;

            // btnCancel
            btnCancel.Location = new Point(598, 548);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.BackColor = Color.FromArgb(100, 35, 35);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(120, 50, 50);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 45, 45);
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 25, 25);
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            // SelectivePickerForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            ClientSize = new Size(720, 590);
            Controls.Add(flowAttackers);
            Controls.Add(flowDefenders);
            Controls.Add(lblAttackers);
            Controls.Add(lblDefenders);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            Controls.Add(btnSelectAllAttackers);
            Controls.Add(btnDeselectAllAttackers);
            Controls.Add(btnSelectAllDefenders);
            Controls.Add(btnDeselectAllDefenders);
            Controls.Add(btnSavePreset);
            Controls.Add(btnLoadPreset);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SelectivePickerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Selective Operator Picker";
            ResumeLayout(false);
        }

        #endregion
    }
}
