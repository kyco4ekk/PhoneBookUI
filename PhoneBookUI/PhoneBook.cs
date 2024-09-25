namespace PhoneBookUI
{
    public class PhoneBook
    {
        public PhoneBook(string contactName, string contactNumberPhone)
        {            
            if (!CheckCorrectContactName(contactName))
                throw new ArgumentException("Некорректное имя контакта. Пожалуйста, введите верное имя.");
            _contactName = contactName;

            if (!CheckCorrectPhoneNumber(contactNumberPhone))
                throw new ArgumentException("Некорректный номер телефона. Пожалуйста, введите правильный номер.\nПример: 89006509090\nНомер должен быть одиннадцатизначный!");
            _contactNumberPhone = contactNumberPhone;

            AddContact(ContactName, ContactNumberPhone);
        }
        
        private static SortedDictionary<string, string> _contact = new SortedDictionary<string, string>();
        private readonly string _contactNumberPhone;
        public string ContactNumberPhone
        {
            get { return _contactNumberPhone; }
        }
        private readonly string _contactName;
        public string ContactName
        {
            get { return _contactName; }
        }
        private bool CheckCorrectPhoneNumber(string contactNumberPhone)
        {
            if (contactNumberPhone.Length != 11)
                return false;
            for (int i = 0; i < contactNumberPhone.Length; i++)
                if (!char.IsDigit(contactNumberPhone[i]))
                    return false;
            return true;
        }
        private bool CheckCorrectContactName(string contactName)
        {
            for (int i = 0; i < contactName.Length; i++)
                if (char.IsDigit(contactName[i]))
                    return false;
            return true;
        }
        protected static void AddContact(string name, string phoneNumber)
        {
            if (_contact.ContainsKey(name))
                throw new ArgumentException("Контакт с таким именем уже существует.");
            if (_contact.ContainsValue(phoneNumber))
                throw new ArgumentException("Контакт с таким номером телефона уже существует.");

            _contact.Add(name, phoneNumber);            
        }
        public static string GetContacts()
        {
            string words = "";
            foreach (KeyValuePair<string, string> entry in _contact)
            {
                words += entry.Value + "\t" + entry.Key + "\n";
            }
            return words;
        }      
        public static string GetSubstringContacts(string substringText)
        {
            var filteredContacts = _contact.Where(entry => entry.Key.StartsWith(substringText));
            string words = "";

            foreach (KeyValuePair<string, string> entry in filteredContacts)
            {
                words += entry.Value + "\t" + entry.Key + "\n";
            }
            return words;
        }
    }
}