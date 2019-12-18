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
    public partial class EditPlan : Form
    {
        Plan plan = null;

        public EditPlan()
        {
            InitializeComponent();
            ControlBox = false;
        }

        public int Edit()
        {
            plan.Title = this.titleTextBox.Text;
            plan.Detail = this.detailTextBox.Text;
            plan.Date = this.dateTimePicker.Value;
            plan.Immediate = this.immediateCheckBox.Checked;
            if (plan.Title == "") return 1;

            Data.EditPlan(plan);
            return 0;
        }

        public void FillWithPlan(Plan plan_)
        {
            plan = plan_;
            this.titleTextBox.Text = plan.Title;
            this.detailTextBox.Text = plan.Detail;
            this.dateTimePicker.Value = plan.Date;
            this.immediateCheckBox.Checked = plan.Immediate;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int ret = Edit();
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
