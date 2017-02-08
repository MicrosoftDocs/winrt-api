---
-api-id: T:Windows.ApplicationModel.Background.ContentPrefetchTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class ContentPrefetchTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.IContentPrefetchTrigger
-->

# Windows.ApplicationModel.Background.ContentPrefetchTrigger

## -description
Provides the ability to run custom handlers when prefetching web resources.

## -remarks
Developers can attach a handler to preload and cache web content so an app can launch and have its content refreshed and up to date. Accessing cached content helps reduce app activation time by not having to queue costly web requests.

In addition to custom tasks, the existing [ContentPrefetcher](../windows.networking.backgroundtransfer/contentprefetcher.md) API is still available and can be used instead of the custom task when the prerequisite work only involves preloading and caching content from a fixed or dynamic set of URIs.

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)