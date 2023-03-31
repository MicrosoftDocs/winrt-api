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

AutomationProperties is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview). The purpose of these attached properties is to enable setting various per-instance values that are pertinent to how a UI element is reported to the Microsoft UI Automation accessibility framework. This is useful in cases where the class design of the UI element doesn't already forward other UI-related property values as part of its Microsoft UI Automation integration or peer implementation behavior, or where the value being forwarded is not the value you want to report to Microsoft UI Automation.

In order to support XAML processor access to the attached properties, and also to expose equivalent get and set operations to code, each XAML attached property has a pair of **Get** and **Set** accessor methods, which are also members of AutomationProperties. For example, the [GetName](automationproperties_getname_865133976.md) and [SetName](automationproperties_setname_2137845140.md) methods support and provide the equivalent code-only support for reporting automation **Name** values to Microsoft UI Automation, instead of using the Name attached property to set it in XAML. Alternatively, you can use the dependency property system to get or set the value of the attached property, and this also reports the underlying value to Microsoft UI Automation. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

#### Name property

Of the various attached properties, probably the most important one is **Name**. This is because it is the **Name** property that is most frequently accessed and reported by assistive technology when users interact with an app in an accessibility scenario. The **Name** serves as the human-readable identifier for the UI element.

Various UI elements have peer forwarding that can provide a default **Name** value based on other element properties. For example, the peer forwarding for the [Button](../windows.ui.xaml.controls/button.md) class will forward the **ToString** evaluation of the [Button](../windows.ui.xaml.controls/button.md) content and use this string as the default **Name**. In order to override that default, or to otherwise provide a **Name** value for any UI element case where there is no Microsoft UI Automation  **Name** available, set the **Name** attached property on that element in XAML. For more info on why a Microsoft UI Automation **Name** is important, see [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information). For more info on how to test whether an element already has a peer-supplied **Name** that is useful, see [Accessibility testing](/windows/uwp/accessibility/accessibility-testing).

For localization reasons, you should avoid hard-coded string values for the **Name** in XAML. If you set [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive) on the element, then you can use RESW resources to target the property and provide different values for localization. For attached properties, the resource identifier form requires full qualification of the attached property in XAML form, including its namespace and a using: prefix. For example, to target the **AutomationProperties.Name** attached property value on a resource that has [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive) value of "sendButton", the **name** value of the **data** item in the RESW resources is `sendButton.[using:Windows.UI.Xaml.Automation]AutomationProperties.Name`

See [Attached properties](#attached-properties) for a complete list (for more info about each attached property, see each property's *Identifier field*).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | GetLandmarkType |
| 1511 | 10586 | GetLocalizedLandmarkType |
| 1511 | 10586 | SetLandmarkType |
| 1511 | 10586 | SetLocalizedLandmarkType |
| 1607 | 14393 | GetDescribedBy |
| 1607 | 14393 | GetFlowsFrom |
| 1607 | 14393 | GetFlowsTo |
| 1607 | 14393 | GetFullDescription |
| 1607 | 14393 | GetIsDataValidForForm |
| 1607 | 14393 | GetIsPeripheral |
| 1607 | 14393 | GetLocalizedControlType |
| 1607 | 14393 | SetFullDescription |
| 1607 | 14393 | SetIsDataValidForForm |
| 1607 | 14393 | SetIsPeripheral |
| 1607 | 14393 | SetLocalizedControlType |
| 1703 | 15063 | GetCulture |
| 1703 | 15063 | SetCulture |
| 1803 | 17134 | GetHeadingLevel |
| 1803 | 17134 | SetHeadingLevel |
| 1809 | 17763 | GetIsDialog |
| 1809 | 17763 | SetIsDialog |

## -examples

> [!TIP]
> [!div class="nextstepaction"]
> Open the WinUI 3 Gallery app and see the following Accessibility principles in action:
> - [Screen reader support](winui3gallery://item/AccessibilityScreenReader)
> - [Keyboard support](winui3gallery://item/AccessibilityKeyboard)
> - [Color contrast](winui3gallery://item/AccessibilityColorContrast)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

## -see-also

[Accessibility](/windows/uwp/accessibility/accessibility), [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information), [Accessibility testing](/windows/uwp/accessibility/accessibility-testing), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview), [Code samples for resolving common programmatic accessibility issues in Windows desktop apps](/accessibility-tools-docs/)
