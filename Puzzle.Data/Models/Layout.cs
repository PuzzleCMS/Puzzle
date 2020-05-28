using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// A boilerplate that gets applied to
    /// every <see cref="Page"/> it is referenced in.
    /// </summary>
    [Table]
    public class Layout
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <summary>
        /// HTML content of the <see cref="Layout"/>.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string HTML { get; set; }

        /// <summary>
        /// CSS content of the <see cref="Layout"/>.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string CSS { get; set; }

        /// <summary>
        /// JavaScript content of the <see cref="Layout"/>.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string JS { get; set; }
    }
}
