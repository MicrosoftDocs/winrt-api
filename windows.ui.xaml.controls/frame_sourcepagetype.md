---
-api-id: P:Windows.UI.Xaml.Controls.Frame.SourcePageType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName SourcePageType { get;  set; }
-->

# Windows.UI.Xaml.Controls.Frame.SourcePageType

## -description
Gets or sets a type reference of the current content, or the content that should be navigated to.



## -property-value
A type reference for the current content, or the content to navigate to.

## -remarks
[CurrentSourcePageType](frame_currentsourcepagetype.md) and SourcePageType are normally the same value. However, if the frame calls [Navigate](frame_navigate_1426351961.md) and the navigation is still in progress, the [CurrentSourcePageType](frame_currentsourcepagetype.md) is the value before the navigation and the SourcePageType is the value being navigated to.

> [!TIP]
> If you are programming using a Microsoft .NET language (C# or Visual Basic), the [TypeName](../windows.ui.xaml.interop/typename.md) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the **typeof** operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type. In Visual Basic, use **GetType**.

SourcePageType can be set in XAML, using string-to-type conversion that's interpreted using XAML namespace mappings, but that's rarely done. It's a better practice to have code at the app level that tracks activation and whether a suspended app is resuming, which then uses [Frame.Navigate](frame_navigate_1426351961.md) to set the current page. The Microsoft Visual Studio templates often produce such code for you. For this same reason, it's also rare to set SourcePageType as an alternative to calling [Frame.Navigate](frame_navigate_1426351961.md), which also specifies a [Page](page.md) by type reference. If you do set a value for SourcePageType in XAML, you typically need to use a prefix such as "local:" that's defined in the same XAML construct. You need the prefix to map a XAML namespace that references the code namespace where your page partial class is defined. For more info, see [XAML namespaces and namespace mapping](/windows/uwp/xaml-platform/xaml-namespaces-and-namespace-mapping).

A more typical scenario for SourcePageType in code is to only read its value, and not set it. For example you might compare SourcePageType for the current page in the [Frame](frame.md) with items in the navigation stacks ([BackStack](frame_backstack.md), [ForwardStack](frame_forwardstack.md)) to see if there are existing entries for that same [Page](page.md).

## -examples

## -see-also
[Page](page.md), [Frame.Navigate](frame_navigate_1426351961.md), [CurrentSourcePageType](frame_currentsourcepagetype.md)
