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
When you handle this event, use the [OldDate](datepickervaluechangedeventargs_olddate.md) and [NewDate](datepickervaluechangedeventargs_newdate.md) properties of the [DatePickerValueChangedEventArgs](datepickervaluechangedeventargs.md) event data for your logic. These properties use different data types depending on your programming language (C# and Visual Basic use [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN); Visual C++ component extensions (C++/CX) uses [Windows::Foundation::DateTime](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime)).

## -examples

## -see-also
[DatePickerValueChangedEventArgs](datepickervaluechangedeventargs.md), [XAML DatePicker and TimePicker controls sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20DatePicker%20and%20TimePicker%20controls%20sample), [Quickstart: Adding a DatePicker](/previous-versions/windows/apps/dn308514(v=win.10))
