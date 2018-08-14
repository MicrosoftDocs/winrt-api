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
When you handle this event, use the [OldDate](datepickervaluechangedeventargs_olddate.md) and [NewDate](datepickervaluechangedeventargs_newdate.md) properties of the [DatePickerValueChangedEventArgs](datepickervaluechangedeventargs.md) event data for your logic. These properties use different data types depending on your programming language (C# and Visual Basic use [System.DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx); Visual C++ component extensions (C++/CX) uses [Windows::Foundation::DateTime](http://msdn.microsoft.com/library/b5533002-8a72-438d-a3d3-0902ffc21830)).

## -examples

## -see-also
[DatePickerValueChangedEventArgs](datepickervaluechangedeventargs.md), [XAML DatePicker and TimePicker controls sample](http://go.microsoft.com/fwlink/p/?LinkID=310075), [Quickstart: Adding a DatePicker](http://msdn.microsoft.com/library/feae870d-e423-457b-9d0a-3929247952a9)