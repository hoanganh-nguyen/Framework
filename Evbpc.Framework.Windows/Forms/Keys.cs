﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Evbpc.Framework.Windows.Forms
{
    /// <summary>
    /// Specifies key codes and modifiers.
    /// 
    /// This enumeration has a FlagsAttribute attribute that allows a bitwise combination of its member values.
    /// </summary>
    /// <remarks>
    /// http://msdn.microsoft.com/en-us/library/system.windows.forms.keys%28v=vs.110%29.aspx
    /// 
    /// The Keys class contains constants for processing keyboard input. The members of the Keys enumeration consist of a key code and a set of modifiers combined into a single integer value. In the Win32 application programming interface (API) a key value has two halves, with the high-order bits containing the key code (which is the same as a Windows virtual key code), and the low-order bits representing key modifiers such as the SHIFT, CONTROL, and ALT keys.
    /// 
    /// Caution: Do not use the values in this enumeration for combined bitwise operations. The values in the enumeration are not mutually exclusive.
    /// 
    /// Also, do note: I wrote a little program that generated this file for me. I cannot guarantee it's accuracy.
    /// </remarks>
    [Flags]
    public enum Keys
    {
        /// <summary>
        /// The A key.
        /// </summary>
        A = 0x41,
        /// <summary>
        /// The add key.
        /// </summary>
        Add = 0x6B,
        /// <summary>
        /// The ALT modifier key.
        /// </summary>
        Alt = 0x40000,
        /// <summary>
        /// The application key (Microsoft Natural Keyboard).
        /// </summary>
        Apps = 0x5D,
        /// <summary>
        /// The ATTN key.
        /// </summary>
        Attn = 0xF6,
        /// <summary>
        /// The B key.
        /// </summary>
        B = 0x42,
        /// <summary>
        /// The BACKSPACE key.
        /// </summary>
        Back = 0x08,
        /// <summary>
        /// The browser back key (Windows 2000 or later).
        /// </summary>
        BrowserBack = 0xA6,
        /// <summary>
        /// The browser favorites key (Windows 2000 or later).
        /// </summary>
        BrowserFavorites = 0xAB,
        /// <summary>
        /// The browser forward key (Windows 2000 or later).
        /// </summary>
        BrowserForward = 0xA7,
        /// <summary>
        /// The browser home key (Windows 2000 or later).
        /// </summary>
        BrowserHome = 0xAC,
        /// <summary>
        /// The browser refresh key (Windows 2000 or later).
        /// </summary>
        BrowserRefresh = 0xA8,
        /// <summary>
        /// The browser search key (Windows 2000 or later).
        /// </summary>
        BrowserSearch = 0xAA,
        /// <summary>
        /// The browser stop key (Windows 2000 or later).
        /// </summary>
        BrowserStop = 0xA9,
        /// <summary>
        /// The C key.
        /// </summary>
        C = 0x43,
        /// <summary>
        /// The CANCEL key.
        /// </summary>
        Cancel = 0x03,
        /// <summary>
        /// The CAPS LOCK key.
        /// </summary>
        Capital = 0x14,
        /// <summary>
        /// The CAPS LOCK key.
        /// </summary>
        CapsLock = 0x14,
        /// <summary>
        /// The CLEAR key.
        /// </summary>
        Clear = 0x0C,
        /// <summary>
        /// The CTRL modifier key.
        /// </summary>
        Control = 0x20000,
        /// <summary>
        /// The CTRL key.
        /// </summary>
        ControlKey = 0x11,
        /// <summary>
        /// The CRSEL key.
        /// </summary>
        Crsel = 0xF7,
        /// <summary>
        /// The D key.
        /// </summary>
        D = 0x44,
        /// <summary>
        /// The 0 key.
        /// </summary>
        D0 = 0x30,
        /// <summary>
        /// The 1 key.
        /// </summary>
        D1 = 0x31,
        /// <summary>
        /// The 2 key.
        /// </summary>
        D2 = 0x32,
        /// <summary>
        /// The 3 key.
        /// </summary>
        D3 = 0x33,
        /// <summary>
        /// The 4 key.
        /// </summary>
        D4 = 0x34,
        /// <summary>
        /// THe 5 key.
        /// </summary>
        D5 = 0x35,
        /// <summary>
        /// The 6 key.
        /// </summary>
        D6 = 0x36,
        /// <summary>
        /// The 7 key.
        /// </summary>
        D7 = 0x37,
        /// <summary>
        /// The 8 key.
        /// </summary>
        D8 = 0x38,
        /// <summary>
        /// The 9 key.
        /// </summary>
        D9 = 0x39,
        /// <summary>
        /// The decimal key.
        /// </summary>
        Decimal = 0x6E,
        /// <summary>
        /// The DEL key.
        /// </summary>
        Delete = 0x2E,
        /// <summary>
        /// THe divide key.
        /// </summary>
        Divide = 0x6F,
        /// <summary>
        /// The DOWN ARROW key.
        /// </summary>
        Down = 0x28,
        /// <summary>
        /// The E key.
        /// </summary>
        E = 0x45,
        /// <summary>
        /// The END key.
        /// </summary>
        End = 0x23,
        /// <summary>
        /// The ENTER key.
        /// </summary>
        Enter = 0x0D,
        /// <summary>
        /// The ERASE EOF key.
        /// </summary>
        EraseEof = 0xF9,
        /// <summary>
        /// The ESC key.
        /// </summary>
        Escape = 0x1B,
        /// <summary>
        /// The EXECUTE key.
        /// </summary>
        Execute = 0x2B,
        /// <summary>
        /// The EXSEL key.
        /// </summary>
        Exsel = 0xF8,
        /// <summary>
        /// The F key.
        /// </summary>
        F = 0x46,
        /// <summary>
        /// THe F1 key.
        /// </summary>
        F1 = 0x70,
        /// <summary>
        /// THe F10 key.
        /// </summary>
        F10 = 0x79,
        /// <summary>
        /// The F11 key.
        /// </summary>
        F11 = 0x7A,
        /// <summary>
        /// The F12 key.
        /// </summary>
        F12 = 0x7B,
        /// <summary>
        /// The F13 key.
        /// </summary>
        F13 = 0x7C,
        /// <summary>
        /// The F14 key.
        /// </summary>
        F14 = 0x7D,
        /// <summary>
        /// The F15 key.
        /// </summary>
        F15 = 0x7E,
        /// <summary>
        /// The F16 key.
        /// </summary>
        F16 = 0x7F,
        /// <summary>
        /// The F17 key.
        /// </summary>
        F17 = 0x80,
        /// <summary>
        /// The F18 key.
        /// </summary>
        F18 = 0x81,
        /// <summary>
        /// The F19 key.
        /// </summary>
        F19 = 0x82,
        /// <summary>
        /// The F2 key.
        /// </summary>
        F2 = 0x71,
        /// <summary>
        /// The F20 key.
        /// </summary>
        F20 = 0x83,
        /// <summary>
        /// The F21 key.
        /// </summary>
        F21 = 0x84,
        /// <summary>
        /// The F22 key.
        /// </summary>
        F22 = 0x85,
        /// <summary>
        /// The F23 key.
        /// </summary>
        F23 = 0x86,
        /// <summary>
        /// The F24 key.
        /// </summary>
        F24 = 0x87,
        /// <summary>
        /// The F3 key.
        /// </summary>
        F3 = 0x72,
        /// <summary>
        /// The F4 key.
        /// </summary>
        F4 = 0x73,
        /// <summary>
        /// The F5 key.
        /// </summary>
        F5 = 0x74,
        /// <summary>
        /// The F6 key.
        /// </summary>
        F6 = 0x75,
        /// <summary>
        /// The F7 key.
        /// </summary>
        F7 = 0x76,
        /// <summary>
        /// The F8 key.
        /// </summary>
        F8 = 0x77,
        /// <summary>
        /// The F9 key.
        /// </summary>
        F9 = 0x78,
        /// <summary>
        /// The IME final mode key.
        /// </summary>
        FinalMode = 0x18,
        /// <summary>
        /// The G key.
        /// </summary>
        G = 0x47,
        /// <summary>
        /// The H key.
        /// </summary>
        H = 0x48,
        /// <summary>
        /// The IME Hanguel mode key. (maintained for compatibility; use HangulMode)
        /// </summary>
        HanguelMode = 0x15,
        /// <summary>
        /// The IME Hangul mode key.
        /// </summary>
        HangulMode = 0x15,
        /// <summary>
        /// The IME Hanja mode key.
        /// </summary>
        HanjaMode = 0x19,
        /// <summary>
        /// The HELP key.
        /// </summary>
        Help = 0x2F,
        /// <summary>
        /// The HOME key.
        /// </summary>
        Home = 0x24,
        /// <summary>
        /// The I key.
        /// </summary>
        I = 0x49,
        /// <summary>
        /// The IME accept key, replaces IMEAceept.
        /// </summary>
        IMEAccept = 0x1E,
        /// <summary>
        /// The IME accept key. Obsolet, use IMEAccept instead.
        /// </summary>
        IMEAceept = 0x1E,
        /// <summary>
        /// The IME convert key.
        /// </summary>
        IMEConvert = 0x1C,
        /// <summary>
        /// The IME mode change key.
        /// </summary>
        IMEModeChange = 0x1F,
        /// <summary>
        /// The IME nonconvert key.
        /// </summary>
        IMENonconvert = 0x1D,
        /// <summary>
        /// The INS key.
        /// </summary>
        Insert = 0x2D,
        /// <summary>
        /// The J key.
        /// </summary>
        J = 0x4A,
        /// <summary>
        /// The IME Junja mode key.
        /// </summary>
        JunjaMode = 0x17,
        /// <summary>
        /// The K key.
        /// </summary>
        K = 0x4B,
        /// <summary>
        /// The IME Kana mode key.
        /// </summary>
        KanaMode = 0x15,
        /// <summary>
        /// The IME Kanji mode key.
        /// </summary>
        KanjiMode = 0x19,
        /// <summary>
        /// The bitmask to extract a key code from a key value.
        /// </summary>
        KeyCode = 0xFFFF,
        /// <summary>
        /// The L key.
        /// </summary>
        L = 0x4C,
        /// <summary>
        /// The start application one key (Windows 2000 or later).
        /// </summary>
        LaunchApplication1 = 0xB6,
        /// <summary>
        /// The start application two key (Windows 2000 or later).
        /// </summary>
        LaunchApplication2 = 0xB7,
        /// <summary>
        /// The launch mail key (Windows 2000 or later).
        /// </summary>
        LaunchMail = 0xB4,
        /// <summary>
        /// The left mouse button.
        /// </summary>
        LButton = 0x01,
        /// <summary>
        /// The left CTRL key.
        /// </summary>
        LControlKey = 0xA2,
        /// <summary>
        /// The LEFT ARROW key.
        /// </summary>
        Left = 0x25,
        /// <summary>
        /// The LINEFEED key.
        /// </summary>
        LineFeed = 0x0A,
        /// <summary>
        /// The ALT key.
        /// </summary>
        LMenu = 0xA4,
        /// <summary>
        /// The left SHIFT key.
        /// </summary>
        LShiftKey = 0xA0,
        /// <summary>
        /// The left Windows logo key (Microsoft Natural Keyboard).
        /// </summary>
        LWin = 0x5B,
        /// <summary>
        /// The M key.
        /// </summary>
        M = 0x4D,
        /// <summary>
        /// The middle mouse button (three-button mouse).
        /// </summary>
        MButton = 0x04,
        /// <summary>
        /// The media next track key (Windows 2000 or later).
        /// </summary>
        MediaNextTrack = 0xB0,
        /// <summary>
        /// The media play pause key (Windows 2000 or later).
        /// </summary>
        MediaPlayPause = 0xB3,
        /// <summary>
        /// The media previous track key (Windows 2000 or later).
        /// </summary>
        MediaPreviousTrack = 0xB1,
        /// <summary>
        /// The media Stop key (Windows 2000 or later).
        /// </summary>
        MediaStop = 0xB2,
        /// <summary>
        /// The ALT key.
        /// </summary>
        Menu = 0x12,
        /// <summary>
        /// The bitmask to extrack modifiers from a key value.
        /// </summary>
        Modifiers = unchecked((int)0xFFFF0000),
        /// <summary>
        /// The multiply key.
        /// </summary>
        Multiply = 0x6A,
        /// <summary>
        /// The N key.
        /// </summary>
        N = 0x4E,
        /// <summary>
        /// The PAGE DOWN key.
        /// </summary>
        Next = 0x22,
        /// <summary>
        /// A constant reserved for future use.
        /// </summary>
        NoName = 0xFC,
        /// <summary>
        /// No key pressed.
        /// </summary>
        None = 0x00,
        /// <summary>
        /// The NUM LOCK key.
        /// </summary>
        NumLock = 0x90,
        /// <summary>
        /// The 0 key on the numeric keypad.
        /// </summary>
        NumPad0 = 0x60,
        /// <summary>
        /// The 1 key on the numeric keypad.
        /// </summary>
        NumPad1 = 0x61,
        /// <summary>
        /// The 2 key on the numeric keypad.
        /// </summary>
        NumPad2 = 0x62,
        /// <summary>
        /// The 3 key on the numeric keypad.
        /// </summary>
        NumPad3 = 0x63,
        /// <summary>
        /// The 4 key on the numeric keypad.
        /// </summary>
        NumPad4 = 0x64,
        /// <summary>
        /// The 5 key on the numeric keypad.
        /// </summary>
        NumPad5 = 0x65,
        /// <summary>
        /// The 6 key on the numeric keypad.
        /// </summary>
        NumPad6 = 0x66,
        /// <summary>
        /// The 7 key on the numeric keypad.
        /// </summary>
        NumPad7 = 0x67,
        /// <summary>
        /// The 8 key on the numeric keypad.
        /// </summary>
        NumPad8 = 0x68,
        /// <summary>
        /// The 9 key on the numeric keypad.
        /// </summary>
        NumPad9 = 0x69,
        /// <summary>
        /// The O key.
        /// </summary>
        O = 0x4F,
        /// <summary>
        /// The OEM 1 key.
        /// </summary>
        Oem1 = 0xBA,
        /// <summary>
        /// The OEM 102 key.
        /// </summary>
        Oem102 = 0xE2,
        /// <summary>
        /// The OEM 2 key.
        /// </summary>
        Oem2 = 0xBF,
        /// <summary>
        /// The OEM 3 key.
        /// </summary>
        Oem3 = 0xC0,
        /// <summary>
        /// The OEM 4 key.
        /// </summary>
        Oem4 = 0xDB,
        /// <summary>
        /// The OEM 5 key.
        /// </summary>
        Oem5 = 0xDC,
        /// <summary>
        /// The OEM 6 key.
        /// </summary>
        Oem6 = 0xDD,
        /// <summary>
        /// The OEM 7 key.
        /// </summary>
        Oem7 = 0xDE,
        /// <summary>
        /// The OEM 8 key.
        /// </summary>
        Oem8 = 0xDF,
        /// <summary>
        /// The OEM angle bracket or backslash key on the RT 102 key keyboard (Windows 2000 or later).
        /// </summary>
        OemBackslash = 0xE2,
        /// <summary>
        /// The CLEAR key.
        /// </summary>
        OemClear = 0xFE,
        /// <summary>
        /// The OEM close bracket key on a US standard keyboard (Windows 2000 or later).
        /// </summary>
        OemCloseBrackets = 0xDD,
        /// <summary>
        /// The OEM comma key on any country/region keyboard (Windows 2000 or later).
        /// </summary>
        Oemcomma = 0xBC,
        /// <summary>
        /// The OEM minus key on any country/region keyboard (Windows 2000 or later).
        /// </summary>
        OemMinus = 0xBD,
        /// <summary>
        /// The OEM open bracket key on a US standard keyboard (Windows 2000 or later).
        /// </summary>
        OemOpenBrackets = 0xDB,
        /// <summary>
        /// The OEM period key on any country/region keyboard (Windows 2000 or later).
        /// </summary>
        OemPeriod = 0xBE,
        /// <summary>
        /// The OEM pipe key on a US standard keyboard (Windows 2000 or later).
        /// </summary>
        OemPipe = 0xDC,
        /// <summary>
        /// The OEM plus key on any country/region keyboard (Windows 2000 or later).
        /// </summary>
        Oemplus = 0xBB,
        /// <summary>
        /// The OEM question mark key on a US standard keyboard (Windows 2000 or later).
        /// </summary>
        OemQuestion = 0xBF,
        /// <summary>
        /// The OEM singled/double quote key on a US standard keyboard (Windows 2000 or later).
        /// </summary>
        OemQuotes = 0xDE,
        /// <summary>
        /// The OEM Semicolon key on a US standard keyboard (Windows 2000 or later).
        /// </summary>
        OemSemicolon = 0xBA,
        /// <summary>
        /// The OEM tilde key on a US standard keyboard (Windows 2000 or later).
        /// </summary>
        Oemtilde = 0xC0,
        /// <summary>
        /// The P key.
        /// </summary>
        P = 0x50,
        /// <summary>
        /// The PA1 key.
        /// </summary>
        Pa1 = 0xFD,
        /// <summary>
        /// Used to pass Unicode characters as if they were keystrokes. The Packet key value is the low word of a 32-bit virtual-key value used for non-keyboard input methods.
        /// </summary>
        Packet = 0xE7,
        /// <summary>
        /// The PAGE DOWN key.
        /// </summary>
        PageDown = 0x22,
        /// <summary>
        /// The PAGE UP key.
        /// </summary>
        PageUp = 0x21,
        /// <summary>
        /// The PAUSE key.
        /// </summary>
        Pause = 0x13,
        /// <summary>
        /// The PLAY key.
        /// </summary>
        Play = 0xFA,
        /// <summary>
        /// The PRINT key.
        /// </summary>
        Print = 0x2A,
        /// <summary>
        /// The PRINT SCREEN key.
        /// </summary>
        PrintScreen = 0x2C,
        /// <summary>
        /// The PAGE UP key.
        /// </summary>
        Prior = 0x21,
        /// <summary>
        /// The PROCESS KEY key.
        /// </summary>
        ProcessKey = 0xE5,
        /// <summary>
        /// The Q key.
        /// </summary>
        Q = 0x51,
        /// <summary>
        /// The R key.
        /// </summary>
        R = 0x52,
        /// <summary>
        /// The right mouse button.
        /// </summary>
        RButton = 0x02,
        /// <summary>
        /// The right CTRL key.
        /// </summary>
        RControlKey = 0xA3,
        /// <summary>
        /// The RETURN key.
        /// </summary>
        Return = 0x0D,
        /// <summary>
        /// The RIGHT ARROW key.
        /// </summary>
        Right = 0x27,
        /// <summary>
        /// The right ALT key.
        /// </summary>
        RMenu = 0xA5,
        /// <summary>
        /// The right SHIFT key.
        /// </summary>
        RShiftKey = 0xA1,
        /// <summary>
        /// The right Windows logo key (Microsoft Natural Keyboard).
        /// </summary>
        RWin = 0x5C,
        /// <summary>
        /// The S key.
        /// </summary>
        S = 0x53,
        /// <summary>
        /// The SCROLL LOCK key.
        /// </summary>
        Scroll = 0x91,
        /// <summary>
        /// The SELECT key.
        /// </summary>
        Select = 0x29,
        /// <summary>
        /// The select media key (Windows 2000 or later).
        /// </summary>
        SelectMedia = 0xB5,
        /// <summary>
        /// The separator key.
        /// </summary>
        Separator = 0x6C,
        /// <summary>
        /// The SHIFT modifier key.
        /// </summary>
        Shift = 0x10000,
        /// <summary>
        /// The SHIFT key.
        /// </summary>
        ShiftKey = 0x10,
        /// <summary>
        /// The computer sleep key.
        /// </summary>
        Sleep = 0x5F,
        /// <summary>
        /// The PRINT SCREEN key.
        /// </summary>
        Snapshot = 0x2C,
        /// <summary>
        /// The SPACEBAR key.
        /// </summary>
        Space = 0x20,
        /// <summary>
        /// The subtract key.
        /// </summary>
        Subtract = 0x6D,
        /// <summary>
        /// The T key.
        /// </summary>
        T = 0x54,
        /// <summary>
        /// The TAB key.
        /// </summary>
        Tab = 0x09,
        /// <summary>
        /// The U key.
        /// </summary>
        U = 0x55,
        /// <summary>
        /// The UP ARROW key.
        /// </summary>
        Up = 0x26,
        /// <summary>
        /// The V key.
        /// </summary>
        V = 0x56,
        /// <summary>
        /// The volume down key (Windows 2000 or later).
        /// </summary>
        VolumeDown = 0xAE,
        /// <summary>
        /// The volume mute key (Windows 2000 or later).
        /// </summary>
        VolumeMute = 0xAD,
        /// <summary>
        /// The volume up key (Windows 2000 or later).
        /// </summary>
        VolumeUp = 0xAF,
        /// <summary>
        /// The W key.
        /// </summary>
        W = 0x57,
        /// <summary>
        /// The X key.
        /// </summary>
        X = 0x58,
        /// <summary>
        /// The first x mouse button (five-button mouse).
        /// </summary>
        XButton1 = 0x05,
        /// <summary>
        /// The second x mouse button (five-button mouse).
        /// </summary>
        XButton2 = 0x06,
        /// <summary>
        /// The Y key.
        /// </summary>
        Y = 0x59,
        /// <summary>
        /// The Z key.
        /// </summary>
        Z = 0x5A,
        /// <summary>
        /// The ZOOM key.
        /// </summary>
        Zoom = 0xFB,
    }
}
