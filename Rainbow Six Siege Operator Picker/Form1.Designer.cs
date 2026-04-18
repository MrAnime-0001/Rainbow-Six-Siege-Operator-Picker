namespace Rainbow_Six_Siege_Operator_Picker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            btnPickAttacker = new Button();
            btnPickDefender = new Button();
            lblResult = new Label();
            pictureBox = new PictureBox();
            btnSelectOperators = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Location = new Point(0, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 28);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "OPERATOR PICKER";
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // btnPickAttacker
            btnPickAttacker.Location = new Point(12, 48);
            btnPickAttacker.Name = "btnPickAttacker";
            btnPickAttacker.Size = new Size(122, 38);
            btnPickAttacker.TabIndex = 0;
            btnPickAttacker.Text = "Pick Attacker";
            btnPickAttacker.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPickAttacker.FlatStyle = FlatStyle.Flat;
            btnPickAttacker.BackColor = Color.FromArgb(55, 55, 60);
            btnPickAttacker.ForeColor = Color.White;
            btnPickAttacker.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 82);
            btnPickAttacker.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 78);
            btnPickAttacker.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 46);
            btnPickAttacker.UseVisualStyleBackColor = false;
            btnPickAttacker.Click += btnPickAttacker_Click;

            // btnPickDefender
            btnPickDefender.Location = new Point(146, 48);
            btnPickDefender.Name = "btnPickDefender";
            btnPickDefender.Size = new Size(122, 38);
            btnPickDefender.TabIndex = 1;
            btnPickDefender.Text = "Pick Defender";
            btnPickDefender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPickDefender.FlatStyle = FlatStyle.Flat;
            btnPickDefender.BackColor = Color.FromArgb(55, 55, 60);
            btnPickDefender.ForeColor = Color.White;
            btnPickDefender.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 82);
            btnPickDefender.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 78);
            btnPickDefender.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 46);
            btnPickDefender.UseVisualStyleBackColor = false;
            btnPickDefender.Click += btnPickDefender_Click;

            // btnSelectOperators
            btnSelectOperators.Location = new Point(12, 96);
            btnSelectOperators.Name = "btnSelectOperators";
            btnSelectOperators.Size = new Size(256, 38);
            btnSelectOperators.TabIndex = 2;
            btnSelectOperators.Text = "Choose Pickable Operators";
            btnSelectOperators.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelectOperators.FlatStyle = FlatStyle.Flat;
            btnSelectOperators.BackColor = Color.FromArgb(55, 55, 60);
            btnSelectOperators.ForeColor = Color.White;
            btnSelectOperators.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 82);
            btnSelectOperators.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 78);
            btnSelectOperators.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 46);
            btnSelectOperators.UseVisualStyleBackColor = false;
            btnSelectOperators.Click += btnSelectOperators_Click;

            // lblResult
            lblResult.AutoSize = false;
            lblResult.Location = new Point(12, 146);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(256, 22);
            lblResult.TabIndex = 3;
            lblResult.Text = "N/A";
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResult.ForeColor = Color.White;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;

            // pictureBox
            pictureBox.Location = new Point(12, 176);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(256, 240);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            ClientSize = new Size(280, 430);
            Controls.Add(lblTitle);
            Controls.Add(btnSelectOperators);
            Controls.Add(pictureBox);
            Controls.Add(lblResult);
            Controls.Add(btnPickDefender);
            Controls.Add(btnPickAttacker);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operator Picker";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnPickAttacker;
        private Button btnPickDefender;
        private Label lblResult;
        private PictureBox pictureBox;
        private Button btnSelectOperators;
    }
}
