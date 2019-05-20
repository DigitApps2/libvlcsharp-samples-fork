using Xamarin.Forms;
using LibVLCSharp.Shared;

namespace VideoMosaic
{
    public partial class MainPage : ContentPage
    {
        const string VIDEO_URL = "http://streams.videolan.org/streams/mp4/Mr_MrsSmith-h264_aac.mp4";
        readonly LibVLC _libvlc;

        public MainPage()
        {
            InitializeComponent();

            // this will load the native libvlc library (if needed, depending on the platform). 
            Core.Initialize();

            // instanciate the main libvlc object
            _libvlc = new LibVLC();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // create mediaplayer objects,
            // attach them to their respective VideoViews
            // create media objects and start playback

            VideoView0.MediaPlayer = new MediaPlayer(_libvlc);
            VideoView0.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView0.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView1.MediaPlayer = new MediaPlayer(_libvlc);
            VideoView1.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView1.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView2.MediaPlayer = new MediaPlayer(_libvlc);
            VideoView2.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView2.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView3.MediaPlayer = new MediaPlayer(_libvlc);
            VideoView3.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView3.MediaPlayer.Media.StateChanged += Media_StateChanged;
        }

        private void Media_StateChanged(object sender, MediaStateChangedEventArgs e)
        {
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            for (; ; )
            {
                VideoView0.MediaPlayer.Stop();
                VideoView1.MediaPlayer.Stop();
                VideoView2.MediaPlayer.Stop();
                VideoView3.MediaPlayer.Stop();

                VideoView0.MediaPlayer.Play();
                VideoView1.MediaPlayer.Play();
                VideoView2.MediaPlayer.Play();
                VideoView3.MediaPlayer.Play();
            }
        }
    }
}