using HotelAppLibrary.Data;
using HotelAppLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Web.Pages
{
    public class RoomSearchModel : PageModel
    {
		private readonly IDatabaseData _db;
		private DateTime _endDate = DateTime.Now.AddDays(1);
		private DateTime _startDate = DateTime.Now;


		[DataType(DataType.Date)]
		[BindProperty(SupportsGet = true)]
		public DateTime StartDate 
        { 
            get => _startDate;
            set 
            { 
                _startDate = value; 
                if(_startDate < DateTime.Now)
                {
                    _startDate = DateTime.Now;

				}
            } 
        }

		[DataType(DataType.Date)]
        [BindProperty(SupportsGet = true)]
        public DateTime EndDate 
        {
            get => _endDate;
            set 
            { 
                _endDate = value; 
                if(_endDate < StartDate)
                {
                    _endDate = StartDate.AddDays(1);
                }
            } 
        }

		[BindProperty(SupportsGet = true)]
        public bool SearchEnabled { get; set; } = false;

        public List<RoomTypeModel> AvailableRoomTypes { get; set; }

        public RoomSearchModel(IDatabaseData db)
        {
			_db = db;
		}

        public void OnGet()
        {

            if(SearchEnabled == true)
            {
                AvailableRoomTypes = _db.GetAvailableRoomTypes(StartDate, EndDate);
            }

        }

        public IActionResult OnPost()
        {
            return RedirectToPage(new 
            {
                SearchEnabled = true, 
                StartDate = StartDate.ToString("yyyy-MM-dd"),
				EndDate = EndDate.ToString("yyyy-MM-dd")
			});
        }
    }
}
