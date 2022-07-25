---
-api-id: P:Windows.UI.Xaml.Controls.TextBox.IsTextPredictionEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsTextPredictionEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBox.IsTextPredictionEnabled

## -description
Gets or sets a value that determines whether text prediction features ("autocomplete") should be enabled for this [TextBox](textbox.md). 
<!--TBW discuss how this interacts with client features rather than app features.-->



## -xaml-syntax
```xaml
<TextBox IsTextPredictionEnabled="bool" />
```


## -property-value
**true** to enable text prediction features, otherwise, **false**. The default is **true**.

## -remarks
Text prediction is not enabled if the user is using a physical keyboard device.

Text prediction is built-in for the[TextBox](textbox.md) control, using language-specific dictionaries. Setting the value to **true** doesn't automatically enable the feature on a custom class.

This property doesn't affect Input Method Editor (IME) for Japanese or Chinese languages. Text prediction for these languages is shown even if this property is **false**.

## -examples

## -see-also
[Touch keyboard text input sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/TouchKeyboardTextInput)
