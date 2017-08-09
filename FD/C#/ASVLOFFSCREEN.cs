﻿using System;
using System.Runtime.InteropServices;

namespace arcsoft
{

    [StructLayout(LayoutKind.Sequential)]
    public struct ASVLOFFSCREEN
    {
        public int u32PixelArrayFormat;
        public int i32Width;
        public int i32Height;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public IntPtr[] ppu8Plane;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] pi32Pitch;
    };

}
