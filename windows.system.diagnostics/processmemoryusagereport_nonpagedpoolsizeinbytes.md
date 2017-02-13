---
-api-id: P:Windows.System.Diagnostics.ProcessMemoryUsageReport.NonPagedPoolSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public ulong NonPagedPoolSizeInBytes { get; }
-->

# Windows.System.Diagnostics.ProcessMemoryUsageReport.NonPagedPoolSizeInBytes

## -description
Gets the amount of non-paged memory available to the process, in bytes.

## -property-value
The amount of non-paged memory available to the process, in bytes.

## -remarks
The value returned by this property represents the current size of nonpaged system memory used by the process. System memory is the physical memory used by the operating system, and is divided into paged and nonpaged pools. Nonpaged memory allocations remain in system memory and are not paged out to the virtual memory paging file.

## -examples

## -see-also
