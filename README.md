# 🧮 Avalonia Calculator

![Platform Support](https://img.shields.io/badge/Platform-Linux%20%7C%20Windows%20%7C%20macOS-success)
![.NET Version](https://img.shields.io/badge/.NET-10.0-purple)
![Framework](https://img.shields.io/badge/UI-Avalonia-red)

A cross-platform desktop calculator application built with **C#** and **Avalonia UI**.
This is my first project diving into the .NET ecosystem, transitioning from a PHP/Symfony and React background.

Developed on **Fedora Linux** 🐧 using JetBrains Rider.

## 🖼️ Preview

<!-- Take a screenshot of your app window and save it as 'screenshot.png' in your folder -->

![Calculator Preview](./screenshot.png)

## 🚀 Technologies

* **Language:** C#
* **Core:** .NET 10.0 (Bleeding Edge)
* **GUI Framework:** [Avalonia UI](https://avaloniaui.net/)
* **IDE:** JetBrains Rider
* **Architecture:** XAML for UI (Frontend) + C# Code-behind (Backend Logic)

## ✨ Features

* **True Cross-Platform:** Runs natively on Linux, Windows, and macOS without code changes.
* **Responsive Layout:** Uses XAML Grids to handle resizing.
* **Standard Math:** Basic arithmetic operations (+, -, *, /).
* **Clean UI:** Styled efficiently using Avalonia's styling system.

## 🛠️ Getting Started

### Prerequisites

* [.NET SDK 9.0 or 10.0](https://dotnet.microsoft.com/download)

### Installation & Run

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/avalonia-calculator.git
   cd avalonia-calculator
   ```
2. **Restore dependencies:**

   ```bash
   dotnet restore
   ```
3. **Run the GUI Application:**

   ```bash
   # Run directly from the project folder
   dotnet run --project CalculatorGUI
   ```

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.
