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
        }

        private void Media_StateChanged(object sender, MediaStateChangedEventArgs e)
        {
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            for (; ; )
            {
                VideoView0.MediaPlayer.Stop();

                VideoView0.MediaPlayer.Play();
            }
        }
    }
}