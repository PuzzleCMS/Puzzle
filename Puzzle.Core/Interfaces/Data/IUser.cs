using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// Information about a user.
    /// </summary>
    public interface IUser : IHasGuidID
    {
        /// <summary>
        /// E-Mail.
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// The name that is displayed in Comments and <see cref="Post"/>s.
        /// </summary>
        public string DisplayName { get; }

        /// <summary>
        /// ID of the <see cref="IUserGroup"/> this <see cref="IUser"/> is in.
        /// </summary>
        public Guid UserGroupID { get; }

        /// <summary>
        /// The Parent <see cref="IUserGroup"/>.
        /// </summary>
        public IUserGroup ParentUserGroup { get; }

        /// <summary>
        /// The <see cref="ILogin"/> associated with this <see cref="IUser"/>.
        /// </summary>
        public ILogin Login { get; }
    }
}
