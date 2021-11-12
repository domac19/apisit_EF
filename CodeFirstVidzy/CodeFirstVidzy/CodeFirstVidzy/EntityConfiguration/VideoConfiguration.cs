using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstVidzy.EntityConfiguration
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(n => n.Name).IsRequired().HasMaxLength(255);

            HasRequired(g => g.Genre).WithMany(v => v.Videos).HasForeignKey(k => k.GenreId);

            HasMany(t => t.Tags).WithMany(v => v.Videos).Map(m =>
            {
                m.ToTable("VideoTags");
                m.MapLeftKey("Video_Id");
                m.MapRightKey("Tag_Id");
            });
        }
    }
}
