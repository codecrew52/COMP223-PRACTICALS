# Calculator App

This is a simple calculator command-line application that evaluates mathematical expressions.

## Usage

Run the application and enter a mathematical expression like:

5 + 6

The app will print out the result of evaluating the expression.

To exit, type `exit`

## Implementation

The app is implemented in C# using .NET Core. 

It uses a DataTable to evaluate expressions by adding the input as a row and then reading the parsed result.

### Features

- Evaluate addition, subtraction, multiplication, division and parentheses
- Exits when user types "exit"
- Displays error messages for invalid expressions

### Limitations

- Only supports basic arithmetic operations
- No advanced math functions like trig, logs etc
- Limited error handling

### Possible Improvements

- Add support for more complex expressions
- Implement advanced math functions
- Improve input validation
- Add unit tests
- Allow variable assignments
- Add memory capabilities
- Implement exponentiation, modulo operators
- Allow multiline expressions
- Add graphing capabilities