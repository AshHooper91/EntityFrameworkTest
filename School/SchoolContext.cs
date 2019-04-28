using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace EntityFrameWorkTutorial.School
{
    public class SchoolContext : DbContext
    {
        #region Entities

        public DbSet<Student> Student { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<StudentGrade> StudentGrade { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }
        public DbSet<StudentContact> StudentContact { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<SchoolTeacher> SchoolTeacher { get; set; }
        public DbSet<SchoolTeacherAddress> SchoolTeacherAddress { get; set; }
        public DbSet<SchoolTeacherContact> SchoolTeacherContact { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SchoolContext"].ConnectionString);
        }

        /// <summary>
        /// Override Save Changes To Include Date Created
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            foreach (var entity in ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified))
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedDate = DateTime.UtcNow;
                    ((BaseEntity)entity.Entity).CreatedBy = Environment.UserName;
                }

                ((BaseEntity)entity.Entity).ModifiedDate = DateTime.UtcNow;
                ((BaseEntity)entity.Entity).ModifiedBy = Environment.UserName;
            }

            return base.SaveChanges();
        }

        #endregion
    }
}
