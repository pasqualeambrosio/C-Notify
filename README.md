# C Sharp Notify

This Windows Form allow to show notification of Success, Info, Warning, Error.

### Example 1
Notification of success.
Notification stay opened.
Click everywhere to close.

```csharp
Notify.Open(new Notify.NotifyOptions
{
	Message = "Success!",
	NotifyType = Notify.NotifyType.Success
});
```
### Example 2
Notification of error with autoclose after 2 seconds.
To close notification must click on close icon.

```csharp
Notify.Open(new Notify.NotifyOptions
{
	Message = "ERROR" + Environment.NewLine + "Data not found",
  AutoHideDelay = 2000,
	NotifyType = Notify.NotifyType.Error,
	ClickToClose = false
});
```
