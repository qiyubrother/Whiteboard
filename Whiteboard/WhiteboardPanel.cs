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
        private int x = 0;
        private int y = 0;
        private Queue<DrawTask> workQueue = new Queue<DrawTask>();
        public WhiteboardPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Bitmap bmp = null;
            Graphics g = null;
            bmp = new Bitmap(Width, Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // 消除锯齿

            var pen = new Pen(new SolidBrush(Color.Black), 0);
            var sb = new SolidBrush(Color.Black);
            foreach (var work in workQueue)
            {
                if (work.Type == DrawType.Line) // 画线
                {
                    pen.Color = work.PenColor;
                    pen.Width = work.PenWidth;
                    g.DrawPolygon(pen, new[] { work.FromPoint, work.ToPoint });
                    sb.Color = work.PenColor;
                    g.FillEllipse(sb, work.ToPoint.X - PenWidth / 2, work.ToPoint.Y - PenWidth / 2, work.PenWidth, work.PenWidth);
                }
                else if (work.Type == DrawType.Image) // 画图片
                {
                    var rg = new Rectangle(0, 0, Math.Min(bmp.Width, work.Image.Width), Math.Min(bmp.Height, work.Image.Height));
                    g.DrawImage(work.Image, rg);
                }
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // 消除锯齿
            e.Graphics.DrawImage((Image)bmp, 0, 0);

            sb.Dispose();
            pen.Dispose();
            bmp.Dispose();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isKeyDown = true;
            x = e.X;
            y = e.Y;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isKeyDown = false;
            x = 0;
            y = 0;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isKeyDown)
            {
                var g = this.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                var pen = new Pen(new SolidBrush(PenColor), PenWidth);
                g.DrawPolygon(pen, new[] { new Point((int)x, (int)y), new Point((int)e.X, (int)e.Y) });
                g.FillEllipse(new SolidBrush(PenColor), e.X - PenWidth*1.0f/2, e.Y - PenWidth*1.0f/2, PenWidth, PenWidth);

                workQueue.Enqueue(new DrawTask
                {
                    PenColor = PenColor,
                    PenWidth = PenWidth,
                    FromPoint = new Point((int)x, (int)y),
                    ToPoint = new Point((int)e.X, (int)e.Y),
                    Type = DrawType.Line,
                    Image = null
                });

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
        public void Open(string fileName)
        {
            var bmp = new Bitmap(Bitmap.FromFile(fileName));
            workQueue.Enqueue(new DrawTask
            {
                PenColor = PenColor,
                PenWidth = PenWidth,
                FromPoint = new Point((int)0, (int)0),
                ToPoint = new Point((int)bmp.Width, (int)bmp.Height),
                Type = DrawType.Image,
                Image = bmp
            });
            Refresh();
        }

        /// <summary>
        /// 新建
        /// </summary>
        public void New()
        {
            workQueue.Clear();
            Refresh();
        }
        #endregion
    }
    public class DrawTask
    {
        public Color PenColor { get; set; }
        public int PenWidth { get; set; }
        public Point FromPoint { get; set; }
        public Point ToPoint { get; set; }
        public Bitmap Image { get; set; } = null;
        public DrawType Type { get; set; } = DrawType.Line;
    }
    public enum DrawType
    {
        Line,
        Image
    }
}
