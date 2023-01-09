using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wonder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoodRating : ContentPage
    {
        public double MoodRating1Percent { get; set; }
        public double MoodRating2Percent { get; set; }
        public double MoodRating3Percent { get; set; }
        public double MoodRating4Percent { get; set; }
        public double MoodRating5Percent { get; set; }

        public MoodRating()
        {
            InitializeComponent();
        }

        public class MoodRatingView
        {


        }
            
            
            
    }
}
