<div align="center">

# 💻 `&` vs `&&` in C#

### They look almost the same... but do they really work the same? 👀

</div>

---

## 🔎 A few hints

> **Hint 01:** One works with bits.

> **Hint 02:** One works with conditions.

> **Hint 03:** One can skip evaluating the second condition.

So...

### Can you tell which one is which? 🤔

---

## 💡 The answer

`&` is the **Bitwise AND** operator.

It works directly with the bits of integer values:

```csharp
int a = 12; // 1100
int b = 10; // 1010

int result = a & b; // 1000 = 8
```

While `&&` is the **Logical AND** operator:

```csharp
if (user != null && user.IsActive)
{
    // Continue
}
```

The useful part to remember is that `&&` uses **short-circuit evaluation**.

If the first condition is `false`, C# does not evaluate the second condition.

---

## 🧠 Quick way to remember

<div align="center">

### `&` → Bits

### `&&` → Conditions

</div>

It's a small difference, but knowing when to use each operator can help avoid bugs and make your C# code easier to understand.

---

## 🔗 LinkedIn Post

https://www.linkedin.com/posts/tariq-zeyad-a6025740b_csharp-dotnet-programming-activity-7505996986484039680-nEnp

---

