---
-api-id: P:Windows.UI.Xaml.Controls.TextBox.IsSpellCheckEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsSpellCheckEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBox.IsSpellCheckEnabled

## -description
Gets or sets a value that specifies whether the [TextBox](textbox.md) input interacts with a spell check engine.



## -xaml-syntax
```xaml
<TextBox IsSpellCheckEnabled="bool" />
```


## -property-value
**true** if the [TextBox](textbox.md) input interacts with a spell check engine; otherwise, **false**. The default is **true**.

## -remarks

When using the Soft Input Panel (SIP), this property enables the following features:

+ auto-cap (Mobile only)
+ spell check
+ auto-correction
+ spelling candidates on-demand when the user taps on a misspelled word


> **Windows 8**
> For Universal Windows 8 app, the default is **false**.

## -examples

## -see-also
[Touch keyboard text input sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/TouchKeyboardTextInput)
