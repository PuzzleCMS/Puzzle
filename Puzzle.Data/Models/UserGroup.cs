using LinqToDB.Mapping;
using Puzzle.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="IUserGroup"/>
    [Table]
    public class UserGroup : IUserGroup
    {
        /// <inheritdoc/>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <inheritdoc/>
        [Column]
        public string Name { get; set; }

        /// <inheritdoc cref="IUserGroup.Users"/>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(User.UserGroupID), CanBeNull = true, Relationship = Relationship.OneToMany)]
        public IEnumerable<User> Users { get; set; }
        IEnumerable<IUser> IUserGroup.Users => throw new NotImplementedException();

        /// <inheritdoc cref="IUserGroup.UserGroupRights"/>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(UserGroupRight.UserGroupID), CanBeNull = true, Relationship = Relationship.OneToMany)]
        public IEnumerable<UserGroupRight> UserGroupRights { get; set; }
        IEnumerable<IUserGroupRight> IUserGroup.UserGroupRights => throw new NotImplementedException();
    }
}
