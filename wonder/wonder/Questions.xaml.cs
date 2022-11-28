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
    public partial class Questions : ContentPage
    {
        public IList<Questiongetandset> questiongetandsets { get; private set; }    

        public Questions()
        {
            InitializeComponent();

            // The Questiongetandset are added to the questiongetandsets collecgtion
            questiongetandsets = new List<Questiongetandset>();
            questiongetandsets.Add(new Questiongetandset
            {
                QName = "Is anything worrying you?",
                QAnswer = "Yes / No"
            });

            questiongetandsets.Add(new Questiongetandset
            {
                QName = "Is it easy for you to fall asleep?",
                QAnswer = "Yes / No"
            });
            // This is set to the Questions object
            BindingContext = this;

        }
    }
}