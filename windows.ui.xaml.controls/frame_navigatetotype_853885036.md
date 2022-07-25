---
-api-id: M:Windows.UI.Xaml.Controls.Frame.NavigateToType(Windows.UI.Xaml.Interop.TypeName,System.Object,Windows.UI.Xaml.Navigation.FrameNavigationOptions)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool Frame.NavigateToType(TypeName sourcePageType, Object parameter, FrameNavigationOptions navigationOptions)
-->

# Windows.UI.Xaml.Controls.Frame.NavigateToType

## -description

Causes the [Frame](frame.md) to load content represented by the specified [Page](page.md), also passing a parameter to be interpreted by the target of the navigation.



## -parameters
### -param sourcePageType

The page to navigate to, specified as a type reference to its partial class type. (A type reference is given as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, or a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param parameter

The navigation parameter to pass to the target page; must have a basic type (string, char, numeric, or [GUID](/windows/win32/api/guiddef/ns-guiddef-guid)) to support parameter serialization using [GetNavigationState](frame_getnavigationstate_1352043812.md).

### -param navigationOptions

Options for the navigation, including whether it is recorded in the navigation stack and what transition animation is used.

## -returns

**false** if a [NavigationFailed](frame_navigationfailed.md) event handler has set [Handled](../windows.ui.xaml.navigation/navigationfailedeventargs_handled.md) to **true**; otherwise, **true**.

## -remarks

## -see-also

## -examples

