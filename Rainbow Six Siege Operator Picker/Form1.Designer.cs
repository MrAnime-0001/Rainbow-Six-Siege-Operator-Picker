namespace Rainbow_Six_Siege_Operator_Picker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPickAttacker = new Button();
            btnPickDefender = new Button();
            lblResult = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnPickAttacker
            // 
            btnPickAttacker.Location = new Point(12, 12);
            btnPickAttacker.Name = "btnPickAttacker";
            btnPickAttacker.Size = new Size(100, 23);
            btnPickAttacker.TabIndex = 0;
            btnPickAttacker.Text = "Pick Attacker";
            btnPickAttacker.UseVisualStyleBackColor = true;
            btnPickAttacker.Click += btnPickAttacker_Click;
            // 
            // btnPickDefender
            // 
            btnPickDefender.Location = new Point(132, 12);
            btnPickDefender.Name = "btnPickDefender";
            btnPickDefender.Size = new Size(100, 23);
            btnPickDefender.TabIndex = 1;
            btnPickDefender.Text = "Pick Defender";
            btnPickDefender.UseVisualStyleBackColor = true;
            btnPickDefender.Click += btnPickDefender_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(12, 38);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(29, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "N/A";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 56);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(220, 220);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(243, 290);
            Controls.Add(pictureBox);
            Controls.Add(lblResult);
            Controls.Add(btnPickDefender);
            Controls.Add(btnPickAttacker);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operator Picker";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPickAttacker;
        private Button btnPickDefender;
        private Label lblResult;
        private PictureBox pictureBox;
    }
}
