using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal class ExamManagementCatalog : ExamCatalog
    {
        protected override ExamItem[] CreateExamItems(List<Exam> exams)
        {
            ExamItem[] items = new ExamItem[exams.Count];
            for (int i = 0; i < exams.Count; i++)
            {
                items[i] = new ExamItem(exams.ElementAt(i), true);
            }
            return items;
        }
    }
}
