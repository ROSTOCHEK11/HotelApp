# Hotel Management App
This is Hotel Management App built with ASP.NET Razor Pages and WPF 

### `Here I have :`
_1) A Web Portal that allows people to book an available room_

_2) A Desktop App for personnel to check guests in_

## Tech Stack
* .NET 8.0
* Razor Pages
* WPF
* Dapper
* SQL
* SQLite


## Description

This application is structured into a well-organized, modular multi-layer architecture and consists of 4 projects, each with its own responsibilities:

---

* ### HotelApp.Desktop
  
 This is a `WPF` application meant for hotel personnel use.
 It provides an user interface where staff can manage guest check-ins and access guest information quickly and efficiently.

* ### HotelApp.Web

 Developed using `Razor Pages`, this web portal allows potential guests to book rooms online. 
 It provides a user-friendly interface that guests can access from anywhere to view available rooms and make reservations.

* ### HotelAppDB

This project is dedicated to the SQL Server database and houses all the data structures such as tables and stored procedures necessary for the application. 
It's the central repository for all the data that the application uses, including guest information, room details, bookings, and more. 
This SQL project ensures that data is well-organized, secure, and efficiently managed.

* ### HotelAppLibrary
  
Serving as the data access layer, this class library is where the data access logic is centralized. 
It utilizes Dapper, a lightweight ORM (Object-Relational Mapping) framework, to facilitate the interaction between the application's front-end layers and the SQL database. 
The use of Dapper contributes to the app’s performance by providing a simple and fast data access mechanism. 
Additionally, because the system is designed to support both `SQL Server` and `SQLite` databases, 
this layer handles the abstraction necessary to switch between these databases seamlessly without affecting the rest of the application’s operations.


# `The view of the App :`
* ### Choose the date
![image](https://github.com/ROSTOCHEK11/HotelApp/assets/113441489/71b306bc-44a1-4ecc-8eea-dbc14d396861)

* ### Loking for the available room types
![image](https://github.com/ROSTOCHEK11/HotelApp/assets/113441489/f2a829d9-66a9-45d4-a558-c88197942d9b)

* ### Booking the room
![image](https://github.com/ROSTOCHEK11/HotelApp/assets/113441489/0875117c-86bd-4dd2-9162-cfd69b3721bd)

---

* ### Searching for the guest in the Desktop App
  ![image](https://github.com/ROSTOCHEK11/HotelApp/assets/113441489/21bbcdd3-635a-4d66-a63a-3c8bb37bab24)

  
  _Searching is making by the Last Name and Today's Date_ 

* ### Checking in the guest
  
  ![image](https://github.com/ROSTOCHEK11/HotelApp/assets/113441489/ca96df19-d958-4f5b-9d43-a9f4dfe620e5)



## `That is a Minimum Viable Product (MVP), it's going to be upgraded and expanded in the future`
