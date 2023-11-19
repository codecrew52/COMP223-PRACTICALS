# PAYE Tax Calculator

This is a simple command-line application for calculating PAYE tax.

## Features

- Accepts monthly income, allowances and deductions
- Calculates taxable income
- Applies PAYE tax brackets to calculate tax
- Displays total PAYE tax amount

## Usage

Run the app and enter the following when prompted:

- Monthly income amount 
- Total allowances
- Total deductions

Your PAYE tax will be calculated and displayed.

## Calculation Logic

The taxable income is calculated as:
taxableIncome = monthlyIncome - allowances - deductions

The PAYE tax slabs used are:

- 10% for first KES 24,000
- 15% for next KES 16,000 
- 20% for next KES 20,000
- 25% for next KES 40,000
- 30% for next KES 50,000
- 35% for next KES 100,000
- 40% for amount above KES 250,000

This is implemented in the `CalculatePayeTax()` method.

## Possible Improvements

- Validate inputs better
- Add option to calculate annual tax 
- Break up tax calculation into multiple functions
- Allow saving/loading previous calculations
- Add unit tests
- Implement payroll system features like NHIF, NSSF etc.