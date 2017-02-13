---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFaceAuthenticationGroup.#ctor(Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Perception.Provider.PerceptionStartFaceAuthenticationHandler,Windows.Devices.Perception.Provider.PerceptionStopFaceAuthenticationHandler)
-api-type: winrt method
---

<!-- Method syntax
public PerceptionFaceAuthenticationGroup(Windows.Foundation.Collections.IIterable<System.String> ids, Windows.Devices.Perception.Provider.PerceptionStartFaceAuthenticationHandler startHandler, Windows.Devices.Perception.Provider.PerceptionStopFaceAuthenticationHandler stopHandler)
-->

# Windows.Devices.Perception.Provider.PerceptionFaceAuthenticationGroup.PerceptionFaceAuthenticationGroup

## -description
Initializes a new PerceptionFaceAuthenticationGroup instance.

## -parameters
### -param ids
The collection of unique identifiers which maps to IPerceptionFrameProviders via PerceptionFrameProviderInfo::Id.

### -param startHandler
The handler to invoke when this group is requested to enter Face Authentication mode returning if it's ready.

### -param stopHandler
The handler to invoke when this group is leaving Face Authentication mode after startHandler is called and returned true.

## -remarks
Creates a PerceptionFaceAuthenticationGroup from a collection of unique identifiers specifying IPerceptionFrameProviders, a handler for the start of Face Authentication, and a handler for the end of Face Authentication.

## -examples

## -see-also
