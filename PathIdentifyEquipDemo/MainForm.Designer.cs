namespace PathIdentifyEquipDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainControlPanel = new System.Windows.Forms.Panel();
            this.btnReadHistoryData = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnInitDriver = new System.Windows.Forms.Button();
            this.EquipTreeView = new System.Windows.Forms.TreeView();
            this.EquipTreeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddEquipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyEquipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelEquipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RetransDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProofTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllExpendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllCollapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.DataReceiveLogGrid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImageFullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImageNear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehiclePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBinVehiclePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehPlateColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReachTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLog = new System.Windows.Forms.TextBox();
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
            this.MainTableLayoutPanel.Controls.Add(this.txtLog, 0, 2);
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
            this.MainControlPanel.Controls.Add(this.btnReadHistoryData);
            this.MainControlPanel.Controls.Add(this.btnSetting);
            this.MainControlPanel.Controls.Add(this.btnInitDriver);
            this.MainControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControlPanel.Location = new System.Drawing.Point(3, 3);
            this.MainControlPanel.Name = "MainControlPanel";
            this.MainControlPanel.Size = new System.Drawing.Size(886, 49);
            this.MainControlPanel.TabIndex = 0;
            // 
            // btnReadHistoryData
            // 
            this.btnReadHistoryData.Location = new System.Drawing.Point(133, 10);
            this.btnReadHistoryData.Name = "btnReadHistoryData";
            this.btnReadHistoryData.Size = new System.Drawing.Size(133, 35);
            this.btnReadHistoryData.TabIndex = 2;
            this.btnReadHistoryData.Text = "读取历史数据";
            this.btnReadHistoryData.UseVisualStyleBackColor = true;
            this.btnReadHistoryData.Click += new System.EventHandler(this.btnReadHistoryData_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(275, 9);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(129, 36);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "全局配置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnInitDriver
            // 
            this.btnInitDriver.Location = new System.Drawing.Point(19, 9);
            this.btnInitDriver.Name = "btnInitDriver";
            this.btnInitDriver.Size = new System.Drawing.Size(107, 36);
            this.btnInitDriver.TabIndex = 0;
            this.btnInitDriver.Text = "初始化";
            this.btnInitDriver.UseVisualStyleBackColor = true;
            this.btnInitDriver.Click += new System.EventHandler(this.btnInitDriver_Click);
            // 
            // EquipTreeView
            // 
            this.EquipTreeView.ContextMenuStrip = this.EquipTreeContextMenuStrip;
            this.EquipTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipTreeView.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EquipTreeView.ImageIndex = 0;
            this.EquipTreeView.ImageList = this.TreeViewImageList;
            this.EquipTreeView.Location = new System.Drawing.Point(3, 58);
            this.EquipTreeView.Name = "EquipTreeView";
            this.EquipTreeView.SelectedImageIndex = 0;
            this.EquipTreeView.Size = new System.Drawing.Size(244, 280);
            this.EquipTreeView.TabIndex = 1;
            // 
            // EquipTreeContextMenuStrip
            // 
            this.EquipTreeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEquipToolStripMenuItem,
            this.ModifyEquipToolStripMenuItem,
            this.DelEquipToolStripMenuItem,
            this.RetransDataToolStripMenuItem,
            this.ProofTimeToolStripMenuItem,
            this.AllExpendToolStripMenuItem,
            this.AllCollapseToolStripMenuItem});
            this.EquipTreeContextMenuStrip.Name = "EquipTreeContextMenuStrip";
            this.EquipTreeContextMenuStrip.Size = new System.Drawing.Size(134, 158);
            this.EquipTreeContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.EquipTreeContextMenuStrip_Opening);
            this.EquipTreeContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.EquipTreeContextMenuStrip_ItemClicked);
            // 
            // AddEquipToolStripMenuItem
            // 
            this.AddEquipToolStripMenuItem.Name = "AddEquipToolStripMenuItem";
            this.AddEquipToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.AddEquipToolStripMenuItem.Text = "添加设备";
            // 
            // ModifyEquipToolStripMenuItem
            // 
            this.ModifyEquipToolStripMenuItem.Name = "ModifyEquipToolStripMenuItem";
            this.ModifyEquipToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ModifyEquipToolStripMenuItem.Text = "修改设备";
            // 
            // DelEquipToolStripMenuItem
            // 
            this.DelEquipToolStripMenuItem.Name = "DelEquipToolStripMenuItem";
            this.DelEquipToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.DelEquipToolStripMenuItem.Text = "删除设备";
            // 
            // RetransDataToolStripMenuItem
            // 
            this.RetransDataToolStripMenuItem.Name = "RetransDataToolStripMenuItem";
            this.RetransDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.RetransDataToolStripMenuItem.Text = "重传数据...";
            // 
            // ProofTimeToolStripMenuItem
            // 
            this.ProofTimeToolStripMenuItem.Name = "ProofTimeToolStripMenuItem";
            this.ProofTimeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ProofTimeToolStripMenuItem.Text = "校时";
            // 
            // AllExpendToolStripMenuItem
            // 
            this.AllExpendToolStripMenuItem.Name = "AllExpendToolStripMenuItem";
            this.AllExpendToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.AllExpendToolStripMenuItem.Text = "全部展开";
            // 
            // AllCollapseToolStripMenuItem
            // 
            this.AllCollapseToolStripMenuItem.Name = "AllCollapseToolStripMenuItem";
            this.AllCollapseToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.AllCollapseToolStripMenuItem.Text = "全部收起";
            // 
            // TreeViewImageList
            // 
            this.TreeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeViewImageList.ImageStream")));
            this.TreeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeViewImageList.Images.SetKeyName(0, "Check.png");
            this.TreeViewImageList.Images.SetKeyName(1, "Cross.png");
            this.TreeViewImageList.Images.SetKeyName(2, "question.png");
            // 
            // DataReceiveLogGrid
            // 
            this.DataReceiveLogGrid.AllowUserToAddRows = false;
            this.DataReceiveLogGrid.AllowUserToDeleteRows = false;
            this.DataReceiveLogGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataReceiveLogGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataReceiveLogGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataReceiveLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataReceiveLogGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colImageFullPath,
            this.colImageNear,
            this.colVehiclePlate,
            this.colBinVehiclePlate,
            this.colEquipName,
            this.colVehPlateNo,
            this.colVehPlateColor,
            this.colReachTime,
            this.colVehSpeed});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataReceiveLogGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataReceiveLogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataReceiveLogGrid.Location = new System.Drawing.Point(253, 58);
            this.DataReceiveLogGrid.Name = "DataReceiveLogGrid";
            this.DataReceiveLogGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataReceiveLogGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataReceiveLogGrid.RowTemplate.Height = 23;
            this.DataReceiveLogGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataReceiveLogGrid.Size = new System.Drawing.Size(236, 280);
            this.DataReceiveLogGrid.TabIndex = 2;
            this.DataReceiveLogGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataReceiveLogGrid_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "设备ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 66;
            // 
            // colImageFullPath
            // 
            this.colImageFullPath.HeaderText = "全景图";
            this.colImageFullPath.Name = "colImageFullPath";
            this.colImageFullPath.ReadOnly = true;
            this.colImageFullPath.Visible = false;
            this.colImageFullPath.Width = 66;
            // 
            // colImageNear
            // 
            this.colImageNear.HeaderText = "近景图";
            this.colImageNear.Name = "colImageNear";
            this.colImageNear.ReadOnly = true;
            this.colImageNear.Visible = false;
            this.colImageNear.Width = 66;
            // 
            // colVehiclePlate
            // 
            this.colVehiclePlate.HeaderText = "车牌图";
            this.colVehiclePlate.Name = "colVehiclePlate";
            this.colVehiclePlate.ReadOnly = true;
            this.colVehiclePlate.Visible = false;
            this.colVehiclePlate.Width = 66;
            // 
            // colBinVehiclePlate
            // 
            this.colBinVehiclePlate.HeaderText = "二值化图";
            this.colBinVehiclePlate.Name = "colBinVehiclePlate";
            this.colBinVehiclePlate.ReadOnly = true;
            this.colBinVehiclePlate.Visible = false;
            this.colBinVehiclePlate.Width = 78;
            // 
            // colEquipName
            // 
            this.colEquipName.HeaderText = "设备名称";
            this.colEquipName.Name = "colEquipName";
            this.colEquipName.ReadOnly = true;
            this.colEquipName.Width = 78;
            // 
            // colVehPlateNo
            // 
            this.colVehPlateNo.HeaderText = "车牌号";
            this.colVehPlateNo.Name = "colVehPlateNo";
            this.colVehPlateNo.ReadOnly = true;
            this.colVehPlateNo.Width = 66;
            // 
            // colVehPlateColor
            // 
            this.colVehPlateColor.HeaderText = "车牌颜色";
            this.colVehPlateColor.Name = "colVehPlateColor";
            this.colVehPlateColor.ReadOnly = true;
            this.colVehPlateColor.Width = 78;
            // 
            // colReachTime
            // 
            this.colReachTime.HeaderText = "到达时间";
            this.colReachTime.Name = "colReachTime";
            this.colReachTime.ReadOnly = true;
            this.colReachTime.Width = 78;
            // 
            // colVehSpeed
            // 
            this.colVehSpeed.HeaderText = "车速";
            this.colVehSpeed.Name = "colVehSpeed";
            this.colVehSpeed.ReadOnly = true;
            this.colVehSpeed.Width = 54;
            // 
            // txtLog
            // 
            this.txtLog.AcceptsReturn = true;
            this.MainTableLayoutPanel.SetColumnSpan(this.txtLog, 3);
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 344);
            this.txtLog.MaxLength = 327679999;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(886, 94);
            this.txtLog.TabIndex = 3;
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
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TableLayoutPanel ImageTableLayoutPanel;
        private System.Windows.Forms.PictureBox picImageAll;
        private System.Windows.Forms.PictureBox picImageNear;
        private System.Windows.Forms.PictureBox picVehiclePlate;
        private System.Windows.Forms.PictureBox picBinVehiclePlate;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImageFullPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImageNear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehiclePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBinVehiclePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehPlateColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReachTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehSpeed;
        private System.Windows.Forms.ImageList TreeViewImageList;
        private System.Windows.Forms.Button btnReadHistoryData;
        private System.Windows.Forms.ToolStripMenuItem ModifyEquipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProofTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RetransDataToolStripMenuItem;

    }
}

