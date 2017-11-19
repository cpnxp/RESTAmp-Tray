using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.InteropServices;

namespace RESTAmpLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RESTAmp:IRESTAmp
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        //Wanted to make all of these const but you can't have const IntPtr
        const UInt32 WM_COMMAND = 0x0111;
        const String WINAMP_CLASS = "Winamp v1.x";
        IntPtr WINAMP_PREV = (IntPtr)40044;
        IntPtr WINAMP_PLAY = (IntPtr)40045;
        IntPtr WINAMP_PAUSE = (IntPtr)40046;
        IntPtr WINAMP_NEXT = (IntPtr)40048;

        private IntPtr WinampHandle;
        private IntPtr LastSendMessage;

        public RESTAmp()
        {
            WinampHandle = IntPtr.Zero;
            LastSendMessage = IntPtr.Zero;
        }
        
        public int Play()
        {
            getHandle();

            IntPtr result = SendMessage(WinampHandle, WM_COMMAND, WINAMP_PLAY, IntPtr.Zero);

            LastSendMessage = result;

            return (int)result;
        }
        
        public int Pause()
        {
            getHandle();

            IntPtr result = SendMessage(WinampHandle, WM_COMMAND, WINAMP_PAUSE, IntPtr.Zero);

            LastSendMessage = result;

            return (int)result;
        }

        public int Next()
        {
            getHandle();

            IntPtr result = SendMessage(WinampHandle, WM_COMMAND, WINAMP_NEXT, IntPtr.Zero);

            LastSendMessage = result;

            return (int)result;
        }

        public int Prev()
        {
            getHandle();

            IntPtr result = SendMessage(WinampHandle, WM_COMMAND, WINAMP_PREV, IntPtr.Zero);

            LastSendMessage = result;

            return (int)result;
        }

        public String Status()
        {
            StringBuilder x = new StringBuilder();
            x.Append("Last SendMessage status: ");
            x.Append(LastSendMessage);
            x.Append("\r\nCurrent Winamp Handle: ");
            x.Append(WinampHandle);
            x.AppendLine();
            return x.ToString();
        }

        private IntPtr getHandle()
        {
            WinampHandle = FindWindow(WINAMP_CLASS, null);

            return WinampHandle;
        }
    }
}
