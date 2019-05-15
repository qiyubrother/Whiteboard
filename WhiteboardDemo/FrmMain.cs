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
        public FrmMain()
        {
            InitializeComponent();
        }
        List<ToolStripButton> colorButtons = new List<ToolStripButton>();
        List<ToolStripButton> lineButtons = new List<ToolStripButton>();
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            #region 颜色按钮初始化
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

            #region 线条按钮初始化
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
        }
    }
}
