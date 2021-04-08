using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// Defines if a <see cref="IUser"/> of a <see cref="IUserGroup"/> has a right to do something.
    /// </summary>
    public interface IRight : IHasGuidID
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Optional description.
        /// </summary>
        public string Description { get; set; }
    }
}
