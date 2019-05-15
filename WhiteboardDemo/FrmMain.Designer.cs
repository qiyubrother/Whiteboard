namespace WhiteboardDemo
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbPen = new System.Windows.Forms.ToolStripButton();
            this.tsbEraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanel = new System.Windows.Forms.ToolStrip();
            this.tsb01 = new System.Windows.Forms.ToolStripButton();
            this.tsb02 = new System.Windows.Forms.ToolStripButton();
            this.tsb03 = new System.Windows.Forms.ToolStripButton();
            this.tsb04 = new System.Windows.Forms.ToolStripButton();
            this.tsb05 = new System.Windows.Forms.ToolStripButton();
            this.tsb06 = new System.Windows.Forms.ToolStripButton();
            this.tsb07 = new System.Windows.Forms.ToolStripButton();
            this.tsb08 = new System.Windows.Forms.ToolStripButton();
            this.tsb09 = new System.Windows.Forms.ToolStripButton();
            this.tsb10 = new System.Windows.Forms.ToolStripButton();
            this.tsb11 = new System.Windows.Forms.ToolStripButton();
            this.tsb12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbWidth04 = new System.Windows.Forms.ToolStripButton();
            this.tsbWidth06 = new System.Windows.Forms.ToolStripButton();
            this.tsbWidth08 = new System.Windows.Forms.ToolStripButton();
            this.tsbWidth10 = new System.Windows.Forms.ToolStripButton();
            this.tsbWidth12 = new System.Windows.Forms.ToolStripButton();
            this.whiteboardPanel1 = new Whiteboard.WhiteboardPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.toolStripPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tsbOpen,
            this.tsbPen,
            this.tsbEraser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1170, 55);
            this.toolStrip1.TabIndex = 1;
            // 
            // tsbNew
            // 
            this.tsbNew.Image = global::WhiteboardDemo.Properties.Resources.add;
            this.tsbNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(91, 52);
            this.tsbNew.Text = "新建";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::WhiteboardDemo.Properties.Resources.save;
            this.tsbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(91, 52);
            this.tsbSave.Text = "保存";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::WhiteboardDemo.Properties.Resources.opened_folder;
            this.tsbOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(91, 52);
            this.tsbOpen.Text = "打开";
            // 
            // tsbPen
            // 
            this.tsbPen.Image = global::WhiteboardDemo.Properties.Resources.pencil_;
            this.tsbPen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPen.Name = "tsbPen";
            this.tsbPen.Size = new System.Drawing.Size(91, 52);
            this.tsbPen.Text = "粉笔";
            // 
            // tsbEraser
            // 
            this.tsbEraser.Image = global::WhiteboardDemo.Properties.Resources.Eraser;
            this.tsbEraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEraser.Name = "tsbEraser";
            this.tsbEraser.Size = new System.Drawing.Size(91, 52);
            this.tsbEraser.Text = "板擦";
            // 
            // toolStripPanel
            // 
            this.toolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripPanel.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStripPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb01,
            this.tsb02,
            this.tsb03,
            this.tsb04,
            this.tsb05,
            this.tsb06,
            this.tsb07,
            this.tsb08,
            this.tsb09,
            this.tsb10,
            this.tsb11,
            this.tsb12,
            this.toolStripSeparator1,
            this.tsbWidth04,
            this.tsbWidth06,
            this.tsbWidth08,
            this.tsbWidth10,
            this.tsbWidth12});
            this.toolStripPanel.Location = new System.Drawing.Point(0, 55);
            this.toolStripPanel.Name = "toolStripPanel";
            this.toolStripPanel.Size = new System.Drawing.Size(41, 568);
            this.toolStripPanel.TabIndex = 2;
            this.toolStripPanel.Text = "toolStrip2";
            // 
            // tsb01
            // 
            this.tsb01.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb01.Image = global::WhiteboardDemo.Properties.Resources.Color_01_fw;
            this.tsb01.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb01.Name = "tsb01";
            this.tsb01.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb02
            // 
            this.tsb02.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb02.Image = global::WhiteboardDemo.Properties.Resources.Color_02_fw;
            this.tsb02.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb02.Name = "tsb02";
            this.tsb02.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb03
            // 
            this.tsb03.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb03.Image = global::WhiteboardDemo.Properties.Resources.Color_03_fw;
            this.tsb03.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb03.Name = "tsb03";
            this.tsb03.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb04
            // 
            this.tsb04.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb04.Image = global::WhiteboardDemo.Properties.Resources.Color_04_fw;
            this.tsb04.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb04.Name = "tsb04";
            this.tsb04.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb05
            // 
            this.tsb05.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb05.Image = global::WhiteboardDemo.Properties.Resources.Color_05_fw;
            this.tsb05.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb05.Name = "tsb05";
            this.tsb05.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb06
            // 
            this.tsb06.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb06.Image = global::WhiteboardDemo.Properties.Resources.Color_06_fw;
            this.tsb06.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb06.Name = "tsb06";
            this.tsb06.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb07
            // 
            this.tsb07.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb07.Image = global::WhiteboardDemo.Properties.Resources.Color_07_fw;
            this.tsb07.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb07.Name = "tsb07";
            this.tsb07.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb08
            // 
            this.tsb08.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb08.Image = global::WhiteboardDemo.Properties.Resources.Color_08_fw;
            this.tsb08.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb08.Name = "tsb08";
            this.tsb08.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb09
            // 
            this.tsb09.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb09.Image = global::WhiteboardDemo.Properties.Resources.Color_09_fw;
            this.tsb09.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb09.Name = "tsb09";
            this.tsb09.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb10
            // 
            this.tsb10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb10.Image = global::WhiteboardDemo.Properties.Resources.Color_10_fw;
            this.tsb10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb10.Name = "tsb10";
            this.tsb10.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb11
            // 
            this.tsb11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb11.Image = global::WhiteboardDemo.Properties.Resources.Color_11_fw;
            this.tsb11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb11.Name = "tsb11";
            this.tsb11.Size = new System.Drawing.Size(38, 40);
            // 
            // tsb12
            // 
            this.tsb12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb12.Image = global::WhiteboardDemo.Properties.Resources.Color_12_fw;
            this.tsb12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb12.Name = "tsb12";
            this.tsb12.Size = new System.Drawing.Size(38, 40);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(38, 6);
            // 
            // tsbWidth04
            // 
            this.tsbWidth04.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWidth04.Image = global::WhiteboardDemo.Properties.Resources.Width_04_fw;
            this.tsbWidth04.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWidth04.Name = "tsbWidth04";
            this.tsbWidth04.Size = new System.Drawing.Size(40, 40);
            // 
            // tsbWidth06
            // 
            this.tsbWidth06.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWidth06.Image = global::WhiteboardDemo.Properties.Resources.Width_06_fw;
            this.tsbWidth06.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWidth06.Name = "tsbWidth06";
            this.tsbWidth06.Size = new System.Drawing.Size(40, 40);
            // 
            // tsbWidth08
            // 
            this.tsbWidth08.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWidth08.Image = global::WhiteboardDemo.Properties.Resources.Width_08_fw;
            this.tsbWidth08.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWidth08.Name = "tsbWidth08";
            this.tsbWidth08.Size = new System.Drawing.Size(40, 40);
            // 
            // tsbWidth10
            // 
            this.tsbWidth10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWidth10.Image = global::WhiteboardDemo.Properties.Resources.Width_10_fw;
            this.tsbWidth10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWidth10.Name = "tsbWidth10";
            this.tsbWidth10.Size = new System.Drawing.Size(40, 40);
            // 
            // tsbWidth12
            // 
            this.tsbWidth12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWidth12.Image = global::WhiteboardDemo.Properties.Resources.Width_12_fw;
            this.tsbWidth12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWidth12.Name = "tsbWidth12";
            this.tsbWidth12.Size = new System.Drawing.Size(40, 40);
            // 
            // whiteboardPanel1
            // 
            this.whiteboardPanel1.BackColor = System.Drawing.Color.Black;
            this.whiteboardPanel1.BlockBoardColor = System.Drawing.Color.Empty;
            this.whiteboardPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whiteboardPanel1.Location = new System.Drawing.Point(41, 55);
            this.whiteboardPanel1.Name = "whiteboardPanel1";
            this.whiteboardPanel1.PenColor = System.Drawing.Color.Empty;
            this.whiteboardPanel1.PenWidth = 0;
            this.whiteboardPanel1.Size = new System.Drawing.Size(1129, 568);
            this.whiteboardPanel1.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 623);
            this.Controls.Add(this.whiteboardPanel1);
            this.Controls.Add(this.toolStripPanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.Text = "简易电子白板";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripPanel.ResumeLayout(false);
            this.toolStripPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbPen;
        private System.Windows.Forms.ToolStripButton tsbEraser;
        private System.Windows.Forms.ToolStrip toolStripPanel;
        private System.Windows.Forms.ToolStripButton tsb01;
        private System.Windows.Forms.ToolStripButton tsb02;
        private System.Windows.Forms.ToolStripButton tsb03;
        private System.Windows.Forms.ToolStripButton tsb04;
        private System.Windows.Forms.ToolStripButton tsb05;
        private System.Windows.Forms.ToolStripButton tsb06;
        private System.Windows.Forms.ToolStripButton tsb07;
        private System.Windows.Forms.ToolStripButton tsb08;
        private System.Windows.Forms.ToolStripButton tsb09;
        private Whiteboard.WhiteboardPanel whiteboardPanel1;
        private System.Windows.Forms.ToolStripButton tsb10;
        private System.Windows.Forms.ToolStripButton tsb11;
        private System.Windows.Forms.ToolStripButton tsb12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbWidth06;
        private System.Windows.Forms.ToolStripButton tsbWidth08;
        private System.Windows.Forms.ToolStripButton tsbWidth10;
        private System.Windows.Forms.ToolStripButton tsbWidth12;
        private System.Windows.Forms.ToolStripButton tsbWidth04;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

