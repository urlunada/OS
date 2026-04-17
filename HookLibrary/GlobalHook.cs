using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HookLibrary
{
    public class GlobalHook
    {
        private IntPtr _hookID = IntPtr.Zero;
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private HookProc _proc;

        // Событие для передачи данных в основное приложение
        public event Action<int, string> KeyCaught;

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        public GlobalHook()
        {
            _proc = HookCallback;
        }

        public void Install()
        {
            _hookID = SetWindowsHookEx(WH_KEYBOARD_LL, _proc,
                GetModuleHandle(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName), 0);
        }

        public void Uninstall()
        {
            if (_hookID != IntPtr.Zero)
            {
                UnhookWindowsHookEx(_hookID);
                _hookID = IntPtr.Zero;
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;

                // Отправляем данные в основное приложение
                KeyCaught?.Invoke(vkCode, key.ToString());
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
    }
}