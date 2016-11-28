#region License
// Copyright (c) 2016 Mark Rienstra
// <p>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

namespace LWCGL.GLFW
{
    public enum GlfwBool
    {
        False = 0,
        True  = 1
    }

    public enum GlfwKeyModifiers
    {
        Shift   = 1 << 0, // 1
        Control = 1 << 1, // 2
        Alt     = 1 << 2, // 4
        Super   = 1 << 3  // 8
    }

    public enum GlfwKeyAction
    {
        Release = 0,
        Press   = 1,
        Repeat  = 2
    }

    public enum GlfwMouseButton
    {
        Button1      = 0,
        Button2      = 1,
        Button3      = 2,
        Button4      = 3,
        Button5      = 4,
        Button6      = 5,
        Button7      = 6,
        Button8      = 7,
        LeftButton   = 0,
        RightButton  = 1,
        MiddleButton = 2
    }

    public enum GlfwJoystick
    {
        Joystick1  =  0,
        Joystick2  =  1,
        Joystick3  =  2,
        Joystick4  =  3,
        Joystick5  =  4,
        Joystick6  =  5,
        Joystick7  =  6,
        Joystick8  =  7,
        Joystick9  =  8,
        Joystick10 =  9,
        Joystick11 = 10,
        Joystick12 = 11,
        Joystick13 = 12,
        Joystick14 = 13,
        Joystick15 = 14,
        Joystick16 = 15
    }

    public enum GlfwKey
    {
        Space           = 32,
        Apostrophe      = 39,
        Comma           = 44,
    }

    public enum GlfwError
    {
        NoError             = 0x00000,
        NotInitialized      = 0x10001,
        NoCurrentContext    = 0x10002,
        InvalidEnum         = 0x10003,
        InvalidValue        = 0x10004,
        OutOfMemory         = 0x10005,
        APIUnavailable      = 0x10006,
        VersionUnavailable  = 0x10007,
        PlatformError       = 0x10008,
        FormatUnavailable   = 0x10009
    }

    public enum GlfwWindowAttrib
    {
        Focused   = 0x20001,
        Iconified = 0x20002,
        Resizable = 0x20003,
        Visible   = 0x20004,
        Decorated = 0x20005
    }

    public enum GlfwWindowHint
    {
        RedBits             = 0x21001,
        GreenBits           = 0x21002,
        BlueBits            = 0x21003,
        AlphaBits           = 0x21004,
        DepthBits           = 0x21005,
        StencilBits         = 0x21006,
        AccumRedBits        = 0x21007,
        AccumGreenBits      = 0x21008,
        AccumBlueBits       = 0x21009,
        AccumAlphaBits      = 0x2100A,
        AuxBuffers          = 0x2100B,
        Stereo              = 0x2100C,
        Samples             = 0x2100D,
        SRGBCapable         = 0x2100E,
        RefreshRate         = 0x2100F,
        ClientAPI           = 0x22001,
        ContextVersionMajor = 0x22002,
        ContextVersionMinor = 0x22003,
        ContextRevision     = 0x22004,
        ContextRobustness   = 0x22005,
        OpenGLForwardCompat = 0x22006,
        OpenGLDebugContext  = 0x22007,
        OpenGLProfile       = 0x22008
    }

    public enum GlfwOpenGLAPI
    {
        OpenGLAPI   = 0x30001,
        OpenGLESAPI = 0x30002
    }

    public enum GlfwContextRobustness
    {
        NoRobustness        = 0x00000,
        NoResetNotification = 0x31001,
        LoseContextOnReset  = 0x31002
    }

    public enum GlfwOpenGLProfile
    {
        Any           = 0x00000,
        Core          = 0x32001,
        Compatibility = 0x32002
    }

    public enum GlfwInputMode
    {
        CursorMode         = 0x33001,
        StickyKeys         = 0x33002,
        StickyMouseButtons = 0x33003
    }

    public enum GlfwCursorMode
    {
        CursorNormal   = 0x34001,
        CursorHidden   = 0x34002,
        CursorDisabled = 0x34003
    }

    public enum GlfwConnectionState
    {
        Connected    = 0x40001,
        Disconnected = 0x40002
    }
}
