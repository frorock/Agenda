
using System.Security;
using System.Windows;
using System.Windows.Controls;


namespace Agenda_Iliana.CustomControls
{

    public partial class BindablelPassword : UserControl
    {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(SecureString), typeof(BindablelPassword));

        public SecureString Password
        {
            get { return (SecureString)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public BindablelPassword()
        {
            InitializeComponent();
            TB_Password.PasswordChanged += OnPasswordChanged;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = TB_Password.SecurePassword;
        }
    }
}
