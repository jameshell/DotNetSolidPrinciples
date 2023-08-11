using System.Diagnostics;
using System.Text;

namespace SingleResponsability;

public class ExportHelper
{
    public void ExportStudents(IEnumerable<Student>? students)
    {
        Debug.Assert(students != null, nameof(students) + " != null");
        var enumerable = students.ToList();
        {
            var csv = string.Join(",", enumerable.Select(x => x.ToString()).ToArray());
        }

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("Id;Fullname;Grades");
        foreach (var item in enumerable)
        {
            sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
        }
        System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
    }
}