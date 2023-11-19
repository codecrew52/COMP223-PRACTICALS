# Water Bill Calculator

This is a simple command-line application for calculating monthly water bills based on usage. 

## Features

- Accepts water consumption in cubic meters
- Accepts usage type (residential, commercial, industrial)
- Calculates bill based on water tariff for the usage type  
- Displays a summary of the bill

## Usage

Run the application and enter:

- Water consumption (cubic meters)  
- Usage type

Your monthly water bill will be calculated and a summary displayed.

## Calculation

The water tariffs used are:

- Residential: KES 25 per cubic meter
- Commercial: KES 30.50 per cubic meter
- Industrial: KES 35.75 per cubic meter

The bill is calculated as:

```
Total Bill = Water Consumption x Rate 
```

## Output

The application displays a summary of the bill including:

- Usage type
- Consumption 
- Rate
- Total bill

The currency is formatted appropriately.

## Possible Improvements

Some ways the app could be improved:

- Better input validation
- Allow entering meter readings instead of consumption 
- Add different rate slabs based on consumption
- Save/load previous bills
- Send bills via SMS, email
- Add charts/graphs in the summary
- Estimate monthly bills
