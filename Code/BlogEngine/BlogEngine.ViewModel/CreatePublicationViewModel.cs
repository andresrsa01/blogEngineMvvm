using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.BusinessLogic;
using BlogEngine.Common.Base;
using BlogEngine.Common.Command;
using BlogEngine.Model;


namespace BlogEngine.ViewModel
{
    public class CreatePublicationViewModel : ViewModelBase
    {
        private Blog _blogSelected;

        [Required(ErrorMessage = "You must select a Blog.")]
        public Blog BlogSelected
        {
            get { return _blogSelected; }
            set
            {
                _blogSelected = value; 
                OnPropertyChanged();
            }
        }

        private string _publicationTitle;

        [Required(ErrorMessage = "The field publication title is required.")]
        public string PublicationTitle
        {
            get { return _publicationTitle; }
            set
            {
                _publicationTitle = value; 
                OnPropertyChanged();
            }
        }
        
        private string _publicationContent;

        [Required(ErrorMessage="The field publication content is required.")]
        public string PublicationContent
        {
            get { return _publicationContent; }
            set
            {
                _publicationContent = value; 
                OnPropertyChanged();
            }
        }


        private RelayCommand _createPublicationCommand;

        public RelayCommand CreatePublicationCommand
        {
            get { return _createPublicationCommand ?? (new RelayCommand(param => CreatePublication(), param => true)); }
            set { _createPublicationCommand = value; }
        }

        private ObservableCollection<Blog> _listBlogs;

        public ObservableCollection<Blog> ListBlogs
        {
            get
            {
                using (var bl= new BLBlog())
                {
                    _listBlogs= new ObservableCollection<Blog>(bl.ListBlogs());
                }
                return _listBlogs;
            }
            set
            {
                _listBlogs = value;
                OnPropertyChanged();
            }
        }

        private void CreatePublication()
        {
            using (var bl= new BLPublication())
            {
                bl.CreatePublication(new Publication()
                {
                    BlogId = BlogSelected.BlogId,
                    Content = PublicationContent,
                    Title = PublicationTitle
                });
            }
            PublicationTitle = null;
            PublicationContent = null;
            BlogSelected = null;
        }
    }
}
