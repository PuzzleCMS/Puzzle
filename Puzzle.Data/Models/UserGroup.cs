using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// A Group of <see cref="User"/>s with specific rights.
    /// </summary>
    [Table]
    public class UserGroup
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <summary>
        /// Name of the <see cref="UserGroup"/>.
        /// </summary>
        [Column]
        public string Name { get; set; }

        /// <summary>
        /// List of associated Rights for this <see cref="UserGroup"/>.
        /// </summary>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(UserGroupRight.UserGroupID), CanBeNull = true, Relationship = Relationship.OneToMany)]
        public List<UserGroupRight> UserGroupRights { get; set; }
    }
}
