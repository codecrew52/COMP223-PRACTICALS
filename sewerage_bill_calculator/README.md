# Sewerage Bill Calculator

This is a simple command-line application to calculate monthly sewerage bills based on water consumption and usage type.

## Features

- Accepts water consumption in cubic meters
- Accepts usage type (Residential, Commercial, Industrial)  
- Calculates sewerage bill based on rates
- Displays monthly sewerage bill

## Usage

Run the app and enter:

- Water consumption (cubic meters)
- Usage type

Your monthly sewerage bill will be calculated and displayed.

## Calculation Logic

The sewerage rates used are:

- Residential: KES 10 per cubic meter
- Commercial: KES 12.50 per cubic meter
- Industrial: KES 15 per cubic meter 

The bill is calculated as:

```
Monthly Bill = Water Consumption x Rate
```

This calculation is done in the `CalculateBill()` method.

## Possible Improvements

Some ways the app could be enhanced:

- Input validation
- Allow choosing usage type from list 
- Add different rate slabs based on consumption
- Accept meter readings instead of consumption
- Save/display previous bills
- Add SMS/email capabilities
- Add graphical reports
- Estimate monthly bills
