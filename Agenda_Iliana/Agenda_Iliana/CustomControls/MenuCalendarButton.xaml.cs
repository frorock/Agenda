using System.Windows.Controls;
using System.Windows;

namespace Agenda_Iliana.CustomControls
{

    public partial class MenuCalendarButton : UserControl
    {
        public MenuCalendarButton()
        {
            InitializeComponent();
        }


        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        public static readonly DependencyProperty CaptionProperty = DependencyProperty.
            Register("Caption", typeof(string), typeof(MenuCalendarButton));

        public FontAwesome.WPF.FontAwesomeIcon Icon
        {
            get { return (FontAwesome.WPF.FontAwesomeIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.
        Register("Icon", typeof(FontAwesome.WPF.FontAwesomeIcon), typeof(MenuCalendarButton));
    }
}