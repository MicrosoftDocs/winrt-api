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

When you handle this event, use the [OldDate](datepickerselectedvaluechangedeventargs_olddate.md) and [NewDate](datepickerselectedvaluechangedeventargs_newdate.md) properties of the [DatePickerSelectedValueChangedEventArgs](datepickerselectedvaluechangedeventargs.md) event data for your logic. These properties use different data types depending on your programming language (C# and Visual Basic use [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true); Visual C++ component extensions (C++/CX) uses [Windows::Foundation::DateTime](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime)).

## -see-also

[SelectedDate](datepicker_selecteddate.md), [DatePickerSelectedValueChangedEventArgs](datepickerselectedvaluechangedeventargs.md), [Date picker](/windows/uwp/design/controls-and-patterns/date-picker)

## -examples

Here's an example of a `SelectedDateChanged` event handler. To see this example with more context, see [Calendar, date, and time controls - Use a date picker and time picker together](/windows/uwp/design/controls-and-patterns/date-and-time#use-a-date-picker-and-time-picker-together).

```xaml
<StackPanel>
    <DatePicker x:Name="arrivalDatePicker" Header="Arrival date"
                SelectedDateChanged="ArrivalDatePicker_SelectedDateChanged"/>
    <TextBlock x:Name="arrivalText"/>
</StackPanel>
```

```csharp
DateTime arrivalDateTime;

private void ArrivalDatePicker_SelectedDateChanged(DatePicker sender, DatePickerSelectedValueChangedEventArgs args)
{
    if (arrivalDatePicker.SelectedDate != null)
    {
        if (VerifyDateIsFuture((DateTimeOffset)arrivalDatePicker.SelectedDate) == true)
        {
            arrivalDateTime = new DateTime(args.NewDate.Value.Year, args.NewDate.Value.Month, args.NewDate.Value.Day);

            arrivalText.Text = arrivalDateTime.ToString();
        }
        else
        {
            arrivalDatePicker.SelectedDate = null;
            arrivalText.Text = "Arrival date must be later than today.";
        }
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
