# Lab 1

## 1. DRY
- In the code were used methods to avoid repeating code.

## 2. KISS
- The project written as simply as possible, each class fulfills its main function without unnecessary complications.

## 3. SOLID - Single Responsibility Principle
- Each class in the code performs its specific function. For example, the [Product](lab1/Lab1/ClassLibrary1/Product.cs) class is responsible for product presentation, [Warehouse](lab1/Lab1/ClassLibrary1/Warehouse.cs) for warehouse management, and so on

## 4. SOLID - Open/Closed Principle
- Classes that represent different currencies ([Hryvnya](lab1/Lab1/ClassLibrary1/Hryvnya.cs) and other) can be extended to change the behavior by adding new classes for new currencies, without requiring changes to existing code.

## 5. SOLID - Liskov Substitution Principle
- Child classes that represent different currencies can be used in place of the [Money](lab1/Lab1/ClassLibrary1/Money.cs) base class without changing the expected result.

## 6. YAGNI
- The code does not contain functionality or components that are not needed in the current context

## 7. Program to Interfaces not Implementations
- The [Product](lab1/Lab1/ClassLibrary1/Product.cs) class uses the [Money](lab1/Lab1/ClassLibrary1/Money.cs) abstraction instead of concrete implementations.
