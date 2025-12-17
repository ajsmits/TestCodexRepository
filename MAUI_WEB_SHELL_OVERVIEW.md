# MAUI Web Shell - Project Overview

## Description

The **MauiWebShell** project is a cross-platform .NET MAUI (Multi-platform App UI) application that provides a web browser shell interface. It allows users to browse websites within a native application wrapper across multiple platforms including Android, iOS, macOS, and Windows.

## Key Components

### 1. Main Application Files

- **App.xaml / App.xaml.cs**: Application entry point and global resources
- **MainPage.xaml / MainPage.xaml.cs**: Main page containing the WebView and navigation controls
- **MauiProgram.cs**: MAUI application builder and configuration

### 2. User Interface

The application features a simple, intuitive interface with:

- **WebView Control**: Full-screen web browser component
- **Navigation Bar**: Contains the following controls:
  - Back Button (◀): Navigate to previous page
  - URL Entry Field: Enter website addresses
  - Go Button: Navigate to entered URL
  - Forward Button (▶): Navigate to next page
  - Refresh Button (⟳): Reload current page

### 3. Platform Support

The application is configured to build for:

- **Android**: API Level 21 (Android 5.0) and above
- **iOS**: iOS 11.0 and above
- **macOS**: macOS Catalyst 13.1 and above
- **Windows**: Windows 10 version 1809 (build 17763) and above

### 4. Architecture

```
┌─────────────────────────────────────┐
│         MauiProgram.cs              │
│   (Application Bootstrap)           │
└─────────────┬───────────────────────┘
              │
              ▼
┌─────────────────────────────────────┐
│           App.xaml.cs               │
│    (Application Lifecycle)          │
└─────────────┬───────────────────────┘
              │
              ▼
┌─────────────────────────────────────┐
│        MainPage.xaml                │
│  ┌────────────────────────────┐    │
│  │   Navigation Bar           │    │
│  │  [◀] [URL] [Go] [▶] [⟳]  │    │
│  └────────────────────────────┘    │
│  ┌────────────────────────────┐    │
│  │                            │    │
│  │       WebView              │    │
│  │   (Website Display)        │    │
│  │                            │    │
│  └────────────────────────────┘    │
└─────────────────────────────────────┘
```

## Features

### Navigation
- **URL-based Navigation**: Enter any website URL to navigate
- **Back/Forward**: Browser-style navigation history
- **Refresh**: Reload the current page
- **Auto-protocol**: Automatically adds "https://" if no protocol is specified

### Error Handling
- Navigation error detection and user notifications
- Invalid URL handling
- Network connectivity requirements

### Theming
- Light and dark theme support
- Platform-specific styling
- Consistent UI across all platforms

## Technical Details

### Dependencies

The project requires the following NuGet packages:
- `Microsoft.Maui.Controls` (version determined by MAUI SDK)
- `Microsoft.Maui.Controls.Compatibility` (version determined by MAUI SDK)
- `Microsoft.Extensions.Logging.Debug` (8.0.0)

### Resources

- **Fonts**: OpenSans Regular and Semibold
- **Icons**: SVG-based app icon with purple (#512BD4) branding
- **Splash Screen**: Branded splash screen
- **Styles**: Centralized XAML styles and color definitions

### Platform-Specific Files

Each platform has its own entry point and configuration:

**Android**:
- `MainActivity.cs`: Main activity
- `MainApplication.cs`: Application class
- `AndroidManifest.xml`: Permissions and configuration

**iOS**:
- `AppDelegate.cs`: Application delegate
- `Program.cs`: Entry point
- `Info.plist`: App configuration and permissions

**macOS Catalyst**:
- `AppDelegate.cs`: Application delegate
- `Program.cs`: Entry point
- `Info.plist`: App configuration

**Windows**:
- `App.xaml/cs`: WinUI application
- `Package.appxmanifest`: App package configuration

## Security Considerations

### Network Permissions

The application requires internet access and includes appropriate permissions:

- **Android**: `INTERNET` and `ACCESS_NETWORK_STATE` permissions
- **iOS/macOS**: App Transport Security (ATS) configured to allow arbitrary loads
- **Windows**: Internet client capability

### Web Content Security

- WebView loads external web content from user-specified URLs
- Content is subject to standard web security policies
- SSL/TLS is used for secure connections (https://)

## Building and Running

### Prerequisites

1. .NET 8.0 SDK or later
2. MAUI workload: `dotnet workload install maui`
3. Platform-specific tools:
   - **Android**: Android SDK
   - **iOS/macOS**: Xcode (macOS only)
   - **Windows**: Windows SDK

### Build Commands

```bash
# Build for all platforms
dotnet build

# Build for specific platform
dotnet build -f net8.0-android
dotnet build -f net8.0-ios
dotnet build -f net8.0-maccatalyst
dotnet build -f net8.0-windows10.0.19041.0
```

### Run Commands

```bash
# Run on Android
dotnet run -f net8.0-android

# Run on iOS (macOS only)
dotnet run -f net8.0-ios

# Run on Windows
dotnet run -f net8.0-windows10.0.19041.0
```

## Customization

### Change Default Website

Edit `MainPage.xaml` to change the default URL:

```xml
<Entry x:Name="UrlEntry" Text="https://your-website.com" ... />
<WebView x:Name="WebViewControl" Source="https://your-website.com" ... />
```

### Modify Branding

- App Icon: Replace SVG files in `Resources/AppIcon/`
- Splash Screen: Replace `Resources/Splash/splash.svg`
- Colors: Edit `Resources/Styles/Colors.xaml`
- App Title: Change `ApplicationTitle` in `.csproj`

### Add Features

Potential enhancements:
- Bookmarks functionality
- Download manager
- Tab support
- History tracking
- JavaScript injection
- Cookie management
- User agent customization

## File Structure

```
MauiWebShell/
├── MauiWebShell.csproj          # Project configuration
├── MauiProgram.cs                # App bootstrap
├── App.xaml                      # Global resources
├── App.xaml.cs                   # App lifecycle
├── MainPage.xaml                 # Main UI
├── MainPage.xaml.cs              # UI logic
├── README.md                     # Project documentation
├── Platforms/                    # Platform-specific code
│   ├── Android/
│   ├── iOS/
│   ├── MacCatalyst/
│   └── Windows/
└── Resources/                    # App resources
    ├── AppIcon/                  # Application icon
    ├── Splash/                   # Splash screen
    ├── Images/                   # Image resources
    ├── Fonts/                    # Font files
    ├── Styles/                   # XAML styles
    └── Raw/                      # Raw assets
```

## License

This is a demonstration project created for the TestCodexRepository.

## Support

For more information about .NET MAUI, visit:
- [Official MAUI Documentation](https://docs.microsoft.com/dotnet/maui/)
- [MAUI GitHub Repository](https://github.com/dotnet/maui)
