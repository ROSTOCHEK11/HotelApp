using HotelAppLibrary.Data;
using HotelAppLibrary.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelApp.Desktop
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly IDatabaseData _db;

		public MainWindow(IDatabaseData db)
		{
			InitializeComponent();
			_db = db;
		}

		public void SearchForGuests()
		{
			List<BookingFullModel> bookings = _db.SearchBookings(lastNameText.Text);
			resultsList.ItemsSource = bookings.Where(x => x.CheckedIn == false);
		}

		private void searchForGuest_Click(object sender, RoutedEventArgs e)
		{
			SearchForGuests();
		}

		private void CheckInButton_Click(object sender, RoutedEventArgs e)
		{
			var checkInForm = App.serviceProvider.GetService<CheckInForm>();
			var model = (BookingFullModel)((Button)e.Source).DataContext;

			checkInForm.PopulateCheckInInfo(model);

			checkInForm.GuestCheckedIn += RefreshList;

			checkInForm.Show(); 

		}


		private void RefreshList(object sender, EventArgs e)
		{
			SearchForGuests();
		}

	}
}