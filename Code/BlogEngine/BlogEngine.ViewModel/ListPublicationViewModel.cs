using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.BusinessLogic;
using BlogEngine.Common.Base;
using BlogEngine.Common.Command;
using BlogEngine.Model;

namespace BlogEngine.ViewModel
{
    public class ListPublicationViewModel : ViewModelBase
    {
        private ObservableCollection<Blog> _listBlogs;

        public ObservableCollection<Blog> ListBlogs
        {
            get
            {
                using (var bl = new BLBlog())
                {
                    _listBlogs = new ObservableCollection<Blog>(bl.ListBlogs());
                }
                return _listBlogs;
            }
        }

        private ObservableCollection<Publication> _listPublicationByBlog;

        public ObservableCollection<Publication> ListPublicationsByBlog
        {
            get { return _listPublicationByBlog; }
            set
            {
                _listPublicationByBlog = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _searchPublicationsCommand;

        public RelayCommand SearchPublicationsCommand
        {
            get
            {
                return _searchPublicationsCommand ??
                    (_searchPublicationsCommand = new RelayCommand(param => SearchPublications(param), param => true));
            }

        }

        private void SearchPublications(object o)
        {
            var blogSeleccionado = (Blog)o;
            using (var bl = new BLPublication())
            {
                ListPublicationsByBlog = new ObservableCollection<Publication>(bl.ListPublications(blogSeleccionado));
            }
        }
    }
}
