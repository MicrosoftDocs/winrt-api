---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ComboBoxItemAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ComboBoxItemAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IComboBoxItemAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.ComboBoxItemAutomationPeer

## -description
Exposes the [ComboBoxItem](../windows.ui.xaml.controls/comboboxitem.md) contents in a [ComboBox](../windows.ui.xaml.controls/combobox.md) to Microsoft UI Automation.



## -remarks
The Windows Runtime  [ComboBoxItem](../windows.ui.xaml.controls/comboboxitem.md) class creates a new ComboBoxItemAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ComboBoxItemAutomationPeer if you are deriving a custom class from [ComboBoxItem](../windows.ui.xaml.controls/comboboxitem.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ComboBoxItemAutomationPeer**

ComboBoxItemAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer doesn't have any patterns. However, the content of the [ComboBoxItem](../windows.ui.xaml.controls/comboboxitem.md) might have a specific peer, for example if it is a [TextBox](../windows.ui.xaml.controls/textbox.md). The parent [ComboBox](../windows.ui.xaml.controls/combobox.md) has the support for any selection-related automation behavior.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ComboBoxItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
+ Because a [ComboBoxItem](../windows.ui.xaml.controls/comboboxitem.md) is a [ContentControl](../windows.ui.xaml.controls/contentcontrol.md), [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. This is implemented so that consumers of the control don't always need to provide an [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) value in app code, and can use a generated-from-content value for the automation **Name** directly from the UI definition. For more info on how this works, see [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [ComboBoxItem](../windows.ui.xaml.controls/comboboxitem.md), [ComboBoxAutomationPeer](comboboxautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
