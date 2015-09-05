﻿namespace PathIdentifyEquipDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainControlPanel = new System.Windows.Forms.Panel();
            this.btnInitDriver = new System.Windows.Forms.Button();
            this.EquipTreeView = new System.Windows.Forms.TreeView();
            this.EquipTreeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddEquipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelEquipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllExpendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllCollapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataReceiveLogGrid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehPlateColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReachTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ImageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.picImageAll = new System.Windows.Forms.PictureBox();
            this.picImageNear = new System.Windows.Forms.PictureBox();
            this.picVehiclePlate = new System.Windows.Forms.PictureBox();
            this.picBinVehiclePlate = new System.Windows.Forms.PictureBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.MainControlPanel.SuspendLayout();
            this.EquipTreeContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataReceiveLogGrid)).BeginInit();
            this.ImageTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageNear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehiclePlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBinVehiclePlate)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 3;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.MainTableLayoutPanel.Controls.Add(this.MainControlPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.EquipTreeView, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.DataReceiveLogGrid, 1, 1);
            this.MainTableLayoutPanel.Controls.Add(this.textBox1, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.ImageTableLayoutPanel, 2, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 3;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(892, 441);
            this.MainTableLayoutPanel.TabIndex = 1;
            // 
            // MainControlPanel
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.MainControlPanel, 3);
            this.MainControlPanel.Controls.Add(this.btnInitDriver);
            this.MainControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControlPanel.Location = new System.Drawing.Point(3, 3);
            this.MainControlPanel.Name = "MainControlPanel";
            this.MainControlPanel.Size = new System.Drawing.Size(886, 49);
            this.MainControlPanel.TabIndex = 0;
            // 
            // btnInitDriver
            // 
            this.btnInitDriver.Location = new System.Drawing.Point(19, 9);
            this.btnInitDriver.Name = "btnInitDriver";
            this.btnInitDriver.Size = new System.Drawing.Size(107, 36);
            this.btnInitDriver.TabIndex = 0;
            this.btnInitDriver.Text = "初始化";
            this.btnInitDriver.UseVisualStyleBackColor = true;
            // 
            // EquipTreeView
            // 
            this.EquipTreeView.ContextMenuStrip = this.EquipTreeContextMenuStrip;
            this.EquipTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipTreeView.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EquipTreeView.Location = new System.Drawing.Point(3, 58);
            this.EquipTreeView.Name = "EquipTreeView";
            this.EquipTreeView.Size = new System.Drawing.Size(244, 280);
            this.EquipTreeView.TabIndex = 1;
            // 
            // EquipTreeContextMenuStrip
            // 
            this.EquipTreeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEquipToolStripMenuItem,
            this.DelEquipToolStripMenuItem,
            this.AllExpendToolStripMenuItem,
            this.AllCollapseToolStripMenuItem});
            this.EquipTreeContextMenuStrip.Name = "EquipTreeContextMenuStrip";
            this.EquipTreeContextMenuStrip.Size = new System.Drawing.Size(125, 92);
            this.EquipTreeContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.EquipTreeContextMenuStrip_ItemClicked);
            // 
            // AddEquipToolStripMenuItem
            // 
            this.AddEquipToolStripMenuItem.Name = "AddEquipToolStripMenuItem";
            this.AddEquipToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.AddEquipToolStripMenuItem.Text = "添加设备";
            // 
            // DelEquipToolStripMenuItem
            // 
            this.DelEquipToolStripMenuItem.Name = "DelEquipToolStripMenuItem";
            this.DelEquipToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.DelEquipToolStripMenuItem.Text = "删除设备";
            // 
            // AllExpendToolStripMenuItem
            // 
            this.AllExpendToolStripMenuItem.Name = "AllExpendToolStripMenuItem";
            this.AllExpendToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.AllExpendToolStripMenuItem.Text = "全部展开";
            // 
            // AllCollapseToolStripMenuItem
            // 
            this.AllCollapseToolStripMenuItem.Name = "AllCollapseToolStripMenuItem";
            this.AllCollapseToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.AllCollapseToolStripMenuItem.Text = "全部收起";
            // 
            // DataReceiveLogGrid
            // 
            this.DataReceiveLogGrid.AllowUserToAddRows = false;
            this.DataReceiveLogGrid.AllowUserToDeleteRows = false;
            this.DataReceiveLogGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataReceiveLogGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataReceiveLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataReceiveLogGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colEquipName,
            this.colVehPlateNo,
            this.colVehPlateColor,
            this.colReachTime,
            this.colVehSpeed});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataReceiveLogGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataReceiveLogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataReceiveLogGrid.Location = new System.Drawing.Point(253, 58);
            this.DataReceiveLogGrid.Name = "DataReceiveLogGrid";
            this.DataReceiveLogGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataReceiveLogGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataReceiveLogGrid.RowTemplate.Height = 23;
            this.DataReceiveLogGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataReceiveLogGrid.Size = new System.Drawing.Size(236, 280);
            this.DataReceiveLogGrid.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.HeaderText = "设备ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colEquipName
            // 
            this.colEquipName.HeaderText = "设备名称";
            this.colEquipName.Name = "colEquipName";
            this.colEquipName.ReadOnly = true;
            // 
            // colVehPlateNo
            // 
            this.colVehPlateNo.HeaderText = "车牌号";
            this.colVehPlateNo.Name = "colVehPlateNo";
            this.colVehPlateNo.ReadOnly = true;
            // 
            // colVehPlateColor
            // 
            this.colVehPlateColor.HeaderText = "车牌颜色";
            this.colVehPlateColor.Name = "colVehPlateColor";
            this.colVehPlateColor.ReadOnly = true;
            // 
            // colReachTime
            // 
            this.colReachTime.HeaderText = "到达时间";
            this.colReachTime.Name = "colReachTime";
            this.colReachTime.ReadOnly = true;
            // 
            // colVehSpeed
            // 
            this.colVehSpeed.HeaderText = "车速";
            this.colVehSpeed.Name = "colVehSpeed";
            this.colVehSpeed.ReadOnly = true;
            // 
            // textBox1
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.textBox1, 3);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 344);
            this.textBox1.MaxLength = 327679999;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(886, 94);
            this.textBox1.TabIndex = 3;
            // 
            // ImageTableLayoutPanel
            // 
            this.ImageTableLayoutPanel.ColumnCount = 2;
            this.ImageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImageTableLayoutPanel.Controls.Add(this.picImageAll, 0, 0);
            this.ImageTableLayoutPanel.Controls.Add(this.picImageNear, 0, 1);
            this.ImageTableLayoutPanel.Controls.Add(this.picVehiclePlate, 0, 2);
            this.ImageTableLayoutPanel.Controls.Add(this.picBinVehiclePlate, 1, 2);
            this.ImageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageTableLayoutPanel.Location = new System.Drawing.Point(495, 58);
            this.ImageTableLayoutPanel.Name = "ImageTableLayoutPanel";
            this.ImageTableLayoutPanel.RowCount = 3;
            this.ImageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ImageTableLayoutPanel.Size = new System.Drawing.Size(394, 280);
            this.ImageTableLayoutPanel.TabIndex = 4;
            // 
            // picImageAll
            // 
            this.ImageTableLayoutPanel.SetColumnSpan(this.picImageAll, 2);
            this.picImageAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageAll.Image = global::PathIdentifyEquipDemo.Properties.Resources.NonImage;
            this.picImageAll.Location = new System.Drawing.Point(3, 3);
            this.picImageAll.Name = "picImageAll";
            this.picImageAll.Size = new System.Drawing.Size(388, 106);
            this.picImageAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageAll.TabIndex = 0;
            this.picImageAll.TabStop = false;
            this.picImageAll.DoubleClick += new System.EventHandler(this.picImage_DoubleClick);
            // 
            // picImageNear
            // 
            this.ImageTableLayoutPanel.SetColumnSpan(this.picImageNear, 2);
            this.picImageNear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageNear.Image = global::PathIdentifyEquipDemo.Properties.Resources.NonImage;
            this.picImageNear.Location = new System.Drawing.Point(3, 115);
            this.picImageNear.Name = "picImageNear";
            this.picImageNear.Size = new System.Drawing.Size(388, 106);
            this.picImageNear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageNear.TabIndex = 1;
            this.picImageNear.TabStop = false;
            this.picImageNear.DoubleClick += new System.EventHandler(this.picImage_DoubleClick);
            // 
            // picVehiclePlate
            // 
            this.picVehiclePlate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picVehiclePlate.Image = global::PathIdentifyEquipDemo.Properties.Resources.NonImage_Small;
            this.picVehiclePlate.Location = new System.Drawing.Point(3, 227);
            this.picVehiclePlate.Name = "picVehiclePlate";
            this.picVehiclePlate.Size = new System.Drawing.Size(191, 50);
            this.picVehiclePlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVehiclePlate.TabIndex = 2;
            this.picVehiclePlate.TabStop = false;
            this.picVehiclePlate.DoubleClick += new System.EventHandler(this.picImage_DoubleClick);
            // 
            // picBinVehiclePlate
            // 
            this.picBinVehiclePlate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBinVehiclePlate.Image = global::PathIdentifyEquipDemo.Properties.Resources.NonImage_Small;
            this.picBinVehiclePlate.Location = new System.Drawing.Point(200, 227);
            this.picBinVehiclePlate.Name = "picBinVehiclePlate";
            this.picBinVehiclePlate.Size = new System.Drawing.Size(191, 50);
            this.picBinVehiclePlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBinVehiclePlate.TabIndex = 3;
            this.picBinVehiclePlate.TabStop = false;
            this.picBinVehiclePlate.DoubleClick += new System.EventHandler(this.picImage_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 441);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "福建高速路径识别设备测试工具";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.MainControlPanel.ResumeLayout(false);
            this.EquipTreeContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataReceiveLogGrid)).EndInit();
            this.ImageTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImageAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageNear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehiclePlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBinVehiclePlate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Panel MainControlPanel;
        private System.Windows.Forms.TreeView EquipTreeView;
        private System.Windows.Forms.DataGridView DataReceiveLogGrid;
        private System.Windows.Forms.ContextMenuStrip EquipTreeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddEquipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelEquipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllExpendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllCollapseToolStripMenuItem;
        private System.Windows.Forms.Button btnInitDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehPlateColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReachTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehSpeed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel ImageTableLayoutPanel;
        private System.Windows.Forms.PictureBox picImageAll;
        private System.Windows.Forms.PictureBox picImageNear;
        private System.Windows.Forms.PictureBox picVehiclePlate;
        private System.Windows.Forms.PictureBox picBinVehiclePlate;

    }
}

