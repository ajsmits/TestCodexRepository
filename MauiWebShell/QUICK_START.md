# MAUI Web Shell - Quick Start Guide

## What is MauiWebShell?

MauiWebShell is a cross-platform web browser application that wraps websites in a native app shell. It allows you to:
- Browse any website within a native mobile/desktop application
- Navigate with familiar browser controls
- Run on Android, iOS, macOS, and Windows from a single codebase

## Visual Layout

```
┌─────────────────────────────────────────────────────────┐
│  [◀]  [URL Entry Field]  [Go]  [▶]  [⟳]                │  ← Navigation Bar
├─────────────────────────────────────────────────────────┤
│                                                         │
│                                                         │
│                    Website Content                      │  ← WebView
│                  (example.com loads here)               │
│                                                         │
│                                                         │
└─────────────────────────────────────────────────────────┘
```

## How to Use

### 1. Enter a Website URL
- Click in the URL entry field
- Type a website address (e.g., `www.github.com` or `https://www.microsoft.com`)
- The app automatically adds `https://` if you don't include it

### 2. Navigate
- Click the **Go** button or press **Enter** to load the website
- Use **◀ Back** to go to the previous page
- Use **▶ Forward** to go to the next page in history
- Use **⟳ Refresh** to reload the current page

### 3. Browse
- Scroll and interact with the website just like in a regular browser
- Click links to navigate within the website
- The URL bar updates automatically as you navigate

## Quick Installation

### Prerequisites
Install the .NET 8 SDK and MAUI workload:

```bash
# Install .NET 8 SDK
# Download from: https://dotnet.microsoft.com/download/dotnet/8.0

# Install MAUI workload
dotnet workload install maui
```

### Platform-Specific Setup

**For Android:**
- Install Android SDK via Visual Studio or Android Studio
- Enable USB debugging on your device or use an emulator

**For iOS/macOS (Mac users only):**
- Install Xcode from the Mac App Store
- Accept Xcode license: `sudo xcodebuild -license accept`

**For Windows:**
- Windows 10 version 1809 (build 17763) or later
- Visual Studio 2022 with Windows App SDK

## Building the App

### Open the Solution
```bash
cd MauiWebShell
dotnet restore
```

### Build for Your Platform

**Android:**
```bash
dotnet build -f net8.0-android
```

**iOS (Mac only):**
```bash
dotnet build -f net8.0-ios
```

**macOS (Mac only):**
```bash
dotnet build -f net8.0-maccatalyst
```

**Windows:**
```bash
dotnet build -f net8.0-windows10.0.19041.0
```

## Running the App

### On Android Device/Emulator
```bash
dotnet run -f net8.0-android
```

### On iOS Simulator (Mac only)
```bash
dotnet run -f net8.0-ios
```

### On Windows
```bash
dotnet run -f net8.0-windows10.0.19041.0
```

## Customization

### Change the Default Website

Edit `MainPage.xaml` lines 25 and 53:

```xml
<!-- Line 25: URL Entry default text -->
<Entry x:Name="UrlEntry"
       Text="https://www.yourwebsite.com"
       ... />

<!-- Line 53: WebView default source -->
<WebView x:Name="WebViewControl"
         Source="https://www.yourwebsite.com"
         ... />
```

### Change the App Name

Edit `MauiWebShell.csproj` line 24:

```xml
<ApplicationTitle>Your App Name</ApplicationTitle>
```

### Change the App Colors

Edit `Resources/Styles/Colors.xaml`:

```xml
<!-- Change the primary purple color to your brand color -->
<Color x:Key="Primary">#512BD4</Color>  <!-- Change this hex value -->
```

## Features Summary

| Feature | Description |
|---------|-------------|
| **WebView** | Displays full websites using native rendering |
| **URL Entry** | Type any web address |
| **Auto HTTPS** | Automatically adds https:// if missing |
| **Back/Forward** | Browser-style navigation history |
| **Refresh** | Reload current page |
| **Error Handling** | Shows alerts for navigation errors |
| **Dark Mode** | Automatically supports light/dark themes |
| **Cross-Platform** | Single codebase for all platforms |

## Troubleshooting

### "Workload not installed" error
```bash
dotnet workload install maui
```

### Android deployment fails
- Ensure Android SDK is installed
- Check USB debugging is enabled on device
- Verify emulator is running

### iOS deployment fails (Mac only)
- Open Xcode at least once to install components
- Accept Xcode license agreement
- Ensure provisioning profile is configured

### Website won't load
- Check internet connection
- Verify the URL is correct and accessible
- Some websites may block WebView access

## Architecture Overview

```
MauiProgram.cs
    ↓
  App.xaml.cs (Application Lifecycle)
    ↓
  MainPage.xaml (UI Layout)
    ↓
  MainPage.xaml.cs (Event Handlers)
    ↓
  WebView (Platform-specific rendering)
```

## Next Steps

1. **Build and run** the app on your target platform
2. **Test navigation** with different websites
3. **Customize branding** (colors, app name, icon)
4. **Deploy to devices** or app stores
5. **Add features** like bookmarks, history, or tabs

## Resources

- [.NET MAUI Documentation](https://docs.microsoft.com/dotnet/maui/)
- [WebView Control Documentation](https://docs.microsoft.com/dotnet/maui/user-interface/controls/webview)
- [XAML Documentation](https://docs.microsoft.com/dotnet/maui/xaml/)

## Support

For detailed technical information, see:
- `README.md` - Project-specific documentation
- `MAUI_WEB_SHELL_OVERVIEW.md` - Comprehensive technical overview
