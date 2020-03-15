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
|| Behavior(Spec)  | Input   | Output  |
|---| :---------------- | :----- | :----- |
|1| Upon launching the application, user sees homepage | http://localhost:5000 | Splash Page <br> Display navigation bar `Vendors`, `AddNewVendor` |
|2| User can view all vendors that currently exist <li>Click `Vendors` in the navbar</li> <li>User can select `View/Add Order`, `Edit Vendor Info` or `Delete this Vendor`</li> | Click `Vendors`| Display a list of all vendors. Each vendor has `View/Add Order`, `Edit Vendor Info`, `Delete this Vendor` buttons |
|3| User can add a new vendor <li>Click `AddNewVendor` in the navbar</li> <li>A application returns a form to enter the vendor's information</li> | Click `AddNewVendor` <br>Vendor Name: Suzie's Cafe <br> Description: ** <br> Click `Add Vendor` | Vendors <br>...<br> Suzie's Cafe <br>...| 
|4| User can update individual vendor's information <li>Click `Edit Vendor Info` button</li><li>A application returns a form to edit the vendor's information</li>  | Click `Edit Vendor Info`<br> Vendor Name: SUZIE'S CAFE <br>Click `Update` | Updated vendors list page <br>...<br> SUZIE'S CAFE<br>... |
|5| User can delete individual vendor <li>Click `Delete this Vendor` button</li> <li>A application returns a form to confirm deletion this vendor</li> | Click `Delete this Vendor`<br>Click `Yes` <br> Click `Delete` | Refresh vendors list page without this vendor |
|6| User can add a new order or view all orders for a particular vendor <li>Click `View/Add Order` button</li> |Click `View/Add Order`<br>Click `Add a New Order`<br>Order Title: Brioche <br> Description: ** <br> Price: $ <br> Date: mm/dd/yyyy <br> Click `Add Order` | Orders for `Suzie's Cafe` <br> Brioche <br> ...|
|7| User can view a order's details <li>Click `Brioche`</li> | Click `Brioche` | Order Details: <br> Brioche <br> Description: ** <br> Price: $ <br> Date: mm/dd/yyyy |
|8| User can delete individual order <li>Click `Delete this Order`</li> | Click `Delete this order` | Confimation message: Order has been deleted |

## Technologies Used

* C#
* .NET
* ASP.NET Core MVC
* Bootstrap

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

Copyright (c) 2020 **_Jieun Kang_**