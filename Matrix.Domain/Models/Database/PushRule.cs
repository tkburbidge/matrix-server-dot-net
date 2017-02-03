using System;

namespace Matrix.Domain.Models.Database
{
    public class PushRule
    {
        public Guid PushRuleId { get; set; }
        public string Username { get; set; }
        public Guid RuleId { get; set; }
        public int PriorityClass { get; set; }
        public int Priority { get; set; }
        public string Conditions { get; set; }
        public string Actions { get; set; }


        public PushRule()
        {
            this.PushRuleId = Guid.NewGuid();
        }
    }
}
