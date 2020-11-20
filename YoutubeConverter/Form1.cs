using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExtractor;
using NReco.VideoConverter;
using YoutubeExplode.Videos.Streams;

namespace YoutubeConverter
{
    public partial class VideoConverter : MaterialSkin.Controls.MaterialForm
    {
        string inputFile;
        string outputFile;
        public VideoConverter()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void btnDownloadAudio_Click(object sender, EventArgs e)
        {
            lbLoading.Visible = false;
            DownloadAudio();
        }

        async void Download()
        {
            lbLoading.Visible = true;
            lbLoading.Text = "Descargando video...";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            
            var url = txbURL.Text;
            const string YOUTUBE_TAG_SIGNATURE = "?v=";

            string[] fileLines = url.Split(new string[] { YOUTUBE_TAG_SIGNATURE }, StringSplitOptions.None);

            var client = new YoutubeClient();
            var video = await client.Videos.GetAsync(url);

            var title = video.Title; // "Infected Mushroom - Spitfire [Monstercat Release]"
            var author = video.Author; // "Monstercat"
            var duration = video.Duration; // 00:07:14

            var streamInfoSet = await client.Videos.Streams.GetManifestAsync(fileLines[1]);

            var streamInfo = streamInfoSet.GetMuxed().WithHighestVideoQuality();

            // Videos Downloads
            if (streamInfo != null)
            {
                // Get the actual stream
                var stream = await client.Videos.Streams.GetAsync(streamInfo);
                var folder = "C:\\VideoDownload";
                DirectoryInfo info = new DirectoryInfo(folder);
                if(!info.Exists)
                {
                    info.Create();
                }

                var path = Path.Combine($"C:\\VideoDownload\\{title}.{streamInfo.Container}");
                // Download the stream to file
                await client.Videos.Streams.DownloadAsync(streamInfo, path);
            }

            lbLoading.Text = "Listo!!! el video se ha descargado";
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
        }

        void DownloadAudio()
        {
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(txbURL.Text);
            /*
             * We want the first extractable video with the highest audio quality.
             */
            VideoInfo video = videos
                .Where(info => info.CanExtractAudio)
                .OrderByDescending(info => info.AudioBitrate)
                .First();

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the audio downloader.
             * The first argument is the video where the audio should be extracted from.
             * The second argument is the path to save the audio file.
             */
            var audioDownloader = new AudioDownloader(video, Path.Combine("D:/Downloads", video.Title + video.AudioExtension));

            // Register the progress events. We treat the download progress as 85% of the progress and the extraction progress only as 15% of the progress,
            // because the download will take much longer than the audio extraction.
            audioDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage * 0.85);
            audioDownloader.AudioExtractionProgressChanged += (sender, args) => Console.WriteLine(85 + args.ProgressPercentage * 0.15);

            /*
             * Execute the audio downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            audioDownloader.Execute();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            lbLoading.Visible = false;
            if (openFileVideo.ShowDialog() == DialogResult.OK)
            {
                inputFile = openFileVideo.FileName;
                outputFile = inputFile.Substring(0, inputFile.IndexOf("."));
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            lbLoading.Visible = false;
            var convertVideo = new  FFMpegConverter();
            convertVideo.ConvertMedia(inputFile, outputFile + ".mp3", "mp3");
        }
    }
}
