using LinqToDB.Mapping;
using Puzzle.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="IRight"/>
    [Table]
    public class Right : IRight
    {
        /// <inheritdoc/>
        [Column, PrimaryKey]
        public Guid ID { get; set; }

        /// <inheritdoc/>
        [Column]
        public string Name { get; set; }

        /// <inheritdoc/>
        [Column]
        public string Description { get; set; }
    }
}
