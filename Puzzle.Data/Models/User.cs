using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// Information about a user.
    /// </summary>
    [Table]
    public class User
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }
        
        /// <summary>
        /// E-Mail .
        /// </summary>
        [Column]
        public string Email { get; set; }

        /// <summary>
        /// The name that is displayed in <see cref="Comment"/>s and <see cref="Post"/>s.
        /// </summary>
        [Column]
        public string DisplayName { get; set; }

        /// <summary>
        /// ID of the <see cref="UserGroup"/> this <see cref="User"/> is in.
        /// </summary>
        [Column]
        public Guid UserGroupID { get; set; }

        /// <summary>
        /// ID of the <see cref="Login"/>.
        /// </summary>
        [Column]
        public Guid LoginID { get; set; }

        /// <summary>
        /// The <see cref="Login"/> associated with this <see cref="User"/>.
        /// </summary>
        [Association(ThisKey = nameof(LoginID), OtherKey = nameof(Models.Login.ID), CanBeNull = false, Relationship = Relationship.OneToOne)]
        public Login Login { get; set; }
    }
}
