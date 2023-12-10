using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Agenda_Iliana.View
{

    public partial class CalendarView : UserControl
    {
        public CalendarView()
        {
            InitializeComponent();
        }
        private void TB_Note_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TB_Note.Focus();
        }
        private void TB_TxtNote_Changed(object sender, TextChangedEventArgs e)
        {
            if ( TB_TxtNote.Text.Length > 0)
            {
                TB_Note.Visibility = Visibility.Collapsed;
            }
            else 
            {
                TB_Note.Visibility = Visibility.Visible;

            }
        }

        private void TB_Time_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TB_Time.Focus();
        }

        private void TB_TxtTime_Changed(object sender, TextChangedEventArgs e)
        {
            if  (TB_TxtTime.Text.Length > 0)
            {
                TB_Time.Visibility = Visibility.Collapsed;
            }
            else
            {
                TB_Time.Visibility = Visibility.Visible;

            }
        }



        private void BTAngleLeft_Click(object sender, RoutedEventArgs e)
        {
            if (calendar.SelectedDate != null)
            {
                DateTime nextDay = calendar.SelectedDate.Value.AddDays(-1);
                calendar.SelectedDate = nextDay;
                TB_DaynbrLeft.Text = calendar.SelectedDate.Value.ToString("dd");

            }

        }

        private void BTAngleRight_Click(object sender, RoutedEventArgs e)
        {
            if (calendar.SelectedDate != null)
            {
                DateTime nextDay = calendar.SelectedDate.Value.AddDays(1);
                calendar.SelectedDate = nextDay;
                TB_DaynbrLeft.Text = calendar.SelectedDate.Value.ToString("dd");

            }

        }

        private void BTAddNote_Click(object sender, RoutedEventArgs e)
        {
            CustomControls.Item NewNote = new CustomControls.Item()
            {
                Title = TB_TxtNote.Text,
                Time = TB_TxtTime.Text,
                IconBell = FontAwesome.WPF.FontAwesomeIcon.Bell,
                Icon = FontAwesome.WPF.FontAwesomeIcon.CircleThin,
                Color = new SolidColorBrush(Colors.White),

            };
            Right_StackPanel.Children.Add(NewNote); 
        }

    }
}
