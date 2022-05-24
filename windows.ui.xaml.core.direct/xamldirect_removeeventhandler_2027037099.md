---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.RemoveEventHandler(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,Windows.UI.Xaml.Core.Direct.XamlEventIndex,System.Object)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void XamlDirect.RemoveEventHandler(IXamlDirectObject xamlDirectObject, XamlEventIndex eventIndex, Object handler)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.RemoveEventHandler

## -description
Removes the specified event handler from this [IXamlDirectObject](ixamldirectobject.md). Typically, the handler in question was added by [XamlDirect.AddEventHandler](xamldirect_addeventhandler_1323041406.md).


## -parameters
### -param xamlDirectObject
A reference to the current [IXamlDirectObject](ixamldirectobject.md).

### -param eventIndex
An identifier for the event to remove the handle for specified through [XamlEventIndex](xamleventindex.md) enum.

### -param handler
A reference to the specified handler implementation.

## -remarks
RemoveEventHandler can only be used to remove event handlers for the events supported by the [XamlEventIndex](xamleventindex.md) enumeration. 

Calling this method has no effect if there were no handlers registered with criteria that match the input parameters for the method call.

This method ignores whether _handledEventsToo_ parameter was true in the [XamlDirect.AddEventHandler](xamldirect_addeventhandler_1323041406.md) call that originally attached the handler.

## -see-also

[XamlDirect.AddEventHandler](xamldirect_addeventhandler_950477410.md), [XamlDirect.AddEventHandler](xamldirect_addeventhandler_1323041406.md), [UIElement.AddHandler](../windows.ui.xaml/uielement_addhandler_2121467075.md), [UIElement.RemoveHandler](../windows.ui.xaml/uielement_removehandler_661998757.md)

## -examples

The following example shows how to add/modify and remove the [PointerEntered](../windows.ui.xaml/uielement_pointerentered.md) event through a specific instance of [PointerEventHandler](../windows.ui.xaml.input/pointereventhandler.md) on a [ToggleSwitch](../windows.ui.xaml.controls/toggleswitch.md) control from its [IXamlDirectObject](ixamldirectobject.md) instance.

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
xd.RemoveEventHandler(toggleSwitch, XamlEventIndex.UIElement_PointerEntered, toggleSwitchPointerHandler);
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
xd->RemoveEventHandler(toggleSwitch, XamlEventIndex::UIElement_PointerEntered, toggleSwitchPointerHandler);
```
