using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// An entity using a Guid as ID.
    /// </summary>
    public interface IHasGuidID
    {
        /// <summary>
        /// ID.
        /// </summary>
        public Guid ID { get; }
    }
}
