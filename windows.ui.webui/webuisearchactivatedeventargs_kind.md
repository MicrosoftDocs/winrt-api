---
-api-id: P:Windows.UI.WebUI.WebUISearchActivatedEventArgs.Kind
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Activation.ActivationKind Kind { get; }
-->

# Windows.UI.WebUI.WebUISearchActivatedEventArgs.Kind

## -description
Gets the activation type.

## -property-value
The [activationKind.search](../windows.applicationmodel.activation/activationkind.md) enumeration value.

## -remarks

## -examples
The [Search contract sample](http://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to determine when an app is activated for search in the app's activated event handler.



[TODO:AUTO_SNIPPET (SAMPLE_ID:searchextension)(SNIPPET_ID:searchkind_js)]In the sample, `e` is a [webUISearchActivatedEventArgs](webuisearchactivatedeventargs.md) object. The sample checks the `e`.[queryText](webuisearchactivatedeventargs_querytext.md) property to determine whether the app should display results for the query.

## -see-also
