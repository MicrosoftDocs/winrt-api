---
-api-id: TP:winrt-api
-api-name: Windows Runtime (WinRT) namespaces
title: Windows Runtime (WinRT) API namespaces - Windows apps
---
# Windows Runtime (WinRT) Namespaces
 
## -description
 
Find detailed information about Windows Runtime (WinRT) APIs.

## -remarks

The Windows Runtime (WinRT) is a type system and API surface built into Windows. WinRT APIs are defined in metadata (`.winmd` files) and can be consumed from multiple languages and app frameworks through language projections such as C#/WinRT, C++/WinRT, and Rust/WinRT.

> [!IMPORTANT]
> **WinRT APIs are not limited to UWP apps.** While WinRT was originally introduced alongside the Universal Windows Platform (UWP), the WinRT API surface is available to:
>
> - **Windows App SDK (WinUI 3) apps** — The modern recommended framework for Windows desktop development. Windows App SDK apps can call WinRT APIs directly.
> - **Win32 desktop apps** — Traditional desktop apps (WPF, WinForms, or unpackaged Win32) can call most WinRT APIs using C++/WinRT or C#/WinRT without requiring a UWP project or app container.
> - **UWP apps** — The original app model for WinRT APIs, still supported but no longer the recommended path for new development.
>
> For guidance on calling WinRT APIs from desktop apps, see [Call Windows Runtime APIs in desktop apps](/windows/apps/desktop/modernize/desktop-to-uwp-enhance).

### Choosing the right app framework

| Scenario | Recommended framework |
|----------|----------------------|
| New Windows desktop app | [Windows App SDK with WinUI 3](/windows/apps/winui/winui3/) |
| Existing Win32/WPF/WinForms app needing WinRT APIs | [Call WinRT APIs from your desktop app](/windows/apps/desktop/modernize/desktop-to-uwp-enhance) |
| Maintaining existing UWP app | Continue with UWP; consider [migrating to WinAppSDK](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/overall-migration-strategy) |

### Language projections

WinRT APIs are accessed through language projections:

- **C#** — Use the [C#/WinRT](/windows/uwp/csharp-winrt/) projection (automatically included in .NET 6+ Windows projects).
- **C++** — Use the [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/) projection (header-only, modern C++17).
- **Rust** — Use the [windows crate](https://github.com/microsoft/windows-rs) for Rust access to WinRT APIs.
- **C++/CX** — Legacy projection; new projects should use C++/WinRT instead.