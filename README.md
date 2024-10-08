# PS2000 GUI Application

This project is a graphical user interface (GUI) for the PS2000 series power supply. The GUI is designed to interact with the device, display its properties, and allow users to control various settings such as voltage and current. 

## This project was optional project tasked in the course in Software architecture and design


## Project Overview

The PS2000 GUI Application provides a user-friendly interface for controlling and monitoring the PS2000 series power supply. It is built using .NET 6 and utilizes the System.IO.Ports NuGet package for serial communication with the device.

## Software Architecture

This section focuses on the software architecture of the PS2000 GUI Application, informed by the principles discussed in *Software Architecture in Practice* by Bass et al. 
### Key Features Implemented

- **Device Information Display on Startup**: 
  - Upon startup, the application checks the following details and displays them on the GUI:
    - **Device Type**
    - **Serial Number** (with a validation against the actual serial number on the back of the PS2000)
    - **Nominal Voltage (U)**
    - **Nominal Current (I)**
    - **Article Number**
    - **Manufacturer**
    - **Software Version**
  - These values are displayed permanently in the GUI until the program is closed.

- **Real-Time Monitoring and Control**:
  - **Display Current Voltage (U)**: The current voltage is shown in the GUI upon button press.
  - **Display Current Current (I)**: The current is shown in the GUI upon button press.
  - **Set Desired Voltage (U)**: Allows the user to set the desired voltage through the GUI.
  - **Set Desired Current (I)**: Allows the user to set the desired current through the GUI.

- **User-Enabled Features**:
  - **Switch Power Output On/Off**: The GUI allows the user to toggle the power output.
  - **Switch Remote Control On/Off**: The GUI allows the user to toggle the remote control functionality.


### Design Considerations

- **Modularity**: The architecture is modular, enabling easy updates and maintenance.
- **Scalability**: Designed to be scalable for future enhancements and support for additional devices.

## Design Patterns

This project implements the following design patterns:

## Design Patterns and Practices

### Factory Method

The project utilizes the **Factory Method** pattern within the `Factory` class to create instances of different power supplies (`PS2000`, `PS3000`, `TestPsu`). This approach provides flexibility and encapsulates the object creation logic, making it easier to manage and extend.

Here’s an example of the `Factory` class:

```csharp
using PSULibrary;
using System;

namespace PS2000
{
    public static class Factory
    {
        public static PSULibrary.IPSU CreatePSU(string name)
        {
            IPSU psu = null;

            if (name.ToUpper() == "PS2000")
                psu = new Ps2000();
            else if (name == "Ps3000")
                psu = new Ps3000();
            else if (name == "Test")
                psu = new TestPsu();
            return psu;
        }

        public static PSULibrary.IPSU CreatePSU()
        {
            IPSU psu = new Ps2000();
            return psu;
        }
    }
}
```

## Dependency Injection
The project implicitly supports Dependency Injection through the use of interfaces (IPSU). By returning an interface (IPSU) from the Factory, the code allows for dependency injection, which promotes loose coupling and makes the system easier to test and maintain.

## Deferred Binding
Deferred Binding is achieved in this implementation by deciding which specific power supply class to instantiate based on the input provided to the CreatePSU method. This pattern allows the exact type of object to be determined at runtime, enabling greater flexibility.

## Custom Library Usage
The project makes use of a custom library (`PSULibrary`) that provides an interface (`IPSU`). This interface is central to the interaction with different power supply units, ensuring that the `Factory` can return any power supply type that implements this interface. This approach promotes a consistent API and makes it easier to add new power supply types in the future. Additionally, it ensures that the interface is completely abstracted from the specific power supply implementation, allowing for greater flexibility and decoupling the core logic from the hardware specifics.



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
