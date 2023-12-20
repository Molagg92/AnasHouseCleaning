# _ana's House Cleaning1_

#### _A Capstone project , still in the works, brough to you by Erik Zambrano._

#### By Erik Z./Molagg92

## Technologies Used

* _C#_
* _.NET v6.0_
* _Git_
* _VSCode_

## Description

![Alt text](image.png)

_A list of Clients, employees, Services, and a calandar to tie it all togetehr!_

## Setup/Installation Requirements

* `git clone https://github.com/Molagg92/AnasHouseCleaning.git`Using this comman in the desktop directory will clone down the project to your machine.
* You will want to navigate to teh project directory type comman `cd AnasHouseCleaning` from the Desktop directory
* Once inside the project folder "Capstone", build an appsettings.json file, copy the following into it (replace the password with your server MySQL server passwor)_
* ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=capstone_page;uid=root;pwd=[!Yourpassword!];"
    }
  } 
* _After this, give commane `$ dotnet ef database update` for the databade_ 
* _Then type `dotnet build` in your terminal to make sure everything is up to date and there are no errors_
* _Then launch the webpage by typing `dotnet watch run --launch-profile "production"` in the teminal_
* _For issuing and trusting a security certificate, type `dotnet dev-certs https --trust` in the terminal and restart your browser_

## Known Bugs

* still a work in progress

## License

MIT License

Copyright (c) [2023] [Erik Z.]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

_If you run into any issues or have questions, ideas or concerns, please reach out to me via email: E92Zambrano@outlook.com.  Contributions to the code are highly encouraged._