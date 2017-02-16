---
-api-id: P:Windows.System.Diagnostics.ProcessMemoryUsageReport.PeakVirtualMemorySizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public ulong PeakVirtualMemorySizeInBytes { get; }
-->

# Windows.System.Diagnostics.ProcessMemoryUsageReport.PeakVirtualMemorySizeInBytes

## -description
Gets the maximum amount of virtual memory used by the associated process.

## -property-value
The maximum amount of virtual memory, in bytes, allocated for the associated process since it was started.

## -remarks
The value returned by this property represents the maximum size of virtual memory used by the process since it started. The operating system maps the virtual address space for each process either to pages loaded in physical memory, or to pages stored in the virtual memory paging file on disk.

## -examples

## -see-also
