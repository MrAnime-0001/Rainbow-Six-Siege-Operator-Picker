using System.Media;

public static class ToastNotifier
{
    private static bool toastActive = false;

    public static async void ShowToast(string message, int duration = 2000, bool playSound = true)
    {
        if (toastActive)
            return; // Exit if a toast is already active

        toastActive = true;

        Form toast = new Form
        {
            FormBorderStyle = FormBorderStyle.None,
            StartPosition = FormStartPosition.Manual,
            ShowInTaskbar = false,
            TopMost = true,
            BackColor = Color.FromArgb(45, 45, 48),
            Size = new Size(250, 60),
            Opacity = 0.9
        };

        Label lbl = new Label
        {
            Text = message,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.Transparent
        };

        toast.Controls.Add(lbl);

        // Position toast at the bottom-right of the screen
        var workingArea = Screen.PrimaryScreen.WorkingArea;
        toast.Location = new Point(workingArea.Right - toast.Width - 10, workingArea.Bottom - toast.Height - 10);

        toast.Shown += async (s, e) =>
        {
            if (playSound)
                SystemSounds.Exclamation.Play();

            await Task.Delay(duration);
            toast.Close();
            toastActive = false; // Reset flag when toast closes
        };

        toast.Show();
    }
}
