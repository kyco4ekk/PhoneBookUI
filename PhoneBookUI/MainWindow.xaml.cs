using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PhoneBookUI
{
    public partial class MainWindow : Window
    {
        private AddContactWindow addContactWindow;
        public MainWindow()
        {
            InitializeComponent();

            PhoneBook phoneBook1 = new PhoneBook("Ангелина", "89998882233");
            PhoneBook phoneBook2 = new PhoneBook("Иван", "87654561122");
            PhoneBook phoneBook3 = new PhoneBook("Женя", "88005553535");
            contacts_tb.Text = PhoneBook.GetContacts();
        }
        private void addContact_Click(object sender, RoutedEventArgs e)
        {
            if (addContactWindow == null || !addContactWindow.IsVisible)
            {
                addContactWindow = new AddContactWindow(this);
                addContactWindow.Closed += (s, args) => addContactWindow = null;
                addContactWindow.Show();
            }
            else
            {
                addContactWindow.Focus();
            }
        }
        public void UpdateContacts(string contacts)
        {
            if(searchContact.Text == "Поиск контактов")
                contacts_tb.Text = contacts;
            else
                contacts_tb.Text = PhoneBook.GetSubstringContacts(searchContact.Text);
        }
        private void searchContact_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            string searchText = searchContact.Text;

            if (!string.IsNullOrEmpty(searchText) && searchText != "Поиск контактов")
            {
                if (char.IsLetter(searchText[0]))
                {
                    contacts_tb.Text = PhoneBook.GetSubstringContacts(searchText);
                }
                else
                {                    
                    contacts_tb.Text = PhoneBook.GetContacts();
                }
            }
            else
            {
                contacts_tb.Text = PhoneBook.GetContacts();
            }
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                if (textBox.Text == "Поиск контактов")
                {
                    textBox.Text = string.Empty;
                    textBox.Foreground = new SolidColorBrush(Colors.Black); // Изменение цвета текста на черный
                }
            }
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    if (textBox.Name == "searchContact_tb")
                        textBox.Text = "Поиск контактов";                   

                    textBox.Foreground = new SolidColorBrush(Colors.Gray);
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}