namespace MineSweeper
{
    partial class Form_Rank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rank));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Beginner = new System.Windows.Forms.TextBox();
            this.TextBox_Importmediate = new System.Windows.Forms.TextBox();
            this.TextBox_Export = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "初级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "中级：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "高级：";
            // 
            // TextBox_Beginner
            // 
            this.TextBox_Beginner.Location = new System.Drawing.Point(105, 23);
            this.TextBox_Beginner.Name = "TextBox_Beginner";
            this.TextBox_Beginner.Size = new System.Drawing.Size(100, 21);
            this.TextBox_Beginner.TabIndex = 3;
            // 
            // TextBox_Importmediate
            // 
            this.TextBox_Importmediate.Location = new System.Drawing.Point(105, 58);
            this.TextBox_Importmediate.Name = "TextBox_Importmediate";
            this.TextBox_Importmediate.Size = new System.Drawing.Size(100, 21);
            this.TextBox_Importmediate.TabIndex = 4;
            // 
            // TextBox_Export
            // 
            this.TextBox_Export.Location = new System.Drawing.Point(105, 91);
            this.TextBox_Export.Name = "TextBox_Export";
            this.TextBox_Export.Size = new System.Drawing.Size(100, 21);
            this.TextBox_Export.TabIndex = 5;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(50, 124);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "重置";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(146, 124);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form_Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(257, 159);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.TextBox_Export);
            this.Controls.Add(this.TextBox_Importmediate);
            this.Controls.Add(this.TextBox_Beginner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Rank";
            this.Text = "MineSweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Beginner;
        private System.Windows.Forms.TextBox TextBox_Importmediate;
        private System.Windows.Forms.TextBox TextBox_Export;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Cancel;
    }
}