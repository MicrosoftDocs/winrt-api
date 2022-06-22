---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple
-api-type: winrt class
---

<!-- Class syntax.
public class IRawElementProviderSimple : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Automation.Provider.IIRawElementProviderSimple
-->

# Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple

## -description
Provides methods and properties that expose basic information about a UI element. IRawElementProviderSimple is a Windows Runtime class, not an interface.



## -remarks
This type is not an interface in this implementation. In fact, it is a [DependencyObject](../windows.ui.xaml/dependencyobject.md), and includes basic dependency property support. The main reason for the specific implementation of IRawElementProviderSimple in the Windows Runtime is to provide the input parameter and return value type for [FindItemByProperty](iitemcontainerprovider_finditembyproperty_1997743353.md).

Because it's a class, IRawElementProviderSimple can't be used for the COM scenario where providers add properties or control patterns on a UI element that already has a provider.

## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [IRawElementProviderSimple (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-irawelementprovidersimple), [FindItemByProperty](iitemcontainerprovider_finditembyproperty_1997743353.md)
