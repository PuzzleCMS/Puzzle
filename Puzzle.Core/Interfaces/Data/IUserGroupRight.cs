using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// Association between <see cref="IUserGroup"/> and <see cref="IRight"/>.
    /// </summary>
    public interface IUserGroupRight
    {
        /// <summary>
        /// Foreign key to <see cref="IUserGroup"/>.
        /// </summary>
        public Guid UserGroupID { get; }

        /// <summary>
        /// Foreign key to <see cref="IRight"/>.
        /// </summary>
        public Guid RightID { get; }

        /// <summary>
        /// The assigned UserGroup.
        /// </summary>
        public IUserGroup UserGroup { get; }

        /// <summary>
        /// The assigned Right.
        /// </summary>
        public IRight Right { get; }
    }
}
