using System;

namespace Matrix.Domain.Models.Database
{
    public class PushRulesEnable
    {
        public Guid PushRulesEnableId { get; set; }
        public string Username { get; set; }
        public Guid RuleId { get; set; }
        public bool IsEnabled { get; set; }

        public PushRulesEnable()
        {
            this.PushRulesEnableId = Guid.NewGuid();
        }
    }
}
