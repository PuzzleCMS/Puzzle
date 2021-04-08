using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// Combines multiple <see cref="IPage"/>s to one web application,
    /// which has to be served on the specified <see cref="RootPath"/>.
    /// </summary>
    public interface IWebsite : IHasGuidID
    {
        /// <summary>
        /// Pages this <see cref="IWebsite"/> is the direct parent of.
        /// </summary>
        public IEnumerable<IPage> Pages { get; }

        /// <summary>
        /// The URL this Website runs on.
        /// </summary>
        public string RootPath { get; }

        /// <summary>
        /// The relative Path the API runs on.
        /// </summary>
        public string APIPath { get; }

        /// <summary>
        /// If the Website should run headless.
        /// </summary>
        public bool HeadlessMode { get; }
    }
}
