---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.IsTextPredictionEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsTextPredictionEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.IsTextPredictionEnabled

## -description
Gets or sets a value that indicates whether text prediction features ("autocomplete") are enabled for this [RichEditBox](richeditbox.md).



## -xaml-syntax
```xaml
<RichEditBox IsTextPredictionEnabled="bool" />
```


## -property-value
**True** to enable text prediction features; otherwise, **false**. The default is **true**.

## -remarks
This property doesn't affect Input Method Editor (IME) for Japanese or Chinese languages. Text prediction for these languages is shown even if this property is **false**.

## -examples

## -see-also
