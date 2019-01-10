using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TalentsManagerService.Data.Model
{
    public class TalentKnowledge : BaseEntity
    {
        public Int64 KnowledgeId { get; set; }

        [ForeignKey("KnowledgeId")]
        public virtual Knowledge Knowledge { get; set; }

        public int SkillLevel { get; set; }
    }
}