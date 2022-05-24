---
-api-id: M:Windows.System.AppUriHandlerRegistration.UpdateHosts(Windows.Foundation.Collections.IIterable{Windows.System.AppUriHandlerHost})
-api-type: winrt method
---

# Windows.System.AppUriHandlerRegistration.UpdateHosts(Windows.Foundation.Collections.IIterable{Windows.System.AppUriHandlerHost})

<!--
public void UpdateHosts (System.Collections.Generic.IEnumerable<Windows.System.AppUriHandlerHost> hosts);
-->


## -description

Updates all the app URI registrations specified in the collection.

## -parameters

### -param hosts

The collection of [AppUriHandlerHost](appurihandlerhost.md) objects to update.

## -remarks

Each registration is represented by an [AppUriHandlerHost](appurihandlerhost.md) object. For each object, the caller can set the [IsEnabled](appurihandlerhost_isenabled.md) property to enable or disable that registration. The list of registrations can either be the full list for that app or a subset. It cannot include new registrations that are not already in the list.  Any existing registrations that are not specified in the list remain unchanged. 

This method requires the **Microsoft.delegatedWebFeatures** capability.

## -see-also

## -examples


