# Strategy Pattern with Tax Calculator

This project is a simple and practical demonstration of the **Strategy Design Pattern** using a tax calculator example. A single API with one endpoint was developed to illustrate how different tax calculation algorithms can be selected and used at runtime.

---

## What is the Strategy Design Pattern?

The Strategy is a **behavioral design pattern** that enables selecting an algorithm at runtime. It lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable. This allows the algorithm to vary independently from clients that use it.

In other words, instead of an object implementing a behavior directly, it receives a "strategy" object that implements that behavior. 

---

## Practical Example: Tax Calculator

In this project, the tax calculation is our "behavior" that can vary. We have different types of taxes, and each one has a specific calculation method. The Strategy pattern allows us to encapsulate each calculation logic in its own class.

The API endpoint receives the type of tax to be calculated and, based on that, selects the corresponding calculation strategy **without the need for multiple `if/else` or `switch/case` statements** in the main code.

---

## Project Structure

The project is organized as follows:

* **Controller**: Responsible for receiving HTTP requests.
* **Service**: Contains the main business logic, including the "Context" of our Strategy pattern.
* **Strategy**:
    * `TaxType` (Interface): Defines the contract that all tax calculation strategies must follow.
    * `ICMS`, `ISS`, etc. (Concrete Classes): Each class implements the `TaxType` interface with its specific calculation logic.
