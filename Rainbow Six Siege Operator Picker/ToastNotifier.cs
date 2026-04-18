using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class ToastNotifier
{
    private static bool toastActive = false;

    public static async void ShowToast(string message, int duration = 2000, bool playSound = true)
    {
        if (toastActive)
            return;

        toastActive = true;

        Size size = new Size(250, 60);
        int margin = 10;

        Form toast = new Form
        {
            FormBorderStyle = FormBorderStyle.FixedToolWindow,
            StartPosition = FormStartPosition.Manual,
            ShowInTaskbar = false,
            TopMost = true,
            ControlBox = false,
            Text = string.Empty,
            BackColor = Color.Black,
            Size = size,
            Opacity = 0.9
        };

        toast.Controls.Add(new Label
        {
            Text = message,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.Transparent
        });

        var screen = Screen.PrimaryScreen.WorkingArea;
        toast.Location = new Point(
            screen.Right - toast.Width - margin,
            screen.Bottom - toast.Height - margin
        );

        toast.Shown += async (s, e) =>
        {
            if (playSound)
                SystemSounds.Exclamation.Play();

            await Task.Delay(duration);

            for (double i = toast.Opacity; i >= 0; i -= 0.05)
            {
                if (toast.IsDisposed) break;
                toast.Invoke((Action)(() => toast.Opacity = i));
                await Task.Delay(20);
            }

            if (!toast.IsDisposed)
                toast.Invoke((Action)(() => toast.Close()));

            toastActive = false;
        };

        toast.Show();
    }
}
