---
-api-id: M:Windows.UI.Xaml.DependencyObjectCollection.ReplaceAll(Windows.UI.Xaml.DependencyObject[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(Windows.UI.Xaml.DependencyObject[] items)
-->

# Windows.UI.Xaml.DependencyObjectCollection.ReplaceAll

## -description
Initially clears the collection, then inserts the provided array as new items.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.DependencyObjectCollection.ReplaceAll](/windows/winui/api/microsoft.ui.xaml.dependencyobjectcollection.replaceall) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param items
The new collection items.

## -remarks
For implementations that track a *changed* event, which this collection does do with **VectorChanged**, the initial reset fires an event, but the items added do not fire discrete per-item events.

## -examples

## -see-also
