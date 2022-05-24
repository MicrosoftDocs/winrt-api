---
-api-id: N:Windows.Globalization.NumberFormatting
-api-type: winrt namespace
---

# Windows.Globalization.NumberFormatting

## -description

Provides classes for formatting currencies, decimal numbers, percent values, and permille values, based on the user's languages and geographic region.

> [!NOTE]
> If you're using C++ or C, then also consider the [International Components for Unicode (ICU)](/windows/win32/intl/international-components-for-unicode--icu-).

## -remarks

If your app passes language tags from this namespace to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

For a list of standard country/region codes used by Microsoft, see the [Official Country/Region List](/windows/uwp/publish/supported-languages).

## -examples

## -see-also

[Number formatting and parsing sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/NumberFormatting)
