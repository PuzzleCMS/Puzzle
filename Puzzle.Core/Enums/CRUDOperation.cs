using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Enums
{
    [Flags]
    public enum CRUDOperation
    {
        Create = 1,
        Read = 2,
        Update = 4,
        Delete = 8,
    }
}
