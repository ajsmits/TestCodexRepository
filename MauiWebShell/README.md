# MAUI Web Shell Application

A cross-platform .NET MAUI application that provides a web browser shell for accessing websites.

## Features

- **WebView Control**: Displays websites in a native WebView component
- **Navigation Controls**: Back, Forward, Refresh buttons
- **URL Bar**: Enter and navigate to any website URL
- **Cross-Platform**: Runs on Android, iOS, macOS (Catalyst), and Windows

## Project Structure

```
MauiWebShell/
├── App.xaml & App.xaml.cs          # Application entry point
├── MainPage.xaml & MainPage.xaml.cs # Main page with WebView
├── MauiProgram.cs                   # MAUI application configuration
├── Platforms/                       # Platform-specific code
│   ├── Android/                     # Android platform files
│   ├── iOS/                         # iOS platform files
│   ├── MacCatalyst/                 # macOS Catalyst platform files
│   └── Windows/                     # Windows platform files
└── Resources/                       # Application resources
    ├── AppIcon/                     # App icon SVG files
    ├── Splash/                      # Splash screen SVG
    ├── Images/                      # Image resources
    ├── Fonts/                       # Font files
    └── Styles/                      # XAML style resources
        ├── Colors.xaml              # Color definitions
        └── Styles.xaml              # UI element styles
```

## Requirements

- .NET 8.0 or later
- MAUI workload installed (`dotnet workload install maui`)

## Building the Application

### Installing MAUI Workload

```bash
dotnet workload install maui
```

### Building for Specific Platforms

**Windows:**
```bash
dotnet build -f net8.0-windows10.0.19041.0
```

**Android:**
```bash
dotnet build -f net8.0-android
```

**iOS:**
```bash
dotnet build -f net8.0-ios
```

**macOS (Catalyst):**
```bash
dotnet build -f net8.0-maccatalyst
```

## Running the Application

### On Windows
```bash
dotnet run -f net8.0-windows10.0.19041.0
```

### On Android Emulator
```bash
dotnet run -f net8.0-android
```

### On iOS Simulator (macOS only)
```bash
dotnet run -f net8.0-ios
```

## Usage

1. Launch the application
2. The default page (https://www.example.com) will load
3. Use the URL bar to enter a different website address
4. Press "Go" or Enter to navigate
5. Use the navigation buttons:
   - **◀ Back**: Go to the previous page
   - **▶ Forward**: Go to the next page
   - **⟳ Refresh**: Reload the current page

## Configuration

To change the default website, edit `MainPage.xaml` and modify the `Source` property of the WebView:

```xml
<WebView Grid.Row="1"
         x:Name="WebViewControl"
         Source="https://your-website.com"
         .../>
```

And update the URL entry default text:

```xml
<Entry Grid.Column="1" 
       x:Name="UrlEntry"
       Placeholder="Enter website URL..."
       Text="https://your-website.com"
       .../>
```

## Security Notes

- The application allows loading arbitrary websites via WebView
- iOS and macOS have App Transport Security (ATS) configured to allow arbitrary loads
- Android has internet permission in the manifest
- Windows has internet client capability configured

## License

This is a sample application for demonstration purposes.
