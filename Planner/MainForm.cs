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
    public partial class MainForm : Form
    {
        List<Plan> finishedPlans = new List<Plan>();
        List<Plan> unfinishedPlans = new List<Plan>();
        AddPlan addPlan = new AddPlan();
        EditPlan editPlan = new EditPlan();
        Plan selected = null;

        public MainForm()
        {
            InitializeComponent();
            LoadPlans();
            ControlBox = false;
        }

        void LoadPlans()
        {
            List<Plan> plans = Data.GetAllPlans();
            finishedPlans.Clear();
            unfinishedPlans.Clear();
            foreach (Plan p in plans)
            {
                if (p.Finished)
                {
                    finishedPlans.Add(p);
                    this.finishedListBox.Items.Add(p.Title + "  @" + p.Date.ToShortDateString());
                }
                else
                {
                    unfinishedPlans.Add(p);
                    this.unfinishedListBox.Items.Add(p.Title + "  @" + p.Date.ToShortDateString());
                }
            }
            finishedPlans.Sort((p1, p2) => (p1.Date - p2.Date).Days);
            unfinishedPlans.Sort((p1, p2) => (p1.Date - p2.Date).Days);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == this.unfinishedListBox)
            {
                int i = this.unfinishedListBox.SelectedIndex;
                if (i >= this.unfinishedListBox.Items.Count || i == -1)
                    return;
                selected = unfinishedPlans[i];
            }
            else
            {
                int i = this.finishedListBox.SelectedIndex;
                if (i >= this.finishedListBox.Items.Count || i == -1)
                    return;
                selected = finishedPlans[i];
            }

            this.detailTextBox.Text = selected.Detail;
            string description = "DDL";
            if (selected.Immediate)
                description = "At Time";
            this.ddlTextBox.Text = $"{description}: {selected.Date.ToShortDateString()}";
        }

        private void Control_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = null;
            this.unfinishedListBox.SelectedIndex = -1;
            this.finishedListBox.SelectedIndex = -1;

            int index = this.tabControl.SelectedIndex;
            if (index == 0)
            {
                this.finishButton.Text = "标记完成";
                this.removeButton.Enabled = false;
            }
            else
            {
                this.finishButton.Text = "标记未完成";
                this.removeButton.Enabled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addPlan.Clear();
            addPlan.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("请选择一个Plan！");
                return;
            }
            editPlan.FillWithPlan(selected);
            editPlan.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("请选择一个Plan！");
                return;
            }
            Data.RemovePlan(selected);
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("请选择一个Plan！");
                return;
            }
            int index = this.tabControl.SelectedIndex;
            if (index == 0)
                Data.SetPlanFinished(selected.token, true);
            else
                Data.SetPlanFinished(selected.token, false);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
