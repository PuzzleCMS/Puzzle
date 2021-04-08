using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// Additional sensible User data that,
    /// for security reasons, is stored separately.
    /// </summary>
    public interface ILogin
    {
        /// <summary>
        /// Foreign key to User.
        /// </summary>
        public Guid UserID { get; }

        /// <summary>
        /// The Bcrypt hash of the password.
        /// </summary>
        public string PasswordHash { get; }
    }
}
