---
-api-id: P:Windows.UI.Xaml.Controls.Page.NavigationCacheMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Navigation.NavigationCacheMode NavigationCacheMode { get;  set; }
-->

# Windows.UI.Xaml.Controls.Page.NavigationCacheMode

## -description
Gets or sets the navigation mode that indicates whether this [Page](page.md) is cached, and the period of time that the cache entry should persist.



## -xaml-syntax
```xaml
<page NavigationCacheMode="navigationCacheModeMemberName" />
```


## -property-value
A value of the enumeration. The default is **Disabled**.

## -remarks
To enable a page to be cached, set NavigationCacheMode to either **Enabled** or **Required**. The difference in behavior is that **Enabled** might not be cached if the frame's cache size limit ([CacheSize](frame_cachesize.md)) is exceeded, whereas **Required** always generates an entry no matter the size limit.

If you want to change the value of NavigationCacheMode programmatically to **Enabled** or **Required**, you can only set these values in the constructor for the page.

If you change the value of NavigationCacheMode from **Required** or **Enabled** to **Disabled**, the page is flushed from the cache. The page is not simply marked as available to be flushed when the configured [CacheSize](frame_cachesize.md) is exceeded.

## -examples
For example code that uses NavigationCacheMode, see [Navigation](/windows/uwp/layout/navigation-basics).

## -see-also
[Frame](frame.md), [Frame.CacheSize](frame_cachesize.md), [NavigationCacheMode](../windows.ui.xaml.navigation/navigationcachemode.md), [Navigation](/windows/uwp/layout/navigation-basics)
