using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SnakeGame
{
    public class ImageLoader
    {
        public List<string> imageUrls { get; set; }
        public BitmapImage currentImage { get; set; }
        public BitmapImage downloadingImage { get; set; }
        private int choosenURL;

        public delegate void onDownloadinFail();
        public onDownloadinFail OnDownloadfail;

        public delegate void onDownloadingStart();
        public onDownloadingStart OnDownloadingStart;

        public delegate void onDownloadFinish();
        public onDownloadFinish OnDownloadFinish;
        public ImageLoader()
        {
            imageUrls = new List<string>();
            currentImage = new BitmapImage();
        }

        public void SelectNewImage()
        {
            if(OnDownloadingStart != null)
                OnDownloadingStart.Invoke();

                Random r = new Random();
                int randomize = r.Next(0, 5);
                while (randomize == choosenURL)
                    randomize = r.Next(0, 5);

                choosenURL = randomize;

                this.downloadingImage = new BitmapImage(new Uri(imageUrls[choosenURL], UriKind.Absolute));
                EventHandler OnDownloadFinish = new EventHandler((object sender, EventArgs e) => { this.currentImage = this.downloadingImage; this.OnDownloadFinish.Invoke();  });
                EventHandler<ExceptionEventArgs> OnDownloadError = new EventHandler<ExceptionEventArgs>
                    ((object sender, ExceptionEventArgs e) => { this.OnDownloadfail.Invoke(); });
                this.downloadingImage.DownloadCompleted += OnDownloadFinish;
                this.downloadingImage.DownloadFailed += OnDownloadError;
        }
    }
}
