using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Security.AccessControl;

namespace MovieHelper
{
    public partial class FormRegistryWorker : MovieHelper.MenuFormTemplete
    {
        String _path = @"\Software\Policies\Microsoft\Windows\Control Panel\Desktop";
        
        public FormRegistryWorker()
        {
            InitializeComponent();
            Boolean status = (Boolean)GetValue("ScreenSaveActive");
            if(status)
            { btnScreenSaverStatusChange.Text = "Deactivate"; }
            else
            { btnScreenSaverStatusChange.Text = "Activate"; }
            lblScreenSaverStatus.Text = status.ToString();
            txtScreenSaverTimeout.Text = GetValue("ScreenSaveTimeOut").ToString();
        }

        private void btnScreenSaverStatusChange_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean status = (Boolean)GetValue("ScreenSaveActive");
                if (status)
                {
                    this.SetValue("ScreenSaveActive", 0);
                    btnScreenSaverStatusChange.Text = "Activate";
                    lblInfo.Text = "Screen Saver is NOT active now.";
                }
                else
                {
                    this.SetValue("ScreenSaveActive", 1);
                    btnScreenSaverStatusChange.Text = "Deactivate";
                    lblInfo.Text = "Screen Saver is active now.";
                }
                lblScreenSaverStatus.Text = GetValue("ScreenSaveActive").ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnScreenSaverTimeout_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 timeout = Convert.ToInt32(txtScreenSaverTimeout.Text);
                this.SetValue("ScreenSaveTimeOut", timeout);
                lblInfo.Text = String.Format("ScreenSaver timeout set to {0}",
                    GetValue("ScreenSaveTimeOut").ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private Object GetValue(String name)
        {
            String path = String.Format("{0}{1}", FindRegKey(),_path);
            Object statusObj = Registry.Users.OpenSubKey(path).GetValue(name);
            Int32 intValue = Convert.ToInt32(statusObj);
            if (intValue == 0)
                return false;
            else if (intValue == 1)
                return true;
            else
                return intValue;
        }
        private void SetValue(String name, Object value)
        {
            try
            {
                String path = String.Format("{0}{1}", FindRegKey(), _path);
                Registry.Users.OpenSubKey(path, true).SetValue(name, Convert.ToString(value));
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You have not enough access permission.");
            }
        }

        private String FindRegKey()
        {
            String[] names = Registry.Users.GetSubKeyNames();

            foreach (String s in names)
            {
                if (s.Contains("S-1-5-21") && !s.Contains("_class"))
                {
                    return s;
                }
            }
            return String.Empty;
        }
    }
}

