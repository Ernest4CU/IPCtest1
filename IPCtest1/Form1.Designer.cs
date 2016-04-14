namespace IPCtest1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pb_video = new System.Windows.Forms.PictureBox();
            this.pl_OrientationUp = new System.Windows.Forms.Label();
            this.pl_OrientationDown = new System.Windows.Forms.Label();
            this.pl_OrientationLeft = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pl_OrientationRight = new System.Windows.Forms.Label();
            this.bt_test = new System.Windows.Forms.Button();
            this.pb_snapshot = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_snapshot)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "视频显示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_video
            // 
            this.pb_video.Location = new System.Drawing.Point(532, 29);
            this.pb_video.Name = "pb_video";
            this.pb_video.Size = new System.Drawing.Size(454, 295);
            this.pb_video.TabIndex = 2;
            this.pb_video.TabStop = false;
            // 
            // pl_OrientationUp
            // 
            this.pl_OrientationUp.AutoSize = true;
            this.pl_OrientationUp.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pl_OrientationUp.Location = new System.Drawing.Point(83, 37);
            this.pl_OrientationUp.Name = "pl_OrientationUp";
            this.pl_OrientationUp.Size = new System.Drawing.Size(33, 28);
            this.pl_OrientationUp.TabIndex = 3;
            this.pl_OrientationUp.Text = "上";
            this.pl_OrientationUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_OrientationUp_MouseDown);
            this.pl_OrientationUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_OrientationUp_MouseUp);
            // 
            // pl_OrientationDown
            // 
            this.pl_OrientationDown.AutoSize = true;
            this.pl_OrientationDown.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pl_OrientationDown.Location = new System.Drawing.Point(83, 130);
            this.pl_OrientationDown.Name = "pl_OrientationDown";
            this.pl_OrientationDown.Size = new System.Drawing.Size(33, 28);
            this.pl_OrientationDown.TabIndex = 4;
            this.pl_OrientationDown.Text = "下";
            this.pl_OrientationDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_OrientationDown_MouseDown);
            this.pl_OrientationDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_OrientationDown_MouseUp);
            // 
            // pl_OrientationLeft
            // 
            this.pl_OrientationLeft.AutoSize = true;
            this.pl_OrientationLeft.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pl_OrientationLeft.Location = new System.Drawing.Point(30, 83);
            this.pl_OrientationLeft.Name = "pl_OrientationLeft";
            this.pl_OrientationLeft.Size = new System.Drawing.Size(33, 28);
            this.pl_OrientationLeft.TabIndex = 5;
            this.pl_OrientationLeft.Text = "左";
            this.pl_OrientationLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_OrientationLeft_MouseDown);
            this.pl_OrientationLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_OrientationLeft_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pl_OrientationRight);
            this.panel1.Controls.Add(this.pl_OrientationDown);
            this.panel1.Controls.Add(this.pl_OrientationLeft);
            this.panel1.Controls.Add(this.pl_OrientationUp);
            this.panel1.Location = new System.Drawing.Point(103, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 6;
            // 
            // pl_OrientationRight
            // 
            this.pl_OrientationRight.AutoSize = true;
            this.pl_OrientationRight.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pl_OrientationRight.Location = new System.Drawing.Point(137, 83);
            this.pl_OrientationRight.Name = "pl_OrientationRight";
            this.pl_OrientationRight.Size = new System.Drawing.Size(33, 28);
            this.pl_OrientationRight.TabIndex = 7;
            this.pl_OrientationRight.Text = "右";
            this.pl_OrientationRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_OrientationRight_MouseDown);
            this.pl_OrientationRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_OrientationRight_MouseUp);
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(228, 469);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(75, 23);
            this.bt_test.TabIndex = 7;
            this.bt_test.Text = "截图";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // pb_snapshot
            // 
            this.pb_snapshot.Location = new System.Drawing.Point(532, 343);
            this.pb_snapshot.Name = "pb_snapshot";
            this.pb_snapshot.Size = new System.Drawing.Size(454, 295);
            this.pb_snapshot.TabIndex = 8;
            this.pb_snapshot.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "视频显示区";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "图片显示区";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_snapshot);
            this.Controls.Add(this.bt_test);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_video);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_snapshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_video;
        private System.Windows.Forms.Label pl_OrientationUp;
        private System.Windows.Forms.Label pl_OrientationDown;
        private System.Windows.Forms.Label pl_OrientationLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pl_OrientationRight;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.PictureBox pb_snapshot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

