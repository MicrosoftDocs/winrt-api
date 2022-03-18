---
-api-id: T:Windows.Globalization.DateTimeFormatting.DateTimeFormatter
-api-type: winrt class
---

<!-- Class syntax.
public class DateTimeFormatter : Windows.Globalization.DateTimeFormatting.IDateTimeFormatter, Windows.Globalization.DateTimeFormatting.IDateTimeFormatter2
-->

# Windows.Globalization.DateTimeFormatting.DateTimeFormatter

## -description

Formats dates and times.

## -remarks

> [!NOTE]
> This API is being updated to support the May 2019 Japanese era change. If your application supports the Japanese calendar, you should validate that it properly handles the new era. See [Prepare your application for the Japanese era change](/windows/uwp/design/globalizing/japanese-era-change) for more information.

> [!NOTE]
> If your app passes language tags used in this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

Some of the constructors for DateTimeFormatter take a *formatTemplate* string parameter that specifies the requested components to be formatted. This parameter can be either a **format template** or a **format pattern**. Format templates are convenient to use and provide formatting which is typical for the language, clock and calendar that you specify. Format patterns provide greater control of output than format templates. If you need formatting that is non-standard, use format patterns instead of templates.

In a format template, you specify the components (time, date, day of week, etc.) that you want to include in the formatted output. The formatter formats the components as appropriate for the specified language, clock and calendar. The order of the components in your template does not matter; the formatter orders the components according to the order shown in the format template language below.

Some commonly-used templates are listed in the following table. In templates with more than one component, the component may be any of the supported component variations and the components may be in any order. For example, "dayofweek.full year month.numeric day" is supported. (See below, after the Examples, for the grammar that defines valid templates.)

> [!IMPORTANT]
> You can't arbitrarily combine components and necessarily obtain a valid template. The only valid templates are those defined by the provided grammar.

<table>
   <tr><th>Template</th></tr>
   <tr><td>longdate</td></tr>
   <tr><td>shortdate</td></tr>
   <tr><td>longtime</td></tr>
   <tr><td>shorttime</td></tr>
   <tr><td>dayofweek</td></tr>
   <tr><td>dayofweek.full</td></tr>
   <tr><td>dayofweek.abbreviated</td></tr>
   <tr><td>day</td></tr>
   <tr><td>month</td></tr>
   <tr><td>month.full</td></tr>
   <tr><td>month.abbreviated</td></tr>
   <tr><td>month.numeric</td></tr>
   <tr><td>year</td></tr>
   <tr><td>year.full</td></tr>
   <tr><td>year.abbreviated</td></tr>
   <tr><td>dayofweek day month year</td></tr>
   <tr><td>dayofweek day month</td></tr>
   <tr><td>day month year</td></tr>
   <tr><td>day month</td></tr>
   <tr><td>month year</td></tr>
   <tr><td>hour</td></tr>
   <tr><td>minute</td></tr>
   <tr><td>second</td></tr>
   <tr><td>hour minute second</td></tr>
   <tr><td>hour minute</td></tr>
   <tr><td>timezone</td></tr>
   <tr><td>timezone.full</td></tr>
   <tr><td>timezone.abbreviated</td></tr>
   <tr><td>year month day hour</td></tr>
</table>

The following table shows sample output from formatters created with various values of template, language, and clock. The "Equivalent pattern" column provides a pattern that produces the same output as the template.

