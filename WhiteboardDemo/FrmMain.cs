using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteboardDemo
{
    public partial class FrmMain : Form
    {
        #region 定义私有成员变量
        List<ToolStripButton> colorButtons = new List<ToolStripButton>();
        List<ToolStripButton> lineButtons = new List<ToolStripButton>();
        // 当前画笔切换成橡皮前的画笔颜色
        Color oldPenColor = Color.Black;
        // 当前画笔切换成橡皮前的画笔宽度
        int oldPenWidth = 0;
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            #region 颜色按钮初始化+Click事件
            colorButtons.AddRange(new[]
            {
                tsb01,tsb02,tsb03,tsb04,tsb05,tsb06,tsb07,tsb08,tsb09,tsb10,tsb11,tsb12
            });

            foreach(var item in colorButtons)
            {
                item.Click += (o, ex) =>
                {
                    var obj = o as ToolStripButton;
                    obj.Checked = true;
                    foreach (var v in colorButtons)
                    {
                        if (v == item) continue;
                        v.Checked = false;
                    }
                };
            }
            tsb01.Click += (o, ex)=> whiteboardPanel1.PenColor = Color.FromArgb(255, 255, 255);
            tsb02.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(20,98,51);
            tsb03.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(30,33,136);
            tsb04.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(255, 241, 0);
            tsb05.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(195, 14, 35);
            tsb06.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(126, 47, 142);
            tsb07.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(230, 24, 116);
            tsb08.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(106, 57, 7);
            tsb09.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(14, 110, 184);
            tsb10.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(114, 114, 114);
            tsb11.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(243, 152, 0);
            tsb12.Click += (o, ex) => whiteboardPanel1.PenColor = Color.FromArgb(202, 202, 202);
            tsb01.PerformClick();
            #endregion

            #region 线条按钮初始化+Click事件
            lineButtons.AddRange(new[]
            {
                tsbWidth04, tsbWidth06,tsbWidth08,tsbWidth10,tsbWidth12
            });
            foreach (var item in lineButtons)
            {
                item.Click += (o, ex) =>
                {
                    var obj = o as ToolStripButton;
                    obj.Checked = true;
                    foreach (var v in lineButtons)
                    {
                        if (v == item) continue;
                        v.Checked = false;
                    }
                };
            }
            tsbWidth04.Click += (o, ex) => whiteboardPanel1.PenWidth = 4;
            tsbWidth06.Click += (o, ex) => whiteboardPanel1.PenWidth = 6;
            tsbWidth08.Click += (o, ex) => whiteboardPanel1.PenWidth = 8;
            tsbWidth10.Click += (o, ex) => whiteboardPanel1.PenWidth = 10;
            tsbWidth12.Click += (o, ex) => whiteboardPanel1.PenWidth = 12;

            tsbWidth08.PerformClick();
            #endregion

            #region 铅笔和橡皮初始化+Click事件
            tsbPen.Click += (o, ex) => {
                tsbPen.Checked = true;
                tsbEraser.Checked = false;
                toolStripPanel.Enabled = true;
                whiteboardPanel1.PenColor = oldPenColor; // 黑板色
                whiteboardPanel1.PenWidth = oldPenWidth;
            };
            tsbEraser.Click += (o, ex) => {
                tsbPen.Checked = false;
                tsbEraser.Checked = true;
                toolStripPanel.Enabled = false;
                oldPenColor = whiteboardPanel1.PenColor;
                oldPenWidth = whiteboardPanel1.PenWidth;
                whiteboardPanel1.PenColor = Color.Black; // 黑板色
                whiteboardPanel1.PenWidth = 50;
            };
            tsbPen.Checked = true;
            #endregion

            #region 保存按钮Click事件
            tsbSave.Click += (o, ex) =>
            {
                whiteboardPanel1.Save(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ff") + ".jpg");
            };
            #endregion

            #region 打开按钮Click事件
            tsbOpen.Click += (o, ex) =>
            {
                openFileDialog1.Filter = "*.jpg|*.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    whiteboardPanel1.Open(openFileDialog1.FileName);
                }
            };
            #endregion

            #region 新建按钮Click事件
            tsbNew.Click += (o, ex) => whiteboardPanel1.New();
            #endregion
        }
    }
}
