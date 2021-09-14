---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.AddEventHandler(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,Windows.UI.Xaml.Core.Direct.XamlEventIndex,System.Object,System.Boolean)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void XamlDirect.AddEventHandler(IXamlDirectObject xamlDirectObject, XamlEventIndex eventIndex, Object handler, Boolean handledEventsToo)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.AddEventHandler

## -description
Adds the specified event handler for a specified event using [XamlEventIndex](xamleventindex.md), adding the handler to the handler collection on the current [IXamlDirectObject](ixamldirectobject.md). Specify *handledEventsToo* as true to have the provided handler be invoked even if the event is handled elsewhere.


## -parameters
### -param xamlDirectObject
A reference to the current [IXamlDirectObject](ixamldirectobject.md).

### -param eventIndex
An identifier for the event to be handled specified through [XamlEventIndex](xamleventindex.md) enum.

### -param handler
A reference to the specified handler implementation.

### -param handledEventsToo
**true** to register the handler such that it is invoked even when the routed event is marked handled in its event data.
**false** to register the handler with the default condition that it will not be invoked if the routed event is already marked handled. 

The default is false and the parameter is optional.

## -remarks
AddEventHandler can only be used to add event handlers for the events supported by the [XamlEventIndex](xamleventindex.md) enumeration. You can use this method to add handlers to routed as well non-routed events supported by the xaml object.

See [UIElement.AddHandler](../windows.ui.xaml/uielement_addhandler_2121467075.md) for when to use _handledEventsToo_ and the restrictions around the same. For non-routed events, the _handleEventsToo_ flag is completely ignored.

## -see-also

[XamlDirect.AddEventHandler](xamldirect_addeventhandler_950477410.md), [XamlDirect.RemoveEventHandler](xamldirect_removeeventhandler_2027037099.md), [UIElement.AddHandler](../windows.ui.xaml/uielement_addhandler_2121467075.md), [UIElement.RemoveHandler](../windows.ui.xaml/uielement_removehandler_661998757.md)

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

xd.AddEventHandler(toggleSwitch, XamlEventIndex.UIElement_PointerEntered, toggleSwitchPointerHandler, true);
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

xd->AddEventHandler(toggleSwitch, XamlEventIndex::UIElement_PointerEntered, toggleSwitchPointerHandler, true);
```
