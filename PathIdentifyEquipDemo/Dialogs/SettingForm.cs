using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathIdentifyEquipDemo.Dialogs
{
    public partial class SettingForm : Form
    {
        private string cntpl = @"metadata=res://*/PathIdentifyEquipDemoDB.csdl|res://*/PathIdentifyEquipDemoDB.ssdl|res://*/PathIdentifyEquipDemoDB.msl;provider=System.Data.SqlClient;provider connection string=';data source={0};initial catalog=PathIdentifyEquipDemoDB;user id={1};password={2};multipleactiveresultsets=True;App=EntityFramework'";

        public SettingForm()
        {
            InitializeComponent();
            string[] cnstrSplit = ConfigurationManager.ConnectionStrings["PathIdentifyEquipDemoDBEntities"].ConnectionString.Split(';');
            foreach (string item in cnstrSplit)
            {
                if (item.Contains("data source"))
                {
                    string[] ds = item.Split('=');
                    txtDbIP.Text = ds[2];
                }
                else if (item.Contains("user id"))
                {
                    string[] ds = item.Split('=');
                    txtDbUserName.Text = ds[1];
                }
                else if (item.Contains("password"))
                {
                    string[] ds = item.Split('=');
                    txtDbPwd.Text = ds[1];
                }
            }

            txtImageSavePath.Text = ConfigurationManager.AppSettings["ImageSavePath"];
        }

        private bool CheckValue()
        {
            if (string.IsNullOrEmpty(txtDbIP.Text))
            {
                MessageBox.Show("数据库IP地址不可为空！");
                txtDbIP.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDbUserName.Text))
            {
                MessageBox.Show("数据库登陆用户名不可为空！");
                txtDbUserName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtImageSavePath.Text))
            {
                MessageBox.Show("图片保存路径不可为空！");
                btnBrowser.Focus();
                return false;
            }
            return true;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(txtImageSavePath.Text))
            {
                dialog.SelectedPath = txtImageSavePath.Text;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtImageSavePath.Text = dialog.SelectedPath + "\\";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                string cnstr = string.Format(cntpl, txtDbIP.Text, txtDbUserName.Text, txtDbPwd.Text);
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                System.Configuration.ConnectionStringSettings cnsetting = new System.Configuration.ConnectionStringSettings("PathIdentifyEquipDemoDBEntities",
                    cnstr, "System.Data.EntityClient");
                config.ConnectionStrings.ConnectionStrings.Remove("PathIdentifyEquipDemoDBEntities");
                config.ConnectionStrings.ConnectionStrings.Add(cnsetting);
                config.AppSettings.Settings.Remove("ImageSavePath");
                config.AppSettings.Settings.Add("ImageSavePath", txtImageSavePath.Text);
                config.Save(ConfigurationSaveMode.Modified);
                config = null;
                this.DialogResult = DialogResult.OK;
                // System.Configuration.ConfigurationManager.ConnectionStrings.Add(cnsetting);
            }
        }
    }
}