using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// An entity using HTML, CSS and JavaScript content.
    /// </summary>
    public interface IHasWebContent: IHasHtmlContent
    {
        /// <summary>
        /// CSS content.
        /// </summary>
        public string CSS { get; }

        /// <summary>
        /// JavaScript content.
        /// </summary>
        public string JS { get; }
    }
}
