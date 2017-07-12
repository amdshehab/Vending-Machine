
<h1 align="center"> Vending Machine</h1>

A one of a kind, interactive vending machine console application!

## Quick Start

  + Fork and download this repo.
  + Install .NET Core on your device: https://www.microsoft.com/net/core
  + cd into the vendingMachine folder and type "dotnet run" to run the application and follow the console instructions.
  + cd into the tests folder and type "dotnet test" to run tests.

## Initial Approach

My approach to this challenge will be guided by three main topics:

1. OOP & single responsibility
2. Extendability
3. TDD & good exception handling

In terms of testing, I need to unit test the main logic behind the application. Since this is a Console application; I will also have to account for bad user inputs with exception handling.

My main thoughts on the classes are as follows:

#### Item class:

  + I could just use a C# dictionary to input each item and its price. However, i feel like extending this would be a mess as you           would be left with a massive dictionary, and what if you wanted to add extra properties to the item such as description or      quantity, then the dictionary would bloat up. I have chosen to add an Item class for extendability purposes.

#### Vending Machine class:

  + This class will hold instantiated Items as an array property.

#### Printer class:

  + This class will print the main heading and ending of the application.

#### Controller class:

  + This is where all the application comes together, this class wil configure the required loops to run the program; as well as delegate user input to the appropriate class.

#### Price class:

  + This class will control the main logic behind the pricing and deal with payments. Although I could just put this in the controller, I feel like that would hinder the applications extendability.


![Screenshot](https://user-images.githubusercontent.com/25505115/27997536-d359d41e-64f1-11e7-96fc-1005f009868c.jpeg)

## Halfway through

The Vending machine's main logic has now been implemented, and the user can now successfully run the program from start to finish; all wrong inputs have been handled to loop back to previous state so the application does not exit. Now I need to focus on some main issues:

#### 1. The controller class is getting too "fat" 

  + To remedy this, I will extract the main console output functionality to a printer class which will deal with all that.

#### 2. Near duplicate exception handling methods for different cases

  + I will refactor to keep the code DRY, possibly merge the two handleInput methods into one and work with their return value to drive the direction of the program.

## Final thoughts

The printer logic is now complete and the controller class refactored, exception handling is very good and unit tests insure full functionality. The program satisfies the following aims I set out in the begining of the project:

#### Extendability: 

  + By adopting single responsability principles, this program can be easily extended; for example to add a new "item", you would just need to add the item to the Vendor class, the program would function as normal and you would not need to amend anything else.

#### OOP: 

  + This program demonstrates very good OOP principles throughout its design. 

#### Well tested and good exception handling:

  + I have unit tested the main classes in this program. Exception handling is designed to never break out of the application.


