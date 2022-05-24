---
-api-id: M:Windows.UI.UIAutomation.Core.CoreAutomationRegistrar.RegisterAnnotationType(System.Guid)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.CoreAutomationRegistrar.RegisterAnnotationType(System.Guid)

<!--
public static Windows.UI.UIAutomation.Core.AutomationAnnotationTypeRegistration RegisterAnnotationType (Guid guid);
-->

## -description

Registers a custom annotation type for text ranges.

## -parameters

### -param guid

The GUID that represents the custom annotation type. This must be the same as the GUID used by the UI Automation provider.

## -returns

An object that provides an ID corresponding to the GUID registered for use in other UIA APIs that require an annotation ID.

## -remarks

Both the UI Automation (UIA) provider and client call this method to register a custom annotation type. The *guid* must be the same for both.

The same annotation type GUID can be registered more than once on the same process. An identical registration is returned if called on a GUID that is already registered. [UnregisterAnnotationType(Windows.UI.UIAutomation.Core.AutomationAnnotationTypeRegistration)](coreautomationregistrar_unregisterannotationtype_936763465.md) must still be called once for each call to this method, even if the same GUID is registered multiple times.

An annotation type registration lasts as long as the process for which it was registered or until [UnregisterAnnotationType(Windows.UI.UIAutomation.Core.AutomationAnnotationTypeRegistration)](coreautomationregistrar_unregisterannotationtype_936763465.md) is called.

## -see-also

## -examples
