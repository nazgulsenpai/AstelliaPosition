using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstelliaPosition
{
    public partial class frmAstellia : Form
    {
        public float curx, cury, curz, x, y, z;
        public long Xbase, X, Y, Z;

        private void CheckSignature_Tick(object sender, EventArgs e)
        {
            if(threadSignatureScan.IsBusy)
            {

            }
        }

        private void ThreadSignatureScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            { this.Text = "Scanning..."; buttonApply.Enabled = false; buttonSet.Enabled = false; }
            if (e.ProgressPercentage == 100)
            { this.Text = "Astellia Position Hack"; buttonApply.Enabled = true; buttonSet.Enabled = true; }
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            numX.Text = x.ToString();
            numY.Text = y.ToString();
            numZ.Text = z.ToString();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            m.writeMemory(Z.ToString("X"), "float", numX.Text);
            m.writeMemory(Y.ToString("X"), "float", numY.Text);
            m.writeMemory(Z.ToString("X"), "float", numZ.Text);
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            threadSignatureScan.RunWorkerAsync();
        }

        private void ThreadUpdater_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SetPos(x, y, z);
        }

        private void ThreadSignatureScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!threadUpdater.IsBusy) { threadUpdater.RunWorkerAsync(); }
        }

        private void ThreadUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                x = m.readFloat(String.Format("{0:X}", X));
                y = m.readFloat(String.Format("{0:X}", Y));
                z = m.readFloat(String.Format("{0:X}", Z));
                threadUpdater.ReportProgress(1);
                System.Threading.Thread.Sleep(500);
            }
        }

        public Mem m;
        private void ThreadSignatureScan_DoWork(object sender, DoWorkEventArgs e)
        {
            m = new Mem();
            curx = 0f; cury = 0f; curz = 0f;
            m.OpenProcess("Astellia");
            threadSignatureScan.ReportProgress(1);
            Xbase = m.AoBScan(Properties.Settings.Default.positionAOB, true, true).Result.FirstOrDefault();
            X = Xbase + 0x20;
            Y = X + 0x4;
            Z = X + 0x8;
            threadSignatureScan.ReportProgress(100);
        }

        public frmAstellia()
        {
            InitializeComponent();
        }

        private void Astellia_Load(object sender, EventArgs e)
        {
            m = new Mem();
            curx = 0f; cury = 0f; curz = 0f;
            m.OpenProcess("Astellia");
            threadSignatureScan.RunWorkerAsync();
        }

        public void SetPos(float x, float y, float z)
        {
            curx = x; cury = y; curz = z;
            curX.Text = curx.ToString();
            curY.Text = cury.ToString();
            curZ.Text = curz.ToString();
        }
    }
}
