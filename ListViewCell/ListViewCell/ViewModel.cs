using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Icones em: 
 *  http://findicons.com/search/url
 */
namespace ListViewCell
{
    public class ViewModel
    {
        public ObservableCollection<Item> Items { get; set; }

        public ViewModel()
        {
            this.Items = new ObservableCollection<ListViewCell.Item>();

            this.Items.Add(new ListViewCell.Item
            {
                Title = "Item 1",
                Description = "Descrição 1",
                Image = "http://goo.gl/KVBnUl",
                Selected = true
            });

            this.Items.Add(new ListViewCell.Item
            {
                Title = "Item 2",
                Description = "Descrição 2",
                Image = "http://goo.gl/EDWO5j",
                Selected = false
            });

            this.Items.Add(new ListViewCell.Item
            {
                Title = "Item 3",
                Description = "Descrição 3",
                Image = "http://goo.gl/KVBnUl",
                Selected = true
            });

            this.Items.Add(new ListViewCell.Item
            {
                Title = "Item 4",
                Description = "Descrição 4",
                Image = "http://goo.gl/EDWO5j",
                Selected = false
            });
        }
    }

    public class Item : INotifyPropertyChanged
    {
        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                this.Notify(nameof(image));
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                this.Notify(nameof(description));
            }
        }

        private bool selected;
        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                this.Notify(nameof(Selected));
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.Notify(nameof(Title));
            }
        }

        public override string ToString()
        {
            return this.Title;
        }

        private void Notify(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
