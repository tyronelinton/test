using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppLandingPage : ContentPage, INotifyPropertyChanged
    {
        private Data _data = new Data();

        private string _userFeedback = "Test data";

        public string UserFeedback
        {
            get { return _userFeedback; }
            set
            {
                _userFeedback = value;
                OnPropertyChanged("UserFeedback");
            }
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;




        public AppLandingPage()
        {
            InitializeComponent();
            BindingContext = this;
            profilePicker.ItemsSource = new List<string>() { "Clean water metals", "Radioactive isotopes", "Bacti (Petri Dishes - Incubator)" };
        }

        private void ScanButton_Clicked(object sender, EventArgs e)
        {
            ShowSpinner();

            var button = sender as Button;
            if (button != null)
                button.IsVisible = false;
            hiddenLayout.IsVisible = true;


            //Set UserFeedback
            UserFeedback = (_data.SampleList.Count() <= 50) ? "Observations found {" + _data.SampleList.Count() +
                "} which is within the capacity limit of {50}. {" + _data.SoonEndingSamples() + "} samples are close to end of shelf live and have been prioritized" :
                "Observations found {" + _data.SampleList.Count() +
                "} with over the capacity limit of {50} the data will be split.  {" + _data.SoonEndingSamples() + "} samples are close to end of shelf live and have been prioritized";
        }

        public void ShowSpinner()
        {
            animationView.IsVisible = true;
            animationView.IsVisible = true;
            animationView.IsPlaying = true;
            animationView.Loop = true;
            animationView.AutoPlay = true;

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                animationView.IsVisible = false;
                animationView.AutoPlay = true;
                animationView.IsEnabled = true;
                animationView.IsPlaying = true;
                animationView.FlowDirection = FlowDirection.RightToLeft;
                animationView.Loop = true;

                return false;
            });
        }

        public void Validation()
        {
            bool optionSelected = false;

            //Oldest sample
            if (!string.IsNullOrEmpty(oldestSampleIdEntry.Text) && ((oldestSampleYrDatePicker.Date != null) && oldestSampleYrDatePicker.Date < DateTime.Now) && oldestSampleYrDatePicker.Date > DateTime.Now.AddDays(-30))
            {
                if (allOutstandingSwitch.IsToggled)
                {
                    UserFeedback = "Please ensure to choose one option";
                }
                else
                {
                    optionSelected = true;
                }
            }
            else
            { UserFeedback = "Please ensure to choose one option"; }

            //AllOutstanding
            if (allOutstandingSwitch.IsToggled)
            {
                if (!string.IsNullOrEmpty(oldestSampleIdEntry.Text))
                {
                    UserFeedback = "Please ensure to choose one option";
                }
                else
                {
                    optionSelected = true;
                }
            }
            else
            {
                UserFeedback = "Please ensure to choose one option";
            }
            //Since
            if (sinceDatePicker.Date != null && sinceDatePicker.Date < DateTime.Now && sinceDatePicker.Date > DateTime.Now.AddDays(-30))
            {
                if (allOutstandingSwitch.IsToggled || oldestSampleIdEntry.Text != null)
                {
                    UserFeedback = "Please ensure to choose one option";
                }
                else
                {
                    optionSelected = true;
                }
            }
            else { UserFeedback = "Please ensure to choose one option"; }
            return;
        }


        private void GeneratorButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewPage());
            ShowSpinner();
        }

       
    }
}
#endregion