using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az1
{
    public class CV
    {
        public string? Speciality { get; set; }
        public string? SchoolName { get; set; }
        public string? ExamPoint { get; set; }
        public List<string?>? Skills { get; set; }
        public List<string?>? Companies { get; set; }
        public string? PractiseTime { get; set; }
        public List<string?>? Language { get; set; }
        public bool HonorsDiplom { get; set; } = false;
        public string? GitLink { get; set; } = null;
        public string? Linkedin { get; set; } = null;
    }
}
