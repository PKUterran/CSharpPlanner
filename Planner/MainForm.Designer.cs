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
            this.finishedTabPage = new System.Windows.Forms.TabPage();
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.ddlTextBox = new System.Windows.Forms.TextBox();
            this.unfinishedListBox = new System.Windows.Forms.ListBox();
            this.FinishedListBox = new System.Windows.Forms.ListBox();
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
            this.splitContainer1.Panel2.Controls.Add(this.ddlTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.detailTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(681, 441);
            this.splitContainer1.SplitterDistance = 227;
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
            this.tabControl.Size = new System.Drawing.Size(227, 441);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // unfinishedTabPage
            // 
            this.unfinishedTabPage.Controls.Add(this.unfinishedListBox);
            this.unfinishedTabPage.Location = new System.Drawing.Point(4, 22);
            this.unfinishedTabPage.Name = "unfinishedTabPage";
            this.unfinishedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.unfinishedTabPage.Size = new System.Drawing.Size(219, 415);
            this.unfinishedTabPage.TabIndex = 0;
            this.unfinishedTabPage.Text = "未完成";
            this.unfinishedTabPage.UseVisualStyleBackColor = true;
            // 
            // finishedTabPage
            // 
            this.finishedTabPage.Controls.Add(this.FinishedListBox);
            this.finishedTabPage.Location = new System.Drawing.Point(4, 22);
            this.finishedTabPage.Name = "finishedTabPage";
            this.finishedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.finishedTabPage.Size = new System.Drawing.Size(219, 415);
            this.finishedTabPage.TabIndex = 1;
            this.finishedTabPage.Text = "已完成";
            this.finishedTabPage.UseVisualStyleBackColor = true;
            // 
            // detailTextBox
            // 
            this.detailTextBox.Location = new System.Drawing.Point(3, 3);
            this.detailTextBox.Multiline = true;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.Size = new System.Drawing.Size(444, 353);
            this.detailTextBox.TabIndex = 0;
            // 
            // ddlTextBox
            // 
            this.ddlTextBox.Location = new System.Drawing.Point(2, 381);
            this.ddlTextBox.Name = "ddlTextBox";
            this.ddlTextBox.Size = new System.Drawing.Size(445, 21);
            this.ddlTextBox.TabIndex = 1;
            // 
            // unfinishedListBox
            // 
            this.unfinishedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unfinishedListBox.FormattingEnabled = true;
            this.unfinishedListBox.ItemHeight = 12;
            this.unfinishedListBox.Location = new System.Drawing.Point(3, 3);
            this.unfinishedListBox.Name = "unfinishedListBox";
            this.unfinishedListBox.Size = new System.Drawing.Size(213, 409);
            this.unfinishedListBox.TabIndex = 0;
            // 
            // FinishedListBox
            // 
            this.FinishedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinishedListBox.FormattingEnabled = true;
            this.FinishedListBox.ItemHeight = 12;
            this.FinishedListBox.Location = new System.Drawing.Point(3, 3);
            this.FinishedListBox.Name = "FinishedListBox";
            this.FinishedListBox.Size = new System.Drawing.Size(213, 409);
            this.FinishedListBox.TabIndex = 1;
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
        private System.Windows.Forms.ListBox FinishedListBox;
    }
}

