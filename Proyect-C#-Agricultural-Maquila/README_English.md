# Pineapple Production Management System

This system manages the pineapple production and packaging process for export at company. It’s designed to help employees administer the entire production workflow, from fruit reception and cleaning to packaging and dispatch, with specific roles for administrators and data entry clerks.

## Project Features

- **Programming Language**: C# in Visual Studio.
- **Database**: SQL Server 2019 or higher.
- **Graphical Interface**: The project is developed exclusively with a graphical interface.

## Key Functionalities

### 1. Secure Login
- **Username and Password**: Encrypted passwords for security.
- **Roles**: Role-based access control, restricting sections based on role (Administrator or Data Entry Clerk).

### 2. Administrator Module
- **CRUD for Suppliers, Farms, Fruit Types, and Varieties**: Complete management of supplier and product type information.

### 3. Data Entry Clerk Module
- **CRUD for Harvest Tickets and Immersion Records**: Management of documentation and fruit entry records.
- **Packaging and Palletizing**: Fruit sizing, box calculation, and pallet organization for export.

### 4. Reports
- **Visualization and Graphs**: Generates reports with graphs, such as:
  - Number of boxes and pallets packed on a specific day.
  - Fruit origin by location.
  - Records of rejected fruit and movement logs.

## Production and Packaging Process
- **Fruit Entry**: Registers bins from farms to the packing plant.
- **Cleaning**: Immerses bins in water and chemicals, recording date and time.
- **Packaging and Palletizing**: Organizes fruit into boxes and stacks them on pallets for export.
- **Logbook**: Records every transaction for control and auditing purposes.

## User Roles
- **Administrator**: Full access and control over users and system parameters.
- **Data Entry Clerk**: Manages fruit entry data and packaging processes.

---
