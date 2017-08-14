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
```

```xaml
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
<dl><dt>inputScopeName</dt><dd>inputScopeNameA string that matches one of the named constants of the InputScopeNameValue enumeration, such as Number.</dd>
</dl>
## -property-value
The input scope, which provides a hint at the type of text input expected by the control.

## -remarks
The input scope provides a hint at the type of text input expected by the control. Various elements of the system can respond to the hint provided by the input scope and provide a specialized UI for the input type. For example, the touch keyboard might show a number pad for text input when the control has its [InputScope](../windows.ui.xaml.input/inputscope.md) set to **Number**.

The control might also interpret the data being entered differently (typically for East Asian related input scopes). The input scope does not perform any validation, and does not prevent the user from providing any input through a hardware keyboard or other input device.

Other properties that affect the touch keyboard are [IsSpellCheckEnabled](textbox_isspellcheckenabledproperty.md), [IsTextPredictionEnabled](textbox_istextpredictionenabledproperty.md), and [PreventKeyboardDisplayOnProgrammaticFocus](textbox_preventkeyboarddisplayonprogrammaticfocus.md). For more info and examples, see [Use input scope to change the touch keyboard](http://msdn.microsoft.com/library/6e5f55d7-24d6-47cc-b457-b6231ede2a71).

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
[IsSpellCheckEnabled](textbox_isspellcheckenabledproperty.md), [IsTextPredictionEnabled](textbox_istextpredictionenabledproperty.md), [Use input scope to change the touch keyboard](http://msdn.microsoft.com/library/6e5f55d7-24d6-47cc-b457-b6231ede2a71)