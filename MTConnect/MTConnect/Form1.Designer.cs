namespace MTConnect
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_agent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_driver = new System.Windows.Forms.TextBox();
            this.lv_content = new System.Windows.Forms.ListView();
            this.col_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.txt_driver);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_agent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lv_content);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 303);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "agent:";
            // 
            // txt_agent
            // 
            this.txt_agent.Location = new System.Drawing.Point(72, 6);
            this.txt_agent.Name = "txt_agent";
            this.txt_agent.Size = new System.Drawing.Size(161, 21);
            this.txt_agent.TabIndex = 1;
            this.txt_agent.Text = "http://agent.mtconnect.org";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "driver:";
            // 
            // txt_driver
            // 
            this.txt_driver.Location = new System.Drawing.Point(338, 6);
            this.txt_driver.Name = "txt_driver";
            this.txt_driver.Size = new System.Drawing.Size(161, 21);
            this.txt_driver.TabIndex = 3;
            this.txt_driver.Text = "VMC-3Axis";
            // 
            // lv_content
            // 
            this.lv_content.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_number,
            this.col_name,
            this.col_timestamp,
            this.col_value});
            this.lv_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_content.GridLines = true;
            this.lv_content.Location = new System.Drawing.Point(0, 0);
            this.lv_content.Name = "lv_content";
            this.lv_content.Size = new System.Drawing.Size(747, 303);
            this.lv_content.TabIndex = 0;
            this.lv_content.UseCompatibleStateImageBehavior = false;
            this.lv_content.View = System.Windows.Forms.View.Details;
            this.lv_content.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_content_ColumnClick);
            // 
            // col_number
            // 
            this.col_number.Text = "Number";
            // 
            // col_name
            // 
            this.col_name.Text = "Name";
            this.col_name.Width = 150;
            // 
            // col_timestamp
            // 
            this.col_timestamp.Text = "Timestamp";
            this.col_timestamp.Width = 126;
            // 
            // col_value
            // 
            this.col_value.Text = "Value";
            this.col_value.Width = 300;
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Location = new System.Drawing.Point(579, 4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "启动";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop.Location = new System.Drawing.Point(660, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_driver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_agent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_content;
        private System.Windows.Forms.ColumnHeader col_number;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_timestamp;
        private System.Windows.Forms.ColumnHeader col_value;
    }
}

