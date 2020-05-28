using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// Additional sensible <see cref="User"/> data
    /// that, for security reasons, is stored separately.
    /// </summary>
    [Table]
    public class Login
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <summary>
        /// The Bcrypt hash of the password.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Char, Length = 60)]
        public string PasswordHash { get; set; }
    }
}
