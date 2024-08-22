# PS2000 GUI Application

This project is a graphical user interface (GUI) for the PS2000 series power supply. The GUI is designed to interact with the device, display its properties, and allow users to control various settings such as voltage and current. 

## Table of Contents
- [Project Overview](#project-overview)
- [Software Architecture](#software-architecture)
- [Design Patterns](#design-patterns)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Project Overview

The PS2000 GUI Application provides a user-friendly interface for controlling and monitoring the PS2000 series power supply. It is built using .NET 6 and utilizes the System.IO.Ports NuGet package for serial communication with the device.

## Software Architecture

This section focuses on the software architecture of the PS2000 GUI Application, informed by the principles discussed in *Software Architecture in Practice* by Bass et al. 

### Key Architectural Components

- **Device Communication Layer**: Handles the communication between the GUI and the PS2000 power supply via serial ports.
- **GUI Layer**: Displays device information and controls. The GUI is built to be intuitive and permanent information such as device type, serial number, nominal voltage, current, article number, manufacturer, and software version are displayed on startup and remain visible until the program is closed.
- **Control Logic**: Manages user interactions, such as setting voltage and current, and enabling or disabling power output and remote control.

### Architectural Styles and Patterns

- **Layered Architecture**: The application follows a layered architecture with distinct responsibilities segregated across different layers.
- **Model-View-Controller (MVC)**: The GUI application leverages the MVC pattern to separate concerns:
  - **Model**: Represents the data related to the PS2000 device.
  - **View**: Manages the presentation layer and user interface.
  - **Controller**: Handles user inputs and updates the Model and View accordingly.

### Design Considerations

- **Modularity**: The architecture is modular, enabling easy updates and maintenance.
- **Scalability**: Designed to be scalable for future enhancements and support for additional devices.

## Design Patterns

This project implements the following design patterns:

- **Singleton**: Ensures a single instance of the communication manager, which handles the interaction between the application and the PS2000 power supply.
- **Observer**: The GUI components observe changes in the data model and update the display accordingly.
- **Factory Method**: Used for creating instances of communication objects depending on the type of device detected at startup.

## Features

- **Automatic Device Detection**: On startup, the application detects and displays the device type, serial number, nominal voltage, current, article number, manufacturer, and software version.
- **Real-Time Monitoring**: Users can view the current voltage and current in real-time by pressing the respective buttons.
- **Control Capabilities**: Users can set the desired voltage and current, and toggle the power output and remote control functionalities.

## Installation

Ensure you have .NET v6 or higher installed on your machine. You can download it [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

### Steps:

1. **Clone the repository:
   ```bash
   git clone https://github.com/yourusername/PS2000.git
   cd PS2000
   
2. **Install required NuGet packages:
   ```bash
   dotnet add package System.IO.Ports
   
3. **Download and install the necessary drivers from the product page**:  
   [Product Page Link](https://elektroautomatik.com/shop/en/products/programmable-dc-laboratory-power-supplies/dc-laboratory-power-supplies/series-ps-2000b-br-100-up-to-332-w/728/power-supply-0...84v/0...3a/100w?c=623)

4. **Check the COM port (likely COM3) in the Device Manager**:  
   - Go to `Control Panel -> Device Manager -> Ports (COM & LPT)`  
   - Identify the port assigned to the PS2000 device.
