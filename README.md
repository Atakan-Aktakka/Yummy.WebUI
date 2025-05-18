# Yummy Restaurant Web Application

## Overview
Yummy is a modern, responsive web application built with ASP.NET Core MVC (.NET 9.0) that serves as the frontend for a restaurant management system. The application integrates with a RESTful API to display menu items, chef profiles, services, testimonials, and events. It features a component-based architecture for better maintainability and reusability.

## Features

### Main Sections
- **Home Page**: Dynamic landing page with featured content
- **Menu**: Categorized display of food and beverage items
- **Chefs**: Showcase of culinary team members
- **Events**: Display of upcoming events and special occasions
- **Services**: Highlighting restaurant amenities and services
- **Testimonials**: Customer reviews and feedback
- **Contact**: Contact information and location details

### Technical Features
- Built with ASP.NET Core MVC (.NET 9.0)
- API-First approach with HTTP client integration
- Component-based architecture using View Components
- Responsive design with modern CSS and JavaScript
- Clean separation of concerns with DTOs (Data Transfer Objects)
- Asynchronous programming model

## Project Structure
```
Yummy.WebUI/
├── Controllers/          # MVC Controllers
│   └── HomeController.cs  # Main controller for the application
├── Dtos/                 # Data Transfer Objects
│   ├── CategoryDtos/     # Category data models
│   ├── ChefDtos/         # Chef profile data models
│   ├── EventDtos/        # Event data models
│   ├── ProductDtos/      # Menu item data models
│   ├── ServiceDtos/      # Service data models
│   └── TestimonialDtos/  # Testimonial data models
├── Models/               # Application models
├── ViewComponents/       # Reusable UI Components
│   ├── _AboutDefaultComponentPartial.cs
│   ├── _ChefDefaultComponentPartial.cs
│   ├── _EventDefaultComponentPartial.cs
│   ├── _FeatureDefaultComponentPartial.cs
│   ├── _ServiceDefaultComponentPartial.cs
│   └── _TestimonialDefaultComponentPartial.cs
├── Views/                # Razor Views
│   ├── Home/             # Home page views
│   └── Shared/           # Shared views and components
│       └── Components/   # Component-specific views
├── wwwroot/              # Static files (CSS, JS, images)
├── Program.cs           # Application entry point
└── appsettings.json      # Configuration
```

## API Integration
The application integrates with a backend API (typically running on `http://localhost:7090`) to fetch and display data. The following endpoints are used:
- `/api/Services` - Restaurant services
- `/api/Testimonials` - Customer testimonials
- `/api/Events` - Upcoming events
- `/api/Chefs` - Chef profiles
- `/api/Categories` - Menu categories
- `/api/Products` - Menu items

## Getting Started

### Prerequisites
- .NET 9.0 SDK or later
- Your preferred IDE (Visual Studio 2022, VS Code, or Rider)
- Backend API service (typically running on `http://localhost:7090`)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/Atakan-Aktakka/Yummy.WebUI.git
   cd Yummy.WebUI
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Ensure the backend API is running on `http://localhost:7090`

4. Run the application:
   ```bash
   dotnet run
   ```

5. Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

## Usage
- Navigate through the website using the main navigation menu
- Browse menu items organized by categories
- View chef profiles and their specialties
- Check out upcoming events and specials
- Read customer testimonials
- Contact the restaurant for inquiries or reservations

## Technologies Used
- **Backend**: ASP.NET Core MVC (.NET 9.0)
- **Frontend**: HTML5, CSS3, JavaScript, jQuery
- **UI Framework**: Bootstrap 5
- **HTTP Client**: IHttpClientFactory for API communication
- **JSON Processing**: Newtonsoft.Json
- **Build Tools**: .NET CLI
- **Package Manager**: NuGet
- **Architecture**: Component-based architecture with View Components
- **API Integration**: RESTful API consumption with async/await pattern

## Contributing
Contributions are welcome! Please feel free to submit a Pull Request.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact
For any inquiries, please open an issue on the GitHub repository.
