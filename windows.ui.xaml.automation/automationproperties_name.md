---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.Name
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.Name

<!--
see GetName, and SetName
-->

## -description

Gets or sets the UI Automation name of the element.

## -remarks
The `Name` property should be the same as the label text on screen. For example, `Name` should be "Browse" for a button element with the label "Browse". The `Name` property must not include the mnemonic character for the access keys (that is, "&amp;"), which is underlined in the UI text presentation. Also, the `Name` property should not be an extended or modified version of the on-screen label because the inconsistency between the name and the label can cause confusion among client applications and users.

When the corresponding label text is not visible on screen, or when it is replaced by graphics, alternative text should be chosen. The alternative text should be concise, intuitive, and localized to the application UI language, or to the operating system default UI language. The alternative text should not be a detailed description of the visual details, but a concise description of the UI function or feature as if it were labeled by simple text. For example, the Windows Start menu button is named "Start" (button) instead of "Windows Logo on blue round sphere graphics" (button). For more information, see [Creating Text Equivalents for Images](/previous-versions/windows/desktop/dnacc/creating-text-equivalents-for-images).

When a UI label uses text graphics (for example, using "&gt;&gt;" for a button that adds an item from left to right), the `Name` property should be overridden by an appropriate text alternative (for example, "Add"). However the practice of using text graphics as a UI label is discouraged due to both localization and accessibility concerns.

The `Name` property must not include the control role or type information, such as "button" or "list"; otherwise, it will conflict with the text from the [LocalizedControlType](automationproperties_localizedcontroltypeproperty.md) property when these two properties are appended (many existing assistive technologies do this).

The `Name` property cannot be used as a unique identifier among siblings. However, as long as it is consistent with the UI presentation, the same `Name` value can be supported among peers. For test automation, the clients should consider using the [AutomationId](automationproperties_name.md) or [RuntimeId](../windows.ui.xaml.automation.peers/rawelementproviderruntimeid.md) property.

Text controls do not always have to have the `Name` property be identical to the text that is displayed within the control, so long as the **Text** pattern is also supported.

Of the various attached properties, probably the most important one is `Name`. This is because it is the `Name` property that is most frequently accessed and reported by assistive technology when users interact with an app in an accessibility scenario. The `Name` serves as the human-readable identifier for the UI element.

Various UI elements have peer forwarding that can provide a default `Name` value based on other element properties. For example, the peer forwarding for the [Button](../windows.ui.xaml.controls/button.md) class will forward the `ToString` evaluation of the [Button](../windows.ui.xaml.controls/button.md) content and use this string as the default `Name`. In order to override that default, or to otherwise provide a `Name` value for any UI element case where there is no Microsoft UI Automation  `Name` available, set the `Name` attached property on that element in XAML. For more info on why a Microsoft UI Automation `Name` is important, see [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information). For more info on how to test whether an element already has a peer-supplied `Name` that is useful, see [Accessibility testing](/windows/uwp/accessibility/accessibility-testing).

For localization reasons, you should avoid hard-coded string values for the `Name` in XAML. If you set [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive) on the element, then you can use RESW resources to target the property and provide different values for localization. For attached properties, the resource identifier form requires full qualification of the attached property in XAML form, including its namespace and a using: prefix. For example, to target the `AutomationProperties.Name` attached property value on a resource that has [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive) value of "sendButton", the `Name` value of the **data** item in the RESW resources is `sendButton.[using:Windows.UI.Xaml.Automation]AutomationProperties.Name`

<ul><li>Type: string</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.nameproperty">NameProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.getname">GetName</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.setname">SetName</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


