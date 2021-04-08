using System;
using System.Collections.Generic;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// A Group of Users with specific rights.
    /// </summary>
    public interface IUserGroup : IHasGuidID
    {
        /// <summary>
        /// Name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// List of <see cref="IUser"/>s this <see cref="IUserGroup"/> is the parent of.
        /// </summary>
        IEnumerable<IUser> Users { get; }

        /// <summary>
        /// List of Associations of <see cref="IRight"/>s for this UserGroup.
        /// </summary>
        IEnumerable<IUserGroupRight> UserGroupRights { get; }
    }
}