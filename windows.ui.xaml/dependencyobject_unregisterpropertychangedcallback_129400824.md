---
-api-id: M:Windows.UI.Xaml.DependencyObject.UnregisterPropertyChangedCallback(Windows.UI.Xaml.DependencyProperty,System.Int64)
-api-type: winrt method
---

<!-- Method syntax
public void UnregisterPropertyChangedCallback(Windows.UI.Xaml.DependencyProperty dp, System.Int64 token)
-->

# Windows.UI.Xaml.DependencyObject.UnregisterPropertyChangedCallback

## -description
Cancels a change notification that was previously registered by calling [RegisterPropertyChangedCallback](dependencyobject_registerpropertychangedcallback_1557279748.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.DependencyObject.UnregisterPropertyChangedCallback](/windows/winui/api/microsoft.ui.xaml.dependencyobject.unregisterpropertychangedcallback) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param dp
The dependency property identifier of the property to unregister for property-changed notification.

### -param token
A token that represents the callback (returned by [RegisterPropertyChangedCallback](dependencyobject_registerpropertychangedcallback_1557279748.md)).

## -remarks

## -examples

## -see-also
[RegisterPropertyChangedCallback](dependencyobject_registerpropertychangedcallback_1557279748.md), [DependencyPropertyChangedCallback](dependencypropertychangedcallback.md)
