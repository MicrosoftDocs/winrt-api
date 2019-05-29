---
-api-id: M:Windows.UI.Xaml.Navigation.PageStackEntry.#ctor(Windows.UI.Xaml.Interop.TypeName,System.Object,Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo)
-api-type: winrt method
---

<!-- Method syntax
public PageStackEntry(Windows.UI.Xaml.Interop.TypeName sourcePageType, System.Object parameter, Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo navigationTransitionInfo)
-->

# Windows.UI.Xaml.Navigation.PageStackEntry.PageStackEntry

## -description
Initializes a new instance of the [PageStackEntry](pagestackentry.md) class.

## -parameters
### -param sourcePageType
The type of page associated with the navigation entry, as a type reference ([System.Type](https://docs.microsoft.com/dotnet/api/system.type?redirectedfrom=MSDN) for Microsoft .NET, a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param parameter
The navigation parameter associated with the navigation entry.

### -param navigationTransitionInfo
Info about the animated transition associated with the navigation entry.

## -remarks
> [!NOTE]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](../windows.ui.xaml.interop/typename.md) type projects as [System.Type](https://docs.microsoft.com/dotnet/api/system.type?redirectedfrom=MSDN). When programming using C#, it is common to use the **typeof** operator to get references to the [System.Type](https://docs.microsoft.com/dotnet/api/system.type?redirectedfrom=MSDN) of a type. In Microsoft Visual Basic, use **GetType**. If you're using Visual C++ component extensions (C++/CX)), where you'll need to create a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct, you can use the [typeid component extension](https://docs.microsoft.com/cpp/windows/typeid-cpp-component-extensions).

## -examples

## -see-also
[BackStack](../windows.ui.xaml.controls/frame_backstack.md), [ForwardStack](../windows.ui.xaml.controls/frame_forwardstack.md), [XAML Navigation sample](https://go.microsoft.com/fwlink/p/?LinkID=330214)
