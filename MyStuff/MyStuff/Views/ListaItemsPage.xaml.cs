using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MyStuff.ViewModels;

namespace MyStuff.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaItemsPage : ContentPage
    {

        ItemViewModel VmItem;


        public ListaItemsPage()
        {
            InitializeComponent();

            BindingContext = VmItem = new ItemViewModel();

            //TODO. Como no hemos hecho un usuario global que contiene la info del usuario logueado
            //debo "quemar" el id del usuario 

            VmItem.MyItem.UserId = 10;

            LtsItems.ItemsSource = VmItem.ListarItems();

        }

        private void LtsItems_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}