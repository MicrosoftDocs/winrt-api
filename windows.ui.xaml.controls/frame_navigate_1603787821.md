---
-api-id: M:Windows.UI.Xaml.Controls.Frame.Navigate(Windows.UI.Xaml.Interop.TypeName,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public bool Navigate(Windows.UI.Xaml.Interop.TypeName sourcePageType, System.Object parameter)
-->

# Windows.UI.Xaml.Controls.Frame.Navigate

## -description
Causes the [Frame](frame.md) to load content represented by the specified [Page](page.md)-derived data type, also passing a parameter to be interpreted by the target of the navigation.



## -parameters
### -param sourcePageType
The page to navigate to, specified as a type reference to its partial class type. Must be a [Page](page.md)-derived data type; otherwise, an exception is thrown. (A type reference is given as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, or a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param parameter
The navigation parameter to pass to the target page; must have a basic type (string, char, numeric, or [GUID](/windows/win32/api/guiddef/ns-guiddef-guid)) to support parameter serialization using [GetNavigationState](frame_getnavigationstate_1352043812.md).

## -returns
**false** if a [NavigationFailed](frame_navigationfailed.md) event handler has set [Handled](../windows.ui.xaml.navigation/navigationfailedeventargs_handled.md) to **true**; otherwise, **true**. See Remarks for more info.

## -remarks

## -examples

## -see-also
[Page](page.md), [Navigate(Type)](frame_navigate_442648331.md), [Navigation](/windows/uwp/layout/navigation-basics)
