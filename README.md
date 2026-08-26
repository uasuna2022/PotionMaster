# Potion Master

![C#](https://img.shields.io/badge/-C%23-512BD4)
![.NET](https://img.shields.io/badge/-.NET-512BD4)
![WinForms](https://img.shields.io/badge/-WinForms-blue)

**Potion Master** is a **single-player WinForms puzzle game** where the goal is to **sort multi-colored liquids** across vials until each vial contains only a **single uniform color**.

Players move liquid between vials by pouring the **top color segment** into another vial matching that same top color (or into an **empty helper vial**). The game features 3 difficulty levels (**Easy**, **Medium**, and **Hard** providing **3, 2, or 1 helper vials**), configurable **vial and segment counts**, and a **Light/Dark theme** setting.

---

## Demonstration

![Demonstration](demo.gif)

---

## Requirements & Setup

### Prerequisites
* **.NET 6.0 SDK** or higher
* **Windows OS** (WinForms requirement)
* **Visual Studio 2022** / **JetBrains Rider** / **VS Code**

### Building and Running

1. **Clone the repository**:
   ```pwsh
   git clone https://github.com/uasuna2022/PotionMaster.git
   cd PotionMaster
   ```

2. **Build the solution**:
   ```pwsh
   dotnet build PotionMasterNew.sln
   ```

3. **Run the application**:
   ```pwsh
   dotnet run --project PotionMasterNew/PotionMasterNew.csproj
   ```
