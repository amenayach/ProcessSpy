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

        private void Form1_Load(object sender, EventArgs e)
        {
            _timer = new Timer() { Interval =  1000};
            _timer.Tick += Tm_Tick;
            _timer.Start();
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            NativeMethods.POINT p;

            if (NativeMethods.GetCursorPos(out p))
            {

                IntPtr hWnd = NativeMethods.WindowFromPoint(p);

                IntPtr processId;
                NativeMethods.GetWindowThreadProcessId(hWnd, out processId);
                richTextBox1.Text = Process.GetProcessById(processId.ToInt32()).MainModule.FileName;

            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
