# Strategy Pattern Example (C#)

## Overview

This example demonstrates the **Strategy design pattern** using a simple price calculation scenario.  
The goal is to show how different discount algorithms can be applied **without modifying the core calculation logic**.

Instead of using conditional statements (`if` / `else`) to select a discount, the discount behavior is encapsulated in separate strategy classes.  
The concrete strategy is chosen at runtime and injected into the calculator.

---

## Problem Statement

In many software systems, business rules such as pricing or discount logic change frequently.  
A naïve implementation often relies on conditional logic, which leads to:

- Reduced readability  
- Increased coupling  
- Difficult extensibility  
- Higher risk of errors when modifying existing code  

This example illustrates how the Strategy pattern avoids these problems.

---

## Solution Approach

The Strategy pattern defines a common interface (`IDiscountStrategy`) that represents a discount algorithm.  
Each concrete implementation encapsulates one specific discount rule.

The `PriceCalculator` class acts as the **context**.  
It does not know which discount algorithm is used; it only relies on the interface.  
This allows new discount strategies to be added **without changing the calculator code**.

---

## Project Structure

- **IDiscountStrategy**  
  Defines the contract for all discount algorithms.

- **NoDiscount / PercentageDiscount**  
  Concrete strategy implementations containing different discount logic.

- **PriceCalculator**  
  Uses a discount strategy via composition and delegates the calculation.

- **Program**  
  Selects and injects the desired strategy at runtime.

---

## Benefits of This Design

- Eliminates conditional logic for behavior selection  
- Supports the Open–Closed Principle  
- Favors composition over inheritance  
- Improves testability and maintainability  
- Allows behavior to be changed at runtime  

---

## Summary

This example shows how the Strategy pattern can be applied in a minimal and practical way.  
By separating behavior from usage, the system becomes easier to extend and adapt to changing requirements without introducing unnecessary complexity.
