---
-api-id: E:Windows.UI.Xaml.Controls.TimePicker.SelectedTimeChanged
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler SelectedTimeChanged<TimePicker, TimePickerSelectedValueChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.TimePicker.SelectedTimeChanged

## -description

Occurs when the value of the `SelectedTime` property is changed.



## -xaml-syntax

```xaml
<TimePicker SelectedTimeChanged="eventhandler" />
```

## -remarks

## -see-also

## -examples

For an example of using a `DatePicker` and `TimePicker` together to update a single `DateTime` value, see [Calendar, date, and time controls - Use a date picker and time picker together](/windows/uwp/design/controls-and-patterns/date-and-time#use-a-date-picker-and-time-picker-together).

```xaml
 <TimePicker SelectedTimeChanged="TimePicker_SelectedTimeChanged"/>
 <TextBlock x:Name="resultText"/>
```

```csharp
private void TimePicker_SelectedTimeChanged(TimePicker sender, TimePickerSelectedValueChangedEventArgs args)
{
    DateTime myTime = DateTime.Today + (TimeSpan)args.NewTime;
    if (DateTime.Now >= myTime)
    {
        resultText.Text = "Your selected time has already past.";
    }
    else
    {
        string hrs = (myTime - DateTime.Now).Hours.ToString();
        string mins = (myTime - DateTime.Now).Minutes.ToString();
        resultText.Text = string.Format("Your selected time is {0} hours, {1} minutes from now.", hrs, mins);
    }
}
```
