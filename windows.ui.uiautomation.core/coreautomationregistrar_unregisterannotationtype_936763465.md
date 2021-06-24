---
-api-id: M:Windows.UI.UIAutomation.Core.CoreAutomationRegistrar.UnregisterAnnotationType(Windows.UI.UIAutomation.Core.AutomationAnnotationTypeRegistration)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.CoreAutomationRegistrar.UnregisterAnnotationType(Windows.UI.UIAutomation.Core.AutomationAnnotationTypeRegistration)

<!--
public static void UnregisterAnnotationType (Windows.UI.UIAutomation.Core.AutomationAnnotationTypeRegistration registration);
-->

## -description

Unregisters a custom annotation type that was previously registered for text ranges with [RegisterAnnotationType(System.Guid)](coreautomationregistrar_registerannotationtype_1084655315.md).

## -parameters

### -param registration

A registration object returned by [RegisterAnnotationType(System.Guid)](coreautomationregistrar_registerannotationtype_1084655315.md).

## -remarks

An annotation type registration lasts as long as the process for which it was registered. You can call this method, or let the registration expire with the process for which it was registered.

If the same annotation type is registered more than once, this method must be called for each.

## -see-also

## -examples
