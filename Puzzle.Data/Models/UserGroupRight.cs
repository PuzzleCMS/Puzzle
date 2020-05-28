using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// Association between <see cref="UserGroup"/> and <see cref="Right"/>.
    /// </summary>
    [Table]
    public class UserGroupRight
    {
        /// <summary>
        /// Foreign key to <see cref="Models.UserGroup"/>.
        /// </summary>
        [Column]
        public Guid UserGroupID { get; set; }

        /// <summary>
        /// Foreign key to <see cref="Models.Right"/>.
        /// </summary>
        [Column]
        public Guid RightID { get; set; }

        /// <summary>
        /// The assigned UserGroup.
        /// </summary>
        [Association(ThisKey = nameof(UserGroupID), OtherKey = nameof(Models.UserGroup.ID), CanBeNull = false, Relationship = Relationship.ManyToOne)]
        public UserGroup UserGroup { get; set; }

        /// <summary>
        /// The assigned UserGroup.
        /// </summary>
        [Association(ThisKey = nameof(RightID), OtherKey = nameof(Models.Right.ID), CanBeNull = false, Relationship = Relationship.ManyToOne)]
        public Right Right { get; set; }
    }
}
