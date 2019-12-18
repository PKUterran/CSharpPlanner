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
            this.ddlTextBox = new System.Windows.Forms.TextBox();
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.ddlTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.detailTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(908, 551);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.unfinishedTabPage);
            this.tabControl.Controls.Add(this.finishedTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(302, 551);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            this.tabControl.TabIndexChanged += new System.EventHandler(this.Control_TabIndexChanged);
            // 
            // unfinishedTabPage
            // 
            this.unfinishedTabPage.Controls.Add(this.unfinishedListBox);
            this.unfinishedTabPage.Location = new System.Drawing.Point(4, 25);
            this.unfinishedTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.unfinishedTabPage.Name = "unfinishedTabPage";
            this.unfinishedTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.unfinishedTabPage.Size = new System.Drawing.Size(294, 522);
            this.unfinishedTabPage.TabIndex = 0;
            this.unfinishedTabPage.Text = "未完成";
            this.unfinishedTabPage.UseVisualStyleBackColor = true;
            // 
            // unfinishedListBox
            // 
            this.unfinishedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unfinishedListBox.FormattingEnabled = true;
            this.unfinishedListBox.ItemHeight = 15;
            this.unfinishedListBox.Location = new System.Drawing.Point(4, 4);
            this.unfinishedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.unfinishedListBox.Name = "unfinishedListBox";
            this.unfinishedListBox.Size = new System.Drawing.Size(286, 514);
            this.unfinishedListBox.TabIndex = 0;
            this.unfinishedListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // finishedTabPage
            // 
            this.finishedTabPage.Controls.Add(this.finishedListBox);
            this.finishedTabPage.Location = new System.Drawing.Point(4, 25);
            this.finishedTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.finishedTabPage.Name = "finishedTabPage";
            this.finishedTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.finishedTabPage.Size = new System.Drawing.Size(294, 522);
            this.finishedTabPage.TabIndex = 1;
            this.finishedTabPage.Text = "已完成";
            this.finishedTabPage.UseVisualStyleBackColor = true;
            // 
            // finishedListBox
            // 
            this.finishedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishedListBox.FormattingEnabled = true;
            this.finishedListBox.ItemHeight = 15;
            this.finishedListBox.Location = new System.Drawing.Point(4, 4);
            this.finishedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.finishedListBox.Name = "finishedListBox";
            this.finishedListBox.Size = new System.Drawing.Size(286, 514);
            this.finishedListBox.TabIndex = 1;
            this.finishedListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ddlTextBox
            // 
            this.ddlTextBox.Location = new System.Drawing.Point(3, 476);
            this.ddlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ddlTextBox.Name = "ddlTextBox";
            this.ddlTextBox.Size = new System.Drawing.Size(592, 25);
            this.ddlTextBox.TabIndex = 1;
            // 
            // detailTextBox
            // 
            this.detailTextBox.Location = new System.Drawing.Point(4, 4);
            this.detailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.detailTextBox.Multiline = true;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.Size = new System.Drawing.Size(591, 440);
            this.detailTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 516);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(398, 516);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 551);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

