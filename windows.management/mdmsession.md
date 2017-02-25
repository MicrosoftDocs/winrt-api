---
-api-id: T:Windows.Management.MdmSession
-api-type: winrt class
---

<!-- Class syntax.
public class MdmSession 
-->

# Windows.Management.MdmSession

## -description
Provides functionality to start an MDM session with the server.

## -remarks
Once a session is complete, the caller can determine the server's response to each alert from the client.  By default, sessions persist so clients can look up the results later.

Data from a session can be deleted by calling [MdmSession.Delete](mdmsession_delete_432759908.md) or [MdmSessionManager.DeleteSessionById](mdmsessionmanager_deletesessionbyid_612343759.md) once the session is complete.

> Note: MDM sessions are **not** abortable. If the caller cancels a session and starts a new one, the original sessions will continue in the background until it's complete. 

This API does not expose the server ID or enrollment.

## -see-also

## -examples

