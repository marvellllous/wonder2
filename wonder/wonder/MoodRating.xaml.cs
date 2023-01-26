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
        public MoodRating()
        {
            InitializeComponent();
        }
    }

    /*
    1. Create a Xamarin.Forms project.

    2. Add a ContentPage to the project.

    3. Add a StackLayout to the ContentPage.

    4. Add a Label to the StackLayout.

    5. Add a Slider to the StackLayout.

    6. Add a Label to the StackLayout to display the current mood rating.

    7. Add a ChartView to the StackLayout.

    8. Create a List of MoodRating objects.
    
    9. Create a method to add a MoodRating object to the List.
   
    10. Create a method to update the ChartView with the List of MoodRating objects.

    11. Create an event handler for the Slider's ValueChanged event.

    12. In the event handler, call the method to add a MoodRating object to the List.

    13. In the event handler, call the method to update the ChartView with the List of MoodRating objects.
    
    14. Run the application and test the mood rating graph. 
    */
}