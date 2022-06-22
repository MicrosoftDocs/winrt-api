---
-api-id: P:Windows.UI.Xaml.Controls.PasswordBox.IsPasswordRevealButtonEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsPasswordRevealButtonEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.PasswordBox.IsPasswordRevealButtonEnabled

## -description
Gets or sets a value that specifies whether the visual UI of the [PasswordBox](passwordbox.md) includes a button element that toggles showing or hiding the typed characters. In Windows 10 and later, use [PasswordRevealMode](passwordbox_passwordrevealmode.md) instead.



## -xaml-syntax
```xaml
<PasswordBox IsPasswordRevealButtonEnabled="bool" />
```


## -property-value
**True** to show a password reveal button; **false** to not show a password reveal button. The default is **false**.

## -remarks
> **Windows 10**
> [PasswordRevealMode](passwordbox_passwordrevealmode.md) replaces IsPasswordRevealButtonEnabled to give you more options for how the user is able to view their password. The IsPasswordRevealButtonEnabled property is ignored.

The value of this property is not the only factor that determines whether a password reveal button is visible to the user. Other factors include whether the control is displayed above a minimum width, whether the [PasswordBox](passwordbox.md) has focus, and whether the text entry field contains at least one character.

## -examples

## -see-also
