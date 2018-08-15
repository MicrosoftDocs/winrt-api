---
-api-id: M:Windows.UI.Xaml.Controls.Frame.Navigate(Windows.UI.Xaml.Interop.TypeName,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public bool Navigate(Windows.UI.Xaml.Interop.TypeName sourcePageType, System.Object parameter)
-->

# Windows.UI.Xaml.Controls.Frame.Navigate

## -description
Causes the [Frame](frame.md) to load content represented by the specified [Page](page.md), also passing a parameter to be interpreted by the target of the navigation.

## -parameters
### -param sourcePageType
The page to navigate to, specified as a type reference to its partial class type. (A type reference is given as [System.Type](https://msdn.microsoft.com/library/system.type.aspx) for Microsoft .NET, or a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param parameter
The navigation parameter to pass to the target page; must have a basic type (string, char, numeric, or GUID) to support parameter serialization using [GetNavigationState](frame_getnavigationstate_1352043812.md).

## -returns
**false** if a [NavigationFailed](frame_navigationfailed.md) event handler has set [Handled](../windows.ui.xaml.navigation/navigationfailedeventargs_handled.md) to **true**; otherwise, **true**. See Remarks for more info.

## -remarks

## -examples

## -see-also
[Page](page.md), [Navigate(Type)](frame_navigate_442648331.md), [Navigation](http://msdn.microsoft.com/library/742c1c18-c7b1-47b7-866c-726eeb8235ec), [XAML Navigation sample](http://go.microsoft.com/fwlink/p/?LinkID=330214)