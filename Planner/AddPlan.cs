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
    }
}
