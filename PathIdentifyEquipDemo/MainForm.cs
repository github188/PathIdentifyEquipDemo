using DAL;
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
        }

        #region 初始化界面

        private void InitEquipTree()
        {
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
        }

        #endregion 初始化界面
    }
}