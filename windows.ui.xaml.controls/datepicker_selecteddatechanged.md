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

## -xaml-syntax

```xaml
<DatePicker SelectedDateChanged="eventhandler" />
```

## -remarks

When you handle this event, use the [OldDate](datepickerselectedvaluechangedeventargs_olddate.md) and [NewDate](datepickerselectedvaluechangedeventargs_newdate.md) properties of the [DatePickerSelectedValueChangedEventArgs](datepickerselectedvaluechangedeventargs.md) event data for your logic. These properties use different data types depending on your programming language (C# and Visual Basic use [System.DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx); Visual C++ component extensions (C++/CX) uses [Windows::Foundation::DateTime](http://msdn.microsoft.com/library/b5533002-8a72-438d-a3d3-0902ffc21830)).

## -see-also

## -examples

