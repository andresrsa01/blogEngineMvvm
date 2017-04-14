using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.BusinessLogic;
using BlogEngine.Common.Base;
using BlogEngine.Common.Command;
using BlogEngine.Model;

namespace BlogEngine.ViewModel
{
    public class CreateBlogViewModel : ViewModelBase
    {
        private Blog _blog;

        public Blog Blog
        {
            get
            {
                return _blog ?? (_blog = new Blog());
            }
            set
            {
                _blog = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _createBlogCommand;

        public RelayCommand CreateBlogCommand
        {
            get
            {
                return _createBlogCommand ??
                  (_createBlogCommand = new RelayCommand(param => CreateBlog(), param => true));
            }
        }

        private void CreateBlog()
        {
            using (var bl = new BLBlog())
            {
                bl.CreateBlog(new Blog()
                {
                    Name = Blog.Name
                });
                Blog = null;
            }
        }
    }
}
