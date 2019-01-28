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
The type of page associated with the navigation entry, as a type reference ([System.Type](https://msdn.microsoft.com/library/system.type.aspx) for Microsoft .NET, a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param parameter
The navigation parameter associated with the navigation entry.

### -param navigationTransitionInfo
Info about the animated transition associated with the navigation entry.

## -remarks
> [!NOTE]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](../windows.ui.xaml.interop/typename.md) type projects as [System.Type](https://msdn.microsoft.com/library/system.type.aspx). When programming using C#, it is common to use the **typeof** operator to get references to the [System.Type](https://msdn.microsoft.com/library/system.type.aspx) of a type. In Microsoft Visual Basic, use **GetType**. If you're using Visual C++ component extensions (C++/CX)), where you'll need to create a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct, you can use the [typeid component extension](https://msdn.microsoft.com/library/kwd9abya.aspx).

## -examples

## -see-also
[BackStack](../windows.ui.xaml.controls/frame_backstack.md), [ForwardStack](../windows.ui.xaml.controls/frame_forwardstack.md), [XAML Navigation sample](http://go.microsoft.com/fwlink/p/?LinkID=330214)