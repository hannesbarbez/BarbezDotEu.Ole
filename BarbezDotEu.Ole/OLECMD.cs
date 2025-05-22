// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.InteropServices;

namespace BarbezDotEu.Ole
{
    /// <summary>
    /// OLE command structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class OLECMD
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public int cmdID;
        /// <summary>
        /// Flags associated with cmdID.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public int cmdf;
    }
}
