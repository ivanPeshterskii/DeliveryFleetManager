# DeliveryFleetManager

# 🚚 Delivery Fleet Manager

Delivery Fleet Manager is a simple console-based C# application designed to simulate the management of a delivery van fleet. Each van has mileage and fuel, and you can interact with them through commands like delivering, refueling, and servicing.

---

## 📌 Features

- ✅ Add multiple vans at startup  
- 🚐 Deliver vans to a given distance if they have enough fuel  
- ⛽ Refuel vans up to 100 liters max  
- 🛠️ Service vans (reduce mileage, but never below 5000 km)  
- 🗑️ Automatically decommission vans reaching 150,000 km  

---

## 🏗️ Technologies Used

- C# (.NET 6 or later)
- Console application
- Object-Oriented Programming (OOP)

---

## 📥 Input Format

1. **First line** – Integer `n`: number of vans  
2. **Next n lines** – `{vanName}|{mileage}|{fuel}`  
3. **Following lines** – Commands until `"Shutdown"` is received  
4. **Commands**:
    - `Deliver : {vanName} : {distance} : {fuel}`
    - `Refuel : {vanName} : {fuelAmount}`
    - `Service : {vanName} : {kilometers}`  
5. **Final output** – Remaining vans info

---

## 📤 Output Format

- Message for each command executed  
- At the end, list of vans in format:  
  `{vanName} -> Mileage: {mileage} km, Fuel: {fuel} lt.`

---

## ▶️ Example

**Input:**
3
Ford Transit|120000|80
Mercedes Sprinter|60000|50
VW Crafter|10000|70
Deliver : Ford Transit : 20000 : 30
Refuel : VW Crafter : 50
Service : Mercedes Sprinter : 15000
Shutdown

**Output:**
Delivery van Ford Transit drove 20000 km using 30 liters
Van Ford Transit is decommissioned
Van VW Crafter refueled with 30 liters
Van Mercedes Sprinter mileage decreased by 15000 km
Mercedes Sprinter -> Mileage: 45000 km, Fuel: 50 lt.
VW Crafter -> Mileage: 10000 km, Fuel: 100 lt.

---

## ▶️ How to Run

1. Clone the repository  
2. Open in Visual Studio or any C# IDE  
3. Make sure the namespace is `DeliveryFleetManager`  
4. Run `Program.cs`  
5. Input data via console

---

## 📁 Project Structure


---

## 🧠 Learning Objectives

- Practice working with classes and methods
- Understand basic OOP principles
- Work with dictionaries and console input
- Simulate stateful applications

---

## 💡 Ideas for Future Improvements

- Add saving/loading vans from a file
- GUI version with Windows Forms or WPF
- Sorting vans by mileage or name
- Unit tests for each van method

---

## 🧑‍💻 Author

Created as a practice project for learning C# and object-oriented design.
