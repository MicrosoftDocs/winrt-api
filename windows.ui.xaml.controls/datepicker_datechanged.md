---
-api-id: E:Windows.UI.Xaml.Controls.DatePicker.DateChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.EventHandler DateChanged<Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.DatePicker.DateChanged

## -description

Occurs when the date value is changed.

## -xaml-syntax
```xaml
<DatePicker DateChanged="eventhandler" />
```

## -remarks
When you handle this event, use the [OldDate](datepickervaluechangedeventargs_olddate.md) and [NewDate](datepickervaluechangedeventargs_newdate.md) properties of the [DatePickerValueChangedEventArgs](datepickervaluechangedeventargs.md) event data for your logic. These properties use different data types depending on your programming language (C# and Visual Basic use [System.DateTimeOffset](https://docs.microsoft.com/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN); Visual C++ component extensions (C++/CX) uses [Windows::Foundation::DateTime](https://docs.microsoft.com/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime)).

## -examples

## -see-also
[DatePickerValueChangedEventArgs](datepickervaluechangedeventargs.md), [XAML DatePicker and TimePicker controls sample](https://go.microsoft.com/fwlink/p/?LinkID=310075), [Quickstart: Adding a DatePicker](https://docs.microsoft.com/previous-versions/windows/apps/dn308514(v=win.10))
