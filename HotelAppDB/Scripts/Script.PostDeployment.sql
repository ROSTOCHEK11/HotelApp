/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists (select 1 from dbo.RoomTypes) 
begin
    
    insert into dbo.RoomTypes (Title, Description, Price)
    values ('King Size Room','A room with King-size bed and wide balcony', 100),
    ('Double King Size Room','A room with TWO King-size bed and wide balcony', 115),
    ('Executive Suite','Two rooms, each with a King-size bed and wide balcony', 205);

end

if not exists (select 1 from dbo.Rooms) 
begin
    
    declare @roomId1 int;
    declare @roomId2 int;
    declare @roomId3 int;

    select @roomId1 = Id from dbo.RoomTypes where Title = 'King Size Room'
    select @roomId2 = Id from dbo.RoomTypes where Title = 'Double King Size Room'
    select @roomId3 = Id from dbo.RoomTypes where Title = 'Executive Suite'


    insert into dbo.Rooms (RoomNumber, RoomTypeId)
    values ('101',@roomId1),
    ('202',@roomId2),
    ('303',@roomId3), 
    ('304',@roomId3), 
    ('203',@roomId2),
    ('102',@roomId1);
    
end


