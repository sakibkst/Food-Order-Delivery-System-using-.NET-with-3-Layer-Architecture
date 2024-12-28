# Food-Order-Delivery-System-using-.NET-with-3-Layer-Architecture


## Description

The **Food Order Delivery System** is a web-based application designed to manage food ordering and delivery for customers and restaurants. The system follows a **3-Layer Architecture** (Presentation Layer, Business Logic Layer, Data Access Layer) to separate concerns and ensure scalability, maintainability, and ease of testing.

The system allows customers to browse menus, place orders, make payments, and track deliveries. Restaurants can manage orders, menus, and deliveries. Admins can monitor system performance, manage users, and generate reports.

---

## Features

### 1. **User Authentication**
- Secure login and registration for customers, restaurant staff, and admins using **ASP.NET Identity**.
- Role-based access control ensuring users only access appropriate functionalities.

### 2. **Customer Interface**
- Browse restaurant menus, add items to the cart, and customize orders.
- Checkout with delivery or pickup options.
- Integration with payment gateways like **Stripe** and **PayPal**.
- Real-time order tracking (Order Received, In Preparation, Out for Delivery, Delivered).

### 3. **Restaurant Management**
- Manage menus, item availability, and prices.
- Staff can receive orders, process them, and assign delivery drivers.
- Update order statuses as they are prepared and dispatched.

### 4. **Admin Panel**
- Admins can manage customers, restaurant staff, and delivery drivers.
- View and generate reports on orders, sales, and customer feedback.
- Monitor system health and performance.

### 5. **Delivery Management**
- Assign deliveries to drivers based on location and availability.
- Real-time delivery tracking and notifications for customers.
  
### 6. **Database Management**
- Use **SQL Server** with **Entity Framework Core** to store customer profiles, restaurant menus, orders, and transaction logs.
  
---

## Architecture

The system follows a **3-Layer Architecture**, consisting of the following layers:

1. **Presentation Layer**:  
   - The user interface of the application where customers, restaurant staff, and admins interact with the system. Built using **ASP.NET Core MVC** and **Razor Pages**.
   
2. **Business Logic Layer (BLL)**:  
   - Contains the core business logic of the application. Handles operations such as order processing, payment validation, and status updates.  
   - Acts as an intermediary between the Presentation Layer and the Data Access Layer.
   
3. **Data Access Layer (DAL)**:  
   - Manages database interactions using **Entity Framework Core**.
   - Handles CRUD operations on the SQL Server database and ensures that business logic is abstracted from data access operations.

---

## Technology Stack

- **Frontend**: ASP.NET Core MVC, Razor Pages
- **Backend**: C#
- **Database**: SQL Server
- **ORM**: Entity Framework Core
- **Authentication**: ASP.NET Identity
- **Payment Gateways**: Stripe, PayPal
- **Tools**: Visual Studio
- **Deployment**: IIS / Azure / Docker

---

## Installation

### Prerequisites

- **.NET SDK 6.0** or higher
- **SQL Server** (or SQL Server Express)
- **Visual Studio 2022** (or higher)

### Clone the Repository

```bash
git clone https://github.com/yourusername/Food-Order-Delivery-System.git
cd Food-Order-Delivery-System
