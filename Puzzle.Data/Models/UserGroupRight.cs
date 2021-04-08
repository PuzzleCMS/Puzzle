using LinqToDB.Mapping;
using Puzzle.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="IUserGroupRight"/>
    [Table]
    public class UserGroupRight : IUserGroupRight
    {
        /// <inheritdoc/>
        [Column]
        public Guid UserGroupID { get; set; }

        /// <inheritdoc/>
        [Column]
        public Guid RightID { get; set; }

        /// <inheritdoc cref="IUserGroupRight.UserGroup"/>
        [Association(ThisKey = nameof(UserGroupID), OtherKey = nameof(Models.UserGroup.ID), CanBeNull = false, Relationship = Relationship.ManyToOne)]
        public UserGroup UserGroup { get; set; }
        IUserGroup IUserGroupRight.UserGroup => UserGroup;

        /// <inheritdoc cref="IUserGroupRight.Right"/>
        [Association(ThisKey = nameof(RightID), OtherKey = nameof(Models.Right.ID), CanBeNull = false, Relationship = Relationship.ManyToOne)]
        public Right Right { get; set; }
        IRight IUserGroupRight.Right => Right;
    }
}
