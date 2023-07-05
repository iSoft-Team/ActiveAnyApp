using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Threading;
using System.Windows.Forms;

namespace NetCore
{
  public class AutoActive
  {
    [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetCursorPos(int x, int y);

   
    [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("USER32.DLL")]
    public static extern bool SetForegroundWindow(IntPtr hWnd);



    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string lclassName, string windowTitle);

    public static IntPtr FindWindowExFromParent(IntPtr parentHandle, string text, string className)
    {
      return FindWindowEx(parentHandle, IntPtr.Zero, className, text);
    }

    public static Point GetGlobalPoint(IntPtr hWnd, int x = 0, int y = 0)
    {
      Point result = default(Point);
      RECT windowRect = GetWindowRect(hWnd);
      result.X = x + windowRect.Left;
      result.Y = y + windowRect.Top;
      return result;
    }

    public static RECT GetWindowRect(IntPtr hWnd)
    {
      RECT lpRect = default(RECT);
      GetWindowRect(hWnd, ref lpRect);
      return lpRect;
    }
    
    public static void MouseClick(Point point, EMouseKey mouseKey = EMouseKey.LEFT)
    {
      Cursor.Position = point;
      Click(mouseKey);
    }
    public static void Click(EMouseKey mouseKey = EMouseKey.LEFT)
    {
      switch (mouseKey)
      {
        case EMouseKey.LEFT:
          mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
          break;
        case EMouseKey.RIGHT:
          mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
          break;
        case EMouseKey.DOUBLE_LEFT:
          mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
          mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
          break;
        case EMouseKey.DOUBLE_RIGHT:
          mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
          mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
          break;
      }
    }


    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
    public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);


    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);


    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
    public static void SendText(IntPtr handle, string text)
    {
      SendMessage(handle, 12, 0, text);
    }


    public static IntPtr BringToFront(IntPtr hWnd)
    {
      SetForegroundWindow(hWnd);
      return hWnd;
    }









    //Numpy
    #region numpy
    public enum EMouseKey
    {
      LEFT,
      RIGHT,
      DOUBLE_LEFT,
      DOUBLE_RIGHT
    }

    public struct RECT
    {
      public int Left;

      public int Top;

      public int Right;

      public int Bottom;
    }

    #endregion

  }
}
