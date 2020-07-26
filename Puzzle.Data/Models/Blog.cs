using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// A Group of Posts.
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
        [Column]
        public string Title { get; set; }

        /// <summary>
        /// Pages this <see cref="Page"/> is the direct parent of.
        /// </summary>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(Post.BlogID), CanBeNull = true, Relationship = Relationship.OneToMany)]
        public List<Post> Posts { get; set; }
    }
}
