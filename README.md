# Name Character Analyzer

A small **C# .NET console application** that accepts a user's name, reports its length, calculates the combined numeric value of its characters, and displays the average character value.

<p>
  <img src="https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/Console-Application-555555?style=flat-square" alt="Console Application" />
  <img src="https://img.shields.io/badge/Status-Complete-238636?style=flat-square" alt="Project status: Complete" />
</p>

## Overview

Name Character Analyzer is a compact console practice project focused on user input, validation, loops, numeric calculations, string handling, and formatted output.

The application prompts for a name, rejects blank input, and then analyzes each character in the supplied value.

## Features

- Interactive console input
- Validation that prevents blank names
- Trims unnecessary leading and trailing whitespace
- Reports the total number of characters
- Calculates the combined numeric value of all characters
- Calculates the average character value
- Formats the average to two decimal places
- Separates input and calculation logic into dedicated methods

## Character Values

C# stores each `char` as a UTF-16 code unit. The application converts each character to its numeric value and adds those values together.

For example, a short name is processed conceptually like this:

```text
Character 1 value
+ Character 2 value
+ Character 3 value
= Combined character value
```

The average is then calculated as:

```text
combined character value / number of characters
```

This value is a programming exercise rather than a linguistic measurement of a name.

## Technology

| Area | Technology |
| --- | --- |
| Language | C# |
| Runtime | .NET 10 |
| Interface | Console |
| Concepts | Input validation, strings, loops, numeric calculations |

## Running the Project

### Requirements

- .NET 10 SDK, or
- Visual Studio with .NET development support

Clone the repository:

```bash
git clone https://github.com/IPFizzy/NameCharacterAnalyzer.git
cd NameCharacterAnalyzer
```

Run the application:

```bash
dotnet run
```

Or open `ConsoleMessages.slnx` in Visual Studio and run the project.

## Example Interaction

```text
Name Character Analyzer
-----------------------
Enter your name: Keon

Hello Keon, it is nice to meet you.
Your name contains 4 characters.
Combined character value: ...
Average character value: ...
```

The exact numeric values depend on the characters entered.

## Practice Project Context

This repository is intentionally small and is preserved as a completed introductory practice project. It demonstrates a clean console interaction, defensive input handling, iteration over string characters, type conversion, arithmetic, and formatted output without unnecessary complexity.

## Author

**Keon Bushman**  
Software Development Student & IT Professional  
[GitHub Profile](https://github.com/IPFizzy)
