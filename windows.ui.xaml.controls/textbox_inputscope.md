---
-api-id: P:Windows.UI.Xaml.Controls.TextBox.InputScope
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Input.InputScope InputScope { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBox.InputScope

## -description

Gets or sets the context for input used by this [TextBox](textbox.md).



## -xaml-syntax

```xaml
<TextBox InputScope="inputScopeName" .../>
- or -
<TextBox>
  <TextBox.InputScope>
    <InputScope>
      <InputScope.Names>
        <InputScopeName NameValue="inputScopeName"/>
      </InputScope.Names>
    </InputScope>
  </TextBox.InputScope>
</TextBox>
```

## -xaml-values

<dl><dt>inputScopeName</dt><dd>A string that matches one of the named constants of the [InputScopeNameValue](../windows.ui.xaml.input/inputscopenamevalue.md) enumeration, such as NumericPin.</dd>
</dl>

## -property-value

The input scope, which provides a hint at the type of text input expected by the control. The default is **null**.

## -remarks

The input scope provides a hint at the type of text input expected by the control. Various elements of the system can respond to the hint provided by the input scope and provide a specialized UI for the input type. For example, the touch keyboard might show a number pad for text input when the control has its [InputScope](../windows.ui.xaml.input/inputscope.md) set to **Number**. See the [InputScopeNameValue](../windows.ui.xaml.input/inputscopenamevalue.md) enumeration for a complete list of input scope values.

The control might also interpret the data being entered differently (typically for East Asian related input scopes). The input scope does not perform any validation, and does not prevent the user from providing any input through a hardware keyboard or other input device.

Other properties that affect the touch keyboard are [IsSpellCheckEnabled](textbox_isspellcheckenabledproperty.md), [IsTextPredictionEnabled](textbox_istextpredictionenabledproperty.md), and [PreventKeyboardDisplayOnProgrammaticFocus](textbox_preventkeyboarddisplayonprogrammaticfocus.md). For more info and examples, see [Use input scope to change the touch keyboard](/windows/uwp/design/input/use-input-scope-to-change-the-touch-keyboard).

> [!NOTE]
> While this property can hold a collection of [InputScopeName](../windows.ui.xaml.input/inputscopename.md) values, only the first is used, and the rest are ignored.

## -examples

Here's how to set the [InputScope](../windows.ui.xaml.input/inputscope.md) in XAML and in code.

```xaml
<TextBox Header="Telephone Number" InputScope="TelephoneNumber"/>
```

```csharp

TextBox phoneNumberTextBox = new TextBox();
phoneNumberTextBox.Header="Telephone Number";

InputScope scope = new InputScope();
InputScopeName scopeName = new InputScopeName();
scopeName.NameValue = InputScopeNameValue.TelephoneNumber;
scope.Names.Add(scopeName);
phoneNumberTextBox.InputScope = scope;
```

## -see-also

[IsSpellCheckEnabled](textbox_isspellcheckenabledproperty.md), [IsTextPredictionEnabled](textbox_istextpredictionenabledproperty.md), [InputScopeNameValue](../windows.ui.xaml.input/inputscopenamevalue.md), [Use input scope to change the touch keyboard](/windows/uwp/design/input/use-input-scope-to-change-the-touch-keyboard)
