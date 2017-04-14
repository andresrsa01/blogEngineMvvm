using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.BusinessLogic;
using BlogEngine.Common.Base;
using BlogEngine.Model;

namespace BlogEngine.ViewModel
{
    public class ListBlogViewModel : ViewModelBase
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
            set
            {
                _listBlogs = value;
                OnPropertyChanged();
            }
        }

    }
}
