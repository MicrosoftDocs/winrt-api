---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.GetDefault
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public XamlDirect XamlDirect.GetDefault()
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.GetDefault

## -description
Returns the current [XamlDirect](xamldirect.md) instance. 

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Core.Direct.XamlDirect.GetDefault](/windows/winui/api/microsoft.ui.xaml.core.direct.xamldirect.getdefault) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -returns
[XamlDirect](xamldirect.md)
Returns the current [XamlDirect](xamldirect.md) instance. 

## -remarks
For even better performance, consider caching this locally instead of querying for the instance every time.

## -see-also
[XamlDirect.CreateInstance](xamldirect_createinstance_2026807211.md)

## -examples

```csharp
XamlDirect xamlDirectInstance = XamlDirect.GetDefault();
```
