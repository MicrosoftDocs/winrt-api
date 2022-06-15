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

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.TimePicker.TimeChanged](/windows/winui/api/microsoft.ui.xaml.controls.timepicker.timechanged) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

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