<table>
   <tr><th>Template</th><th>Language</th><th>Clock</th><th>Output</th><th>Equivalent pattern</th></tr>
   <tr><td>longdate</td><td>en-US</td><td>&lt;not specified&gt;</td><td>‎Monday‎, ‎September‎ ‎2‎, ‎2013</td><td>‎{dayofweek.full}‎, ‎{month.full}‎ ‎{day.integer}‎, ‎{year.full}</td></tr>
   <tr><td>longdate</td><td>fr-FR</td><td>&lt;not specified&gt;</td><td>lundi‎ ‎2‎ ‎septembre‎ ‎2013</td><td>{dayofweek.full}‎ ‎{day.integer}‎ ‎{month.full}‎ ‎{year.full}</td></tr>
   <tr><td>shortdate</td><td>en-US</td><td>&lt;not specified&gt;</td><td>9‎/‎2‎/‎2013</td><td>{month.integer}‎/‎{day.integer}‎/‎{year.full}</td></tr>
   <tr><td>shortdate</td><td>fr-FR</td><td>&lt;not specified&gt;</td><td>02‎/‎09‎/‎2013</td><td>‎{day.integer(2)}‎/‎{month.integer(2)}‎/‎{year.full}</td></tr>
   <tr><td>dayofweek month day</td><td>en-US</td><td>&lt;not specified&gt;</td><td>‎Monday‎, ‎September‎ ‎2</td><td>{dayofweek.full}‎, ‎{month.full}‎ ‎{day.integer}</td></tr>
   <tr><td>month day dayofweek</td><td>en-US</td><td>&lt;not specified&gt;</td><td>‎Monday‎, ‎September‎ ‎2</td><td>{dayofweek.full}‎, ‎{month.full}‎ ‎{day.integer}</td></tr>
   <tr><td>longtime</td><td>en-US</td><td>&lt;not specified&gt;</td><td>‎6‎:‎01‎:‎24‎ ‎AM</td><td>{hour.integer}‎:‎{minute.integer(2)}‎:‎{second.integer(2)}‎ ‎{period.abbreviated}</td></tr>
   <tr><td>longtime</td><td>en-US</td><td>24HourClock</td><td>‎17‎:‎32‎:‎45</td><td>{hour.integer}‎:‎{minute.integer(2)}‎:‎{second.integer(2)}</td></tr>
   <tr><td>longtime</td><td>fr-FR</td><td>&lt;not specified&gt;</td><td>17‎:‎32‎:‎45</td><td>{hour.integer(2)}‎:‎{minute.integer(2)}‎:‎{second.integer(2)}</td></tr>
   <tr><td>shorttime</td><td>en-US</td><td>&lt;not specified&gt;</td><td>6‎:‎01‎ ‎AM</td><td>{hour.integer}‎:‎{minute.integer(2)}‎ ‎{period.abbreviated}</td></tr>
   <tr><td>shorttime</td><td>en-US</td><td>24HourClock</td><td>17‎:‎32</td><td>‎{hour.integer}‎:‎{minute.integer(2)}</td></tr>
   <tr><td>shorttime</td><td>fr-FR</td><td>&lt;not specified&gt;</td><td>17‎:‎32</td><td>‎{hour.integer(2)}‎:‎{minute.integer(2)}</td></tr>
</table>

**Format patterns** are composed of a literal string with fields delimited by braces, such as "{day.numeric}/{month.numeric}/{year.full}". Some commonly-used fields are listed in the following table. (See below, after the Examples, for the grammar that defines valid patterns.)

> [!IMPORTANT]
> You can't arbitrarily combine fields and necessarily obtain a valid pattern. The only valid patterns are those defined by the provided grammar.

<table>
   <tr><th>Format pattern field</th></tr>
   <tr><td>{openbrace}</td></tr>
   <tr><td>{closebrace}</td></tr>
   <tr><td>{dayofweek.solo.&lt;type&gt;} where &lt;type&gt; is full / abbreviated / abbreviated(n)</td></tr>
   <tr><td>{dayofweek.&lt;type&gt;} where &lt;type&gt; is full / abbreviated / abbreviated(n)</td></tr>
   <tr><td>{day.&lt;type&gt;} where &lt;type&gt; is integer / integer(n)</td></tr>
   <tr><td>{month.&lt;type&gt;} where &lt;type&gt; is full / abbreviated / abbreviated(n) / integer / integer(n)</td></tr>
   <tr><td>{month.solo.&lt;type&gt;} where &lt;type&gt; is full / abbreviated / abbreviated(n)</td></tr>
   <tr><td>{year.&lt;type&gt;} where &lt;type&gt; is full / abbreviated / abbreviated(n)</td></tr>
   <tr><td>{era.&lt;type&gt;} where &lt;type&gt; is full / abbreviated / abbreviated(n)</td></tr>
   <tr><td>{hour.&lt;type&gt;} where &lt;type&gt; is integer / integer(n)</td></tr>
   <tr><td>{period.&lt;type&gt;} where &lt;type&gt; is full / abbreviated / abbreviated(n)</td></tr>
   <tr><td>{minute.&lt;type&gt;} where &lt;type&gt; is integer / integer(n)</td></tr>
   <tr><td>{second.&lt;type&gt;} where &lt;type&gt; is integer / integer(n)</td></tr>
   <tr><td>{timezone.&lt;type&gt;} where &lt;type&gt; is full / abbreviated / abbreviated(n)</td></tr>
