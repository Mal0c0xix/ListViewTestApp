using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ListViewTestApp.ViewModel
{
    public class ContactViewModel : ViewModelBase
    {
        private ObservableCollection<Contact> _contacts;
        private RelayCommand _addCommand;
        private RelayCommand _removeCommand;

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

        public RelayCommand AddCommand => _addCommand ?? (_addCommand = new RelayCommand(AddContact));
        public RelayCommand RemoveCommand => _removeCommand ?? (_removeCommand = new RelayCommand(RemoveContact));

        private void AddContact()
        {
            Contacts.Add(new Contact("Pierre", "Guatuso", "pierre.gat@hotmail.com"));
            //RaisePropertyChanged(() => Contacts);
        }

        private void RemoveContact()
        {
            Contacts.Remove(Contacts[Contacts.Count - 1]);
            //RaisePropertyChanged(() => Contacts);
        }
    }
}
