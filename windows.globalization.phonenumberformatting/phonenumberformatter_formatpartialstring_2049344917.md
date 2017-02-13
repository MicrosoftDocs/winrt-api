---
-api-id: M:Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter.FormatPartialString(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string FormatPartialString(System.String number)
-->

# Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter.FormatPartialString

## -description
Returns a string representing the formatted partial phone number given.

Use this method to format phone numbers as they are being entered by a user, to help the user visualize the complete, formatted number.

## -parameters
### -param number
A string representing a partial phone number.

## -returns
The input string, formatted as a partial phone number.

## -remarks
The following table shows the results of repeatedly calling this method as a user enters digits from a phone number, using a formatter set to the "US" region.

<table>
   <tr><th>Digits passed to FormatPartialString</th><th>Formatted output</th></tr>
   <tr><td>1</td><td>1</td></tr>
   <tr><td>14</td><td>14</td></tr>
   <tr><td>142</td><td>142</td></tr>
   <tr><td>1425</td><td>1 425</td></tr>
   <tr><td>1425555</td><td>1 425-555</td></tr>
   <tr><td>14255558</td><td>1 425-555-8</td></tr>
   <tr><td>14255558080</td><td>1 425-555-8080</td></tr>
</table>

The following code snippet demonstrates a TextChanged event handler that updates a TextBlock with the formatted partial number whenever the number typed into the event handler's TextBox changes.

```csharp

using Windows.Globalization.PhoneNumberFormatting;

PhoneNumberFormatter currentFormatter;

public MainPage()
{
    this.InitializeComponent();

    // Using the current default region
    currentFormatter = new PhoneNumberFormatter();
}

private void gradualInput_TextChanged(object sender, TextChangedEventArgs e)
{
    outBlock.Text = currentFormatter.FormatPartialString(gradualInput.Text);
}

```



## -examples

## -see-also
