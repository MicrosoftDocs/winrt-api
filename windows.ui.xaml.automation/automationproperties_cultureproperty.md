---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.CultureProperty
-api-type: winrt property
---

<!-- Property syntax.
public DependencyProperty CultureProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.CultureProperty

## -description
Gets the identifier for the culture attached property which contains a locale identifier for the automation element (for example, 0x0409 for "en-US" or English (United States)).  

## -property-value
The identifier for the culture attached property.  

## -remarks
Each locale has a unique identifier, a 32-bit value that consists of a language identifier and a sort order identifier. The locale identifier is a standard international numeric abbreviation and has the components necessary to uniquely identify one of the installed operating system-defined locales. For more information, see [Language Identifier Constants and Strings](https://docs.microsoft.com/windows/desktop/Intl/language-identifier-constants-and-strings).  

This property may exist on a per-control basis, but typically is only available on an application level.

## -see-also

## -examples

