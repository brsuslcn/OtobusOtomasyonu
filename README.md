# Barış USLUCAN - Otobüs Otomasyonu


The application consists of 10 forms: MainMenu.cs, Private Seats.cs, Define Bus, SatisRezervasyon.cs, SeferTanim.cs, SvR.cs, DefinedSeferler.cs, GirisPaneli.cs, SifreSifirlama.cs and AllReservations.cs.

GirisPaneli.cs: It is the form that is projected before login to automation. The user is prompted to enter the username and password. Username: Baris and Password: barisuslucan.com.tr.

SifreSifirlama.cs: The password defined for automation can be changed from this panel.

AnaMenu.cs: It is the main menu of the application. On the application, Expedition Definition, ticket sales or reservation operations, voyage Reset, display of defined voyages, etc. assumes access to transactions.

OzelKoltuklar.cs: In this form, records search and deletion processes are performed according to the TR ID number of the reservations made. 

SatisVeRezervasyon.cs / SatisVeRezervasyon2.cs: It is the form in which sales and reservations are made. In this form, when making a purchase or reservation, TR, Name, Surname, Telephone, Gender data and seat number selection are requested. In addition, a valid 11-digit TR ID number must be entered. TC ID number control is done by algorithm. In addition, the occupancy rate of the bus is displayed with the ProgressBar.

OtobusTanimla.cs: It is the form in which buses are defined. Here, License plate is the key column. Vehicle model, wifi, display and charging information, seat type can be recorded on the relevant plate.

SeferTanim.cs: Expeditions are defined in this form. The user is requested to start and end stop information. In addition, the user is prompted to select one of the previously defined tools. Here plate is the key column. Only one service is defined for a bus. If a bus service has already been defined here (Executed route, etc.), the user is asked if he wants to edit or delete the relevant flight. If the user requests this status, he will be directed to the voyage arrangement form. Additionally, the user cannot define trips to past dates, so the minimum time of dateTimePicker is set to the current present date of the system date. Thus, the definition of expeditions to the past dates was prevented.

SvR.cs: It is the form in which the flights are checked before proceeding with the sale or reservation process. Here querying is done with From, To comboboxes and dateTimePicker. Information from the desired locations and the desired date are obtained from the user, and the times of the relevant expeditions on that date are displayed to the user. Here, the minimum time of dateTimePicker is set to the present of the current system's time. Thus, the user cannot book tickets for the past dates or the flights on the past dates are not shown to the user. However, even if the time of the relevant flight passes, tickets can be issued on that day. The aim here is to give the user the right to issue a ticket until the end of the day if the relevant time is delayed, and when questioned the next day, that time will not be seen anyway.

For example, let the Istanbul - Izmir flight be defined as 15/09/2020 at 19:00. If the system date is 15.09.2020 at 20:00, the user will still be able to issue a ticket or query this time. However, the next day will not display this time yet for 16.09.2020. The user has to process the relevant selected flight before proceeding with the sales and reservation process. When it is processed, the properties of the vehicle defined for the relevant expedition are reflected on the screen. If the seats of the bus are of 2+1 type, the seat arrangement is 2+1; if it is 2+2 it is reflected as 2+2.

TanimliSeferler.cs: It is the panel where the user can view, edit, reset or completely remove the defined flights. Here, expeditions can be queried according to the place where the voyage will start and where it will end. In addition, only the date and time information of the relevant voyage can be updated. If the user wants to change the vehicle of the voyage or change the address of the voyage, he must completely remove and re-create the voyage. The main purpose here is to update the vehicle from the past time with a new date.

TumKayitlar.cs: By this panel, previously booked or purchased records can be viewed, searched, updated or deleted according to TR ID number. It is obligatory to enter a real 11-digit TR ID number here, too, when making transactions with a TR ID. Since the real TC ID number must be entered while registering, the TC ID number cannot be changed during the registration update. Therefore, the txtTC textbox box is disabled. Also, Name, Surname, Phone and Gender textboxes are disabled until the record is selected.

While operating in the database in the application, SQL connections are opened in a controlled manner and closed when the process is finished. In addition, care has been taken to use methods to reduce code repetitions, and any errors that may occur are controlled with try-catch structures.

The data in the application is kept in the SQL database called otobus.mdf. The database file consists of 4 tables as Vehicle, Bus, SatisVeRezerve and YonetimPanel. While keeping the data about the customer, which is SalesAndReserved from these tables, the Vehicle table keeps the flights. The bus table, on the other hand, holds the properties related to the defined bus. The ManagementPanel table also keeps the Username and Password information to log in to the automation. It is determined by the "ID2" column in SatisVeRezerve that the color of the seats is red or green. In ID2, if the record is reserved, "Reserved" information is added with all the information. Then, while reading the data, it is determined according to the situation in ID2 and seat colors are filled accordingly.

Likewise, the “IDP” column in the Vehicle table holds all the data for the defined trip. This data is kept for easy transactions on the relevant flights. Since the records of the relevant flights are taken according to the IDP column, the color of the seats is not determined by gender. It is possible to distribute the seats by gender, but this was not necessary as it required too many SQL queries. It is more reasonable to leave red/green according to the color of the seats being full/empty.
