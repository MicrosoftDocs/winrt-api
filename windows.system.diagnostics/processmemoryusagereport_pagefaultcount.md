---
-api-id: P:Windows.System.Diagnostics.ProcessMemoryUsageReport.PageFaultCount
-api-type: winrt property
---

<!-- Property syntax
public uint PageFaultCount { get; }
-->

# Windows.System.Diagnostics.ProcessMemoryUsageReport.PageFaultCount

## -description
Gets the number of memory page faults.

## -property-value
The number of memory page faults.

## -remarks
A memory page fault occurs when requested data is not found in memory. The system generates a fault, which normally indicates that the system looks for data in the paging file. In this circumstance, however, the missing data is identified as being located within an area of memory that cannot be paged out to disk. The system faults, but cannot find, the data and is unable to recover. Faulty hardware, a buggy system service, antivirus software, and a corrupted NTFS volume can all generate this type of error.

## -examples

## -see-also
