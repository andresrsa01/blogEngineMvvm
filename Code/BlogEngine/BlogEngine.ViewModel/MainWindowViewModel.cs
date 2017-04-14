using System.ComponentModel;
using System.Runtime.CompilerServices;
using BlogEngine.Common.Base;
using BlogEngine.Common.Command;

namespace BlogEngine.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _page;

        public string Page
        {
            get
            {
                return _page;
            }
            set
            {
                _page = value;
                base.OnPropertyChanged();
            }

        }

        private RelayCommand _createBlogCommand;

        public RelayCommand CreateBlogCommand
        {
            get
            {
                return _createBlogCommand ??
                       (_createBlogCommand = new RelayCommand(param => OpenCreateBlog(), parama => true));
            }

        }

        private RelayCommand _listBlogCommand;

        public RelayCommand ListBlogCommand
        {
            get
            {
                return _listBlogCommand ??
                       (_listBlogCommand = new RelayCommand(param => ListBlogs(), parama => true));
            }
        }

        private RelayCommand _createPublicationCommand;

        private RelayCommand _reportBlogCommand;

        public RelayCommand ReportBlogCommand
        {
            get
            {
                return _reportBlogCommand ??
                       (_reportBlogCommand = new RelayCommand(param => OpenReportBlog(), param => true));
            }

        }

        public RelayCommand CreatePublicationCommand
        {
            get
            {
                return _createPublicationCommand ??
                   (_createPublicationCommand = new RelayCommand(param => OpenCreatePublication(), parama => true));
            }
        }

        private RelayCommand _listPublicationsCommand;

        public RelayCommand ListPublicationsCommand
        {
            get
            {
                return _listPublicationsCommand ??
                  (_listPublicationsCommand = new RelayCommand(param => OpenListPublications(), param => true));
            }
        }

        private void OpenCreateBlog()
        {
            Page = "CreateBlog.xaml";
        }

        private void ListBlogs()
        {
            Page = "ListBlogs.xaml";
        }

        private void OpenReportBlog()
        {
            Page = "ReportBlog.xaml";
        }

        private void OpenCreatePublication()
        {
            Page = "CreatePublication.xaml";
        }

        private void OpenListPublications()
        {
            Page = "ListPublication.xaml";
        }

    }
}
