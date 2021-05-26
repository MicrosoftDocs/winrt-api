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

Equivalent WinUI class: [Microsoft.UI.Xaml.Automation.AutomationProperties](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties).

## -remarks

### XAML attached properties

AutomationProperties is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview). The purpose of these attached properties is to enable setting various per-instance values that are pertinent to how a UI element is reported to the Microsoft UI Automation accessibility framework. This is useful in cases where the class design of the UI element doesn't already forward other UI-related property values as part of its Microsoft UI Automation integration or peer implementation behavior, or where the value being forwarded is not the value you want to report to Microsoft UI Automation.

In order to support XAML processor access to the attached properties, and also to expose equivalent get and set operations to code, each XAML attached property has a pair of **Get** and **Set** accessor methods, which are also members of AutomationProperties. For example, the [GetName](automationproperties_getname_865133976.md) and [SetName](automationproperties_setname_2137845140.md) methods support and provide the equivalent code-only support for reporting automation **Name** values to Microsoft UI Automation, instead of using the Name attached property to set it in XAML. Alternatively, you can use the dependency property system to get or set the value of the attached property, and this also reports the underlying value to Microsoft UI Automation. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

#### Name property

Of the various attached properties, probably the most important one is **Name**. This is because it is the **Name** property that is most frequently accessed and reported by assistive technology when users interact with an app in an accessibility scenario. The **Name** serves as the human-readable identifier for the UI element.

Various UI elements have peer forwarding that can provide a default **Name** value based on other element properties. For example, the peer forwarding for the [Button](../windows.ui.xaml.controls/button.md) class will forward the **ToString** evaluation of the [Button](../windows.ui.xaml.controls/button.md) content and use this string as the default **Name**. In order to override that default, or to otherwise provide a **Name** value for any UI element case where there is no Microsoft UI Automation  **Name** available, set the **Name** attached property on that element in XAML. For more info on why a Microsoft UI Automation **Name** is important, see [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information). For more info on how to test whether an element already has a peer-supplied **Name** that is useful, see [Accessibility testing](/windows/uwp/accessibility/accessibility-testing).

For localization reasons, you should avoid hard-coded string values for the **Name** in XAML. If you set [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive) on the element, then you can use RESW resources to target the property and provide different values for localization. For attached properties, the resource identifier form requires full qualification of the attached property in XAML form, including its namespace and a using: prefix. For example, to target the **AutomationProperties.Name** attached property value on a resource that has [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive) value of "sendButton", the **name** value of the **data** item in the RESW resources is `sendButton.[using:Windows.UI.Xaml.Automation]AutomationProperties.Name`

#### Attached properties

> [!NOTE]
> For more info about each attached property, see the page for the property's _Identifier field_.

| Attached property | Description |
| - | - |
| [AcceleratorKey](automationproperties_acceleratorkey.md) | Gets or sets the accelerator key for the specified element. |
| [AccessibilityView](automationproperties_accessibilityview.md) | Gets or sets the Microsoft UI Automation tree view mode for an element. |
| [AccessKey](automationproperties_accesskey.md) | Gets or sets the access key for the specified element. |
| [AutomationId](automationproperties_automationid.md) | Gets or sets the string that uniquely identifies the element to Microsoft UI Automation. |
| [Culture](automationproperties_culture.md) | Gets or sets the locale identifier for the automation element (for example, 0x0409 for "en-US" or English (United States)). |
| [FullDescription](automationproperties_fulldescription.md) | Gets or sets a localized string containing extended description text for an element. |
| [HeadingLevel](automationproperties_headinglevel.md) | Gets or sets the heading level for a UI Automation element. |
| [HelpText](automationproperties_helptext.md) | Gets or sets the help text for the element. |
| [IsDataValidForForm](automationproperties_isdatavalidforform.md) | Gets or sets a value that indicates whether the data is valid for the form. |
| [IsDialog](automationproperties_isdialog.md) | Gets or sets a value that indicates whether the automation element is a dialog window. |
| [IsPeripheral](automationproperties_isperipheral.md) | Gets or sets a value that indicates whether the automation element represents peripheral UI. |
| [IsRequiredForForm](automationproperties_isrequiredforform.md) | Gets or sets a value that indicates whether the element is required to be filled out on a form. |
| [ItemStatus](automationproperties_itemstatus.md) | Gets or sets a description of the status of an item in an element. |
| [ItemType](automationproperties_itemtype.md) | Gets or sets a description of the type of the specified element. |
| [LabeledBy](automationproperties_labeledby.md) | Gets or sets the element that contains the text label for the element. |
| [LandmarkType](automationproperties_landmarktype.md) | Gets or sets a [Landmark Type Identifier](/windows/desktop/WinAuto/landmark-type-identifiers) associated with an element. |
| [Level](automationproperties_level.md) | Gets or sets a 1-based integer that describes the location of an element inside hierarchical or broken hierarchical structures. |
| [LiveSetting](automationproperties_livesetting.md) | Gets or sets the live setting value  for the specified element. |
| [LocalizedControlType](automationproperties_localizedcontroltype.md) | Gets or sets a localized text string that describes the type of control that the automation element represents. |
| [LocalizedLandmarkType](automationproperties_localizedlandmarktype.md) | Gets or sets a localized text string that describes the type of landmark that the automation element represents. |
| [Name](automationproperties_name.md) | Gets or sets the UI Automation name of the element. |
| [PositionInSet](automationproperties_positioninset.md) | Gets or sets a 1-based integer that describes the ordinal location of the element within a set of elements that are considered to be siblings. |
| [SizeOfSet](automationproperties_sizeofset.md) | Gets or sets the number of elements in a set of elements that are considered to be siblings. |

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

## -see-also
[Accessibility](/windows/uwp/accessibility/accessibility), [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information), [Accessibility testing](/windows/uwp/accessibility/accessibility-testing), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview), [Code samples for resolving common programmatic accessibility issues in Windows desktop apps](/accessibility-tools-docs/)
