---
-api-id: T:Windows.UI.Xaml.Automation.AutomationProperties
-api-type: winrt class
---

<!-- Class syntax.
public class AutomationProperties : Windows.UI.Xaml.Automation.IAutomationProperties
-->

# Windows.UI.Xaml.Automation.AutomationProperties

## -description
Provides support for getting or setting instance-level values of automation properties. These property values are set as attached properties (typically in XAML) and supplement or override automation property values from a control's [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md).

## -remarks
### AutomationProperties XAML attached properties

[AutomationProperties](automationproperties.md) is the host service class for several XAML attached properties. The purpose of these attached properties is to enable setting various per-instance values that are pertinent to how a UI element is reported to the Microsoft UI Automation accessibility framework. This is useful in cases where the class design of the UI element doesn't already forward other UI-related property values as part of its Microsoft UI Automation integration or peer implementation behavior, or where the value being forwarded is not the value you want to report to Microsoft UI Automation.

In order to support XAML processor access to the attached properties, and also to expose equivalent get and set operations to code, each XAML attached property has a pair of **Get** and **Set** accessor methods, which are also members of [AutomationProperties](automationproperties.md). For example, the [GetName](automationproperties_getname_865133976.md) and [SetName](automationproperties_setname_2137845140.md) methods support and provide the equivalent code-only support for reporting automation **Name** values to Microsoft UI Automation, instead of using [Name](automationproperties_nameproperty.md) to set it in XAML. Alternatively, you can use the dependency property system to get or set the value of the attached property, and this also reports the underlying value to Microsoft UI Automation. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

### Name property

Of the various attached properties, probably the most important one is [Name](automationproperties_nameproperty.md). This is because it is the **Name** property that is most frequently accessed and reported by assistive technology when users interact with an app in an accessibility scenario. The **Name** serves as the human-readable identifier for the UI element.

Various UI elements have peer forwarding that can provide a default **Name** value based on other element properties. For example, the peer forwarding for the [Button](../windows.ui.xaml.controls/button.md) class will forward the **ToString** evaluation of the [Button](../windows.ui.xaml.controls/button.md) content and use this string as the default **Name**. In order to override that default, or to otherwise provide a **Name** value for any UI element case where there is no Microsoft UI Automation  **Name** available, set the [Name](automationproperties_nameproperty.md) attached property on that element in XAML. For more info on why a Microsoft UI Automation  **Name** is important, see [Basic accessibility information](http://msdn.microsoft.com/library/9641c926-68c9-4842-8b55-c38c39a9e5c5). For more info on how to test whether an element already has a peer-supplied **Name** that is useful, see [Accessibility testing](http://msdn.microsoft.com/library/272d9c9e-b179-4f5a-8493-926d007a0225).

For localization reasons, you should avoid hard-coded string values for the [Name](automationproperties_nameproperty.md) in XAML. If you set [x:Uid directive](http://msdn.microsoft.com/library/9fd6b62e-d345-44c6-b739-17ed1a187d69) on the element, then you can use RESW resources to target the property and provide different values for localization. For attached properties, the resource identifier form requires full qualification of the attached property in XAML form, including its namespace and a using: prefix. For example, to target the **AutomationProperties.Name** attached property value on a resource that has [x:Uid directive](http://msdn.microsoft.com/library/9fd6b62e-d345-44c6-b739-17ed1a187d69) value of "sendButton", the **name** value of the **data** item in the RESW resources is `sendButton.[using:Windows.UI.Xaml.Automation]AutomationProperties.Name`

## -examples

## -see-also
[Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd), [Basic accessibility information](http://msdn.microsoft.com/library/9641c926-68c9-4842-8b55-c38c39a9e5c5), [Accessibility testing](http://msdn.microsoft.com/library/272d9c9e-b179-4f5a-8493-926d007a0225), [Attached properties overview](http://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2), [XAML accessibility sample](http://go.microsoft.com/fwlink/p/?LinkID=238570)