using System;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace Rainbow_Six_Siege_Operator_Picker
{
    internal class HotkeyHandler : IDisposable
    {
        private readonly IKeyboardMouseEvents globalHook;
        private readonly System.Windows.Forms.Timer cooldownTimer;
        private bool onCooldown = false;

        public bool Enabled { get; set; } = true;

        public event Action AttackerHotkeyPressed;
        public event Action DefenderHotkeyPressed;

        public HotkeyHandler(int cooldownDuration = 2000)
        {
            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += OnKeyDown;

            cooldownTimer = new System.Windows.Forms.Timer { Interval = cooldownDuration };
            cooldownTimer.Tick += (s, e) =>
            {
                onCooldown = false;
                cooldownTimer.Stop();
            };
        }

        // Starts cooldown and returns true. Returns false if already on cooldown.
        public bool TryStartCooldown()
        {
            if (onCooldown)
                return false;

            onCooldown = true;
            cooldownTimer.Start();
            return true;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (!Enabled || !e.Control || !e.Alt)
                return;

            if (e.KeyCode == Keys.NumPad1)
                TriggerWithCooldown(AttackerHotkeyPressed);
            else if (e.KeyCode == Keys.NumPad2)
                TriggerWithCooldown(DefenderHotkeyPressed);
        }

        private void TriggerWithCooldown(Action action)
        {
            if (!TryStartCooldown())
                return;

            action?.Invoke();
        }

        public void Dispose()
        {
            globalHook?.Dispose();
            cooldownTimer?.Dispose();
        }
    }
}
