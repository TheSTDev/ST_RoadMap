﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<CheckpointsSkill> CheckpointsSkills { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<MentorCheckpointComment> MentorCheckpointComments { get; set; }
        public virtual DbSet<MentorRMComment> MentorRMComments { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<RegistrationKey> RegistrationKeys { get; set; }
        public virtual DbSet<RMCheckpoint> RMCheckpoints { get; set; }
        public virtual DbSet<RoadMap> RoadMaps { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillLevel> SkillLevels { get; set; }
        public virtual DbSet<SkillMatrix> SkillMatrices { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<UserCheckpointComment> UserCheckpointComments { get; set; }
    }
}
