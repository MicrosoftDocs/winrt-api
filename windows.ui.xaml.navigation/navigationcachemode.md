---
-api-id: T:Windows.UI.Xaml.Navigation.NavigationCacheMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Navigation.NavigationCacheMode : int
-->

# NavigationCacheMode

## -description
Specifies caching characteristics for a page involved in a navigation.



## -enum-fields
### -field Disabled:0
The page is never cached and a new instance of the page is created on each visit.

### -field Required:1
The page is cached and the cached instance is reused for every visit regardless of the cache size for the frame.

### -field Enabled:2
The page is cached, but the cached instance is discarded when the size of the cache for the frame is exceeded.


## -remarks

## -examples

## -see-also
