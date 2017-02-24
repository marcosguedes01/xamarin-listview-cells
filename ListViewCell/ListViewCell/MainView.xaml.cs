using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewCell
{
    public partial class MainView : TabbedPage
    {
        private ViewModel _viewModel = new ViewModel();
        public MainView()
        {
            InitializeComponent();
            this.BindingContext = _viewModel;
        }

        public void MenuItemClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var item = menuItem.CommandParameter as Item;

            if (menuItem.IsDestructive)
            {
                _viewModel.Items.Remove(item);
            }
            else
            {
                DisplayAlert("Informações", item.Description, "Ok");
            }
        }
    }
}
