# MyScribe
### By **Keturah Howard, Jose Amesquita, Todd Wallraven, James Carlos**  April 6th 2020

Repo holding ASP.NET core MVC application to display views that interact with the CatBoardApi application and the Api.

## Specifications 

### user stories:

* As a user, I want to be able see all my boards.
* As a user, I want to be able create new boards.
* As a user, I want to be able to see all posts after clicking on a board.
* As a user, I want to be able to POST boards.
* As a user, I want to be able to POST posts to boards.
* As a user, I want to be able to POST comments to posts.
* As a user, I want to be able to PUT/Update specific boards.
* As a user, I want to be able to PUT/Update specific posts.
* As a user, I want to be able to DELETE specific boards.
* As a user, I want to be able to DELETE specific posts.


### API Endpoints

BOARDS
```
GET /api/boards
POST /api/boards
GET /api/boards/{boardId}
PUT /api/boards/{boardId}
DELETE /api/boards/{boardId}
```

POSTS
```
GET /api/boards/{boardId}/Posts
POST /api/boards/{boardId}/Posts
GET /api​/boards​/{boardId}​/Posts​/{id}
PUT /api​/boards​/{boardId}​/Posts​/{id}
DELETE /api/boards/{boardId}/Posts/{id}
PATCH /api​/boards​/{boardId}​/Posts​/{id}​/upvote
PATCH /api/boards/{boardId}/Posts/{id}/downvote
```

COMMENTS (*- Interface: work in progress -*)
```
GET /api/boards/{boardId}/posts/{postId}/Comments
POST /api/boards/{boardId}/posts/{postId}/Comments
GET /api/boards/{boardId}/posts/{postId}/Comments/{id}
PUT /api/boards/{boardId}/posts/{postId}/Comments/{id}
DELETE /api/boards/{boardId}/posts/{postId}/Comments/{id}
```


## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

In terminal, located in your desktop directory...

1. Clone the repository:
    ```
    git clone https://github.com/KeturahDev/CatBoard.git
    ```
2. Open repo in VSCode - Do so manually, or type into terminal:
    ```
    Code CatBoard
    ```

### Application Setup
*Let's start up the Api*

3. Navigate to Api folder:
    ```
    cd CatBoardApi
    ```
4. Restore all dependencies:
    ```
    dotnet restore
    ```

5. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```
*Now to do the same thing for the interface*

6. Navigate to Interface directory:
    ```
    cd ..
    cd CatBoardInterface
    ```
7. Restore all dependencies:
    ```
    dotnet restore
    ```

8. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```
 ### Opening the Program
 
 open the **localhost:5010** link that shows in the terminal, and enjoy!

## Technologies Used

* C#
* ASP.NET core MVC 2.2
* RestSharp API
* Newtonsoft.Json
* Git
* Entity Framework Core
* Swashbuckle 5.2.1
* Pomelo.EntityFrameworkCore.MySql 2.2.1
* MySqlConnector 

## External Assets
* MySqlWorkBench
* Postman

## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email us at 
* keturah.dev@gmail.com.
* jamisoncozart@gmail.com

## License

Licensed under the MIT license.

&copy; 2020 Keturah Howard, Jamison Cozart, Dusty McCord, Zakkrey Short.