using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.Common.Annotations;

namespace BlogEngine.Common.Base
{
    public class ViewModelBase : INotifyPropertyChanged, IDisposable, IDataErrorInfo
    {

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string this[string columnName] => OnValidate(columnName);

        public string Error => null;

        protected virtual string OnValidate(string propertyName)
        {
            var context = new ValidationContext(this, null, null)
            {
                MemberName = propertyName
            };
            var results = new Collection<ValidationResult>();
            var isValid = Validator.TryValidateProperty(this.GetType().GetProperty(propertyName).GetValue(this),
                context, results);
            return !isValid ? results[0].ErrorMessage : null;
        }
    }
}
