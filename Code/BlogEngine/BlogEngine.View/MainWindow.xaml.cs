using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls.Ribbon;
using BlogEngine.Common.Command;
using BlogEngine.View.Annotations;

namespace BlogEngine.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow, INotifyPropertyChanged
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
                OnPropertyChanged();
            }

        }

        private RelayCommand _createBlogCommand;
        public RelayCommand CreateBlogCommand
        {
            get
            {
                return _createBlogCommand ??
                       (_createBlogCommand = new RelayCommand(param => this.OpenCreateBlog(), parama => true));
            }

        }

        private RelayCommand _listBlogCommand;

        public RelayCommand ListBlogCommand
        {
            get
            {
                return _listBlogCommand ??
                       (_listBlogCommand = new RelayCommand(param => this.ListBlogs(), parama => true));
            }
        }

        private void ListBlogs()
        {
            Page = "ListBlogs.xaml";
        }


        private void OpenCreateBlog()
        {
            Page = "CreateBlog.xaml";
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
