namespace VIP云解析
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textUrl = new System.Windows.Forms.TextBox();
            this.inputUrl = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.LinkLabel();
            this.rbtOne = new System.Windows.Forms.RadioButton();
            this.rbtTwo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(117, 36);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(422, 21);
            this.textUrl.TabIndex = 0;
            // 
            // inputUrl
            // 
            this.inputUrl.AutoSize = true;
            this.inputUrl.Location = new System.Drawing.Point(22, 39);
            this.inputUrl.Name = "inputUrl";
            this.inputUrl.Size = new System.Drawing.Size(83, 12);
            this.inputUrl.TabIndex = 1;
            this.inputUrl.Text = "输入视频Url：";
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Location = new System.Drawing.Point(128, 156);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(53, 12);
            this.play.TabIndex = 6;
            this.play.TabStop = true;
            this.play.Text = "点击播放";
            this.play.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.play_LinkClicked);
            // 
            // rbtOne
            // 
            this.rbtOne.AutoSize = true;
            this.rbtOne.Checked = true;
            this.rbtOne.Location = new System.Drawing.Point(130, 89);
            this.rbtOne.Name = "rbtOne";
            this.rbtOne.Size = new System.Drawing.Size(155, 16);
            this.rbtOne.TabIndex = 9;
            this.rbtOne.TabStop = true;
            this.rbtOne.Text = "腾讯，优酷，搜狐，乐视";
            this.rbtOne.UseVisualStyleBackColor = true;
            // 
            // rbtTwo
            // 
            this.rbtTwo.AutoSize = true;
            this.rbtTwo.Location = new System.Drawing.Point(130, 124);
            this.rbtTwo.Name = "rbtTwo";
            this.rbtTwo.Size = new System.Drawing.Size(59, 16);
            this.rbtTwo.TabIndex = 9;
            this.rbtTwo.Text = "爱奇艺";
            this.rbtTwo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 261);
            this.Controls.Add(this.rbtTwo);
            this.Controls.Add(this.rbtOne);
            this.Controls.Add(this.play);
            this.Controls.Add(this.inputUrl);
            this.Controls.Add(this.textUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIP云解析";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Label inputUrl;
        private System.Windows.Forms.LinkLabel play;
        private System.Windows.Forms.RadioButton rbtOne;
        private System.Windows.Forms.RadioButton rbtTwo;
    }
}

