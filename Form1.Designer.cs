namespace 针对SQL数据库_简单SQL语句程序
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
            this.显示说明1 = new System.Windows.Forms.Label();
            this.text数据库名 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.数据库连接Box = new System.Windows.Forms.GroupBox();
            this.text数据表 = new System.Windows.Forms.TextBox();
            this.text密码 = new System.Windows.Forms.TextBox();
            this.text用户名 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but退出 = new System.Windows.Forms.Button();
            this.but连接数据库 = new System.Windows.Forms.Button();
            this.Box数据表 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1查询内容 = new System.Windows.Forms.Button();
            this.group查询功能 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox表名 = new System.Windows.Forms.TextBox();
            this.group数据更改 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.butt数据删除 = new System.Windows.Forms.Button();
            this.butt查询单一数据 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text实际数据 = new System.Windows.Forms.TextBox();
            this.text数据列名 = new System.Windows.Forms.TextBox();
            this.but帮助说明 = new System.Windows.Forms.Button();
            this.button2获取表名 = new System.Windows.Forms.Button();
            this.but断开数据库 = new System.Windows.Forms.Button();
            this.数据库连接Box.SuspendLayout();
            this.Box数据表.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.group查询功能.SuspendLayout();
            this.group数据更改.SuspendLayout();
            this.SuspendLayout();
            // 
            // 显示说明1
            // 
            this.显示说明1.AutoSize = true;
            this.显示说明1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.显示说明1.Location = new System.Drawing.Point(25, 220);
            this.显示说明1.Name = "显示说明1";
            this.显示说明1.Size = new System.Drawing.Size(69, 19);
            this.显示说明1.TabIndex = 0;
            this.显示说明1.Text = "label1";
            // 
            // text数据库名
            // 
            this.text数据库名.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text数据库名.Location = new System.Drawing.Point(129, 18);
            this.text数据库名.Name = "text数据库名";
            this.text数据库名.Size = new System.Drawing.Size(182, 30);
            this.text数据库名.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器名";
            // 
            // 数据库连接Box
            // 
            this.数据库连接Box.Controls.Add(this.显示说明1);
            this.数据库连接Box.Controls.Add(this.text数据表);
            this.数据库连接Box.Controls.Add(this.text密码);
            this.数据库连接Box.Controls.Add(this.text用户名);
            this.数据库连接Box.Controls.Add(this.label4);
            this.数据库连接Box.Controls.Add(this.label3);
            this.数据库连接Box.Controls.Add(this.label2);
            this.数据库连接Box.Controls.Add(this.label1);
            this.数据库连接Box.Controls.Add(this.text数据库名);
            this.数据库连接Box.Location = new System.Drawing.Point(12, 12);
            this.数据库连接Box.Name = "数据库连接Box";
            this.数据库连接Box.Size = new System.Drawing.Size(328, 249);
            this.数据库连接Box.TabIndex = 2;
            this.数据库连接Box.TabStop = false;
            this.数据库连接Box.Text = "数据库连接";
            // 
            // text数据表
            // 
            this.text数据表.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text数据表.Location = new System.Drawing.Point(129, 156);
            this.text数据表.Name = "text数据表";
            this.text数据表.Size = new System.Drawing.Size(182, 30);
            this.text数据表.TabIndex = 7;
            this.text数据表.Text = "SPECM";
            // 
            // text密码
            // 
            this.text密码.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text密码.Location = new System.Drawing.Point(129, 108);
            this.text密码.Name = "text密码";
            this.text密码.Size = new System.Drawing.Size(182, 30);
            this.text密码.TabIndex = 6;
            this.text密码.Text = "Feeler82831393";
            this.text密码.UseSystemPasswordChar = true;
            // 
            // text用户名
            // 
            this.text用户名.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text用户名.Location = new System.Drawing.Point(129, 61);
            this.text用户名.Name = "text用户名";
            this.text用户名.Size = new System.Drawing.Size(182, 30);
            this.text用户名.TabIndex = 5;
            this.text用户名.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(25, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "数据表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名";
            // 
            // but退出
            // 
            this.but退出.Font = new System.Drawing.Font("宋体", 12F);
            this.but退出.Location = new System.Drawing.Point(1177, 205);
            this.but退出.Name = "but退出";
            this.but退出.Size = new System.Drawing.Size(128, 56);
            this.but退出.TabIndex = 10;
            this.but退出.Text = "退出";
            this.but退出.UseVisualStyleBackColor = true;
            this.but退出.Click += new System.EventHandler(this.But退出_Click);
            // 
            // but连接数据库
            // 
            this.but连接数据库.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but连接数据库.Location = new System.Drawing.Point(360, 15);
            this.but连接数据库.Name = "but连接数据库";
            this.but连接数据库.Size = new System.Drawing.Size(127, 63);
            this.but连接数据库.TabIndex = 8;
            this.but连接数据库.Text = "连接数据库";
            this.but连接数据库.UseVisualStyleBackColor = true;
            this.but连接数据库.Click += new System.EventHandler(this.But连接数据库_Click);
            // 
            // Box数据表
            // 
            this.Box数据表.Controls.Add(this.dataGridView1);
            this.Box数据表.Location = new System.Drawing.Point(12, 267);
            this.Box数据表.Name = "Box数据表";
            this.Box数据表.Size = new System.Drawing.Size(1309, 453);
            this.Box数据表.TabIndex = 3;
            this.Box数据表.TabStop = false;
            this.Box数据表.Text = "数据表单";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1285, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1查询内容
            // 
            this.button1查询内容.Font = new System.Drawing.Font("宋体", 12F);
            this.button1查询内容.Location = new System.Drawing.Point(329, 18);
            this.button1查询内容.Name = "button1查询内容";
            this.button1查询内容.Size = new System.Drawing.Size(143, 63);
            this.button1查询内容.TabIndex = 4;
            this.button1查询内容.Text = "查询表内容";
            this.button1查询内容.UseVisualStyleBackColor = true;
            this.button1查询内容.Click += new System.EventHandler(this.Button1_Click);
            // 
            // group查询功能
            // 
            this.group查询功能.Controls.Add(this.label7);
            this.group查询功能.Controls.Add(this.textBox表名);
            this.group查询功能.Controls.Add(this.button1查询内容);
            this.group查询功能.Location = new System.Drawing.Point(531, 12);
            this.group查询功能.Name = "group查询功能";
            this.group查询功能.Size = new System.Drawing.Size(640, 91);
            this.group查询功能.TabIndex = 7;
            this.group查询功能.TabStop = false;
            this.group查询功能.Text = "查询功能";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "数据表名";
            // 
            // textBox表名
            // 
            this.textBox表名.Location = new System.Drawing.Point(10, 41);
            this.textBox表名.Name = "textBox表名";
            this.textBox表名.Size = new System.Drawing.Size(236, 25);
            this.textBox表名.TabIndex = 7;
            // 
            // group数据更改
            // 
            this.group数据更改.Controls.Add(this.label8);
            this.group数据更改.Controls.Add(this.butt数据删除);
            this.group数据更改.Controls.Add(this.butt查询单一数据);
            this.group数据更改.Controls.Add(this.label6);
            this.group数据更改.Controls.Add(this.label5);
            this.group数据更改.Controls.Add(this.text实际数据);
            this.group数据更改.Controls.Add(this.text数据列名);
            this.group数据更改.Location = new System.Drawing.Point(532, 110);
            this.group数据更改.Name = "group数据更改";
            this.group数据更改.Size = new System.Drawing.Size(639, 151);
            this.group数据更改.TabIndex = 8;
            this.group数据更改.TabStop = false;
            this.group数据更改.Text = "数据更改";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(27, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "务必确保数据唯一性（防止误删除）";
            // 
            // butt数据删除
            // 
            this.butt数据删除.Font = new System.Drawing.Font("宋体", 12F);
            this.butt数据删除.Location = new System.Drawing.Point(439, 105);
            this.butt数据删除.Name = "butt数据删除";
            this.butt数据删除.Size = new System.Drawing.Size(86, 36);
            this.butt数据删除.TabIndex = 13;
            this.butt数据删除.Text = "删除";
            this.butt数据删除.UseVisualStyleBackColor = true;
            this.butt数据删除.Click += new System.EventHandler(this.Butt数据删除_Click);
            // 
            // butt查询单一数据
            // 
            this.butt查询单一数据.Font = new System.Drawing.Font("宋体", 12F);
            this.butt查询单一数据.Location = new System.Drawing.Point(439, 33);
            this.butt查询单一数据.Name = "butt查询单一数据";
            this.butt查询单一数据.Size = new System.Drawing.Size(86, 36);
            this.butt查询单一数据.TabIndex = 12;
            this.butt查询单一数据.Text = "查询";
            this.butt查询单一数据.UseVisualStyleBackColor = true;
            this.butt查询单一数据.Click += new System.EventHandler(this.Butt查询单一数据_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(180, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "数据";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "数据表列名";
            // 
            // text实际数据
            // 
            this.text实际数据.Location = new System.Drawing.Point(184, 44);
            this.text实际数据.Name = "text实际数据";
            this.text实际数据.Size = new System.Drawing.Size(204, 25);
            this.text实际数据.TabIndex = 1;
            // 
            // text数据列名
            // 
            this.text数据列名.Location = new System.Drawing.Point(10, 44);
            this.text数据列名.Name = "text数据列名";
            this.text数据列名.Size = new System.Drawing.Size(139, 25);
            this.text数据列名.TabIndex = 0;
            // 
            // but帮助说明
            // 
            this.but帮助说明.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but帮助说明.Location = new System.Drawing.Point(1177, 43);
            this.but帮助说明.Name = "but帮助说明";
            this.but帮助说明.Size = new System.Drawing.Size(128, 50);
            this.but帮助说明.TabIndex = 9;
            this.but帮助说明.Text = "帮助";
            this.but帮助说明.UseVisualStyleBackColor = true;
            this.but帮助说明.Click += new System.EventHandler(this.But帮助说明_Click);
            // 
            // button2获取表名
            // 
            this.button2获取表名.Font = new System.Drawing.Font("宋体", 12F);
            this.button2获取表名.Location = new System.Drawing.Point(346, 166);
            this.button2获取表名.Name = "button2获取表名";
            this.button2获取表名.Size = new System.Drawing.Size(163, 61);
            this.button2获取表名.TabIndex = 11;
            this.button2获取表名.Text = "显示全部表名";
            this.button2获取表名.UseVisualStyleBackColor = true;
            this.button2获取表名.Click += new System.EventHandler(this.Button2获取表名_Click);
            // 
            // but断开数据库
            // 
            this.but断开数据库.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but断开数据库.Location = new System.Drawing.Point(360, 90);
            this.but断开数据库.Name = "but断开数据库";
            this.but断开数据库.Size = new System.Drawing.Size(127, 61);
            this.but断开数据库.TabIndex = 11;
            this.but断开数据库.Text = "断开数据库";
            this.but断开数据库.UseVisualStyleBackColor = true;
            this.but断开数据库.Click += new System.EventHandler(this.But断开数据库_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 748);
            this.Controls.Add(this.button2获取表名);
            this.Controls.Add(this.but断开数据库);
            this.Controls.Add(this.but帮助说明);
            this.Controls.Add(this.but退出);
            this.Controls.Add(this.group数据更改);
            this.Controls.Add(this.but连接数据库);
            this.Controls.Add(this.group查询功能);
            this.Controls.Add(this.Box数据表);
            this.Controls.Add(this.数据库连接Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "关于数据库重复数据删除（后期增加其他功能）-WangYan 2022-09-09";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.数据库连接Box.ResumeLayout(false);
            this.数据库连接Box.PerformLayout();
            this.Box数据表.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.group查询功能.ResumeLayout(false);
            this.group查询功能.PerformLayout();
            this.group数据更改.ResumeLayout(false);
            this.group数据更改.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label 显示说明1;
        private System.Windows.Forms.TextBox text数据库名;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox 数据库连接Box;
        private System.Windows.Forms.Button but连接数据库;
        private System.Windows.Forms.TextBox text数据表;
        private System.Windows.Forms.TextBox text密码;
        private System.Windows.Forms.TextBox text用户名;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Box数据表;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1查询内容;
        private System.Windows.Forms.GroupBox group查询功能;
        private System.Windows.Forms.TextBox textBox表名;
        private System.Windows.Forms.GroupBox group数据更改;
        private System.Windows.Forms.Button butt数据删除;
        private System.Windows.Forms.Button butt查询单一数据;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text实际数据;
        private System.Windows.Forms.TextBox text数据列名;
        private System.Windows.Forms.Button but退出;
        private System.Windows.Forms.Button but帮助说明;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2获取表名;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but断开数据库;
    }
}

