using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// Defines if a <see cref="User"/> of a <see cref="UserGroup"/> has a right to do something.
    /// </summary>
    [Table]
    public class Right
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey]
        public Guid ID { get; set; }

        /// <summary>
        /// Readable name that is displayed to the <see cref="User"/>.
        /// </summary>
        [Column]
        public string Name { get; set; }

        /// <summary>
        /// Optional description.
        /// </summary>
        [Column]
        public string Description { get; set; }
    }
}
