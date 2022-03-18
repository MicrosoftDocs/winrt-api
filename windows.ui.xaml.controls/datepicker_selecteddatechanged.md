---
-api-id: E:Windows.UI.Xaml.Controls.DatePicker.SelectedDateChanged
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler SelectedDateChanged<DatePicker, DatePickerSelectedValueChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.DatePicker.SelectedDateChanged

## -description

Occurs when the date value is changed.

Equivalent WinUI event: [Microsoft.UI.Xaml.Controls.DatePicker.SelectedDateChanged](/windows/winui/api/microsoft.ui.xaml.controls.datepicker.selecteddatechanged).

## -xaml-syntax

```xaml
<DatePicker SelectedDateChanged="eventhandler" />
```

## -remarks

When you handle this event, use the [OldDate](datepickerselectedvaluechangedeventargs_olddate.md) and [NewDate](datepickerselectedvaluechangedeventargs_newdate.md) properties of the [DatePickerSelectedValueChangedEventArgs](datepickerselectedvaluechangedeventargs.md) event data for your logic. These properties use different data types depending on your programming language (C# and Visual Basic use [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true); Visual C++ component extensions (C++/CX) uses [Windows::Foundation::DateTime](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime)).

## -see-also

## -examples

