# Pierre's Bakery: Vendor and Order Tracker

#### C# Basic Web Appication Independent Project, 13 March 2020
 
#### By **_Jieun Kang_**

## Description
An MVC application to help Pierre track the vendors that purchase baked goods from Pierre's bakery and the orders belonging to those vendors.

## Setup/Installation Requirements

### # Install C# and .NET

**macOS**
1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)
    * Click this link will prompt a `.pkg` file download from Microsoft.
2. Open the file     
    * This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
3. Confirm the installation is successful (2.2.105)
    * Open your terminal and run the command <br/> `$ dotnet --version`    

**Windows**
1. Download [64-bit .NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)
    * Click this links will prompt a `.exe` file download from Microsoft.
2. Open the file
    * Follow the steps provided by the installer for your OS.
3. Confirm the installation is successful
    * Open a new Windows PowerShell window and run the command <br/> `$ dotnet --version`  

### # Clone this repository
1. Clone this project.
    * `$ cd desktop`
    * `$ git clone https://github.com/jieunkang-101/VendorOrderTracker.Solution`
    * `$ cd VendorOrderTracker.Solution`
2. Run this MVC application
    * `$ cd VendorOrderTracker`
    * `$ dotnet run` 
    * Launch localhost http://localhost:5000

## Behavior Driven Development Specifications
| Behavior(Spec) <img width=500/>    | Input <img width=400/>   | Output <img width=500/>  |
| :---------------- | :-----: | :-----: |
| Upon launching the application, user sees homepage | http://localhost:5000 | Splash Page |
| Upon clicking on [Vendors] tab, user can view all vendors that have been added | Click [Vendors] tab | Display a list of all vendors |
| Upon clicking on [Add New Vendor] tab, user can add a new vendor | Click [Add New Vendor] tab,<br>Vendor Name: Suzie's Cafe <br> Description: ** <br> Click [Add Vendor] | The new vendor added to vendor list, and user can select [View/ Add Order], [Edit Vendor Info], [Delete this Vendor] | 
| If user select [Edit Vendor Info], user can update individual vendor's information | Click [Edit Vendor Info] | Vendor Name: SUZIE'S CAFE |
| If user select [Delete this Vendor], user can delete individual vendor | Click [Delete this Vendor] | Refresh vendors list page |
| If user select [View/ Add Order], user cad add a new order for a particular vendor | Order Title<br> Description <br> Price <br> Date <br> Click [Add Order] | The new order added to order list, and user can select individual order to see details |
| If user click the order title, user can see the order details, and user can delete individual order | Click [Delete this Order] | Order has been deleted |

## Technologies Used

* C#
* .NET
* ASP.NET Core MVC
* CSS
* Bootstrap

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

Copyright (c) 2020 **_Jieun Kang_**