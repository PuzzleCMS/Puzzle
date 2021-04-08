using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// Holds the content of a single Post.
    /// Can be a Child of a <see cref="IBlog"/>
    /// </summary>
    public interface IPost : IHasGuidID
    {
        /// <summary>
        /// HTML content of the Post.
        /// </summary>
        public string HTML { get; }

        /// <summary>
        /// Foreign key to Blog.
        /// </summary>
        public Guid BlogID { get; }

        /// <summary>
        /// The parent <see cref="IBlog"/>.
        /// </summary>
        public IBlog ParentBlog { get; }
    }
}
