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
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.EquipManagerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainControlPanel = new System.Windows.Forms.Panel();
            this.EquipTreeView = new System.Windows.Forms.TreeView();
            this.DataReceiveLogGrid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehPlateColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReachTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipTreeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部展开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部收起ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataReceiveLogGrid)).BeginInit();
            this.EquipTreeContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EquipManagerToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(863, 48);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // EquipManagerToolStripButton
            // 
            this.EquipManagerToolStripButton.Image = global::PathIdentifyEquipDemo.Properties.Resources.EquipManager;
            this.EquipManagerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EquipManagerToolStripButton.Name = "EquipManagerToolStripButton";
            this.EquipManagerToolStripButton.Size = new System.Drawing.Size(60, 45);
            this.EquipManagerToolStripButton.Text = "设备管理";
            this.EquipManagerToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.MainControlPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.EquipTreeView, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.DataReceiveLogGrid, 1, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 48);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(863, 364);
            this.MainTableLayoutPanel.TabIndex = 1;
            // 
            // MainControlPanel
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.MainControlPanel, 2);
            this.MainControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControlPanel.Location = new System.Drawing.Point(3, 3);
            this.MainControlPanel.Name = "MainControlPanel";
            this.MainControlPanel.Size = new System.Drawing.Size(857, 49);
            this.MainControlPanel.TabIndex = 0;
            // 
            // EquipTreeView
            // 
            this.EquipTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipTreeView.Location = new System.Drawing.Point(3, 58);
            this.EquipTreeView.Name = "EquipTreeView";
            this.EquipTreeView.Size = new System.Drawing.Size(344, 303);
            this.EquipTreeView.TabIndex = 1;
            // 
            // DataReceiveLogGrid
            // 
            this.DataReceiveLogGrid.AllowUserToAddRows = false;
            this.DataReceiveLogGrid.AllowUserToDeleteRows = false;
            this.DataReceiveLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataReceiveLogGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colEquipName,
            this.colVehPlateNo,
            this.colVehPlateColor,
            this.colReachTime,
            this.colVehSpeed});
            this.DataReceiveLogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataReceiveLogGrid.Location = new System.Drawing.Point(353, 58);
            this.DataReceiveLogGrid.Name = "DataReceiveLogGrid";
            this.DataReceiveLogGrid.ReadOnly = true;
            this.DataReceiveLogGrid.RowTemplate.Height = 23;
            this.DataReceiveLogGrid.Size = new System.Drawing.Size(507, 303);
            this.DataReceiveLogGrid.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.HeaderText = "设备ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
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
            // EquipTreeContextMenuStrip
            // 
            this.EquipTreeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加设备ToolStripMenuItem,
            this.删除设备ToolStripMenuItem,
            this.全部展开ToolStripMenuItem,
            this.全部收起ToolStripMenuItem});
            this.EquipTreeContextMenuStrip.Name = "EquipTreeContextMenuStrip";
            this.EquipTreeContextMenuStrip.Size = new System.Drawing.Size(125, 92);
            // 
            // 添加设备ToolStripMenuItem
            // 
            this.添加设备ToolStripMenuItem.Name = "添加设备ToolStripMenuItem";
            this.添加设备ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加设备ToolStripMenuItem.Text = "添加设备";
            // 
            // 删除设备ToolStripMenuItem
            // 
            this.删除设备ToolStripMenuItem.Name = "删除设备ToolStripMenuItem";
            this.删除设备ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除设备ToolStripMenuItem.Text = "删除设备";
            // 
            // 全部展开ToolStripMenuItem
            // 
            this.全部展开ToolStripMenuItem.Name = "全部展开ToolStripMenuItem";
            this.全部展开ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部展开ToolStripMenuItem.Text = "全部展开";
            // 
            // 全部收起ToolStripMenuItem
            // 
            this.全部收起ToolStripMenuItem.Name = "全部收起ToolStripMenuItem";
            this.全部收起ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部收起ToolStripMenuItem.Text = "全部收起";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 412);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Controls.Add(this.MainToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "福建高速路径识别设备测试工具";
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataReceiveLogGrid)).EndInit();
            this.EquipTreeContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton EquipManagerToolStripButton;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Panel MainControlPanel;
        private System.Windows.Forms.TreeView EquipTreeView;
        private System.Windows.Forms.DataGridView DataReceiveLogGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehPlateColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReachTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehSpeed;
        private System.Windows.Forms.ContextMenuStrip EquipTreeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 添加设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部展开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部收起ToolStripMenuItem;

    }
}

