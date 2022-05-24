---
-api-id: N:Windows.Globalization.Fonts
-api-type: winrt namespace
---

# Windows.Globalization.Fonts

## -description

Provides classes that allow apps to select language-appropriate and script-appropriate fonts for text display.

> [!NOTE]
> If you're using C++ or C, then also consider the [International Components for Unicode (ICU)](/windows/win32/intl/international-components-for-unicode--icu-).

## -remarks

If your app passes language tags from this namespace to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

For a list of standard country/region codes used by Microsoft, see the [Official Country/Region List](/windows/uwp/publish/supported-languages).

## -examples

## -see-also

[Language font mapping sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/LanguageFont)
