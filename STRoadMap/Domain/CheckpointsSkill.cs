//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckpointsSkill
    {
        public int Achieved { get; set; }
        public int RMCheckpointId { get; set; }
        public int SkillLevelId { get; set; }
    
        public virtual RMCheckpoint RMCheckpoint { get; set; }
        public virtual SkillLevel SkillLevel { get; set; }
    }
}
