---
-api-id: T:Windows.Media.Protection.PlayReady.PlayReadyContentResolver
-api-type: winrt class
---

<!-- Class syntax.
public class PlayReadyContentResolver 
-->

# Windows.Media.Protection.PlayReady.PlayReadyContentResolver

## -description
Receives multiple service request objects that are necessary to enable the playback ability for a given content header.

## -remarks
There are multiple operations that may need to be performed before playback can occur for a given content header. For example, individualization, domain join, and license acquisition may all be required (and multiple attempts of each could occur). If licenses are already present, the content resolver will try to enable the first license that is found rather than making a deterministic choice or allowing the app to choose.

## -examples

## -see-also
