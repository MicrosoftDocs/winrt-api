---
-api-id: P:Windows.UI.Xaml.Controls.PasswordBox.InputScope
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Input.InputScope InputScope { get;  set; }
-->

# Windows.UI.Xaml.Controls.PasswordBox.InputScope

## -description

Gets or sets the context for input used by this [PasswordBox](passwordbox.md).



## -xaml-syntax

```xaml
<PasswordBox>
  <PasswordBox.InputScope>
    <InputScope>
      <InputScope.Names>
        <InputScopeName NameValue="inputScopeName"/>
      </InputScope.Names>
    </InputScope>
  </PasswordBox.InputScope>
</PasswordBox>
```

## -xaml-values

<dl><dt>inputScopeName</dt><dd>A string that matches one of the named constants of the [InputScopeNameValue](../windows.ui.xaml.input/inputscopenamevalue.md) enumeration, such as NumericPin.</dd>
</dl>

## -property-value

The input scope, which provides a hint at the type of text input expected by the control. The default is **null**.

## -remarks

The `InputScope` property on [PasswordBox](passwordbox.md) supports only the [Password](../windows.ui.xaml.input/inputscopenamevalue.md) and [NumericPin](../windows.ui.xaml.input/inputscopenamevalue.md) values. Any other value is ignored.

The input scope provides a hint at the type of text input expected by the control. Various elements of the system can respond to the hint provided by the input scope and provide a specialized UI for the input type. For example, the soft keyboard might show a number pad for text input when the control has its `InputScope` set to **NumericPin**.

The input scope does not perform any validation, and does not prevent the user from providing any input through a hardware keyboard or other input device.

## -examples

Here's how to set the [InputScope](../windows.ui.xaml.input/inputscope.md) in XAML and in code.

```xaml
<PasswordBox x:Name="pinBox" Header="Enter PIN">
    <PasswordBox.InputScope>
        <InputScope>
            <InputScope.Names>
                <InputScopeName NameValue="NumericPin"/>
            </InputScope.Names>
        </InputScope>
    </PasswordBox.InputScope>
</PasswordBox>
```

```csharp
PasswordBox passwordBox = new PasswordBox();
passwordBox.Header = "Enter password";

InputScope scope = new InputScope();
InputScopeName scopeName = new InputScopeName();
scopeName.NameValue = InputScopeNameValue.Password;
scope.Names.Add(scopeName);
passwordBox.InputScope = scope;
```

## -see-also

[InputScopeNameValue](../windows.ui.xaml.input/inputscopenamevalue.md)
