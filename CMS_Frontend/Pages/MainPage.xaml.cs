using CMS_Frontend.Models;
using CMS_Frontend.PageModels;

namespace CMS_Frontend.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}