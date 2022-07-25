---
-api-id: E:Windows.UI.Xaml.Controls.TimePicker.TimeChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.EventHandler TimeChanged<Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.TimePicker.TimeChanged

## -description
Occurs when the value of the `Time` property is changed.



## -xaml-syntax
```xaml
<TimePicker TimeChanged="eventhandler" />
```


## -remarks

## -examples

```xaml
 <TimePicker TimeChanged="TimePicker_TimeChanged"/>
 <TextBlock x:Name="resultText"/>
```

```csharp
private void TimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
{
    DateTime myTime = DateTime.Today + e.NewTime;
    var timeDiff = e.NewTime - e.OldTime;
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

## -see-also
