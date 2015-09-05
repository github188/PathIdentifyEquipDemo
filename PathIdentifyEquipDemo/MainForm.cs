using DAL;
using PathIdentifyEquipDemo.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathIdentifyEquipDemo
{
    public partial class MainForm : Form
    {
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
            T_PathIdentifyEquip[] rootEquips = Cache.PathIdEquips.Where(it => it.ParentId == -1).ToArray();
            foreach (T_PathIdentifyEquip equip in rootEquips)
            {
                TreeNode CurrentRootNode = new TreeNode(equip.EquipName);
                CurrentRootNode.Tag = equip;
                EquipTreeView.Nodes.Add(CurrentRootNode);
                T_PathIdentifyEquip[] childEquips = Cache.PathIdEquips.Where(it => it.ParentId == equip.Id).ToArray();
                foreach (T_PathIdentifyEquip ce in childEquips)
                {
                    TreeNode node = new TreeNode(ce.EquipName);
                    CurrentRootNode.Tag = ce;
                    CurrentRootNode.Nodes.Add(node);
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
    }
}