</table>

> [!NOTE]
> + Use **{openbrace}** or **{closebrace}** to specify that "{" or "}" appears as part of the literal string.
+ **solo** specifies the standalone form. For languages with genitive case distinctions, the genitive case is the unmarked case. To get the nominative case, use **solo**.
+ **integer(2)** for the fifth day of the month (for example) is "05", while **integer(1)** produces "5". **integer** produces the best **n** for a given language/calendar combination.
+ For years, **full** produces all digits ("2013"). **abbreviated** is synonymous with **abbreviated(2)**, which is the 2-digit year for the gregorian calendar ("13"). (Other calendars may eventually use something else as the default; we have kept **abbreviated** to have the semantics of the best for a given language/calendar combination.) **abbreviated(n)** is truncated to the least significant **n** digits (for example, 2013 with **n** =1 is "3").

The following table shows sample output from formatters created with various values of pattern, language, and clock.

<table>
   <tr><th>Pattern</th><th>Language</th><th>Clock</th><th>Output</th></tr>
   <tr><td>{dayofweek.full}, ‎{month.full} {day.integer}, ‎{year.full}</td><td>en-US</td><td>&lt;not specified&gt;</td><td>Monday, ‎September 2, ‎2013</td></tr>
   <tr><td>{dayofweek.full}, ‎{day.integer(2)} ‎{month.full}, ‎{year.full}</td><td>fr-FR</td><td>&lt;not specified&gt;</td><td>lundi, ‎02 ‎septembre, ‎2013</td></tr>
   <tr><td>{month.integer}/‎{day.integer}/{year.full}</td><td>en-US</td><td>&lt;not specified&gt;</td><td>9/‎2/2013</td></tr>
   <tr><td>{month.integer}/‎{day.integer}/{year.abbreviated}</td><td>en-US</td><td>&lt;not specified&gt;</td><td>9/‎2/13</td></tr>
   <tr><td>{month.integer(2)}/‎{day.integer(2)}/{year.abbreviated}</td><td>en-US</td><td>&lt;not specified&gt;</td><td>09/‎02/13</td></tr>
   <tr><td>{hour.integer}:{minute.integer(2)}:{second.integer(2)} {period.abbreviated}</td><td>en-US</td><td>&lt;not specified&gt;</td><td>6:01:24 AM</td></tr>
   <tr><td>{hour.integer}:{minute.integer(2)}:{second.integer(2)} {period.abbreviated}</td><td>en-US</td><td>24HourClock</td><td>17:32:45</td></tr>
</table>

## -examples

Use the DateTimeFormatter class to format a date.

```csharp
// Format a date via a string template. Note that the order specifed in the string pattern does
// not determine the order of the parts of the formatted string. The user's language and region
// preferences will determine the pattern of the date returned based on the specified parts.

var formatter = new Windows.Globalization.DateTimeFormatting.DateTimeFormatter("month day dayofweek year");
DateTime dateToFormat = DateTime.Now;
var mydate = formatter.Format(dateToFormat);

```

**Pattern grammar**The following grammar defines what is accepted for a pattern:

```
<pattern> ::= [<literal-text>] <datetime-pattern> [<literal-text>] |
              [<literal-text>] <datetime-pattern> <pattern>

<literal-text> ::= <literal-character>+

<literal-character> ::= [^{}] | "{openbrace}" | "{closebrace}"

<datetime-pattern> ::= <date-pattern> | <time-pattern>

<date-pattern> ::= <era> | <year> | <month> | <day> | <dayofweek>

<time-pattern> ::= <period> | <hour> | <minute> | <second> | <timezone>

<era> ::= "{era.abbreviated" [<ideal-length>] "}"

<year> ::= "{year.full" [<ideal-length>] "}" |
           "{year.abbreviated" [<ideal-length>] "}"

<month> ::= "{month.full}" |
            "{month.solo.full}" |
            "{month.abbreviated" [<ideal-length>] "}"
            "{month.solo.abbreviated" [<ideal-length>] "}"
            "{month.integer" [<ideal-length>] "}"

<dayofweek> ::= "{dayofweek.full}" |
                "{dayofweek.solo.full}" |
                "{dayofweek.abbreviated" [<ideal-length>] "}"
                "{dayofweek.solo.abbreviated" [<ideal-length>] "}"

<day> ::= "{day.integer" [<ideal-length>] "}"

<period> ::= "{period.abbreviated" [<ideal-length>] "}"

<hour> ::= "{hour.integer" [<ideal-length>] "}"

<minute> ::= "{minute.integer" [<ideal-length>] "}"

<second> ::= "{second.integer" [<ideal-length>] "}"

<timezone> ::= "{timezone.full}" |
                "{timezone.abbreviated" [<ideal-length>] "}"

<ideal-length> ::= "(" <non-zero-digit> ")"

<non-zero-digit> ::= "1" | "2" | "3" | "4" | "5" | "6" | "7" | "8" | "9"

```

