---
-api-id: T:Windows.UI.Xaml.ApplicationInitializationCallbackParams
-api-type: winrt class
---

<!-- Class syntax.
public class ApplicationInitializationCallbackParams : Windows.UI.Xaml.IApplicationInitializationCallbackParams
-->

# Windows.UI.Xaml.ApplicationInitializationCallbackParams

## -description
A class that developers should derive from in order to pass information for a custom initialization sequence, in cases where both an [Application](application.md) subclass is present and the entry point [Start](application_start_1074858869.md) call is adjusted to pass the information.

Equivalent WinUI class: [Microsoft.UI.Xaml.ApplicationInitializationCallbackParams](/windows/winui/api/microsoft.ui.xaml.applicationinitializationcallbackparams).

## -remarks
This class is used as a custom information source for an [ApplicationInitializationCallback](applicationinitializationcallback.md) implementation. The basic ApplicationInitializationCallbackParams does not have any unique members. Your subclass should add any members you need for initialization information.

## -examples

## -see-also
[Application](application.md), [ApplicationInitializationCallback](applicationinitializationcallback.md)
