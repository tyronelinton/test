using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
        private List<string> _letters = new List<string>();
        private List<int> _numbers = new List<int>();
        private ObservableCollection<Sample> _samples = new ObservableCollection<Sample>();
        private int HasBacteria { get; set; }
        public ObservableCollection<Sample> SampleList { get; set; } = new ObservableCollection<Sample>();


        public ListViewPage()
		{
			InitializeComponent ();
            Populate();
            sampleListView.ItemsSource = SampleList.OrderBy(i => i.Date);
            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            sampleListView.SelectedItem = null;
            sampleListView.Opacity = 0.2;
            hiddenLayout.IsVisible = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            hiddenLayout.IsVisible = false;
            sampleListView.Opacity = 1;
        }

        private void BacteriaSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            var ex2 = sender as Switch;
              var entry = ((ex2.Parent.Parent as StackLayout).Children.FirstOrDefault() as StackLayout).Children.LastOrDefault() as CustomEntryCell;
            var stackLayout = (ex2.Parent.Parent as StackLayout);

            if (e.Value)
            {
                HasBacteria++;
                stackLayout.BackgroundColor = Color.LightGray;
            }
            else
            {
                HasBacteria--;
                stackLayout.BackgroundColor = Color.White;
                entry.BackgroundColor = Color.LightGray;
            }
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {

            if (HasBacteria > 0)
            {
                await DisplayAlert("Worksheet Uploaded", "A notfification has been sent to those concerned regarding the unusual results.", "OK");
            }
            else
            {
                await DisplayAlert("Worksheet Uploaded", "The results are all clear.", "OK");
            }
        }

        public void Populate()
        {
            //get samples
            SampleList = new ObservableCollection<Sample>() { new Sample(2019000001, 1, "A1", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000001, 1, "A2", "Arkingsall Creasent", DateTime.Now.AddDays(-30), Result.HasBacteria),
                new Sample(2019000002, 1, "A3", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Clear),
                new Sample(2019000003, 1, "A4", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Clear),
                new Sample(2019000004, 1, "A5", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Clear),
                new Sample(2019000005, 1, "A6", "Hampshire Bridge", DateTime.Now.AddDays(-30), Result.Clear),
                new Sample(2019000006, 1, "A7", "Hampshire Bridge", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000007, 1, "A8", "Hampshire Bridge", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000008, 1, "A9", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000009, 1, "A10", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Clear),
                new Sample(2019000010, 1, "A11", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000011, 1, "A12", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000011, 1, "A13", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000012, 1, "A14", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000013, 1, "A14", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Clear),
                new Sample(2019000014, 1, "A15", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000015, 1, "A16", "Kates Hill", DateTime.Now.AddDays(29), Result.Outstanding),
                new Sample(2019000016, 1, "A17", "Kates Hill", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000017, 1, "A18", "Kates Hill", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000018, 1, "A19", "Kates Hill", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000019, 1, "A20", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000020, 1, "A21", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000021, 1, "A22", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000022, 1, "A23", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000023, 1, "A24", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000024, 1, "A25", "Overdale Road", DateTime.Now.AddDays(-80), Result.Outstanding),
                new Sample(2019000025, 1, "A26", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000026, 1, "A27", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000027, 1, "A28", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000028, 1, "A29", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000029, 1, "A30", "Lincoln Way", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000030, 1, "A31", "Lincoln Way", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000031, 1, "A32", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000032, 1, "A33", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000033, 1, "A34", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000034, 1, "A35", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000035, 1, "A36", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000036, 1, "A37", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000037, 1, "A38", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000038, 1, "A39", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000039, 1, "A40", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            };

        }

    }
}