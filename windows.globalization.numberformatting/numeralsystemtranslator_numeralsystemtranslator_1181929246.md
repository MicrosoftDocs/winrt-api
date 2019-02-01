---
-api-id: M:Windows.Globalization.NumberFormatting.NumeralSystemTranslator.#ctor(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public NumeralSystemTranslator(Windows.Foundation.Collections.IIterable<System.String> languages)
-->

# Windows.Globalization.NumberFormatting.NumeralSystemTranslator.NumeralSystemTranslator

## -description
Creates a [NumeralSystemTranslator](numeralsystemtranslator.md) object initialized by a language list.

## -parameters
### -param languages
A list of [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) language tags, in priority order, representing the choice of languages. They must all be well-formed according to [Windows.Globalization.Language.isWellFormed](../windows.globalization/language_iswellformed_1733554260.md).

## -remarks
This constructor creates an object initialized to use the default numeral system of the first language in *languages* which is known to the system. If none are known, it uses the current runtime language preferred by the user.

If your app passes language tags used in this class to any [National Language Support](https://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](https://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

## -examples

## -see-also
[NumeralSystemTranslator()](numeralsystemtranslator_numeralsystemtranslator_1221375020.md), [BCP-47 language tags](https://go.microsoft.com/fwlink/p/?linkid=227302)
