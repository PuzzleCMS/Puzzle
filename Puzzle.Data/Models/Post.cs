using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// A Post.
    /// </summary>
    [Table]
    public class Post
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <summary>
        /// HTML content of the <see cref="Post"/>.
        /// </summary>
        [Column]
        public string HTML { get; set; }

        /// <summary>
        /// Foreign key to <see cref="Blog"/>.
        /// </summary>
        [Column]
        public Guid BlogID { get; set; }

        /// <summary>
        /// The parent <see cref="Blog"/>.
        /// </summary>
        [Association(ThisKey = nameof(BlogID), OtherKey = nameof(Blog.ID), CanBeNull = false, Relationship = Relationship.ManyToOne)]
        public Blog ParentBlog { get; set; }
    }
}
