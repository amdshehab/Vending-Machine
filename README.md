# Vending-Machine
A vending machine console application

## Initial Approach

My approach to this challenge will be guided by three main topics:

1. OOP
2. Extendability
3. Simplicity

In terms of testing, I need to figure out not only how to unit test, but also how to black box test the application to eliminate descrepencies and uncertainty. Since this is a Console application; my tests will have to acount for wrong user input types.

My main thoughts on the classes are as follows:

#### Item class:

- I could just use a C# dictionary to input each item and its price. However, i feel like extending this would be a mess as you would be left with a massive dictionary, and what if you wanted to add extra properties to the item such as description or quantity, then the dictionary would bloat up. I will have to have a think about this.

#### Vending Machine class:

- This classe's sole responsability is to hold items.

#### Printer class:

- This classe's sole responsability is to print stuff out.

#### Controller class => initial program.cs:

- This will be the application runner.

#### Price class => a class that calculates pricing and submits change:

- Although I could just put this in the controller, I feel like that would hinder the applications extendability.

![Screenshot](https://user-images.githubusercontent.com/25505115/27997536-d359d41e-64f1-11e7-96fc-1005f009868c.jpeg)

## Intermediate Approach

The Vending machine's main logic has now been implemented, and the user can now successfully run the program from start to finish; all wrong inputs have been handled to loop back to previous state so the application does not exit. Now I need to focus on some main issues:

1. The controller class is getting too "fat" 
To remedy this, I will extract all the console WriteLine functionality to a printer class which will deal with all that.
2. Long "if-else" statements for exception handling in controller class
I will refactor to keep the code DRY, possibly merge the two handleInput methods into one and work with their return value to drive the direction of the program.
3. Exception handling methods are untested
I will test the "merged" handleInput method to insure that exception handling acounts for all cases.


## Final Approach

The printer logic is not complete and the controller class refactored, exception handling is very good and unit tests insure full functionality. The program satisfies the following aims I set out in the begining of the project:

1. Extendability: By adopting single responsability principles, this program can be easily extended; for example to add a new "item", you would just need to add the item to the Vendor class, the program would function as normal and you would not need to amend anything else.

2. OOP: This program demonstrates very good OOP principles throughout its design.

3. Simplicity: Becuase everything is seperated out, no class is "fat", all classes are designed with simplicity in mind.

I will now complete the class diagram and refactor anything remaining.
