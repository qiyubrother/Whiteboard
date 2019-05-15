using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whiteboard
{
    public partial class WhiteboardPanel : UserControl
    {
        private bool isKeyDown = false; // 按下屏幕
        private float x = 0;
        private float y = 0;
        public WhiteboardPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isKeyDown = true;
            x = e.X;
            y = e.Y;
            FindForm().Text = $"D,x={x},y={y}";
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isKeyDown = false;
            x = 0;
            y = 0;
            base.OnMouseUp(e);
            FindForm().Text = $"U,x={x},y={y}";
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isKeyDown)
            {
                FindForm().Text = $"M,x={x},y={y}";
                var g = this.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                var pen = new Pen(new SolidBrush(PenColor), PenWidth);
                g.DrawPolygon(pen, new[] { new Point((int)x, (int)y), new Point((int)e.X, (int)e.Y) });
                g.FillEllipse(new SolidBrush(PenColor), e.X - PenWidth/2, e.Y - PenWidth/2, PenWidth, PenWidth);
                x = e.X;
                y = e.Y;
            }
        }

        #region 管理方法
        /// <summary>
        /// 画笔的粗细
        /// </summary>
        public int PenWidth { get; set; }
        /// <summary>
        /// 画笔颜色
        /// </summary>
        public Color PenColor { get; set; }
        /// <summary>
        /// 黑板颜色
        /// </summary>
        public Color BlockBoardColor { get; set; }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool Save(string fileName)
        {
            var bmp = new Bitmap(Width, Height);
            this.DrawToBitmap(bmp, new Rectangle { X = 0, Y = 0, Width = Width, Height = Height });
            bmp.Save(fileName);

            return true;
        }
        /// <summary>
        /// 打开
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool Open(string fileName)
        {

            return true;
        }
        #endregion
    }
}
