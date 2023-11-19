# Currency Converter

This is a simple currency converter command-line application. 

## Features

- Convert between 4 currencies:
  - USD - US Dollar
  - EUR - Euro
  - JPY - Japanese Yen 
  - KES - Kenyan Shilling
- Enter source currency code
- Enter target currency code 
- Enter amount to convert
- Displays converted amount

## Usage

Run the application and follow the prompts:

- Enter source currency code 
- Enter target currency code
- Enter amount to convert

The converted amount will be displayed.

## Implementation

The app is implemented in C# using .NET Core.

It uses a dictionary to store the exchange rates between currencies. The user input is validated and the appropriate exchange rate is looked up to perform the conversion.

### Possible Improvements

- Add more currencies 
- Lookup exchange rates from a web API
- Store rates in a file/database rather than hardcoded
- Add input validation
- Round converted amount properly 
- Allow user to convert multiple amounts
- Record conversion history
- Add unit tests

## License

This project is open source and licensed under the MIT license. be free to use and modify the code as needed.