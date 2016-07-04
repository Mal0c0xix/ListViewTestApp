using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace ListViewTestApp.ViewModel
{
    public class ContactViewModel : ViewModelBase
    {
        private ObservableCollection<Contact> _contacts;

        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set
            {
                _contacts = value;
                RaisePropertyChanged(() => Contacts);
            }
        }

        public ContactViewModel()
        {
            Contacts = new ObservableCollection<Contact>
            {
                new Contact("Pascal", "Larivé", "pascallarive@aol.com"),
                new Contact("Gérard", "Menvussa", "gerard.menv@gmail.com"),
                new Contact("Mathilde", "Lambert", "mathilde.lamb@yahoo.fr")
            };
        }

    }
}
