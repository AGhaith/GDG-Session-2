# **Gym Fitness Management System Using Abstract Classes and Interfaces**

## **Objective**

Develop a program to practice **abstract classes, interfaces, and polymorphism** by modeling a **gym fitness management system**.

## **Task Overview**

### **1. Create an Abstract Class - `Member`**

Define an abstract class `Member` with the following properties and methods:

### **Properties:**

- `MemberID` (integer)
- `Name` (string)
- `Age` (integer)

### **Abstract Methods:**

- `CalculateMonthlyFee()`: Calculates the monthly fee for a member.
- `DisplayDetails()`: Displays the details of a member.

### **2. Create Derived Classes - `RegularMember` and `PremiumMember`**

### **`RegularMember` Class:**

- **Additional Property:**
  - `WorkoutPlanFee` (double)
- **Implementation of `CalculateMonthlyFee()`**:
  - Base fee: **$50** + `WorkoutPlanFee`.

### **`PremiumMember` Class:**

- **Additional Properties:**
  - `PersonalTrainerFee` (double)
  - `DietPlanFee` (double)
- **Implementation of `CalculateMonthlyFee()`**:
  - Base fee: **$100** + `PersonalTrainerFee` + `DietPlanFee`.

### **3. Implement an Interface - `IGymManagement`**

Define an interface `IGymManagement` with the following methods:

- `AddMember(Member member)`: Adds a new member to the gym.
- `DisplayAllMembers()`: Displays details of all members.

### **4. Create the `Gym` Class**

- Implement the `IGymManagement` interface.
- Use a **list** to store members.
- Implement methods to **add members** and **display all member details**.

### **5. Implement the `Main` Method**

- Instantiate the `Gym` class.
- Add at least **two members of each type** (`RegularMember` and `PremiumMember`).
- Display the **details and monthly fees** of all members.

## **Example Output**

```
Created New Member [Member Name] With ID [ID]
Created New Member [Member Name] With ID [ID]
Created New Member [Member Name] With ID [ID]
Created New Member [Member Name] With ID [ID]
Member Number : [ID] Was Successfully Added.
Member Number : [ID] Was Successfully Added.
Member Number : [ID] Was Successfully Added.
Member Number : [ID] Was Successfully Added.
---
Member Details
---
ID : [ID]
Name : [Member Name]
Age : [Age]
Monthly Fee = [Calculated Fee]
---
...
```

## **Requirements**

✔ Utilize **abstract classes** and **interfaces** effectively.

✔ Implement **polymorphism** to handle different member types.

✔ Include **meaningful comments** explaining code logic.
