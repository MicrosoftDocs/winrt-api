---
-api-id: P:Windows.System.MemoryManager.ExpectedAppMemoryUsageLimit
-api-type: winrt property
---

<!-- Property syntax.
public ulong ExpectedAppMemoryUsageLimit { get; }
-->

# Windows.System.MemoryManager.ExpectedAppMemoryUsageLimit

## -description
Gets the amount of memory that your app may expect to have available.

## -property-value
The expected memory cap in bytes.

## -remarks
When an app launches on Xbox, it is initially given a small app memory usage limit that may grow as the system frees memory. This property returns the expected upper limit that your app will be able to use.

When an app launches on a non-Xbox system, the memory usage limit the app gets at launch remains the same and this property will return the same value as [Windows.System.MemoryManager.AppMemoryUsageLimit](memorymanager_appmemoryusagelimit.md).

## -see-also
[Windows.System.MemoryManager.AppMemoryUsageLimitChanging](memorymanager_appmemoryusagelimitchanging.md), [Windows.System.MemoryManager.TrySetAppMemoryUsageLimit](memorymanager_trysetappmemoryusagelimit_415446483.md)

## -examples
