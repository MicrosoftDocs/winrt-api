---
-api-id: P:Windows.UI.Xaml.UIElement.AccessKey
-api-type: winrt property
---

<!-- Property syntax
public string AccessKey { get;  set; }
-->

# Windows.UI.Xaml.UIElement.AccessKey

## -description
Gets or sets the access key (mnemonic) for this element.

## -property-value
The access key (mnemonic) for this element.

## -remarks
Setting this property enables the [AccessKeyDisplayRequested](uielement_accesskeydisplayrequested.md) event to be raised.

If the [AutomationProperties.AccessKey](../windows.ui.xaml.automation/automationproperties_accesskey.md) attached property is not set, this property is used by the Automation framework instead. The value is used as case-insensitive, using the user language. It is used as text, so if an Input Method Editor (IME) is active the composed text is used.

## -examples

## -see-also
