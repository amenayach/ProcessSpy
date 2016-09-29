using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessSpy
{
    public partial class MainForm : Form
    {

        private Timer _timer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _timer = new Timer() { Interval =  1000};
            _timer.Tick += Tm_Tick;
            _timer.Start();
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            GetProcess(false);
        }

        private void GetProcess(bool copyToClipBoard)
        {
            NativeMethods.POINT p;

            if (NativeMethods.GetCursorPos(out p))
            {
                IntPtr hWnd = NativeMethods.WindowFromPoint(p);

                IntPtr processId;

                NativeMethods.GetWindowThreadProcessId(hWnd, out processId);

                rtbProcessFilename.Text = Process.GetProcessById(processId.ToInt32()).MainModule.FileName;

                if (copyToClipBoard)
                {
                    Clipboard.SetText(rtbProcessFilename.Text);
                }

            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
