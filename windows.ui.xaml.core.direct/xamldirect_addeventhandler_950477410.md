---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.AddEventHandler(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,Windows.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void XamlDirect.AddEventHandler(IXamlDirectObject xamlDirectObject, XamlEventIndex eventIndex, Object handler)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.AddEventHandler

## -description
Adds the specified event handler for a specified event using [XamlEventIndex](xamleventindex.md), adding the handler to the handler collection on the current [IXamlDirectObject](ixamldirectobject.md).


## -parameters
### -param xamlDirectObject
A reference to the current [IXamlDirectObject](ixamldirectobject.md).

### -param eventIndex
An identifier for the event to be handled specified through [XamlEventIndex](xamleventindex.md) enum.

### -param handler
A reference to the specified handler implementation.

## -remarks
AddEventHandler can only be used to add event handlers for the events supported by the [XamlEventIndex](xamleventindex.md) enumeration. You can use this method to add handlers to routed as well non-routed events supported by the xaml object.

## -see-also

[XamlDirect.AddEventHandler](xamldirect_addeventhandler_1323041406.md), [XamlDirect.RemoveEventHandler](xamldirect_removeeventhandler_2027037099.md)

## -examples
The following example shows how to add/modify the [PointerEntered](../windows.ui.xaml/uielement_pointerentered.md) event through a specific instance of [PointerEventHandler](../windows.ui.xaml.input/pointereventhandler.md) on a [ToggleSwitch](../windows.ui.xaml.controls/toggleswitch.md) control from its [IXamlDirectObject](ixamldirectobject.md) instance.

```csharp
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject toggleSwitch = xd.CreateInstance(XamlTypeIndex.ToggleSwitch);

PointerEventHandler toggleSwitchPointerHandler = new PointerEventHandler((sender, args) =>
{
    if (sender is ToggleSwitch)
    {
        ((ToggleSwitch)sender).IsOn = !((ToggleSwitch)sender).IsOn;
    }
});

xd.AddEventHandler(toggleSwitch, XamlEventIndex.UIElement_PointerEntered, toggleSwitchPointerHandler);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ toggleSwitch = xd->CreateInstance(XamlTypeIndex::ToggleSwitch);

PointerEventHandler^ toggleSwitchPointerHandler = ref new PointerEventHandler([&](Platform::Object^ sender, PointerRoutedEventArgs^ args)
{
    ToggleSwitch^ ts = dynamic_cast<ToggleSwitch^>(sender);
    if (nullptr != ts)
    {
        ts->IsOn = !ts->IsOn;
    }
});

xd->AddEventHandler(toggleSwitch, XamlEventIndex::UIElement_PointerEntered, toggleSwitchPointerHandler);
```
