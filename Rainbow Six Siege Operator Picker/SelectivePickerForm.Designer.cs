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

        // New buttons
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
            // 
            // flowAttackers
            // 
            flowAttackers.AutoScroll = true;
            flowAttackers.BorderStyle = BorderStyle.FixedSingle;
            flowAttackers.ForeColor = Color.White;
            flowAttackers.Location = new Point(18, 45);
            flowAttackers.Margin = new Padding(3, 2, 3, 2);
            flowAttackers.Name = "flowAttackers";
            flowAttackers.Size = new Size(306, 248);
            flowAttackers.TabIndex = 0;
            // 
            // flowDefenders
            // 
            flowDefenders.AutoScroll = true;
            flowDefenders.BorderStyle = BorderStyle.FixedSingle;
            flowDefenders.ForeColor = Color.White;
            flowDefenders.Location = new Point(350, 45);
            flowDefenders.Margin = new Padding(3, 2, 3, 2);
            flowDefenders.Name = "flowDefenders";
            flowDefenders.Size = new Size(306, 248);
            flowDefenders.TabIndex = 1;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.White;
            btnAccept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAccept.Location = new Point(440, 362);
            btnAccept.Margin = new Padding(3, 2, 3, 2);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(105, 26);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(551, 362);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 26);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblAttackers
            // 
            lblAttackers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAttackers.ForeColor = Color.White;
            lblAttackers.Location = new Point(131, 15);
            lblAttackers.Name = "lblAttackers";
            lblAttackers.Size = new Size(88, 19);
            lblAttackers.TabIndex = 2;
            lblAttackers.Text = "Attackers";
            // 
            // lblDefenders
            // 
            lblDefenders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDefenders.ForeColor = Color.White;
            lblDefenders.Location = new Point(464, 15);
            lblDefenders.Name = "lblDefenders";
            lblDefenders.Size = new Size(88, 19);
            lblDefenders.TabIndex = 3;
            lblDefenders.Text = "Defenders";
            // 
            // btnSelectAllAttackers
            // 
            btnSelectAllAttackers.BackColor = Color.White;
            btnSelectAllAttackers.Location = new Point(18, 297);
            btnSelectAllAttackers.Margin = new Padding(3, 2, 3, 2);
            btnSelectAllAttackers.Name = "btnSelectAllAttackers";
            btnSelectAllAttackers.Size = new Size(70, 22);
            btnSelectAllAttackers.TabIndex = 6;
            btnSelectAllAttackers.Text = "Select All";
            btnSelectAllAttackers.UseVisualStyleBackColor = false;
            btnSelectAllAttackers.Click += btnSelectAllAttackers_Click;
            // 
            // btnDeselectAllAttackers
            // 
            btnDeselectAllAttackers.BackColor = Color.White;
            btnDeselectAllAttackers.Location = new Point(94, 297);
            btnDeselectAllAttackers.Margin = new Padding(3, 2, 3, 2);
            btnDeselectAllAttackers.Name = "btnDeselectAllAttackers";
            btnDeselectAllAttackers.Size = new Size(79, 22);
            btnDeselectAllAttackers.TabIndex = 7;
            btnDeselectAllAttackers.Text = "Deselect All";
            btnDeselectAllAttackers.UseVisualStyleBackColor = false;
            btnDeselectAllAttackers.Click += btnDeselectAllAttackers_Click;
            // 
            // btnSelectAllDefenders
            // 
            btnSelectAllDefenders.BackColor = Color.White;
            btnSelectAllDefenders.Location = new Point(350, 297);
            btnSelectAllDefenders.Margin = new Padding(3, 2, 3, 2);
            btnSelectAllDefenders.Name = "btnSelectAllDefenders";
            btnSelectAllDefenders.Size = new Size(70, 22);
            btnSelectAllDefenders.TabIndex = 8;
            btnSelectAllDefenders.Text = "Select All";
            btnSelectAllDefenders.UseVisualStyleBackColor = false;
            btnSelectAllDefenders.Click += btnSelectAllDefenders_Click;
            // 
            // btnDeselectAllDefenders
            // 
            btnDeselectAllDefenders.BackColor = Color.White;
            btnDeselectAllDefenders.Location = new Point(426, 297);
            btnDeselectAllDefenders.Margin = new Padding(3, 2, 3, 2);
            btnDeselectAllDefenders.Name = "btnDeselectAllDefenders";
            btnDeselectAllDefenders.Size = new Size(79, 22);
            btnDeselectAllDefenders.TabIndex = 9;
            btnDeselectAllDefenders.Text = "Deselect All";
            btnDeselectAllDefenders.UseVisualStyleBackColor = false;
            btnDeselectAllDefenders.Click += btnDeselectAllDefenders_Click;
            // 
            // btnSavePreset
            // 
            btnSavePreset.BackColor = Color.White;
            btnSavePreset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSavePreset.Location = new Point(18, 362);
            btnSavePreset.Margin = new Padding(3, 2, 3, 2);
            btnSavePreset.Name = "btnSavePreset";
            btnSavePreset.Size = new Size(105, 26);
            btnSavePreset.TabIndex = 10;
            btnSavePreset.Text = "Save Preset";
            btnSavePreset.UseVisualStyleBackColor = false;
            btnSavePreset.Click += btnSavePreset_Click;
            // 
            // btnLoadPreset
            // 
            btnLoadPreset.BackColor = Color.White;
            btnLoadPreset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLoadPreset.Location = new Point(129, 362);
            btnLoadPreset.Margin = new Padding(3, 2, 3, 2);
            btnLoadPreset.Name = "btnLoadPreset";
            btnLoadPreset.Size = new Size(105, 26);
            btnLoadPreset.TabIndex = 11;
            btnLoadPreset.Text = "Load Preset";
            btnLoadPreset.UseVisualStyleBackColor = false;
            btnLoadPreset.Click += btnLoadPreset_Click;
            // 
            // SelectivePickerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(682, 399);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "SelectivePickerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Selective Operator Picker";
            ResumeLayout(false);
        }

        #endregion
    }
}
