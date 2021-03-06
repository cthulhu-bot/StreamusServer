using System;
using FluentNHibernate.Mapping;
using Streamus.Domain;

namespace Streamus.Dao.Mappings
{
    public class UserMapping : ClassMap<User>
    {
        public UserMapping()
        {
            Table("[Users]");

            Id(e => e.Id).GeneratedBy.GuidComb().UnsavedValue(Guid.Empty);

            //  Only update properties which have changed.
            DynamicUpdate();

            Map(e => e.Name).Not.Nullable();
            Map(e => e.GooglePlusId).Not.Nullable();

            HasMany(u => u.Playlists)
                .Inverse()
                .Fetch.Join()
                .Cascade.AllDeleteOrphan()
                .KeyColumn("UserId");
        }
    }
}