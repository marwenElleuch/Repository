using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Models.Modes;

namespace Repository.Models.Context
{
    public class StudentMap
    {
        public StudentMap(EntityTypeBuilder<Student> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.FirstName).IsRequired();
            entityBuilder.Property(t => t.LastName).IsRequired();
            entityBuilder.Property(t => t.Email).IsRequired();
            entityBuilder.Property(t => t.EnrollmentNo).IsRequired();
        }
    }
}
