---
-api-id: T:Windows.Globalization.NumberFormatting.PermilleFormatter
-api-type: winrt class
---

<!-- Class syntax.
public class PermilleFormatter : Windows.Globalization.NumberFormatting.INumberFormatter, Windows.Globalization.NumberFormatting.INumberFormatter2, Windows.Globalization.NumberFormatting.INumberFormatterOptions, Windows.Globalization.NumberFormatting.INumberParser, Windows.Globalization.NumberFormatting.INumberRounderOption, Windows.Globalization.NumberFormatting.ISignedZeroOption, Windows.Globalization.NumberFormatting.ISignificantDigitsOption
-->

# Windows.Globalization.NumberFormatting.PermilleFormatter

## -description

Formats and parses permillages.

## -remarks

> [!NOTE]
> If your app passes language tags used in this class to any [National Language Support](https://docs.microsoft.com/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](https://docs.microsoft.com/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

```javascript
// This scenario uses the Windows.Globalization.NumberFormatting.PercentFormatter and
// the Windows.Globalization.NumberFormatting.PermilleFormatter classes to format numbers
// as a percent or a permille.

// Create formatters initialized using the current user's preference settings.
var percentFormat = new Windows.Globalization.NumberFormatting.PercentFormatter();
var permilleFormat = new Windows.Globalization.NumberFormatting.PermilleFormatter();

// Make a random number.
var randomNumber = Math.random();

// Format with current user preferences.
var percent = percentFormat.format(randomNumber);
var permille = permilleFormat.format(randomNumber);

// Get a fixed number.
var fixedNumber = 500;

// Format with grouping using default.
var percentFormat1 = new Windows.Globalization.NumberFormatting.PercentFormatter();
percentFormat1.isGrouped = true;
var percent1 = percentFormat1.format(fixedNumber);

// Format with grouping using French.
var percentFormatFR = new Windows.Globalization.NumberFormatting.PercentFormatter(["fr-FR"], "FR");
percentFormatFR.isGrouped = true;
var percentFR = percentFormatFR.format(fixedNumber);

// Format with no fractional digits using default.
var percentFormat2 = new Windows.Globalization.NumberFormatting.PercentFormatter();
percentFormat2.fractionDigits = 0;
var percent2 = percentFormat2.format(fixedNumber);

// Format always with a decimal point.
var percentFormat3 = new Windows.Globalization.NumberFormatting.PercentFormatter();
percentFormat3.isDecimalPointAlwaysDisplayed = true;
percentFormat3.fractionDigits = 0;
var percent3 = percentFormat3.format(fixedNumber);

// Display the results.
var results = "Random number (" + randomNumber + ")\n" +
              "Percent formatted: " + percent + "\n" +
              "Permille formatted: " + permille + "\n\n" +
              "Fixed number (" + fixedNumber + ")\n" +
              "Percent formatted (grouped): " + percent1 + "\n" +
              "Percent formatted (grouped as fr-FR): " + percentFR + "\n" +
              "Percent formatted (no fractional digits): " + percent2 + "\n" +
              "Percent formatted (always with a decimal point): " + percent3;
```

```csharp
// This scenario uses the Windows.Globalization.NumberFormatting.PercentFormatter and
// the Windows.Globalization.NumberFormatting.PermilleFormatter classes to format numbers
// as a percent or a permille.

//using System.Text;
//using Windows.Globalization.NumberFormatting;
            
StringBuilder sb = new StringBuilder();

// Create numbers to format.
double randomNumber = new Random().NextDouble();
ulong fixedNumber = 500;

// Create percent formatters.
PercentFormatter defaultPercentFormatter = new PercentFormatter();
PercentFormatter languagePercentFormatter = new PercentFormatter(new[] { "fr-FR" }, "ZZ");

// Create permille formatters.
PermilleFormatter defaultPermilleFormatter = new PermilleFormatter();
PermilleFormatter languagePermilleFormatter = new PermilleFormatter(new[] { "ar" }, "ZZ");

// Format random numbers as percent or permille.
sb.AppendLine("Random number: " + randomNumber);
sb.AppendLine("Percent formatted: " + defaultPercentFormatter.Format(randomNumber));
sb.AppendLine("Permille formatted: " + defaultPermilleFormatter.Format(randomNumber));
sb.AppendLine();
sb.AppendLine("Language-specific percent formatted: " + languagePercentFormatter.Format(randomNumber));
sb.AppendLine("Language-specific permille formatted: " + languagePermilleFormatter.Format(randomNumber));
sb.AppendLine();
sb.AppendLine("Fixed number: " + fixedNumber);

// Format fixed number with grouping.
defaultPercentFormatter.IsGrouped = true;
sb.AppendLine("Percent formatted (grouped): " + defaultPercentFormatter.Format(fixedNumber));

//Format with grouping using French language.
languagePercentFormatter.IsGrouped = true;
sb.AppendLine("Percent formatted (grouped as fr-FR): " + defaultPercentFormatter.Format(fixedNumber));

// Format with no fraction digits.
defaultPercentFormatter.FractionDigits = 0;
sb.AppendLine("Percent formatted (no fractional digits): " + defaultPercentFormatter.Format(fixedNumber));

// Format always with a decimal point.
defaultPercentFormatter.IsDecimalPointAlwaysDisplayed = true;
sb.AppendLine("Percent formatted (always with a decimal point): " + defaultPercentFormatter.Format(fixedNumber));
```

## -see-also

[Number formatting and parsing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Universal%20Windows%20app%20samples/111487-Universal%20Windows%20app%20samples/Number%20formatting%20and%20parsing%20sample), [INumberFormatterOptions](inumberformatteroptions.md), [INumberFormatter](inumberformatter.md), [INumberFormatter2](inumberformatter2.md), [INumberParser](inumberparser.md), [ISignificantDigitsOption](isignificantdigitsoption.md), [INumberRounderOption](inumberrounderoption.md), [Number formatting and parsing sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620578)
