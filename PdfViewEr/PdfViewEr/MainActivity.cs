using Android.App;
using Android.Widget;
using Android.OS;
using Com.Joanzapata.Pdfview;

namespace PdfViewEr
{
    [Activity(Label = "PdfViewEr", MainLauncher = true)]
    public class MainActivity : Activity
    {
        PDFView pdfView;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            pdfView = FindViewById<PDFView>(Resource.Id.pdfView);
            pdfView.FromAsset("xamarin.pdf").Load();

        }
    }
}

