---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.InputScope
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Input.InputScope InputScope { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.InputScope

## -description
Gets or sets the context for input used by this [RichEditBox](richeditbox.md).

## -xaml-syntax
```xaml
<RichEditBox InputScope="inputScopeName" .../>
```

```xaml
<RichEditBox>
  <RichEditBox.InputScope>
    <InputScope>
      <InputScope.Names>
        <InputScopeName NameValue="inputScopeName"/>
      </InputScope.Names>
    </InputScope>
  </RichEditBox.InputScope>
</RichEditBox>
```


## -xaml-values
<dl><dt>inputScopeName</dt><dd>inputScopeNameA string that matches one of the named constants of the InputScopeNameValue enumeration, such as Number.</dd>
</dl>
## -property-value
The input scope, which provides a hint at the type of text input expected by the control.

## -remarks
The input scope provides a hint at the type of text input expected by the control. Various elements of the system can respond to the hint provided by the input scope and provide a specialized UI for the input type. For example, the soft keyboard might show a number pad for text input when the control has its [InputScope](../windows.ui.xaml.input/inputscope.md) set to **Number**.

The control might also interpret the data being entered differently (typically for East Asian related input scopes). The input scope does not perform any validation, and does not prevent the user from providing any input through a hardware keyboard or other input device.

> [!NOTE]
> While this property can hold a collection of InputeNameScope values, only the first is used, and the rest are ignored.

## -examples
Here's how to set the [InputScope](../windows.ui.xaml.input/inputscope.md) in XAML and in code.

```xaml
<RichEditBox InputScope="Formula"/>
```

```csharp

RichEditBox editBox = new RichEditBox();

InputScope scope = new InputScope();
InputScopeName scopeName = new InputScopeName();
scopeName.NameValue = InputScopeNameValue.Formula;
scope.Names.Add(scopeName);
editBox.InputScope = scope;
```



## -see-also
[InputScopeNameValue](../windows.ui.xaml.input/inputscopenamevalue.md)
