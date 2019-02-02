---
-api-id: T:Windows.UI.Xaml.Automation.AutomationElementIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class AutomationElementIdentifiers : Windows.UI.Xaml.Automation.IAutomationElementIdentifiers
-->

# Windows.UI.Xaml.Automation.AutomationElementIdentifiers

## -description
Contains values used as automation property identifiers by UI Automation providers and UI Automation clients.

## -remarks
Classes such as **AutomationElementIdentifiers** are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. **AutomationElementIdentifiers** identifies the general automation peer properties that are part of the basic peer functionality, as opposed to being related to a specific automation control pattern. You might use these identifiers if you are implementing a Windows Runtime custom automation peer based on [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md) or [FrameworkElementAutomationPeer](../windows.ui.xaml.automation.peers/frameworkelementautomationpeer.md). These identifiers are needed for the [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md) calls that you make from control code that references your own peer, or for [FindItemByProperty](../windows.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty_1997743353.md) in an items container peer.

This same set of property identifiers is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. One such property identifier list for clients is documented in the topic [Automation Element Property Identifiers](https://msdn.microsoft.com/library/f7613ad1-0b75-46fb-b9ac-b1ae9eea4193).

## -examples

## -see-also
[FrameworkElementAutomationPeer](../windows.ui.xaml.automation.peers/frameworkelementautomationpeer.md), [Automation Element Property Identifiers](https://msdn.microsoft.com/library/f7613ad1-0b75-46fb-b9ac-b1ae9eea4193), [Control patterns and interfaces](https://msdn.microsoft.com/library/2091883c-5d0c-44ed-936a-709022926a42), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)
