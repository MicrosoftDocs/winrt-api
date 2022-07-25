---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetDescribedByCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Automation.Peers.AutomationPeer> GetDescribedByCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetDescribedByCore

## -description
Gets a collection of elements that provide more information about the automation element.



## -returns
A collection of elements that provide more information about the automation element.

## -remarks
GetDescribedBy is used when an automation element is explained by another segment of the application UI. For example, the collection can point to a text element of "2,529 items in 85 groups, 10 items selected" from a complex custom list object. Instead of using the object model for clients to digest similar information, the collection returned by GetDescribedBy can offer quick access to UI elements that may already offer useful end-user information that describes the UI element.

## -examples

## -see-also
