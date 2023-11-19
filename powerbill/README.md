# Power Bill Calculator 

This is a simple command-line application to calculate monthly electricity bills based on power consumption and usage type.

## Features

- Accepts power consumption in kWh 
- Accepts usage type (Residential, Commercial, Industrial)
- Calculates bill based on tariff rate for the usage type
- Displays total monthly bill 

## Usage

Run the application and enter:

- Power consumption (kWh)
- Usage type 

Your monthly electricity bill will be calculated and displayed.

## Calculation Logic

The tariff rates used are:

- Residential: KES 12.50 per kWh
- Commercial: KES 15.75 per kWh  
- Industrial: KES 18.90 per kWh

The bill is calculated as:

```
Monthly Bill = Power Consumption x Tariff Rate 
```

## Possible Improvements

Some ways the app could be improved:

- Add input validation
- Allow choosing from a list of usage types
- Add different rate slabs based on consumption 
- Allow entering meter readings instead of consumption
- Save and display previous bills  
- Add SMS/email capabilities 
- Add graphical reports
- Implement monthly bill estimation
