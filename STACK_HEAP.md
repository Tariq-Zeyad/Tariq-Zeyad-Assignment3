<div align="center">

# Stack and Heap

### Value Types and Reference Types

</div>

---

## Introduction

In this part of the assignment, I worked with a `struct` and a `class` to see the difference between value types and reference types in C#.

I also used an `object` variable to check what happens when a reference-type object is assigned to `object`.

---

## 1. Value Type — `struct`

`Point` is a `struct`, so it is a value type.

I created two variables and assigned `p1` to `p2`:

```csharp
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;

p2.X = 99;
```

The important thing here is that `p2` gets a copy of the values from `p1`.

```text
p1                    p2
┌─────────────┐       ┌─────────────┐
│ X = 1       │       │ X = 99      │
│ Y = 2       │       │ Y = 2       │
└─────────────┘       └─────────────┘
      separate copies of the data
```

So the output is:

```text
p1.X = 1
p2.X = 99
```

Changing `p2.X` does not change `p1.X`.

---

## 2. Reference Type — `class`

`Order` is a class, so it is a reference type.

For the second test, I used:

```csharp
Order order2 = order;
order2.IsPaid = true;
```

In this case, `order2` does not create another `Order` object. Both variables refer to the same object.

```text
order ────────┐
              ▼
        ┌──────────────┐
        │ Order object │
        │ IsPaid=true  │
        └──────────────┘
              ▲
              │
order2 ───────┘
```

Because they refer to the same object:

```text
order.IsPaid  = True
order2.IsPaid = True
```

This is the main difference from the `Point` example. With the struct, the values were copied. With the class, the reference to the object was copied.

---

## 3. Assigning `Order` to `object`

I also tested the following:

```csharp
object boxedOrder = order;
Order order3 = (Order)boxedOrder;
```

Even though the variable is called `boxedOrder`, this is **not boxing**.

Boxing happens when a value type is converted to `object`, for example:

```csharp
int number = 10;
object value = number;
```

`Order` is a class, so it is already a reference type. Assigning it to `object` keeps the same reference.

I checked this using:

```csharp
object.ReferenceEquals(order, order3)
```

The result is:

```text
True
```

This means that `order` and `order3` are referring to the same `Order` object.

---

## Quick Comparison

| Example            | Type           | What happens when assigned? |
| ------------------ | -------------- | --------------------------- |
| `Point`            | Value type     | The value is copied         |
| `Order`            | Reference type | The reference is copied     |
| `int` → `object`   | Value type     | Boxing occurs               |
| `Order` → `object` | Reference type | The same reference is kept  |

---

## Final Notes

The main idea I learned from these examples is that **value types and reference types behave differently when assigned**.

A `struct` such as `Point` gives the new variable its own copy of the data. A `class` such as `Order` gives the new variable a reference to the same object.

Also, assigning an `Order` object to `object` is not boxing because `Order` is already a reference type.
