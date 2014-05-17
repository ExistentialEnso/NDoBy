NDoBy
=====

A C#, NuGet-ready version of andyw8/do_by (which is for Ruby projects) that enables creation of "ToDo" notes that will trigger exceptions if left past a certain date. **As many people have said about the original, use of something like this is somewhat bad form,** but I was bored and wanted to see if I could throw it together in C# in about 10 minutes, complete with (included) unit tests.

Like the original, an environmental variable must be set for it to trigger to prevent it from happening in production environments:

```C#
Environment.SetEnvironmentVariable("NDoByEnabled", "1"); // Any value other than "1" treated as false
```

Creation of new ToDos involves instatiating a new NDoBy.ToDo object:

```C#
new ToDo("We need to fix this by the end of June!", new DateTime("7/1/2014 12:00 AM"));
```