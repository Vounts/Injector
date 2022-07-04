using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Injector
{
    public class Imports
    {
        // winapi imports
        public static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

        [DllImport("kernel32.dll")]
        internal static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        internal static extern int CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        internal static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr dllMemoryPointer, IntPtr dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        internal static extern void VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, uint dwFreeType);

        [DllImport("kernel32.dll")]
        internal static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        internal static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress,
            IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll")]
        internal static extern void WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool IsWow64Process([In] IntPtr process, [Out] out bool wow64Process);

        // some constants
        public const int PROCESS_CREATE_THREAD = 0x2;
        public const int PROCESS_QUERY_INFORMATION = 0x400;
        public const int PROCESS_VM_OPERATION = 0x8;
        public const int PROCESS_VM_WRITE = 0x20;
        public const int PROCESS_VM_READ = 0x10;
        public const int PROCESS_ALL_ACCESS = 2035711;

        public const int MEM_COMMIT = 0x1000;
        public const int MEM_RESERVE = 0x2000;
        public const int MEM_RELEASE = 0x8000;

        public const int PAGE_READWRITE = 0x4;
        public const int PAGE_EXECUTE_READWRITE = 0x40;

        public const uint INFINITE = 0xFFFFFFFF;
        public const int MAX_PATH = 260;
    }
}
