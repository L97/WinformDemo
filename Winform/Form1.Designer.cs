namespace Winform
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Button();
            this.textPw = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.labelRegist = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btInsert = new System.Windows.Forms.Button();
            this.textInsertPw = new System.Windows.Forms.TextBox();
            this.textInsertId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.insertName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonUp = new System.Windows.Forms.Button();
            this.textNew1 = new System.Windows.Forms.TextBox();
            this.textNew = new System.Windows.Forms.TextBox();
            this.textOld = new System.Windows.Forms.TextBox();
            this.labelNew1 = new System.Windows.Forms.Label();
            this.labelNew = new System.Windows.Forms.Label();
            this.labelOld = new System.Windows.Forms.Label();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUpdatePw = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemXiaoHu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.textPw);
            this.panel1.Controls.Add(this.textId);
            this.panel1.Controls.Add(this.pw);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(115, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 197);
            this.panel1.TabIndex = 0;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Location = new System.Drawing.Point(164, 144);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // textPw
            // 
            this.textPw.Location = new System.Drawing.Point(116, 94);
            this.textPw.Name = "textPw";
            this.textPw.Size = new System.Drawing.Size(199, 21);
            this.textPw.TabIndex = 3;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(116, 54);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(199, 21);
            this.textId.TabIndex = 2;
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.BackColor = System.Drawing.Color.Transparent;
            this.pw.Font = new System.Drawing.Font("SimSun", 15F);
            this.pw.Location = new System.Drawing.Point(30, 95);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(69, 20);
            this.pw.TabIndex = 1;
            this.pw.Text = "密码：";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("SimSun", 15F);
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(30, 55);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(69, 20);
            this.id.TabIndex = 0;
            this.id.Text = "账户：";
            // 
            // labelRegist
            // 
            this.labelRegist.AutoSize = true;
            this.labelRegist.BackColor = System.Drawing.Color.Transparent;
            this.labelRegist.Font = new System.Drawing.Font("SimSun", 15F);
            this.labelRegist.Location = new System.Drawing.Point(542, 9);
            this.labelRegist.Name = "labelRegist";
            this.labelRegist.Size = new System.Drawing.Size(69, 20);
            this.labelRegist.TabIndex = 1;
            this.labelRegist.Text = "·注册";
            this.labelRegist.Click += new System.EventHandler(this.labelRegist_Click);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.BackColor = System.Drawing.Color.Transparent;
            this.labelOut.Font = new System.Drawing.Font("SimSun", 15F);
            this.labelOut.Location = new System.Drawing.Point(604, 9);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(69, 20);
            this.labelOut.TabIndex = 3;
            this.labelOut.Text = "·退出";
            this.labelOut.Click += new System.EventHandler(this.labelOut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(148, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 256);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(352, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btInsert);
            this.panel3.Controls.Add(this.textInsertPw);
            this.panel3.Controls.Add(this.textInsertId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.insertName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(93, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 237);
            this.panel3.TabIndex = 5;
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("SimSun", 15F);
            this.btInsert.Location = new System.Drawing.Point(173, 180);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 36);
            this.btInsert.TabIndex = 7;
            this.btInsert.Text = "注册";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // textInsertPw
            // 
            this.textInsertPw.Location = new System.Drawing.Point(151, 139);
            this.textInsertPw.Name = "textInsertPw";
            this.textInsertPw.Size = new System.Drawing.Size(188, 21);
            this.textInsertPw.TabIndex = 6;
            // 
            // textInsertId
            // 
            this.textInsertId.Location = new System.Drawing.Point(151, 82);
            this.textInsertId.Name = "textInsertId";
            this.textInsertId.Size = new System.Drawing.Size(188, 21);
            this.textInsertId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 15F);
            this.label2.Location = new System.Drawing.Point(83, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码";
            // 
            // insertName
            // 
            this.insertName.AutoSize = true;
            this.insertName.Font = new System.Drawing.Font("SimSun", 15F);
            this.insertName.Location = new System.Drawing.Point(83, 82);
            this.insertName.Name = "insertName";
            this.insertName.Size = new System.Drawing.Size(49, 20);
            this.insertName.TabIndex = 3;
            this.insertName.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 15F);
            this.label1.Location = new System.Drawing.Point(169, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "新建账户";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.buttonUp);
            this.panel4.Controls.Add(this.textNew1);
            this.panel4.Controls.Add(this.textNew);
            this.panel4.Controls.Add(this.textOld);
            this.panel4.Controls.Add(this.labelNew1);
            this.panel4.Controls.Add(this.labelNew);
            this.panel4.Controls.Add(this.labelOld);
            this.panel4.Location = new System.Drawing.Point(151, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 313);
            this.panel4.TabIndex = 8;
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(113, 251);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "修改";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // textNew1
            // 
            this.textNew1.Location = new System.Drawing.Point(120, 202);
            this.textNew1.Name = "textNew1";
            this.textNew1.Size = new System.Drawing.Size(144, 21);
            this.textNew1.TabIndex = 5;
            // 
            // textNew
            // 
            this.textNew.Location = new System.Drawing.Point(120, 157);
            this.textNew.Name = "textNew";
            this.textNew.Size = new System.Drawing.Size(144, 21);
            this.textNew.TabIndex = 4;
            // 
            // textOld
            // 
            this.textOld.Location = new System.Drawing.Point(120, 106);
            this.textOld.Name = "textOld";
            this.textOld.Size = new System.Drawing.Size(144, 21);
            this.textOld.TabIndex = 3;
            // 
            // labelNew1
            // 
            this.labelNew1.AutoSize = true;
            this.labelNew1.Location = new System.Drawing.Point(44, 205);
            this.labelNew1.Name = "labelNew1";
            this.labelNew1.Size = new System.Drawing.Size(53, 12);
            this.labelNew1.TabIndex = 2;
            this.labelNew1.Text = "确认密码";
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Location = new System.Drawing.Point(44, 160);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(41, 12);
            this.labelNew.TabIndex = 1;
            this.labelNew.Text = "新密码";
            // 
            // labelOld
            // 
            this.labelOld.AutoSize = true;
            this.labelOld.Location = new System.Drawing.Point(44, 109);
            this.labelOld.Name = "labelOld";
            this.labelOld.Size = new System.Drawing.Size(41, 12);
            this.labelOld.TabIndex = 0;
            this.labelOld.Text = "旧密码";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUpdate,
            this.ToolStripMenuItemUpdatePw,
            this.ToolStripMenuItemXiaoHu});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.ToolStripMenuItem.Text = "菜单";
            // 
            // ToolStripMenuItemUpdate
            // 
            this.ToolStripMenuItemUpdate.Name = "ToolStripMenuItemUpdate";
            this.ToolStripMenuItemUpdate.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItemUpdate.Text = "更新";
            this.ToolStripMenuItemUpdate.Click += new System.EventHandler(this.ToolStripMenuItemUpdate_Click);
            // 
            // ToolStripMenuItemUpdatePw
            // 
            this.ToolStripMenuItemUpdatePw.Name = "ToolStripMenuItemUpdatePw";
            this.ToolStripMenuItemUpdatePw.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItemUpdatePw.Text = "修改密码";
            this.ToolStripMenuItemUpdatePw.Click += new System.EventHandler(this.ToolStripMenuItemUpdatePw_Click);
            // 
            // ToolStripMenuItemXiaoHu
            // 
            this.ToolStripMenuItemXiaoHu.Name = "ToolStripMenuItemXiaoHu";
            this.ToolStripMenuItemXiaoHu.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItemXiaoHu.Text = "销户";
            this.ToolStripMenuItemXiaoHu.Click += new System.EventHandler(this.ToolStripMenuItemXiaoHu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(62, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(673, 446);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.labelRegist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox textPw;
        private System.Windows.Forms.Label labelRegist;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label insertName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInsertId;
        private System.Windows.Forms.TextBox textInsertPw;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelNew1;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Label labelOld;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.TextBox textNew1;
        private System.Windows.Forms.TextBox textNew;
        private System.Windows.Forms.TextBox textOld;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUpdatePw;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemXiaoHu;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

