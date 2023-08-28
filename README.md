# OOP_C_sharp

FR: Ceci est la propriété d'Anna Skoryk, toute copie et mise en libre accès est interdite ! Ce projet est pour référence seulement.

ENG: This is the property of Anna Skoryk, any copying and placing in free access is prohibited! This project is for reference only.

Lab2:
Task. Create the Money class by designing the following class elements:
Fields:
▪ int first;//denomination of the bill
▪ int second; //number of bills
A constructor that allows you to create an instance of a class with the given
the value of the fields.
Methods that allow:
▪ display denomination and number of bills;
▪ to determine whether there are enough funds for the purchase of goods in the amount of N hryvnias.
▪ determine how many pieces of goods worth n hryvnias. can be bought at
available funds.
Properties:
▪ which allows you to get and set the field values (available for
reading and writing);
▪ which allows you to calculate the amount of money (only available for
reading).

Lab3:
Task. Create a class Car that has public car properties Name, Speed, a constructor with two parameters, and a public method that outputs information about the car. Create derived classes: Car (carries passengers), Truck (carries goods), Tractor (pulls a trailer) with its own methods of displaying information on the screen. Create an array of cars, where there is at least one object of all types of cars. Display information about all cars on the screen. Display the name of the car with the highest speed.

Lab4:
Task. There is a class diagram: bird (Bird) - abstract base class, eagle (Eagle) and duck (Duck) - derived classes. The Bird class has abstract methods Eat() and Move(). Each of the derived classes overrides the Eat(), Move() methods of the base class. Develop a console program that uses the principle of polymorphism to output text messages about the movement and eating of an eagle and a duck. For this, the program must:
1. Create a stack (object of the System.Collections.Stack class).
2. Create by reference to the Bird type one object of the Eagle and Duck classes and add them to the stack. 3. Using the foreach loop operator, call the Eat(), Move() methods for each element of the stack.

Lab5:
Task. There is a Bird class, which has two auto properties: Name – the name of the bird and Weight – the weight of the bird. Based on the standard typed List collection, create a collection of Bird type objects to which four birds are added: chicken (weight 3 kg), goose (weight 7 kg), duck (weight 5 kg), turkey (weight 10 kg). Using LINQ technology, make queries and display the following information:
1. List of all birds, ordered by their weight.
2. Names of birds that begin with the letter `k'. (note - in Ukrainian, all three birds have names starting with the letter 'k')
3. List of all birds heavier than 6 kg, ordered by decreasing weight.
