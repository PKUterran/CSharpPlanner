using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    public partial class AddPlan : Form
    {
        public AddPlan()
        {
            InitializeComponent();
            ControlBox = false;
        }

        public int Add()
        {
            string title = this.titleTextBox.Text;
            string detail = this.detailTextBox.Text;
            DateTime date = this.dateTimePicker.Value;
            bool immediate = this.immediateCheckBox.Checked;
            if (title == "") return 1;

            Plan plan = new Plan(title, detail, date, immediate);
            Data.AddPlan(plan);
            return 0;
        }

        public void Clear()
        {
            this.titleTextBox.Text = "";
            this.detailTextBox.Text = "";
            this.dateTimePicker.Value = DateTime.Now;
            this.immediateCheckBox.Checked = false;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int ret = Add();
            if (ret == 0)
                Hide();
            else
            {
                if (ret == 1)
                {
                    MessageBox.Show("标题不能为空！");
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
