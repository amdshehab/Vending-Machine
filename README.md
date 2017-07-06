# Vending-Machine
A vending machine console application

## Initial Approach

My approach to this challenge will be guided by three main topics:

1. OOP
2. Extendability
3. Simplicity

In terms of testing, I need to figure out not only how to unit test, but also how to black box test the application to eliminate descrepencies and uncertainty. Since this is a Console application; my tests will have to acount for wrong user input types.

My main thoughts on the classes are as follows:

1. Item class
I could just use a C# dictionary to input each item and its price. However, i feel like extending this would be a mess as you would be left with a massive dictionary, and what if you wanted to add extra properties to the item such as description or quantity, then the dictionary would bloat up. I will have to have a think about this.

2. Vending Machine class
This classe's sole responsability is to hold items.
3. Printer class
This classe's sole responsability is to print stuff out.
5. Controller class => initial program.cs 
This will be the application runner.
6. Price class => a class that calculates pricing and submits change. Although I could just put this in the controller, I feel like that would hinder the applications extendability.

## Intermediate Approach

The Vending machine's main logic has now been implemented, and the user can now successfully run the program from start to finish; all wrong inputs have been handled to loop back to previous state so the application does not exit. Now I need to focus on some main issues:

1. The controller class is getting too "fat" 
To remedy this, I will extract all the console WriteLine functionality to a printer class which will deal with all that.
2. Long "if-else" statements for exception handling in controller class
I will refactor to keep the code DRY, possibly merge the two handleInput methods into one and work with their return value to drive the direction of the program.
3. Exception handling methods are untested
I will test the "merged" handleInput method to insure that exception handling acounts for all cases.


