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
        Plan selected = null;

        public MainForm()
        {
            InitializeComponent();
            LoadPlans();
            Validate();
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
                    this.finishedListBox.Items.Add(p.Title);
                }
                else
                {
                    unfinishedPlans.Add(p);
                    this.unfinishedListBox.Items.Add(p.Title);
                }
            }
            finishedPlans.Sort((p1, p2) => (p1.Date - p2.Date).Days);
            unfinishedPlans.Sort((p1, p2) => (p1.Date - p2.Date).Days);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == this.unfinishedListBox)
                selected = unfinishedPlans[this.unfinishedListBox.SelectedIndex];
            else
                selected = finishedPlans[this.finishedListBox.SelectedIndex];

            this.detailTextBox.Text = selected.Detail;
            string description = "DDL";
            if (selected.Immediate)
                description = "At Time";
            this.ddlTextBox.Text = $"{description}: {selected.Date.ToString()}";
        }

        private void Control_TabIndexChanged(object sender, EventArgs e)
        {
            selected = null;
            this.unfinishedListBox.SelectedIndex = -1;
            this.finishedListBox.SelectedIndex = -1;
        }
    }
}
