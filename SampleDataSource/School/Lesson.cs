using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataSource.School
{
    public class Lesson
    {
        public int Id { get; set; }
        public string LessonName { get; set; }

        public int TeacherId { get; set; }
        public int StudentId { get; set; }
    }
}
