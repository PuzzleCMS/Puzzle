using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Table]
    public class Blog
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <summary>
        /// The title of the <see cref="Blog"/> which will be used in the URL and frontend.
        /// </summary>
        public string Title { get; set; }


    }
}
