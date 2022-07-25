---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ITransformProvider2
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITransformProvider2 : Windows.UI.Xaml.Automation.Provider.ITransformProvider
-->

# Windows.UI.Xaml.Automation.Provider.ITransformProvider2

## -description
Extends the [ITransformProvider](itransformprovider.md) interface to enable Microsoft UI Automation providers to expose API to support the viewport zooming functionality of a control.



## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Transform Control Pattern](/windows/desktop/WinAuto/uiauto-implementingtransform).


<!--<rem  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"><xref targtype="interface_winrt" rid="w_ui_xaml_auto_prov.itransformprovider2">ITransformProvider2</xref> isn't implemented by any existing <tla rid="winrt"/> automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same <tla rid="winrt"/> managed or C++ <tla plural="1" rid="tla_api"/> as they use to define control logic or other automation support.</rem>-->
Use the [TransformPattern2Identifiers](../windows.ui.xaml.automation/transformpattern2identifiers.md) class if you want to reference the ITransformProvider2 pattern properties from control code when you call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[Transform Control Pattern](/windows/desktop/WinAuto/uiauto-implementingtransform), [ITransformProvider](itransformprovider.md), [ITransformProvider2 (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itransformprovider2), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
