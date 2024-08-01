using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace PhoneBookUI
{
    public partial class AddContactWindow : Window
    {
        private MainWindow mainWindow;

        public AddContactWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                if (textBox.Text == "Имя" || textBox.Text == "Номер телефона")
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
                    if (textBox.Name == "nameContact_tb") 
                        textBox.Text = "Имя";
                    else if (textBox.Name == "phoneNumber_tb") 
                        textBox.Text = "Номер телефона";

                    textBox.Foreground = new SolidColorBrush(Colors.Gray); 
                }
            }
        }       
        private void AddContact_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(nameContact_tb.Text))
                PhoneBook phoneBook = new PhoneBook(nameContact_tb.Text, phoneNumber_tb.Text);
                mainWindow.UpdateContacts(PhoneBook.GetContacts());
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            
        }
    }
}
