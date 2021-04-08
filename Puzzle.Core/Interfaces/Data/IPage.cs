using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// Holds the content of a single Page of a Website.
    /// Can be a child of a <see cref="IWebsite"/> or another <see cref="IPage"/>.
    /// </summary>
    public interface IPage : IHasGuidID, IHasWebContent
    {
        /// <summary>
        /// The name which will be used in the URL.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Foreign key to Website.
        /// </summary>
        public Guid? WebsiteID { get; }

        /// <summary>
        /// Foreign key to Page.
        /// </summary>
        public Guid? ParentPageID { get; }

        /// <summary>
        /// Foreign key to Layout.
        /// </summary>
        public Guid? LayoutID { get; }

        /// <summary>
        /// The parent <see cref="IWebsite"/> if it exists.
        /// </summary>
        public IWebsite ParentWebsite { get; }

        /// <summary>
        /// The parent <see cref="IPage"/> if it exists.
        /// </summary>
        public IPage ParentPage { get; }

        /// <summary>
        /// <see cref="IPage"/>s this <see cref="IPage"/> is the <em><strong>direct parent</strong></em> of.
        /// </summary>
        public IEnumerable<IPage> Pages { get; }

        /// <summary>
        /// The Layout this Page is based on.
        /// </summary>
        public ILayout Layout { get; }

        /// <summary>
        /// HTML content of the Page rendered within the Layout.
        /// If the <see cref="Models.Layout"/> is not defined, only the HTML of the <see cref="Page"/> should be returned.
        /// </summary>
        public string CombinedHTML { get; }
    }
}
