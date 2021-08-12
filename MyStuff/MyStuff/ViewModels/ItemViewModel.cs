using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MyStuff.Models;

namespace MyStuff.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        //atribs del vm 

        public Item MyItem { get; set; }

        //contructor
        public ItemViewModel()
        {
            MyItem = new Item();
        }

        //métodos y funciones
        public ObservableCollection<Item> ListarItems()
        {
            if (IsBusy)
            {
                return null;
            }
            else
            {
                try
                {
                    return MyItem.ListarItems();
                }
                catch (Exception ex)
                {

                    return null;
                }
                finally
                {
                    IsBusy = false;
                }
            }       
        }
    }
}
