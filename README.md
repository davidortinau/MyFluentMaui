# MyFluentMaui

A cross-platform .NET MAUI application that integrates Blazor components with Microsoft Fluent UI, combining native mobile capabilities with modern web-based UI components.

## Overview

This project demonstrates a hybrid architecture using MAUI as the native shell with Blazor WebView for UI components, bridging the gap between native mobile development and web-based user interfaces while maintaining Microsoft's Fluent Design System.

## Features

- **Cross-Platform Support**: Runs on Android, iOS, macOS Catalyst, and Windows
- **Hybrid Architecture**: MAUI native shell with Blazor WebView components
- **Fluent UI Integration**: Modern Microsoft Fluent Design System components
- **Contact Management**: Sample contact form with validation
- **Hot Reload**: Development-time hot reload for Blazor components

## Target Platforms

- **Android**: API 21+
- **iOS**: 15.0+
- **macOS Catalyst**: 15.0+
- **Windows**: 10.0.17763.0+

## Technology Stack

- **.NET 10**: Latest .NET framework
- **MAUI**: Multi-platform App UI framework
- **Blazor**: Web UI framework for .NET
- **Fluent UI**: Microsoft's design system components
- **C#**: Primary programming language

## Project Structure

```
src/
├── Components/          # Blazor Razor components
├── Models/             # Data models and DTOs
├── Platforms/          # Platform-specific code
├── Resources/          # App icons, images, styles
├── wwwroot/           # Static web assets
├── App.xaml           # Main application
├── AppShell.xaml      # Navigation structure
└── MauiProgram.cs     # Bootstrap and DI setup
```

## Getting Started

### Prerequisites

- Visual Studio 2022 17.8+ or Visual Studio Code with C# Dev Kit
- .NET 10 SDK
- Platform-specific SDKs (Android SDK, Xcode for iOS/macOS)

### Building and Running

```bash
# Clone the repository
git clone <repository-url>
cd MyFluentMaui

# Build the solution
dotnet build src/MyFluentMaui.csproj

# Run on Windows
dotnet run --project src/MyFluentMaui.csproj --framework net10.0-windows10.0.19041.0

# Run on Android
dotnet run --project src/MyFluentMaui.csproj --framework net10.0-android

# Run on iOS (macOS only)
dotnet run --project src/MyFluentMaui.csproj --framework net10.0-ios

# Run on macOS Catalyst (macOS only)
dotnet run --project src/MyFluentMaui.csproj --framework net10.0-maccatalyst
```

## Key Dependencies

- **Microsoft.Maui.Controls**: Core MAUI framework
- **Microsoft.AspNetCore.Components.WebView.Maui**: Blazor integration
- **Microsoft.FluentUI.AspNetCore.Components**: Fluent UI components
- **Microsoft.Extensions.Http**: HTTP client services

## Development

- **Debug builds** include Blazor WebView developer tools
- **Hot reload** is supported for Blazor components during development
- **Nullable reference types** are enabled for better code safety
- **Implicit usings** are enabled for cleaner code

## Architecture Notes

The application uses a hybrid navigation model combining:
- **MAUI Shell**: For native navigation and platform integration
- **Blazor Router**: For web-based component navigation within Blazor views

Fluent UI integration includes providers for:
- Toast notifications
- Dialogs
- Tooltips
- Message bars
- Context menus

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test on target platforms
5. Submit a pull request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.