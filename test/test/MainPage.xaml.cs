using Lottie.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test
{
    public enum Result { HasBacteria, Clear, Outstanding }

    public class Sample
    {
        public int Id { get; set; }
        public int BatchId { get; set; }
        public string STC { get; set; }
        public char StcAlpha { get { return STC.First(); } }
        public int StcNumeric { get { return Convert.ToInt32(STC.Substring(1, STC.Length - 1)); } }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public Result Result { get; set; }
        public string Viewed { get; set; }
        public string Notes { get; set; }
        public Color IsClean { get { if (Result == Result.Clear) { return Color.Gray; } else { return Color.White; }; } }
        public ImageSource DisplayImage
        {
            get
            {
                if (DisplayImage == null)
                {
                    return new FileImageSource() { File = "" };
                }
                else
                    return new FileImageSource() { File = "" };
            }
        }
        public Color IsEndingSoon { get { if (Date < DateTime.Now.AddDays(-20)) { return Color.LightGreen; } return Color.White; } }

        public Sample()
        {
        }

        public Sample(int id, int bId, string stc, string location, DateTime dt, Result result)
        {
            Id = id;
            BatchId = bId;
            STC = stc;
            Location = location;
            Date = dt;
            Result = result;
            Viewed = "Not Viewed";
        }


        public class Worksheet
        {
            public int Id { get; set; }
            public List<Sample> Samples = new List<Sample>();

        }

        public partial class MainPage : ContentPage
        {

            //    private List<string> _letters = new List<string>();
            //    private List<int> _numbers = new List<int>();
            //    private List<Sample> _samples = new List<Sample>();
            //    public Sample CurrentSample { get; set; } = new Sample();
            //    //public AnimationView AnimationView { get; set; } = new AnimationView();



            //    public MainPage(Sample sample)
            //    {
            //        InitializeComponent();
            //        BindingContext = this;
            //        Populate();
            //        CurrentSample = sample;
            //        //AnimationView = animationView;


            //    }

            //    public void Populate()
            //    {
            //        //get samples


            //        //get numbers
            //        for (int x = 0; _numbers.Count < 30; x++)
            //        {
            //            _numbers.Add(x);
            //        }

            //        //get letteres
            //        _letters = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            //        //get samples
            //        _samples = new List<Sample>() { new Sample(2019000001, 1, "A1", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000001, 1, "B1", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000002, 1, "C2", "Arkingsall Creasent", DateTime.Now.AddDays(-20), Result.Outstanding),
            //        new Sample(2019000003, 1, "C4", "Arkingsall Creasent", DateTime.Now.AddDays(-5), Result.Outstanding),
            //        new Sample(2019000004, 1, "B5", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000005, 1, "C6", "Hampshire Bridge", DateTime.Now.AddDays(-3), Result.Outstanding),
            //        new Sample(2019000006, 1, "D5", "Hampshire Bridge", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000007, 1, "D7", "Hampshire Bridge", DateTime.Now.AddDays(-9), Result.Outstanding),
            //        new Sample(2019000008, 1, "E6", "Handsworth Orchard", DateTime.Now.AddDays(-22), Result.Outstanding),
            //        new Sample(2019000009, 1, "T1", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000010, 1, "G1", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000011, 1, "G1", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000011, 1, "J1", "Handsworth Orchard", DateTime.Now.AddDays(-14), Result.Outstanding),
            //        new Sample(2019000012, 1, "K1", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000013, 1, "U19", "Handsworth Orchard", DateTime.Now.AddDays(-15), Result.Outstanding),
            //        new Sample(2019000014, 1, "V22", "Handsworth Orchard", DateTime.Now.AddDays(-12), Result.Outstanding),
            //        new Sample(2019000015, 1, "D15", "Kates Hill", DateTime.Now.AddDays(-3), Result.Outstanding),
            //        new Sample(2019000016, 1, "C16", "Kates Hill", DateTime.Now.AddDays(-2), Result.Outstanding),
            //        new Sample(2019000017, 1, "W15", "Kates Hill", DateTime.Now.AddDays(-2), Result.Outstanding),
            //        new Sample(2019000018, 1, "Q13", "Kates Hill", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000019, 1, "R55", "Overdale Road", DateTime.Now.AddDays(-4), Result.Outstanding),
            //        new Sample(2019000020, 1, "H22", "Overdale Road", DateTime.Now.AddDays(-22), Result.Outstanding),
            //        new Sample(2019000021, 1, "B18", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000022, 1, "F12", "Overdale Road", DateTime.Now.AddDays(-17), Result.Outstanding),
            //        new Sample(2019000023, 1, "D6", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000024, 1, "U4", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000025, 1, "P2", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000026, 1, "I5", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000027, 1, "U9", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000028, 1, "T4", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000029, 1, "L1", "Lincoln Way", DateTime.Now.AddDays(-3), Result.Outstanding),
            //        new Sample(2019000030, 1, "J16", "Lincoln Way", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000031, 1, "A13", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000032, 1, "A16", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000033, 1, "A7", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000034, 1, "A2", "Canncock Chase", DateTime.Now.AddDays(-4), Result.Outstanding),
            //        new Sample(2019000035, 1, "A1", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000036, 1, "A3", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000037, 1, "T1", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000038, 1, "R2", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000039, 1, "E4", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            //        new Sample(2019000040, 1, "W3", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),

            //    };

            //    }


            //    //public async void SwitchUpdated()
            //    //{
            //    //    animationView.IsVisible = true;
            //    //    animationView.IsVisible = true;
            //    //    animationView.IsPlaying = true;
            //    //    animationView.Loop = true;
            //    //    animationView.AutoPlay = true;

            //    //    Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            //    //    {
            //    //        animationView.IsVisible = false;
            //    //        animationView.AutoPlay = true;
            //    //        animationView.IsEnabled = true;
            //    //        animationView.IsPlaying = true;
            //    //        animationView.FlowDirection = FlowDirection.RightToLeft;
            //    //        animationView.Loop = true;

            //    //        return false;
            //    //    });

            //    //}

            //    private void MyButton_Clicked(object sender, EventArgs e)
            //    {
            //        Navigation.PopAsync();
            //    }
            //}
        }
    }
}
