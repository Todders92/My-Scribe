# MyScribe

#### _4/09/2020_

#### _By Keturah Howard, Jose Amesquita, Todd Wallraven, Jonathan Carlos_

## **Description**

_A personal reddit-style journal app. Organize your thoughts by creating thought boards and post individual thoughts/ideas to it! This versatile app can be used to collect your favorite memes, store app ideas, or record journal entries related to specific categories of your life. Post links, images, links to other websites, or blocks of text. 

This is a teamweek project done to showcase the skills we learned through the Epicodus C# curriculum, demonstrating our knowledge of ASP.NET Core MVC routing, migrations with Entity Framerwork and SQL, and Authorization through Identity._

## Preview

<p align="center">
  <img src="/img/SS1.png">
	<img src="./img/SS2.png">
	<img src="./img/SS3.png">
	<img src="./img/SS4.png">
	<img src="./img/SS5.png">
</p>
	
## Specifications 

### User Stories:

* As a user, I want to be able to register an account.
* As a user, I want to be able to log in with an account.
* As a user, I want to be able see all my boards.
* As a user, I want to be able create new boards.
* As a user, I want to be able to see all posts after clicking on a board.
* As a user, I want to be able to create new posts under a board.
* As a user, I want to be able to edit a post.
* As a user, I want to be able to edit a board.
* As a user, I want to be able to set boards to public.
* As a user, I want to be able to view other user's non-private boards.
* As a user, I want to be able to leave comments on viewable post (own and others).
* As a user, I want to be able to DELETE my boards, posts, or comments.
* As a user, I want to be able to send dms to other users


## **Minimum Viable Product (MVP)**

The MVP of this project is to successfully create a user-friendly web application where users can create an account and post to a message board.

Stretch goals include:

* Allow images to be posted with both the board subject and posts.
* Allow people to search the message board with specific queries.

## **Setup/Installation**

*Installing .NET Core* 

1. Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download).
2. Open the .Net Core SDK file and install.
3. Confirm the installation was successful by runnning the `$ dotnet --version` command in your terminal (You should see something like this in the response: `2.2.105`).
4. Install the dotnet script REPL tool by running the `$ dotnet tool install -g dotnet-script` command in your terminal.
5. Restart your terminal to complete the installation.

*Installing MySQL | MacOS:*

1. Download the MySQL Community Server DMG File from [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
2. You can exit the mysql program by entering `exit`.
3. Download the MySQL Workbench DMG File from [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391). (Use the No thanks, just start my download link.)
4. Install MySQL Workbench to Applications folder.
5. Open MySQL Workbench and select the `Local instance 3306 server`. You will need to enter the password you set. (We used `epicodus`.) If it connects, you're all set.

*Installing MySQL | Windows 10:*

1. Download the MySQL Web Installer from [MySQL Downloads](https://dev.mysql.com/downloads/file/?id=484919) (Use the No thanks, just start my download link.).
2. Choose `Custom` setup type.
3. When prompted to `Select Products and Features`, make sure you select both `MySQL Server` (Under MySQL Servers), and `MySQL Workbench` (Under applications).
4. When you reach `Configuration`:
  * Set `High Availability` to `Standalone`. 
  * Defaults are OK under `Type and Networking`. 
  * Set `Authentication Method` to `Use Legacy Authenticationn Method`.
  * Lastly, set your password and complete the installation process.
5. You can exit the mysql program by entering `exit`
6. Add the MySQL environment variable to the System PATH. We must include MySQL in the System Environment Path Variable. This is its own multi-step process. Instructions here are for Windows 10:
  * Open the Control Panel and visit System > Advanced System Settings > Environment Variables...
  * Then select PATH..., click Edit..., then Add.
  * Add the exact location of your MySQL installation, and click OK. (This location is likely `C:\Program Files\MySQL\MySQL Server 8.0\bin`, but may differ depending on your specific installation.)
7. Open MySQL Workbench and select the `Local instance 3306` server (it may have a different name). You will need to enter the password you set (We used `epicodus`). If it connects, you're all set.

*Cloning this repository:*

1. Open your terminal.
2. Navigate to the desired directory in which you want to clone this repository.
3. Use the command `git clone https://github.com/Todders92/My-Scribe` to clone this repository.
4. Open this repository from within your terminal and navigate to the project folder: `MyScribe/`.
5. Run the command `dotnet restore`.
6. Run the command `dotnet build`.
7. If build is successful, run the command `dotnet ef migrations add Initial`. If build failed, make necessary updates and repeat steps 5-7.
8. Run the command `dotnet ef database update`.
9. Use `dotnet run` to generate a local server.
10. Copy and paste the generated `localhost:5000` onto your URL.

*Downloading this repository:*

1. On the top right of this page, click the "Clone or download" button.
2. Click on "Download ZIP."
3. Click the downloaded file to unzip and extract this repository to your desired directory.
4. Open this repository from within your terminal and navigate to the project folder: `MyScribe/`.
5. Run the command `dotnet restore`.
6. Run the command `dotnet build`.
7. If build is successful, run the command `dotnet ef migrations add Initial`. If build failed, make necessary updates and repeat steps 5-7.
8. Run the command `dotnet ef database update`.
8. Use `dotnet run` to generate a local server.
10. Copy and paste the generated `localhost:5000` onto your URL.

## **Known Bugs**

There are no known bugs at this time.

## **Support and contact details**

If you have any questions, comments, or concerns, please feel free to contact our team at customerservice@MyScribe.net 

## **Technologies used**

* _Git 2.23.0_

* _C# language_

* _.NET Core 2.2.106_

* _dotnet script 0.50.1_

* _Visual Studio Code 1.43.1_

* _Model-View-Controller(MVC) framework_

* _MySQL 8.0.15_

* _MySQL Workbench 8.0.15_

* _Entity Framework Core 2.2.4_

* _ASP.NET Razor_

* GitBash

* RestSharp version 106.6.10

* Newtonsoft.Json version 12.0.2

## **License**

Copyright (c) 2020 **_MyScribe_**

This software is licensed under the MIT license.