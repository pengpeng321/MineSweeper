using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form_Main : Form
    {
        private int Sweep_width;      //雷区有几列   10/16
        private int Sweep_high;       //雷区有几行   10/16/40 
        private int Sweep_num;        //雷区有几个雷 10/40/99
        private int nOffsetX;         //paint中使用 显示界面 距离 整个界面左边的距离
        private int nOffsetY;         //paint中使用 显示界面 距离 整个界面上边的距离
        private Point mousefocus_new; //鼠标新位置
        private Point mousefocus_old; //鼠标旧位置

        public Form_Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;                     //双缓冲技术，减少屏幕闪屏
            nOffsetX = 6;                                   //初始化参数
            nOffsetY = 6 + UpMenu.Height;                   //初始化参数
            Sweep_num = Properties.Settings.Default.Sweep_num;        //初始化。从以前的设置读取炸弹数量
            Sweep_high = Properties.Settings.Default.Sweep_high;      //初始化。从以前的设置读取有行数
            Sweep_width = Properties.Settings.Default.Sweep_width;   //初始化。从以前的设置读取列数
            mousefocus_new.X = mousefocus_old.X = 0;            //初始化鼠标位置
            mousefocus_new.Y = mousefocus_old.Y = 0;
            SetLevel();
            UpdateSize(Sweep_width, Sweep_high);
        }
        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //绘制句柄
            for (int i = 0; i < Sweep_width; i++)
            {
                for (int j = 0; j < Sweep_high; j++)
                {
                    if (i + 1 == mousefocus_new.X && j + 1 == mousefocus_new.Y)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Violet)), new Rectangle(nOffsetX + 34 * i, nOffsetY + 34 * j + 1, 32, 32));
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Violet, new Rectangle(nOffsetX + 34 * i, nOffsetY + 34 * j + 1, 32, 32));
                    }
                }
            }
        }
        private void UpdateSize(int width_temp, int high_temp)
        {
            int width_update = width_temp * 34 + 12;
            int high_update = high_temp * 34 + 12;
            Width = width_update + (this.Size.Width - this.ClientSize.Width);
            Height = high_update + UpMenu.Height + TableLayoutPanel_Main.Height + (this.Size.Height - this.ClientSize.Height);
        }                         //自适应窗口大小（更新窗口大小）
        private void Form_Main_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (e.X - nOffsetX) / 34 + 1;
            int y = (e.Y - nOffsetY) / 34 + 1;
            mousefocus_new.X = x;
            mousefocus_new.Y = y;
            if (e.X < nOffsetX || e.Y < nOffsetY)
            {
                mousefocus_new.X = mousefocus_new.Y = -1;
                Refresh();
            }
            else if (mousefocus_new != mousefocus_old)
            {
                mousefocus_old = mousefocus_new;
                Refresh();
            }
           
        }              //寻找鼠标的位置，在哪个32x32的方格里

        private void BeginnerBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sweep_width = 10;
            Sweep_high = 10;
            Sweep_num = 10;
            SetLevel();
        }
        private void IntermediateIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sweep_width = 16;
            Sweep_high = 16;
            Sweep_num = 40;
            SetLevel();
        }
        private void ExpertEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sweep_width = 30;
            Sweep_high = 16;
            Sweep_num = 99;
            SetLevel();
        }
        private void SetLevel()
        {
            BeginnerBToolStripMenuItem.Checked = false;
            IntermediateIToolStripMenuItem.Checked = false;
            ExpertEToolStripMenuItem.Checked = false;
            switch (Sweep_num)
            {
                case 10: BeginnerBToolStripMenuItem.Checked = true; break;
                case 40: IntermediateIToolStripMenuItem.Checked = true; break;
                case 99: ExpertEToolStripMenuItem.Checked = true; break;
                default: break;
            }
            Properties.Settings.Default.Sweep_high = Sweep_high;
            Properties.Settings.Default.Sweep_width = Sweep_width;
            Properties.Settings.Default.Sweep_num = Sweep_num;
            Properties.Settings.Default.Save();
            NewGame();
        }
        private void NewGame()
        {
            UpdateSize(Sweep_width, Sweep_high);
            Refresh();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
