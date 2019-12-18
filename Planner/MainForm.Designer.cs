namespace Planner
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.unfinishedTabPage = new System.Windows.Forms.TabPage();
            this.unfinishedListBox = new System.Windows.Forms.ListBox();
            this.finishedTabPage = new System.Windows.Forms.TabPage();
            this.finishedListBox = new System.Windows.Forms.ListBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.ddlTextBox = new System.Windows.Forms.TextBox();
            this.detailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.unfinishedTabPage.SuspendLayout();
            this.finishedTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.finishButton);
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Panel2.Controls.Add(this.removeButton);
            this.splitContainer1.Panel2.Controls.Add(this.editButton);
            this.splitContainer1.Panel2.Controls.Add(this.addButton);
            this.splitContainer1.Panel2.Controls.Add(this.ddlTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.detailTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(681, 441);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.unfinishedTabPage);
            this.tabControl.Controls.Add(this.finishedTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(226, 441);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // unfinishedTabPage
            // 
            this.unfinishedTabPage.Controls.Add(this.unfinishedListBox);
            this.unfinishedTabPage.Location = new System.Drawing.Point(4, 22);
            this.unfinishedTabPage.Name = "unfinishedTabPage";
            this.unfinishedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.unfinishedTabPage.Size = new System.Drawing.Size(218, 415);
            this.unfinishedTabPage.TabIndex = 0;
            this.unfinishedTabPage.Text = "未完成";
            this.unfinishedTabPage.UseVisualStyleBackColor = true;
            // 
            // unfinishedListBox
            // 
            this.unfinishedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unfinishedListBox.FormattingEnabled = true;
            this.unfinishedListBox.ItemHeight = 12;
            this.unfinishedListBox.Location = new System.Drawing.Point(3, 3);
            this.unfinishedListBox.Name = "unfinishedListBox";
            this.unfinishedListBox.Size = new System.Drawing.Size(212, 409);
            this.unfinishedListBox.TabIndex = 0;
            this.unfinishedListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // finishedTabPage
            // 
            this.finishedTabPage.Controls.Add(this.finishedListBox);
            this.finishedTabPage.Location = new System.Drawing.Point(4, 22);
            this.finishedTabPage.Name = "finishedTabPage";
            this.finishedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.finishedTabPage.Size = new System.Drawing.Size(218, 415);
            this.finishedTabPage.TabIndex = 1;
            this.finishedTabPage.Text = "已完成";
            this.finishedTabPage.UseVisualStyleBackColor = true;
            // 
            // finishedListBox
            // 
            this.finishedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishedListBox.FormattingEnabled = true;
            this.finishedListBox.ItemHeight = 12;
            this.finishedListBox.Location = new System.Drawing.Point(3, 3);
            this.finishedListBox.Name = "finishedListBox";
            this.finishedListBox.Size = new System.Drawing.Size(212, 409);
            this.finishedListBox.TabIndex = 1;
            this.finishedListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(271, 407);
            this.finishButton.Margin = new System.Windows.Forms.Padding(2);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(89, 24);
            this.finishButton.TabIndex = 6;
            this.finishButton.Text = "标记完成";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(386, 407);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(56, 24);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(186, 407);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(56, 24);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "删除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(101, 407);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(56, 24);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "编辑";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 407);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(56, 24);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ddlTextBox
            // 
            this.ddlTextBox.Location = new System.Drawing.Point(2, 381);
            this.ddlTextBox.Name = "ddlTextBox";
            this.ddlTextBox.Size = new System.Drawing.Size(445, 21);
            this.ddlTextBox.TabIndex = 1;
            // 
            // detailTextBox
            // 
            this.detailTextBox.Location = new System.Drawing.Point(3, 3);
            this.detailTextBox.Multiline = true;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.Size = new System.Drawing.Size(444, 353);
            this.detailTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.unfinishedTabPage.ResumeLayout(false);
            this.finishedTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage unfinishedTabPage;
        private System.Windows.Forms.ListBox unfinishedListBox;
        private System.Windows.Forms.TabPage finishedTabPage;
        private System.Windows.Forms.TextBox ddlTextBox;
        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.ListBox finishedListBox;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
    }
}

