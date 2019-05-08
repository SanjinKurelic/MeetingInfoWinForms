# Meeting Info

Meeting Info is the program for scheduling meetings. The main part of the program is a calendar with ability to add, update or remove meeting with a specific client. The program is written in C# using Windows Forms technology for Microsoft Windows operating system. This project is alos available in several other technologies:

- Windows Forms (current one)
- [WPF](https://github.com/SanjinKurelic/MeetingInfoWPF)
- Web Forms
- ASP. NET MVC

## Getting started

### Prerequisites

For running the project you need to have the following items:

- Visual Studio 2017 or newer
- SQL Server 2017 or newer
- .NET Framework 4.6.1 or newer
- *MeetingInfoDatabase*

Notice: Project might run on the older .NET Framework or using older Visual Studio/SQL Server version, with or without additional tweaks.

### Installig

Install Visual Studio - include the .NET Framework and Windows Forms. Download the *MeetingInfoDatabase* NuGet package from *MeetingInfoDatabase* project (**NuGet package is located in "packed" folder**):

https://github.com/SanjinKurelic/MeetingInfoDatabase

Open Visual Studio and clone this repository to your computer. Open NuGet shell and install the *MeetingInfoDatabase* package by using the following command:

```
Install-Package MeetingInfoDatabase -Source <path_to_package>
```

### Running

When you run the project, you should be presented with the following screen.

![](https://github.com/SanjinKurelic/MeetingInfoWinForms/images/home.jpg)

The main screen shows all the meetings for a current week. By selecting year, month and week in the upper left corner, the user can view his or her meetings for a given week. By right clicking on the meeting, the user can edit or remove selected meeting. If the user double clicks the meeting, he or she will be presented with a window with more information about the meeting.

![](https://github.com/SanjinKurelic/MeetingInfoWinForms/images/info.jpg)

In the upper right corner of the main screen there are three buttons: *"new meeting"* button, *"print"* button and *"change language"* button. By clicking on the *"new meeting"* button dialog box will open and ask the user information about the meeting: date, time, title, description, place and the meeting client. The program offers list of available clients who are stored in the database. **All fields are required and the user can't have 2 meetings on the same day**.

![](https://github.com/SanjinKurelic/MeetingInfoWinForms/images/new.jpg)

Middle button on the upper right corner is the *"print"* button, which allow the user to print the meetings of a current week (as shown on below image).

![](https://github.com/SanjinKurelic/MeetingInfoWinForms/images/print.jpg)

There are 2 available languages for this project: English and Croatian. The user can change language by clicking the *"change language"* button (the globe icon).

## Licence

See the LICENSE file. For every question write to kurelic@sanjin.eu