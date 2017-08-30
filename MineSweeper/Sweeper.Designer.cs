namespace MineSweeper
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.UpMenu = new System.Windows.Forms.MenuStrip();
            this.gameGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.BeginnerBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntermediateIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpertEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.RankRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AudioAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.PictureBox_Bomb = new System.Windows.Forms.PictureBox();
            this.PictureBox_Timer = new System.Windows.Forms.PictureBox();
            this.UpMenu.SuspendLayout();
            this.TableLayoutPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Timer)).BeginInit();
            this.SuspendLayout();
            // 
            // UpMenu
            // 
            this.UpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameGToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.UpMenu.Location = new System.Drawing.Point(0, 0);
            this.UpMenu.Name = "UpMenu";
            this.UpMenu.Size = new System.Drawing.Size(354, 25);
            this.UpMenu.TabIndex = 0;
            this.UpMenu.Text = "menuStrip1";
            // 
            // gameGToolStripMenuItem
            // 
            this.gameGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.BeginnerBToolStripMenuItem,
            this.IntermediateIToolStripMenuItem,
            this.ExpertEToolStripMenuItem,
            this.toolStripMenuItem2,
            this.RankRToolStripMenuItem,
            this.AudioAToolStripMenuItem,
            this.toolStripMenuItem3,
            this.ExitToolStripMenuItem});
            this.gameGToolStripMenuItem.Name = "gameGToolStripMenuItem";
            this.gameGToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.gameGToolStripMenuItem.Text = "Game(&G)";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NewGameToolStripMenuItem.Text = "New Game(&N)";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // BeginnerBToolStripMenuItem
            // 
            this.BeginnerBToolStripMenuItem.Name = "BeginnerBToolStripMenuItem";
            this.BeginnerBToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.BeginnerBToolStripMenuItem.Text = "Beginner(&B)";
            this.BeginnerBToolStripMenuItem.Click += new System.EventHandler(this.BeginnerBToolStripMenuItem_Click);
            // 
            // IntermediateIToolStripMenuItem
            // 
            this.IntermediateIToolStripMenuItem.Name = "IntermediateIToolStripMenuItem";
            this.IntermediateIToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.IntermediateIToolStripMenuItem.Text = "Intermediate(&I)";
            this.IntermediateIToolStripMenuItem.Click += new System.EventHandler(this.IntermediateIToolStripMenuItem_Click);
            // 
            // ExpertEToolStripMenuItem
            // 
            this.ExpertEToolStripMenuItem.Name = "ExpertEToolStripMenuItem";
            this.ExpertEToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ExpertEToolStripMenuItem.Text = "Expert(&E)";
            this.ExpertEToolStripMenuItem.Click += new System.EventHandler(this.ExpertEToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // RankRToolStripMenuItem
            // 
            this.RankRToolStripMenuItem.Name = "RankRToolStripMenuItem";
            this.RankRToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.RankRToolStripMenuItem.Text = "Rank(&R)";
            this.RankRToolStripMenuItem.Click += new System.EventHandler(this.RankRToolStripMenuItem_Click);
            // 
            // AudioAToolStripMenuItem
            // 
            this.AudioAToolStripMenuItem.Name = "AudioAToolStripMenuItem";
            this.AudioAToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.AudioAToolStripMenuItem.Text = "Audio(&A)";
            this.AudioAToolStripMenuItem.Click += new System.EventHandler(this.AudioAToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ExitToolStripMenuItem.Text = "Exit(&T)";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutAToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // AboutAToolStripMenuItem
            // 
            this.AboutAToolStripMenuItem.Name = "AboutAToolStripMenuItem";
            this.AboutAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutAToolStripMenuItem.Text = "About(&A)";
            this.AboutAToolStripMenuItem.Click += new System.EventHandler(this.AboutAToolStripMenuItem_Click);
            // 
            // TableLayoutPanel_Main
            // 
            this.TableLayoutPanel_Main.ColumnCount = 9;
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.Controls.Add(this.PictureBox_Bomb, 1, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.PictureBox_Timer, 7, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.label1, 3, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.label2, 5, 0);
            this.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel_Main.Location = new System.Drawing.Point(0, 296);
            this.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main";
            this.TableLayoutPanel_Main.RowCount = 1;
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Main.Size = new System.Drawing.Size(354, 48);
            this.TableLayoutPanel_Main.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(99, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "label_Bomb";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(196, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "label_Timer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Main
            // 
            this.Timer_Main.Interval = 1000;
            // 
            // PictureBox_Bomb
            // 
            this.PictureBox_Bomb.BackgroundImage = global::MineSweeper.Properties.Resources.炸弹;
            this.PictureBox_Bomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Bomb.Location = new System.Drawing.Point(35, 3);
            this.PictureBox_Bomb.Name = "PictureBox_Bomb";
            this.PictureBox_Bomb.Size = new System.Drawing.Size(42, 42);
            this.PictureBox_Bomb.TabIndex = 0;
            this.PictureBox_Bomb.TabStop = false;
            // 
            // PictureBox_Timer
            // 
            this.PictureBox_Timer.BackColor = System.Drawing.Color.White;
            this.PictureBox_Timer.BackgroundImage = global::MineSweeper.Properties.Resources.时间;
            this.PictureBox_Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Timer.Location = new System.Drawing.Point(277, 3);
            this.PictureBox_Timer.Name = "PictureBox_Timer";
            this.PictureBox_Timer.Size = new System.Drawing.Size(42, 42);
            this.PictureBox_Timer.TabIndex = 1;
            this.PictureBox_Timer.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 344);
            this.Controls.Add(this.TableLayoutPanel_Main);
            this.Controls.Add(this.UpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.UpMenu;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Main_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseMove);
            this.UpMenu.ResumeLayout(false);
            this.UpMenu.PerformLayout();
            this.TableLayoutPanel_Main.ResumeLayout(false);
            this.TableLayoutPanel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip UpMenu;
        private System.Windows.Forms.ToolStripMenuItem gameGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BeginnerBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IntermediateIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpertEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem RankRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AudioAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutAToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Main;
        private System.Windows.Forms.PictureBox PictureBox_Bomb;
        private System.Windows.Forms.PictureBox PictureBox_Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer_Main;
    }
}