**Template grammar**The following grammar defines what is accepted for a template:

```
<template> ::= <opt-whitespace> <date> <opt-whitespace> |
               <opt-whitespace> <time> <opt-whitespace> |
               <opt-whitespace> <specific-date> <whitespace> <time> <opt-whitespace> |
               <opt-whitespace> <time> <whitespace> <specific-date> <opt-whitespace> |
               <opt-whitespace> <relative-date> <whitespace> <time> <opt-whitespace> |
               <opt-whitespace> <time> <whitespace> <relative-date> <opt-whitespace>

<opt-whitespace> ::= [<whitespace>] 

<whitespace> ::= " "+ 

<date> ::= <year> | <month> | <day> | <month-year> | <relative-date> | <specific-date>

<relativedate> ::= <dayofweek> | <month-day> | <relative-longdate>

<specificdate> ::= <shortdate> | <longdate>

<month-day> ::= <month> <whitespace> <day> |
                <day> <whitespace> <month>

<relative-longdate> ::= <month> <whitespace> <day> <whitespace> <dayofweek> |
                        <month> <whitespace> <dayofweek> <whitespace> <day> |
                        <day> <whitespace> <month> <whitespace> <dayofweek> |
                        <day> <whitespace> <dayofweek> <whitespace> <month> |
                        <dayofweek> <whitespace> <day> <whitespace> <month> |
                        <dayofweek> <whitespace> <month> <whitespace> <day>

<month-year> ::= <month> <whitespace> <year> |
                 <year> <whitespace> <month>


<shortdate> ::= "shortdate" |
                <month> <whitespace> <day> <whitespace> <year> |
                <month> <whitespace> <year> <whitespace> <day> |
                <day> <whitespace> <month> <whitespace> <year> |
                <day> <whitespace> <year> <whitespace> <month> |
                <year> <whitespace> <day> <whitespace> <month> |
                <year> <whitespace> <month> <whitespace> <day>


<longdate> ::= "longdate" |
               <year> <whitespace> <month> <whitespace> <day> <whitespace> <dayofweek> |
               <year> <whitespace> <month> <whitespace> <dayofweek> <whitespace> <day> |
               <year> <whitespace> <day> <whitespace> <month> <whitespace> <dayofweek> |
               <year> <whitespace> <day> <whitespace> <dayofweek> <whitespace> <month> |
               <year> <whitespace> <dayofweek> <whitespace> <day> <whitespace> <month> |
               <year> <whitespace> <dayofweek> <whitespace> <month> <whitespace> <day> |
               <month> <whitespace> <year> <whitespace> <day> <whitespace> <dayofweek> |
               <month> <whitespace> <year> <whitespace> <dayofweek> <whitespace> <day> |
               <day> <whitespace> <year> <whitespace> <month> <whitespace> <dayofweek> |
               <day> <whitespace> <year> <whitespace> <dayofweek> <whitespace> <month> |
               <dayofweek> <whitespace> <year> <whitespace> <day> <whitespace> <month> |
               <dayofweek> <whitespace> <year> <whitespace> <month> <whitespace> <day> |
               <month> <whitespace> <day> <whitespace> <year> <whitespace> <dayofweek> |
               <month> <whitespace> <dayofweek> <whitespace> <year> <whitespace> <day> |
               <day> <whitespace> <month> <whitespace> <year> <whitespace> <dayofweek> |
               <day> <whitespace> <dayofweek> <whitespace> <year> <whitespace> <month> |
               <dayofweek> <whitespace> <day> <whitespace> <year> <whitespace> <month> |
               <dayofweek> <whitespace> <month> <whitespace> <year> <whitespace> <day> |
               <month> <whitespace> <day> <whitespace> <dayofweek> <whitespace> <year> |
               <month> <whitespace> <dayofweek> <whitespace> <day> <whitespace> <year> |
               <day> <whitespace> <month> <whitespace> <dayofweek> <whitespace> <year> |
               <day> <whitespace> <dayofweek> <whitespace> <month> <whitespace> <year> |
               <dayofweek> <whitespace> <day> <whitespace> <month> <whitespace> <year> |
               <dayofweek> <whitespace> <month> <whitespace> <day> <whitespace> <year>

<time> ::= <hour> | 
           <hour> <whitespace> <timezone> |
           <timezone> <whitespace> <hour> |
           <shorttime> |
           <longtime>

<shorttime> ::= "shorttime" |
                <hour> <whitespace> <minute> |
                <minute> <whitespace> <hour> |
                <timezone> <whitespace> <hour> <whitespace> <minute> |
                <timezone> <whitespace> <minute> <whitespace> <hour> |
                <hour> <whitespace> <timezone> <whitespace> <minute> |
                <minute> <whitespace> <timezone> <whitespace> <hour> |
                <hour> <whitespace> <minute> <whitespace> <timezone> |
                <minute> <whitespace> <hour> <whitespace> <timezone>

<longtime> ::= "longtime" |
               <hour> <whitespace> <minute> <whitespace> <second> |
               <hour> <whitespace> <second> <whitespace> <minute> |
               <minute> <whitespace> <hour> <whitespace> <second> |
               <minute> <whitespace> <second> <whitespace> <hour> |
               <second> <whitespace> <minute> <whitespace> <hour> |
               <second> <whitespace> <hour> <whitespace> <minute> |
               <timezone> <whitespace> <hour> <whitespace> <minute> <whitespace> <second> |
               <timezone> <whitespace> <hour> <whitespace> <second> <whitespace> <minute> |
               <timezone> <whitespace> <minute> <whitespace> <hour> <whitespace> <second> |
               <timezone> <whitespace> <minute> <whitespace> <second> <whitespace> <hour> |
               <timezone> <whitespace> <second> <whitespace> <minute> <whitespace> <hour> |
               <timezone> <whitespace> <second> <whitespace> <hour> <whitespace> <minute> |
               <hour> <whitespace> <timezone> <whitespace> <minute> <whitespace> <second> |
               <hour> <whitespace> <timezone> <whitespace> <second> <whitespace> <minute> |
               <minute> <whitespace> <timezone> <whitespace> <hour> <whitespace> <second> |
               <minute> <whitespace> <timezone> <whitespace> <second> <whitespace> <hour> |
               <second> <whitespace> <timezone> <whitespace> <minute> <whitespace> <hour> |
               <second> <whitespace> <timezone> <whitespace> <hour> <whitespace> <minute> |
               <hour> <whitespace> <minute> <whitespace> <timezone> <whitespace> <second> |
               <hour> <whitespace> <second> <whitespace> <timezone> <whitespace> <minute> |
               <minute> <whitespace> <hour> <whitespace> <timezone> <whitespace> <second> |
               <minute> <whitespace> <second> <whitespace> <timezone> <whitespace> <hour> |
               <second> <whitespace> <minute> <whitespace> <timezone> <whitespace> <hour> |
               <second> <whitespace> <hour> <whitespace> <timezone> <whitespace> <minute> |
               <hour> <whitespace> <minute> <whitespace> <second> <whitespace> <timezone> |
               <hour> <whitespace> <second> <whitespace> <minute> <whitespace> <timezone> |
               <minute> <whitespace> <hour> <whitespace> <second> <whitespace> <timezone> |
               <minute> <whitespace> <second> <whitespace> <hour> <whitespace> <timezone> |
               <second> <whitespace> <minute> <whitespace> <hour> <whitespace> <timezone> |
               <second> <whitespace> <hour> <whitespace> <minute> <whitespace> <timezone>

<year> ::= "year" | "year.full" | "year.abbreviated"

<month> ::= "month" | "month.full" | "month.abbreviated" | "month.numeric"

<day> ::= "day"

<dayofweek> ::= "dayofweek" | "dayofweek.full" | "dayofweek.abbreviated"

<hour> ::= "hour"

<minute> ::= "minute"

<second> ::= "second"

<timezone> ::= "timezone" | "timezone.full" | "timezone.abbreviated"

```

## -see-also

[Date and time formatting sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Date%20and%20time%20formatting%20sample), [Date and time formatting sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624044)
