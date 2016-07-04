namespace ListViewTestApp
{
    public class Contact
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mail { get; set; }

        public Contact(string firstname, string lastname, string mail)
        {
            Firstname = firstname;
            Lastname = lastname;
            Mail = mail;
        }
    }
}
