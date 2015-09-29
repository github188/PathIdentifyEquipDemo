using DAL;
using DataDict;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathIdentifyEquipDemo.Dialogs
{
    public partial class AddEquipForm : Form
    {
        public T_PathIdentifyEquip ResultEquip
        {
            get;
            set;
        }

        public AddEquipForm()
        {
            InitializeComponent();
            InitUI();
            this.Text = "添加设备";
            ResultEquip = new T_PathIdentifyEquip();
        }

        public AddEquipForm(T_PathIdentifyEquip equip)
        {
            InitializeComponent();
            InitUI();
            ResultEquip = equip;
            this.Text = "修改设备-" + equip.EquipName;
            txtEquipName.Text = equip.EquipName;
            //if (equip.ParentId != -1)
            //{
            //    cmbParentEquip.SelectedValue = equip.ParentId;
            //}
            txtGroupId.Text = equip.ParentId.ToString();

            txtIP.Text = equip.Ip;
            nudPort.Value = equip.Port ?? 0;
            txtUserName.Text = equip.LoginUserName;
            txtPwd.Text = equip.LoginPwd;
            cmbDriverType.SelectedValue = equip.ProtocolId;
            txtMile.Text = equip.Mile;
            if (equip.EquipType == 0)
            {
                rbRecognizer.Checked = true;
            }
            else
            {
                rbCamera.Checked = true;
            }
        }

        private void InitUI()
        {
            //cmbParentEquip.DataSource = Cache.PathIdEquips.Where(it => it.EquipType == 0 && it.ParentId == -1).ToArray();
            //cmbParentEquip.DisplayMember = "EquipName";
            //cmbParentEquip.ValueMember = "Id";
            //cmbParentEquip.SelectedIndex = -1;

            cmbDriverType.DataSource = Cache.DataDictCache.Where(it => it.FName == ConstValue.DRIVERTYPE).ToArray();
            cmbDriverType.DisplayMember = "FDesc";
            cmbDriverType.ValueMember = "FValue";
            if (cmbDriverType.Items.Count > 0)
                cmbDriverType.SelectedIndex = 0;
        }

        private bool CheckValue()
        {
            if (string.IsNullOrEmpty(txtEquipName.Text))
            {
                MessageBox.Show("设备名称不可为空。");
                txtEquipName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtGroupId.Text))
            {
                MessageBox.Show("设备组ID不可为空。");
                txtGroupId.Focus();
                return false;
            }
            else
            {
                int gid;
                bool convertrel = Int32.TryParse(txtGroupId.Text, out gid);
                if (convertrel == false)
                {
                    MessageBox.Show("设备组ID必须为整数。");
                    txtGroupId.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtIP.Text))
            {
                MessageBox.Show("IP地址不可为空。");
                txtIP.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                ResultEquip.EquipName = txtEquipName.Text;
                ResultEquip.EquipType = rbRecognizer.Checked ? 0 : 1;
                ResultEquip.Ip = txtIP.Text;
                ResultEquip.LoginPwd = txtPwd.Text;
                ResultEquip.LoginUserName = txtUserName.Text;
                ResultEquip.Mile = txtMile.Text;
                ResultEquip.ParentId = Convert.ToInt32(txtGroupId.Text);
                //if (string.IsNullOrEmpty(cmbParentEquip.Text))
                //{
                //    ResultEquip.ParentId = -1;
                //}
                //else
                //{
                //    ResultEquip.ParentId = ((T_PathIdentifyEquip)cmbParentEquip.SelectedItem).Id;
                //}
                ResultEquip.Port = (int)nudPort.Value;
                ResultEquip.ProtocolId = ((T_DataDict)cmbDriverType.SelectedItem).FValue;
                DAL_Equip.SaveOrModifyEquip(ResultEquip);
                Cache.InitAllPathIdEquip();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}