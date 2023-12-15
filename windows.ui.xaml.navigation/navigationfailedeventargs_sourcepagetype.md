---
-api-id: P:Windows.UI.Xaml.Navigation.NavigationFailedEventArgs.SourcePageType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName SourcePageType { get; }
-->

# Windows.UI.Xaml.Navigation.NavigationFailedEventArgs.SourcePageType

## -description

Gets the value of the `sourcePageType` parameter (the page being navigated to) from the originating [Navigate](/uwp/api/windows.ui.xaml.controls.frame.navigate) call.

## -property-value

The value of the `sourcePageType` parameter from the originating [Navigate](/uwp/api/windows.ui.xaml.controls.frame.navigate) call, as a type reference ([System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct for C++/WinRT).

## -remarks

During a navigation event, the `sourcePageType` parameter is the page that is being navigated to. For more info, see [Frame.SourcePageType](/uwp/api/windows.ui.xaml.controls.frame.sourcepagetype).

> [!NOTE]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). If you're using C++/WinRT), this is a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct.

## -examples

## -see-also

[Frame.Navigate](/uwp/api/windows.ui.xaml.controls.frame.navigate), [Frame.SourcePageType](/uwp/api/windows.ui.xaml.controls.frame.sourcepagetype)
