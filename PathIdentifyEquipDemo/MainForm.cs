﻿using DAL;
using DataDict.Models;
using PathIdentifyDrivers;
using PathIdentifyEquipDemo.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PathIdentifyEquipDemo
{
    public partial class MainForm : Form
    {
        private Dictionary<int, TreeNode> TreeNodeDict = new Dictionary<int, TreeNode>();

        public MainForm()
        {
            InitializeComponent();
            DataReceiveLogGrid.AutoGenerateColumns = false;
            Cache.Init();
            InitEquipTree();
        }

        #region 初始化界面

        private void InitEquipTree()
        {
            EquipTreeView.Nodes.Clear();
            //  T_PathIdentifyEquip[] rootEquips = Cache.PathIdEquips.Where(it => it.ParentId == -1).ToArray();
            foreach (T_PathIdentifyEquip equip in Cache.PathIdEquips)
            {
                TreeNode CurrentRootNode = new TreeNode(equip.EquipName);
                CurrentRootNode.ImageIndex = 2;
                CurrentRootNode.Tag = equip;
                if (TreeNodeDict.Keys.Contains(equip.Id))
                {
                    TreeNodeDict[equip.Id] = CurrentRootNode;
                }
                else
                {
                    TreeNodeDict.Add(equip.Id, CurrentRootNode);
                }
                EquipTreeView.Nodes.Add(CurrentRootNode);
                T_PathIdentifyEquip[] childEquips = Cache.PathIdEquips.Where(it => it.ParentId == equip.Id).ToArray();
                foreach (T_PathIdentifyEquip ce in childEquips)
                {
                    TreeNode node = new TreeNode(ce.EquipName);
                    node.ImageIndex = 2;
                    node.Tag = ce;

                    CurrentRootNode.Nodes.Add(node);
                    if (TreeNodeDict.Keys.Contains(ce.Id))
                    {
                        TreeNodeDict[ce.Id] = node;
                    }
                    else
                    {
                        TreeNodeDict.Add(ce.Id, node);
                    }
                }
            }
            EquipTreeView.ExpandAll();
        }

        #endregion 初始化界面

        private void EquipTreeContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "AddEquipToolStripMenuItem":
                    {
                        AddEquipForm form = new AddEquipForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            InitEquipTree();
                        }
                    } break;
                case "ModifyEquipToolStripMenuItem":
                    {
                        if (EquipTreeView.SelectedNode != null && EquipTreeView.SelectedNode.Tag != null)
                        {
                            T_PathIdentifyEquip equip = (T_PathIdentifyEquip)EquipTreeView.SelectedNode.Tag;
                            AddEquipForm form = new AddEquipForm(equip);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                InitEquipTree();
                            }
                        }
                    } break;
                case "DelEquipToolStripMenuItem":
                    {
                        if (EquipTreeView.SelectedNode != null)
                        {
                            if (EquipTreeView.SelectedNode.GetNodeCount(true) > 0)
                            {
                                if (MessageBox.Show("确定删除此节点设备及其下属所有设备？", "删除设备组", MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    foreach (TreeNode node in EquipTreeView.SelectedNode.Nodes)
                                    {
                                        T_PathIdentifyEquip equip = (T_PathIdentifyEquip)node.Tag;
                                        Cache.RemoveEquip(equip);
                                        node.Remove();
                                    }
                                    T_PathIdentifyEquip selectedEquip = (T_PathIdentifyEquip)EquipTreeView.SelectedNode.Tag;
                                    Cache.RemoveEquip(selectedEquip);
                                    EquipTreeView.SelectedNode.Remove();
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("确定删除此节点设备设备？", "删除设备", MessageBoxButtons.OKCancel
                                   , MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    T_PathIdentifyEquip selectedEquip = (T_PathIdentifyEquip)EquipTreeView.SelectedNode.Tag;
                                    Cache.RemoveEquip(selectedEquip);
                                    EquipTreeView.SelectedNode.Remove();
                                }
                            }
                            InitEquipTree();
                        }
                    } break;
                case "ProofTimeToolStripMenuItem":
                    {
                        AppendText("设备校时开始");
                        if (EquipTreeView.SelectedNode != null)
                        {
                            T_PathIdentifyEquip selectedEquip = (T_PathIdentifyEquip)EquipTreeView.SelectedNode.Tag;
                            bool rel = DriverWrapper.ProofTime(selectedEquip.Id);
                            if (rel)
                            {
                                AppendText(string.Format("设备-{0}校时成功。", selectedEquip.EquipName));
                            }
                            else
                            {
                                AppendText(string.Format("设备-{0}校时失败。", selectedEquip.EquipName));
                            }
                        }
                        else
                        {
                            AppendText("设备树上未选择有效的设备");
                        }
                        AppendText("设备校时结束");
                    } break;
                case "RetransDataToolStripMenuItem":
                    {
                        AppendText("设置重传...");
                        if (EquipTreeView.SelectedNode != null)
                        {
                            T_PathIdentifyEquip selectedEquip = (T_PathIdentifyEquip)EquipTreeView.SelectedNode.Tag;
                            RetransDataForm form = new RetransDataForm();
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                bool rel = DriverWrapper.SetRetransData(selectedEquip.Id, form.StartTime, form.EndTime);
                                if (rel)
                                {
                                    AppendText(string.Format("设备-{0}设置重传成功。StartTime:{1}-EndTime:{2}"
                                        , selectedEquip.EquipName, form.StartTime, form.EndTime));
                                }
                                else
                                {
                                    AppendText(string.Format("设备-{0}设置重传失败。StartTime:{1}-EndTime:{2}"
                                        , selectedEquip.EquipName, form.StartTime, form.EndTime));
                                }
                            }
                            else
                            {
                                AppendText("设置重传取消");
                            }
                        }
                        else
                        {
                            AppendText("设备树上未选择有效的设备");
                        }
                        AppendText("设置重传完成");
                    } break;
                case "AllExpendToolStripMenuItem":
                    {
                        EquipTreeView.ExpandAll();
                    } break;
                case "AllCollapseToolStripMenuItem":
                    {
                        EquipTreeView.CollapseAll();
                    } break;
            }
        }

        private void picImage_DoubleClick(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            PictureBoxSizeMode sizemode = PictureBoxSizeMode.StretchImage;
            if (box.Image.Width < 200 || box.Image.Height < 200)
                sizemode = PictureBoxSizeMode.CenterImage;
            ImagePreviewForm form = new ImagePreviewForm(box.Image, sizemode);
            form.ShowDialog();
        }

        private void btnInitDriver_Click(object sender, EventArgs e)
        {
            try
            {
                DriverWrapper.DeviceStatusNotifyHandler = OnDeviceStatusChanged;
                DriverWrapper.VehicleInfoReceiveNotifyHandler = OnVehicleInfoNotified;
                bool rel = DriverWrapper.Init(ConfigurationManager.AppSettings["ImageSavePath"]);

                if (rel)
                {
                    btnInitDriver.Text = "已启动";
                    btnInitDriver.Enabled = false;
                    AppendText("初始化驱动完成");
                    //T_PathIdentifyEquip[] parentEquips = Cache.PathIdEquips.Where(it => it.ParentId == -1).ToArray();
                    foreach (T_PathIdentifyEquip equip in Cache.PathIdEquips)
                    {
                        try
                        {
                            //DriverWrapper.Connect(equip.ParentId);
                            bool connRel = DriverWrapper.GetConnectStatus(equip.Id);
                            if (connRel)
                            {
                                AppendText(string.Format("{0}设备连接成功。", equip.EquipName));
                                if (TreeNodeDict.Keys.Contains(equip.Id))
                                {
                                    TreeNodeDict[equip.Id].ImageIndex = 0;
                                }
                            }
                            else
                            {
                                AppendText(string.Format("{0}设备连接失败。", equip.EquipName));
                                if (TreeNodeDict.Keys.Contains(equip.Id))
                                {
                                    TreeNodeDict[equip.Id].ImageIndex = 1;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            AppendText(string.Format("{0}设备连接连接时发生异常：{1}", equip.EquipName, ex.Message));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("初始化驱动发生异常！");
                    AppendText("初始化驱动发生异常！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化驱动时发生异常，详细如下：\r\n" + ex.Message);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm();
            form.ShowDialog();
        }

        #region 驱动事件回调

        private void OnDeviceStatusChanged(object sender, DeviceStatus args)
        {
            string format = string.Format("【状态改变】设备:{0} 状态发生改变->{1}  时间：{2}", args.Device.EquipName,
                args.StatusDesc, args.GatherTime.ToString());
            AppendText(format);
            if (TreeNodeDict.Keys.Contains(args.Device.Id))
            {
                if (args.Status == 0)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        TreeNodeDict[args.Device.Id].ImageIndex = 0;
                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        TreeNodeDict[args.Device.Id].ImageIndex = 1;
                    });
                }
            }
        }

        private void OnVehicleInfoNotified(object sender, VehicleInfoReceiveEventArgs args)
        {
            string format = string.Format("【车辆通过】设备：{0} 接收到数据，车牌：{1}  通过时间：{2}",
                args.Device.EquipName, args.VehiclePlateNo, args.ReachTime.ToString());
            this.Invoke((MethodInvoker)delegate
            {
                int rowIndex = DataReceiveLogGrid.Rows.Add();
                DataGridViewRow row = DataReceiveLogGrid.Rows[rowIndex];
                row.Cells["colId"].Value = args.Device.Id;
                row.Cells["colImageFullPath"].Value = args.DbData.ImageAllPath;
                row.Cells["colImageNear"].Value = args.DbData.ImageNearPath;
                row.Cells["colVehiclePlate"].Value = args.DbData.ImagePlateNoPath;
                row.Cells["colBinVehiclePlate"].Value = args.DbData.ImageBinPlateNoPath;
                row.Cells["colEquipName"].Value = args.Device.EquipName;
                row.Cells["colVehPlateNo"].Value = args.VehiclePlateNo;
                row.Cells["colVehPlateColor"].Value = args.VehiclePlateColor;
                row.Cells["colReachTime"].Value = args.ReachTime.ToString();
                row.Cells["colVehSpeed"].Value = args.VehicleSpeed;
            });
        }

        #endregion 驱动事件回调

        private void AppendText(string content)
        {
            if (txtLog.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (txtLog.Lines.Length > 200)
                    {
                        txtLog.Clear();
                    }
                    txtLog.AppendText(content + "\r\n");
                });
            }
            else
            {
                if (txtLog.Lines.Length > 200)
                {
                    txtLog.Clear();
                }
                txtLog.AppendText(content + "\r\n");
            }
        }

        private void DataReceiveLogGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataReceiveLogGrid.Rows[e.RowIndex].Cells["colId"].Value != null)
            {
                if (DataReceiveLogGrid.Rows[e.RowIndex].Cells["colImageFullPath"].Value != null &&
                    !string.IsNullOrEmpty(DataReceiveLogGrid.Rows[e.RowIndex].Cells["colImageFullPath"].Value.ToString()))
                {
                    picImageAll.Image = Image.FromFile(DataReceiveLogGrid.Rows[e.RowIndex].Cells["colImageFullPath"].Value.ToString());
                }
                else
                {
                    picImageAll.Image = Properties.Resources.NonImage;
                }

                if (DataReceiveLogGrid.Rows[e.RowIndex].Cells["colImageNear"].Value != null &&
                    !string.IsNullOrEmpty(DataReceiveLogGrid.Rows[e.RowIndex].Cells["colImageNear"].Value.ToString()))
                {
                    picImageNear.Image = Image.FromFile(DataReceiveLogGrid.Rows[e.RowIndex].Cells["colImageNear"].Value.ToString());
                }
                else
                {
                    picImageNear.Image = Properties.Resources.NonImage;
                }

                if (DataReceiveLogGrid.Rows[e.RowIndex].Cells["colVehiclePlate"].Value != null &&
                    !string.IsNullOrEmpty(DataReceiveLogGrid.Rows[e.RowIndex].Cells["colVehiclePlate"].Value.ToString()))
                {
                    picVehiclePlate.Image = Image.FromFile(DataReceiveLogGrid.Rows[e.RowIndex].Cells["colVehiclePlate"].Value.ToString());
                }
                else
                {
                    picVehiclePlate.Image = Properties.Resources.NonImage_Small;
                }

                if (DataReceiveLogGrid.Rows[e.RowIndex].Cells["colBinVehiclePlate"].Value != null &&
                    !string.IsNullOrEmpty(DataReceiveLogGrid.Rows[e.RowIndex].Cells["colBinVehiclePlate"].Value.ToString()))
                {
                    try
                    {
                        picBinVehiclePlate.Image = Image.FromFile(DataReceiveLogGrid.Rows[e.RowIndex].Cells["colBinVehiclePlate"].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        picBinVehiclePlate.Image = Properties.Resources.NonImage_Small;
                    }// Bitmap i=Bitmap.
                }
                else
                {
                    picBinVehiclePlate.Image = Properties.Resources.NonImage_Small;
                }
            }
        }

        private void btnReadHistoryData_Click(object sender, EventArgs e)
        {
            AppendText("【获取历史数据】开始");
            Thread t = new Thread(() =>
            {
                T_ReceiveData[] datas = DAL_ReceiveData.GetAllDatas();
                this.Invoke((MethodInvoker)delegate
                {
                    DataReceiveLogGrid.Rows.Clear();
                });
                foreach (T_ReceiveData item in datas)
                {
                    T_PathIdentifyEquip equip = Cache.PathIdEquips.Where(it => it.Id == item.EquipId).FirstOrDefault();
                    this.Invoke((MethodInvoker)delegate
                    {
                        int rowIndex = DataReceiveLogGrid.Rows.Add();
                        DataGridViewRow row = DataReceiveLogGrid.Rows[rowIndex];
                        row.Cells["colId"].Value = item.EquipId;
                        row.Cells["colImageFullPath"].Value = item.ImageAllPath;
                        row.Cells["colImageNear"].Value = item.ImageNearPath;
                        row.Cells["colVehiclePlate"].Value = item.ImagePlateNoPath;
                        row.Cells["colBinVehiclePlate"].Value = item.ImageBinPlateNoPath;
                        row.Cells["colEquipName"].Value = equip == null ? "未知设备" : equip.EquipName;
                        row.Cells["colVehPlateNo"].Value = item.VehPlateNo;
                        row.Cells["colVehPlateColor"].Value = item.VehPlateColor;
                        row.Cells["colReachTime"].Value = item.ReachTime.ToString();
                        row.Cells["colVehSpeed"].Value = item.VehicleSpeed;
                    });
                }
                AppendText("【获取历史数据】完成");
            });
            t.IsBackground = true;
            t.Start();
        }

        private void EquipTreeContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (EquipTreeView.SelectedNode == null || EquipTreeView.SelectedNode.Tag == null)
            {
                ModifyEquipToolStripMenuItem.Visible = false;
                DelEquipToolStripMenuItem.Visible = false;
                ProofTimeToolStripMenuItem.Visible = false;
                RetransDataToolStripMenuItem.Visible = false;
            }
            else
            {
                ModifyEquipToolStripMenuItem.Visible = true;
                DelEquipToolStripMenuItem.Visible = true;
                ProofTimeToolStripMenuItem.Visible = true;
                RetransDataToolStripMenuItem.Visible = true;
            }
        }
    }
}