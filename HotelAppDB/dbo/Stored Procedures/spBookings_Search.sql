CREATE PROCEDURE [dbo].[spBookings_Search]
	@lastName nvarchar(50),
	@startDate date
AS
begin

	set nocount on;

	select [b].[Id], [b].[RoomId], [b].[GuestId], [b].[StartDate], [b].[EndDate], 
		[b].[CheckedIn], [b].[TotalCost], [g].[FirstName], [g].[LastName], 
		[r].[RoomNumber], [r].[RoomTypeId], [rt].[Title], [rt].[Description], 
		[rt].[Price]
	from Bookings b
	inner join Guests g on b.GuestId = g.Id
	inner join Rooms r on b.RoomId = r.Id
	inner join RoomTypes rt on r.RoomTypeId = rt.Id
	where b.StartDate = @startDate and g.LastName = @lastName;



end
