using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    class Plan
    {
        public string token;
        public string Title;
        public string Detail;
        public DateTime Date;
        public bool Immediate;
        public bool Finished;
        public Plan(string title, string detail, DateTime date, bool immediate)
        {
            token = title + ":" + GetTimeStamp();
            Title = title;
            Detail = detail;
            Date = date;
            Immediate = immediate;
            Finished = false;
        }

        public void SetFinished(bool finished)
        {
            Finished = finished;
        }

        public new string ToString()
        {
            return Title;
        }

        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }

    class Data
    {
        public static List<Plan> GetAllPlans()
        {
            // TODO: 获得数据库中所有的Plan
            List<Plan> plans = new List<Plan>();
            Plan plan0 = new Plan("高数考试", "一教101", DateTime.Parse("2019.5.25"), true);
            Plan plan1 = new Plan("高数作业", "第三章", DateTime.Parse("2019.4.20"), false);
            Plan plan2 = new Plan("线代考试", "一教102", DateTime.Parse("2019.4.23"), true);
            Plan plan3 = new Plan("哈哈哈", "呵呵呵", DateTime.Parse("2019.4.20"), false);
            plan3.SetFinished(true);
            plans.Add(plan0);
            plans.Add(plan1);
            plans.Add(plan2);
            plans.Add(plan3);
            return plans;
        }

        public static void AddPlan(Plan plan)
        {
            // TODO: 添加Plan
        }

        public static void EditPlan(Plan plan)
        {
            // TODO: 修改Plan的内容；提供的参数plan的token在数据库中已存在
        }

        public static void RemovePlan(Plan plan)
        {
            // TODO: 删除Plan；提供的参数plan的token在数据库中已存在
        }

        public static void SetPlanFinished(string token, bool finished)
        {
            // TODO: 把token对应的Plan的Finished字段设置为finished（可能为true/false）
        }
    }
}
