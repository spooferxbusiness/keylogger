using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class defs
{
    // add your own keys

    public static Dictionary<int, string> key_names = new Dictionary<int, string>
    {
        
            { 0x08, "Backspace" },
            { 0x09, "Tab" },
            { 0x0D, "Enter" },
            { 0x1B, "Escape" },
            { 0x20, "Space" },
            { 0x21, "Page Up" },
            { 0x22, "Page Down" },
            { 0x23, "End" },
            { 0x24, "Home" },
            { 0x25, "Left Arrow" },
            { 0x26, "Up Arrow" },
            { 0x27, "Right Arrow" },
            { 0x28, "Down Arrow" },
            { 0x2C, "Print Screen" },
            { 0x2D, "Insert" },
            { 0x2E, "Delete" },
            { 0x2F, "Help" },
            { 0x30, "0" },
            { 0x31, "1" },
            { 0x32, "2" },
            { 0x33, "3" },
            { 0x34, "4" },
            { 0x35, "5" },
            { 0x36, "6" },
            { 0x37, "7" },
            { 0x38, "8" },
            { 0x39, "9" },
            { 0x41, "A" },
            { 0x42, "B" },
            { 0x43, "C" },
            { 0x44, "D" },
            { 0x45, "E" },
            { 0x46, "F" },
            { 0x47, "G" },
            { 0x48, "H" },
            { 0x49, "I" },
            { 0x4A, "J" },
            { 0x4B, "K" },
            { 0x4C, "L" },
            { 0x4D, "M" },
            { 0x4E, "N" },
            { 0x4F, "O" },
            { 0x50, "P" },
            { 0x51, "Q" },
            { 0x52, "R" },
            { 0x53, "S" },
            { 0x54, "T" },
            { 0x55, "U" },
            { 0x56, "V" },
            { 0x57, "W" },
            { 0x58, "X" },
            { 0x59, "Y" },
            { 0x5A, "Z" },
            { 0x60, "Numpad 0" },
            { 0x61, "Numpad 1" },
            { 0x62, "Numpad 2" },
            { 0x63, "Numpad 3" },
            { 0x64, "Numpad 4" },
            { 0x65, "Numpad 5" },
            { 0x66, "Numpad 6" },
            { 0x67, "Numpad 7" },
            { 0x68, "Numpad 8" },
            { 0x69, "Numpad 9" },
            { 0x6A, "Multiply" },
            { 0x6B, "Add" },
            { 0x6C, "Separator" },
            { 0x6D, "Subtract" },
            { 0x6E, "Decimal" },
            { 0x6F, "Divide" },
            { 0x70, "F1" },
            { 0x71, "F2" },
            { 0x72, "F3" },
            { 0x73, "F4" },
            { 0x74, "F5" },
            { 0x75, "F6" },
            { 0x76, "F7" },
            { 0x77, "F8" },
            { 0x78, "F9" },
            { 0x79, "F10" },
            { 0x7A, "F11" }
    };


    public static int[] key_codes = { 0x08, 0x09, 0x0D, 0x1B, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x2C, 0x2D, 0x2E, 0x2F, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4A, 0x4B, 0x4C, 0x4D, 0x4E, 0x4F, 0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A, 0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F, 0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7A }; // add them here, esc is an example.
}
