﻿/// @file VideoStreamInfo.cs 
/// <published> N </published>
/// <privlevel> Non-privilege </privlevel>
/// <privilege> None </privilege>
/// <privacy> N </privacy>
/// <product> TV </product>
/// <version> 5.0.0 </version>
/// <SDK_Support> N </SDK_Support>
/// Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved  
/// PROPRIETARY/CONFIDENTIAL  
/// This software is the confidential and proprietary  
/// information of SAMSUNG ELECTRONICS ("Confidential Information"). You shall  
/// not disclose such Confidential Information and shall use it only in  
/// accordance with the terms of the license agreement you entered into with  
/// SAMSUNG ELECTRONICS. SAMSUNG make no representations or warranties about the  
/// suitability of the software, either express or implied, including but not  
/// limited to the implied warranties of merchantability, fitness for a  
/// particular purpose, or non-infringement. SAMSUNG shall not be liable for any  
/// damages suffered by licensee as a result of using, modifying or distributing  
/// this software or its derivatives.

using System;
using System.Runtime.InteropServices;

namespace Tizen.TV.Multimedia
{
    public struct VideoStreamInfo
    {
        public byte[] codecData;
        public VideoMimeType mimeType;
        public int width;
        public int height;
        public int maxWidth;
        public int maxHeight;
        public int num;
        public int den;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct NativeVideoStreamInfo
    {
        public IntPtr codecData;
        public int codecDataLength;
        public VideoMimeType mimeType;
        public int width;
        public int height;
        public int maxWidth;
        public int maxHeight;
        public int num;
        public int den;
    }
}