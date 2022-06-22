---
-api-id: P:Windows.UI.Xaml.Media.FontFamily.XamlAutoFontFamily
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.FontFamily XamlAutoFontFamily { get; }
-->

# Windows.UI.Xaml.Media.FontFamily.XamlAutoFontFamily

## -description
Gets the default font family based on an app's language settings.



## -property-value
The default font family based on an app's language settings. See Remarks.
## -remarks
XamlAutoFontFamily is the default **FontFamily** property setting for all XAML controls. The [FontFamily](fontfamily.md) that this property gets at run time depends on the app language.

<table>
   <tr><th>Language</th><th>Default FontFamily</th></tr>
   <tr><td>Japanese</td><td>Yu Gothic UI</td></tr>
   <tr><td>Korean</td><td>Malgun Gothic</td></tr>
   <tr><td>All others</td><td>Segoe UI</td></tr>
</table>



<!--<p>	FontFamily.XamlAutoFontFamily.Source returns the actual font family for the app, for example, "Segoe UI" or "Yu Gothic UI", rather than "XamlAutoFontFamily".</p>-->

## -examples
```xaml
<TextBlock FontFamily="XamlAutoFontFamily"/>
```

```csharp

TextBlock textBlock1 = new TextBlock();
textBlock1.FontFamily = FontFamily.XamlAutoFontFamily;
```



## -see-also
