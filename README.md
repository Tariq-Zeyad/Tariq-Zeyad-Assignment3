<div align="center">

# C# Basics Assignment

### Assignment 1–3 | C# Fundamentals

<p>
A practical C# console application covering basic language concepts,
memory management, scope, operators, and problem solving.
</p>

<img src="https://raw.githubusercontent.com/dotnet/brand/main/logo/dotnet-logo.png" width="180">

<br>

<img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white">
<img src="https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=csharp&logoColor=white">
<img src="https://img.shields.io/badge/Project-Console%20App-blue?style=flat-square">

</div>

---

## About The Project

This project was created as part of a C# programming assignment.

The main goal was to practice the basic concepts of C# by writing small examples and testing them directly in a console application.

The project covers:

* C# data types and conversions
* Value types and reference types
* Stack and heap memory
* Scope and operators
* Bitwise operations
* XOR problem solving
* C# project configuration
* XML documentation and code organization

---

## Technologies Used

| Technology   | Version             |
| ------------ | ------------------- |
| C#           | C#                  |
| .NET         | 10.0                |
| IDE          | Visual Studio       |
| Project Type | Console Application |

---

## Project Structure

```text
CSharpBasicsAssignment/
│
├── Program.cs
├── Order.cs
├── STACK_HEAP.md
├── ANSWERS.md
├── CSharpBasicsAssignment.csproj
└── README.md
```

---

# Assignment Parts

## Part A — C# Basics

The first part focuses on the basic C# types and how values are handled.

Topics covered:

* Integer and floating-point types
* `string`
* `bool`
* `char`
* `decimal`
* `long`
* `GetType()`
* Implicit and explicit conversions
* Integer division
* Boxing and unboxing
* `Parse()`
* `TryParse()`

The project also uses the following settings:

```xml
<TargetFramework>net10.0</TargetFramework>
<ImplicitUsings>enable</ImplicitUsings>
<Nullable>enable</Nullable>
```

---

## Part B — Type Conversion and Parsing

This part continues working with different C# types and conversions.

Examples include:

* Converting between numeric types
* Explicit casting
* `Convert.ToInt32()`
* `Parse()`
* `TryParse()`
* Working with `float` and `decimal`

The examples were kept simple so the difference between each operation can be seen directly from the console output.

---

## Part C — Value Types and Reference Types

This part demonstrates the difference between a `struct` and a `class`.

A simple `Point` struct was used to show value type behavior.

```csharp
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;

p2.X = 99;
```

Changing `p2.X` does not change `p1.X` because the struct value is copied.

The project also contains an `Order` class with different fields and methods.

```csharp
Order order = new Order();
```

Since `Order` is a class, assigning it to another variable copies the reference to the same object.

```csharp
Order order2 = order;
```

Both variables therefore point to the same object in memory.

---

## Part D — Scope & Operators

Part D focuses on variable scope and different types of operators.

### Scope

The project demonstrates:

* Field scope
* Method scope
* Block scope

For example, a variable declared inside a `for` loop cannot be accessed after the loop because it is outside its scope.

### Compound Assignment Operators

The following operators were tested:

```text
+=
-=
*=
/=
%=
```

Starting from:

```csharp
int total = 100;
```

The value is changed and printed after each operation.

### Bitwise Operators

The project also demonstrates:

```text
&
|
^
```

Using:

```csharp
int a = 12;
int b = 10;
```

The binary values were also included in the comments to show how the operations work bit by bit.

---

## Part E — Stack & Heap

`STACK_HEAP.md` explains how objects are stored and referenced in memory.

The following sequence was used:

```csharp
Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };
Order o2 = o1;
o2.IsPaid = true;
```

The document contains three diagrams showing:

1. `o1` pointing to an `Order` object on the heap.
2. `o2` pointing to the same object as `o1`.
3. The `IsPaid` field changing while both references still point to the same object.

It also compares this behavior with the `Point` struct from Part C.

---

## Part F — LeetCode 136

The project includes a solution for:

**LeetCode 136 — Single Number**

The solution uses the XOR operator:

```csharp
private static int FindSingleNumber(int[] nums)
{
    int result = 0;

    foreach (int num in nums)
    {
        result ^= num;
    }

    return result;
}
```

The important XOR rules used here are:

```text
x ^ x = 0
x ^ 0 = x
```

When every number appears twice except one, the duplicate values cancel each other out and the single value remains.

### Example

```text
Input:  [4, 1, 2, 1, 2]
Output: 4
```

The solution uses:

```text
Time:  O(n)
Space: O(1)
```

No sorting, dictionary, or extra array is used.

---

## Part G — Short Answers

`ANSWERS.md` contains short answers about:

* The `.csproj` file
* `#region` and `#endregion`
* XML documentation comments
* Global variables in C#

The answers are based on the C# concepts used throughout the project.

---

# What I Practiced

Through this assignment, I practiced several C# fundamentals:

```text
Data Types
    ↓
Conversions & Parsing
    ↓
Value Types & Reference Types
    ↓
Stack & Heap
    ↓
Scope
    ↓
Compound Operators
    ↓
Bitwise Operators
    ↓
XOR Problem Solving
```

Each part was implemented as a small example so the result could be tested and understood directly from the console.

---

## Files

### `Program.cs`

Contains the main program and the examples for the different assignment parts.

### `Order.cs`

Contains the `Order` class used in Part C and Part E.

### `STACK_HEAP.md`

Contains the stack and heap diagrams required for Part E.

### `ANSWERS.md`

Contains the short-answer questions from Part G.

### `CSharpBasicsAssignment.csproj`

Contains the project configuration and targets `.NET 10`.

---

## How to Run

Clone the repository and open the project in Visual Studio.

Then build and run the console application.

You can also run it from the terminal:

```bash
dotnet run
```

---

## Final Notes

This project is mainly focused on understanding how C# works rather than building a large application.

Each part was implemented separately to practice a specific concept and then test it through the console.

---

<div align="center">

### C# • .NET 10 • Console Application

</div>
