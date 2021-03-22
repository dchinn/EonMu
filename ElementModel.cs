using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StateEval;

namespace service.Models
{
    public class LearningWalkClassroomScoringElementModel
    {
        public long Id { get; set; }
        public string ShortName { get; set; }
        public string Title { get; set; }
        public SERubricPerformanceLevel PerformanceLevel { get; set; }
        public bool IsFrameworkNode { get; set; }
        public string Color { get; set; }
        public string PerformanceLevelShortName { get; set; }
    }
}