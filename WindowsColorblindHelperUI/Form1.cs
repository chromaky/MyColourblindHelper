using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsColorblindHelperUI
{
    public partial class Form1 : Form
    {
        // For dragging custom titlebar. I trust this I guess.
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Shadow!!!
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool GetColorFilterActiveValue()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\ColorFiltering"))
            {
                if (key != null)
                {
                    object value = key.GetValue("Active");
                    if (value != null)
                    {
                        return Convert.ToInt32(value) == 1;
                    }
                }
            }
            return false; // key or value doesn't exist → treat as inactive
        }

        private int? GetColorFilterTypeValue()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\ColorFiltering"))
            {
                if (key != null)
                {
                    object value = key.GetValue("FilterType");
                    if (value != null)
                    {
                        return Convert.ToInt32(value);
                    }
                }
            }
            return null; // key or value doesn't exist
        }

        bool isToggled = false;
        bool isGrayScale = false;
        bool isProtan = false;

        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;
            this.titlebar.MouseDown += new MouseEventHandler(panelTitleBar_MouseDown);

            if (GetColorFilterActiveValue())
            {
                // Debug.WriteLine("Your debug message here");
                isToggled = true;
                ToggleFilter.Image = Properties.Resources.on1;
            }

            if(GetColorFilterTypeValue() == 0)
            {
                // Debug.WriteLine("grey");
                isGrayScale = true;
                Grayscale.Image = Properties.Resources.on1;
            }

            if (GetColorFilterTypeValue() == 4)
            {
                // Debug.WriteLine("protan");
                Protan.Image = Properties.Resources.on1;
                isProtan = true;
            }


        }

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private const byte VK_LWIN = 0x5B;
        private const byte VK_CONTROL = 0x11;
        private const byte VK_C = 0x43;
        private const uint KEYEVENTF_KEYUP = 0x0002;

        private void ToggleFilter_Key()
        {
            // Press Win + Ctrl + C
            keybd_event(VK_LWIN, 0, 0, UIntPtr.Zero);
            keybd_event(VK_CONTROL, 0, 0, UIntPtr.Zero);
            keybd_event(VK_C, 0, 0, UIntPtr.Zero);

            // Release in reverse order
            keybd_event(VK_C, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
            keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
        }

        private void ToggleFilter_Click(object sender, EventArgs e)
        {
            if (isToggled == true)
            {
                isToggled = false;
                ToggleFilter.Image = Properties.Resources.off;
            } else
            {
                isToggled = true;
                ToggleFilter.Image = Properties.Resources.on1;
            }


            ToggleFilter_Key();
        }

        private void reToggleFix()
        {
            string command = "Set-ItemProperty -Path \"HKCU:\\Software\\Microsoft\\ColorFiltering\" -Name \"Active\" -Value 1";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{command}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
            }
        }

        private async void Grayscale_Click(object sender, EventArgs e)
        {
            if (isGrayScale == false)
            {
                isGrayScale = true;
                isProtan = false;

                Protan.Image = Properties.Resources.off;
                Grayscale.Image = Properties.Resources.on1;
            } else
            {
                return;
            }


            string command = "Set-ItemProperty -Path \"HKCU:\\Software\\Microsoft\\ColorFiltering\" -Name \"FilterType\" -Value 0";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{command}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
            }

            if (isToggled == true)
            {
                ToggleFilter_Key();
                await Task.Delay(10);
                ToggleFilter_Key();
            }

        }

        private async void Protan_Click(object sender, EventArgs e)
        {
            if (isProtan == false)
            {
                isGrayScale = false;
                isProtan = true;

                Protan.Image = Properties.Resources.on1;
                Grayscale.Image = Properties.Resources.off;
            } else
            {
                return;
            }


            string command = "Set-ItemProperty -Path \"HKCU:\\Software\\Microsoft\\ColorFiltering\" -Name \"FilterType\" -Value 4";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{command}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error: " + error);
                }
            }

            if (isToggled == true)
            {
                ToggleFilter_Key();
                await Task.Delay(10);
                ToggleFilter_Key();
            }


        }
    }
}
