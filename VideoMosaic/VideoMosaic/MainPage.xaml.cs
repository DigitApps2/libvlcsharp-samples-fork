using Xamarin.Forms;
using LibVLCSharp.Shared;

namespace VideoMosaic
{
    public partial class MainPage : ContentPage
    {
        //const string VIDEO_URL = "http://streams.videolan.org/streams/mp4/Mr_MrsSmith-h264_aac.mp4";
        //const string VIDEO_URL = "rtsp://184.72.239.149/vod/mp4:BigBuckBunny_175k.mov";
        const string VIDEO_URL = "http://194.44.202.21:80/mjpg/video.mjpg";
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
            //VideoView0.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView0.MediaPlayer.Media = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);
            VideoView0.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView1.MediaPlayer = new MediaPlayer(_libvlc);
            //VideoView1.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView1.MediaPlayer.Media = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);
            VideoView1.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView2.MediaPlayer = new MediaPlayer(_libvlc);
            // VideoView2.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView2.MediaPlayer.Media = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);
            VideoView2.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView3.MediaPlayer = new MediaPlayer(_libvlc);
            //VideoView3.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView3.MediaPlayer.Media = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);
            VideoView3.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView4.MediaPlayer = new MediaPlayer(_libvlc);
            //VideoView3.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView4.MediaPlayer.Media = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);
            VideoView4.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView5.MediaPlayer = new MediaPlayer(_libvlc);
            //VideoView3.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView5.MediaPlayer.Media = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);
            VideoView5.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView6.MediaPlayer = new MediaPlayer(_libvlc);
            //VideoView3.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView6.MediaPlayer.Media = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);
            VideoView6.MediaPlayer.Media.StateChanged += Media_StateChanged;

            VideoView7.MediaPlayer = new MediaPlayer(_libvlc);
            //VideoView3.MediaPlayer.Play(new Media(_libvlc, VIDEO_URL, FromType.FromLocation));
            VideoView7.MediaPlayer.Media = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);
            VideoView7.MediaPlayer.Media.StateChanged += Media_StateChanged;
        }

        private void Media_StateChanged(object sender, MediaStateChangedEventArgs e)
        {
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            MoveBack();

            MainGrid.Children.Add(VideoView0, 0, 0);
            MainGrid.Children.Add(VideoView1, 1, 0);
            MainGrid.Children.Add(VideoView2, 0, 1);
            MainGrid.Children.Add(VideoView3, 1, 1);
            MainGrid.Children.Add(VideoView4, 0, 2);
            MainGrid.Children.Add(VideoView5, 1, 2);

            MainGrid.Children.Add(VideoView6, 0, 3);
            MainGrid.Children.Add(VideoView7, 1, 3);

            VideoView0.MediaPlayer.Play();
            VideoView1.MediaPlayer.Play();

            VideoView2.MediaPlayer.Play();
            VideoView3.MediaPlayer.Play();

            VideoView4.MediaPlayer.Play();

            VideoView5.MediaPlayer.Play();
            VideoView6.MediaPlayer.Play();
            VideoView7.MediaPlayer.Play();
        }

        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            MoveBack();

            MainGrid.Children.Add(VideoView0, 0, 0);
            MainGrid.Children.Add(VideoView1, 1, 0);



            VideoView0.MediaPlayer.Play();
            VideoView1.MediaPlayer.Play();

            VideoView2.MediaPlayer.Stop();
            VideoView3.MediaPlayer.Stop();

            VideoView4.MediaPlayer.Stop();

            VideoView5.MediaPlayer.Stop();
            VideoView6.MediaPlayer.Stop();
            VideoView7.MediaPlayer.Stop();
        }

        private void Button_Clicked_2(object sender, System.EventArgs e)
        {
            MoveBack();

            MainGrid.Children.Add(VideoView3, 0, 0);

            VideoView0.MediaPlayer.Stop();
            VideoView1.MediaPlayer.Stop();

            VideoView2.MediaPlayer.Stop();
            VideoView3.MediaPlayer.Play();

            VideoView4.MediaPlayer.Stop();

            VideoView5.MediaPlayer.Stop();
            VideoView6.MediaPlayer.Stop();
            VideoView7.MediaPlayer.Stop();
        }

        private void MoveBack()
        {
            MainGrid.Children.Add(VideoView0, 0, 4);
            MainGrid.Children.Add(VideoView1, 1, 4);
            MainGrid.Children.Add(VideoView2, 0, 5);
            MainGrid.Children.Add(VideoView3, 1, 5);
            MainGrid.Children.Add(VideoView4, 0, 6);
            MainGrid.Children.Add(VideoView5, 1, 6);

            MainGrid.Children.Add(VideoView6, 0, 7);
            MainGrid.Children.Add(VideoView7, 1, 7);
        }
    }
}