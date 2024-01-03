---
-api-id: P:Windows.UI.Xaml.Controls.Frame.CurrentSourcePageType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName CurrentSourcePageType { get; }
-->

# Windows.UI.Xaml.Controls.Frame.CurrentSourcePageType

## -description
Gets a type reference for the content that is currently displayed.



## -property-value
A type reference for the content that is currently displayed.

## -remarks
CurrentSourcePageType and [SourcePageType](frame_sourcepagetype.md) are normally the same value. However, if the frame calls [Navigate](frame_navigate_1426351961.md) and the navigation is still in progress, the CurrentSourcePageType is the value before the navigation and the [SourcePageType](frame_sourcepagetype.md) is the value being navigated to.



> [!TIP]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](../windows.ui.xaml.interop/typename.md) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the **typeof** operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type. In Microsoft Visual Basic, use **GetType**.

## -examples

## -see-also
[Navigating](frame_navigating.md), [Page.OnNavigatingFrom](page_onnavigatingfrom_425696585.md)
