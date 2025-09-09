# C# Lesson: Increment and Decrement Operators

This repository demonstrates the use of **increment (`++`)** and **decrement (`--`)** operators in C#.  
It is designed as a simple educational project for understanding how **pre-increment / pre-decrement** and **post-increment / post-decrement** work in practice.

---

## 📌 Overview

The project is a console application that:

- Shows the difference between:
  - **Pre-increment (`++x`)** and **post-increment (`x++`)**
  - **Pre-decrement (`--x`)** and **post-decrement (`x--`)**
- Demonstrates how these operators behave inside expressions.
- Prints results to the console for better visualization.

---

## 💻 Example Code (from `Program.cs`)

```csharp
int x = 5;

// Post-increment: value is used first, then increased
Console.WriteLine(x++); // Output: 5
Console.WriteLine(x);   // Output: 6

// Pre-increment: value is increased first, then used
Console.WriteLine(++x); // Output: 7
Console.WriteLine(x);   // Output: 7

// Post-decrement
Console.WriteLine(x--); // Output: 7
Console.WriteLine(x);   // Output: 6

// Pre-decrement
Console.WriteLine(--x); // Output: 5
Console.WriteLine(x);   // Output: 5
```

---

## 📊 Expected Output

```
5
6
7
7
7
6
5
5
```

---

## 🎯 Learning Goals

- Understand the difference between **prefix** and **postfix** increment/decrement.
- See how operator order affects expressions.
- Gain confidence in using these operators correctly in conditions, loops, and calculations.

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/NikitaVakarenko/IncrementDecrementExamples.git
   ```

2. Open the solution (`.sln`) in **Visual Studio** or any IDE that supports C#.

3. Run the program:
   - In Visual Studio: press `F5` or select `Debug → Start Debugging`.
   - Or via CLI (if .NET Core is used):  
     ```bash
     dotnet run
     ```

---

## 🔧 Possible Improvements

- Add examples with increment/decrement inside **loops** (`for`, `while`).
- Demonstrate usage inside **complex expressions** (e.g., `y = ++x + x++`).
- Provide edge cases (like overflow with `int.MaxValue`).

---

## 📜 License

No specific license — free to use for learning and practice.
