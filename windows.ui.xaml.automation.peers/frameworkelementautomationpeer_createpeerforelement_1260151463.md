---
-api-id: M:Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer.CreatePeerForElement(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Automation.Peers.AutomationPeer CreatePeerForElement(Windows.UI.Xaml.UIElement element)
-->

# Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer.CreatePeerForElement

## -description
Creates a [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) for the specified [UIElement](../windows.ui.xaml/uielement.md).



## -parameters
### -param element
The [UIElement](../windows.ui.xaml/uielement.md) that is associated with this [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md).

## -returns
A [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md).

## -remarks
CreatePeerForElement is a helper class that is used by custom control code to return the acting peer instance. Using the returned peer, you can fire automation events from within the same routines that also fire your general control logic events or change control properties. Or you can write your own helper methods that do this and are invoked from your control logic.

The created [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) remains in memory until the associated [UIElement](../windows.ui.xaml/uielement.md) is destroyed. The same instance of the [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) is returned from subsequent calls to CreatePeerForElement and calls to [FromElement](frameworkelementautomationpeer_fromelement_1666357111.md) that reference the same *element* instance.

The type of the peer returned is determined by the [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) implementation of the relevant [UIElement](../windows.ui.xaml/uielement.md), which is typically a [Control](../windows.ui.xaml.controls/control.md). If the class code for the *element* type doesn't implement [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md), no peer is created, and CreatePeerForElement returns **null**. As a best practice you should always check for **null** after calling CreatePeerForElement, because there are a number of Windows Runtime elements that won't have an [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) implementation. For example, a [ContentControl](../windows.ui.xaml.controls/contentcontrol.md) doesn't have a peer by default unless it's customized or is a more-derived Windows Runtime control.

CreatePeerForElement has basically the same behavior as [FromElement](frameworkelementautomationpeer_fromelement_1666357111.md).

CreatePeerForElement can return the peer even if the **CreateAutomationPeer** system logic hasn't run yet on the *element* target for some reason. It will invoke the same **CreateAutomationPeer** logic internally in order to get the peer.

## -examples
CreatePeerForElement is useful if you are writing a peer that forwards the peer information from one of its component parts, because it's the component part that might implement a pattern as requested in the peer's [GetPatternCore](automationpeer_getpatterncore_1167667011.md) implementation. For example, if one of a control's main component parts is a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) the control itself may have some other function and doesn't scroll directly. But the peer might still want to report support for a **Scroll** pattern, and provide a peer so that a client can interact with the automation pattern of the scrolling part.

```csharp
protected override object GetPatternCore(PatternInterface patternInterface)
{
    if (patternInterface == PatternInterface.Scroll)
    {
        ItemsControl owner = (ItemsControl) base.Owner;
        UIElement itemsHost = owner.ItemsHost;
        ScrollViewer element = null;
        while (itemsHost != owner)
        {
            itemsHost = VisualTreeHelper.GetParent(itemsHost) as UIElement;
            element = itemsHost as ScrollViewer;
            if (element != null)
            {
                break;
            }
        }
        if (element != null)
        {
            AutomationPeer peer = FrameworkElementAutomationPeer.CreatePeerForElement(element);
            if ((peer != null) && (peer is IScrollProvider))
            {
                return (IScrollProvider) peer;
            }
        }
    }
    return base.GetPatternCore(patternInterface);
}

```



## -see-also
[FromElement](frameworkelementautomationpeer_fromelement_1666357111.md)
