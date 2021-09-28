using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieHelper
{
    public partial class FormMain : Form
    {
        private AboutBox formAboutBox;
        private static Int32 _clickCount = 0;

        public FormMain()
        {
            InitializeComponent();
            timer.Interval = tpTime.Time;
            tpTime.PropertyChanged += new PropertyChangedEventHandler(tpTime_PropertyChanged);
        }

        void tpTime_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            lblStatus_Info.Text = string.Format("Value:{0}", tpTime.Time);
        }

        #region Timer
        private void timer_Tick(object sender, EventArgs e)
        {
            //this.notifyIcon.ShowBalloonTip(2000,
            //    "Times Up", "Your Time Is Up Baby...", ToolTipIcon.Info);
            MouseEvents.Click();
            MouseEvents.DrawLine(MouseEvents.DirectionType.Yplus, 20);
            MouseEvents.DrawLine(MouseEvents.DirectionType.Yminus, 20);

            lblStatus_TimesClicked.Text = string.Format("{0} Times Clicked.", ++_clickCount);
        }
        #endregion

        #region Notify Icon Context Menu
        private void contextClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void contextOpen_Click(object sender, EventArgs e)
        {
            notifyIcon_MouseDoubleClick(null, null);
        }

        #endregion

        #region Form Client
        private void FormClient_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.notifyIcon.ShowBalloonTip(500,
                    "Movie Helper",
                    string.Format("Within every {0} , mouse clicks once for you.", tpTime.ShowTimeAsString()),
                    ToolTipIcon.Info);
            }
        }
        #endregion

        #region Notify Icon
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Opacity = 100;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        #endregion

        #region Menu Buttons

        private void menuFile_Close_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            timer.Interval = tpTime.Time;
            lblStatus_Info.Text = string.Format("Time Set:{0}", tpTime.Time);
        }

        private void drawShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDrawShapes fds = new FormDrawShapes();
            fds.Show();
        }

        private void menuTools_Registry_Click(object sender, EventArgs e)
        {
            FormRegistryWorker frw = new FormRegistryWorker();
            frw.ShowDialog(this);
        }

        private void menuHelp_About_Click_1(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog(this);
        }

        private void menuFile_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuTools_Mouse_Click(object sender, EventArgs e)
        {
            FormDrawShapes mou = new FormDrawShapes();
            mou.ShowDialog(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Validator.Check(this);
        }
    }
}