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

When you handle this event, use the [OldDate](datepickervaluechangedeventargs_olddate.md) and [NewDate](datepickervaluechangedeventargs_newdate.md) properties of the [DatePickerValueChangedEventArgs](datepickervaluechangedeventargs.md) event data for your logic. These properties use different data types depending on your programming language (C# and Visual Basic use [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true); Visual C++ component extensions (C++/CX) uses [Windows::Foundation::DateTime](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime)).

## -examples

Here's an example of a `DateChanged` event handler.

```xaml
<StackPanel>
    <DatePicker x:Name="arrivalDatePicker" Header="Arrival date"
                DateChanged="ArrivalDatePicker_DateChanged"/>
    <TextBlock x:Name="arrivalText"/>
</StackPanel>
```

```csharp
DateTime arrivalDateTime;

private void ArrivalDatePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
{
    if (VerifyDateIsFuture(arrivalDatePicker.Date) == true)
    {
        arrivalDateTime = new DateTime(e.NewDate.Year, e.NewDate.Month, e.NewDate.Day);
        arrivalText.Text = string.Format("Thank you. Your arrival is set for {0}.",
                                         arrivalDateTime.Date.ToString("D"));
    }
    else
    {
        arrivalText.Text = "Arrival date must be later than today.";
    }
}

private bool VerifyDateIsFuture(DateTimeOffset date)
{
    if (date > DateTimeOffset.Now)
    {
        return true;
    }
    return false;
}
```

## -see-also

[Date](datepicker_date.md), [SelectedDate](datepicker_selecteddate.md), [DatePickerValueChangedEventArgs](datepickervaluechangedeventargs.md), [Date picker](/windows/uwp/design/controls-and-patterns/date-picker)
