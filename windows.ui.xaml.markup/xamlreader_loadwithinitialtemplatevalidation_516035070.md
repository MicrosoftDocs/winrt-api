---
-api-id: M:Windows.UI.Xaml.Markup.XamlReader.LoadWithInitialTemplateValidation(System.String)
-api-type: winrt method
---

<!-- Method syntax
public object LoadWithInitialTemplateValidation(System.String xaml)
-->

# Windows.UI.Xaml.Markup.XamlReader.LoadWithInitialTemplateValidation

## -description
Parses a well-formed XAML fragment creates a corresponding object tree, and returns the root of the object tree. Also performs load-time validation of any linked templates.

## -parameters
### -param xaml
A string that contains a valid XAML fragment.

## -returns
The root object of the created object tree.

## -remarks
Usage for [LoadWithInitialTemplateValidation](xamlreader_loadwithinitialtemplatevalidation_516035070.md) is generally the same as for [XamlReader.Load](xamlreader_load_1077941801.md). For more info, see "Remarks" section of [XamlReader.Load](xamlreader_load_1077941801.md). Most apps won't need the template validation feature; that aspect is more intended for design tools that are actively changing and reloading XAML, and perhaps enabling real-time XAML template editing.

## -examples

## -see-also
[XamlReader.Load](xamlreader_load_1077941801.md), [XAML syntax guide](http://msdn.microsoft.com/library/a57fe7b4-9947-4aa0-bc99-5fe4686b611d), [XAML overview](http://msdn.microsoft.com/library/48041b37-f1a8-44a4-bb8e-1d4de30e7823)