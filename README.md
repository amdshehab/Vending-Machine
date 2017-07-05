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

