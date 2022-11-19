using System;
using System.Windows.Forms;

namespace Trojan
{
    public partial class LastPayload : Form
    {
        public LastPayload( ) => InitializeComponent( );

        private void LastPayload_FormClosing( object sender, FormClosingEventArgs e ) => e.Cancel = true;

        private void LastPayload_Load( object sender, EventArgs e )
        {
            var NewForm = new NextPayload( );

            NewForm.ShowDialog( );
        }
    }
}
