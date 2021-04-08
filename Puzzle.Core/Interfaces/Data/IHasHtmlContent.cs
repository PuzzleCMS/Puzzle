using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// An entity using HTML content.
    /// </summary>
    public interface IHasHtmlContent
    {
        /// <summary>
        /// HTML content.
        /// </summary>
        public string HTML { get; }
    }
}
