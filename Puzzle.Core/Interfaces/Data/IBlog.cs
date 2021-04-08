using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// A Group of Posts.
    /// </summary>
    public interface IBlog : IHasGuidID
    {
        /// <summary>
        /// The title of the Blog which will be used in the URL and frontend.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// <see cref="IPost"/>s this <see cref="IBlog"/> is the parent of.
        /// </summary>
        public IEnumerable<IPost> Posts { get; }
    }
}
