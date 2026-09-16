## Part A — Project Structure

### `.csproj` File

The project file contains the main configuration and settings used to build and run the application.

For this project, the following settings are configured:

* **OutputType:** `Exe`
  This means the project is a console application that can be executed

* **TargetFramework:** `net10.0`
  The project targets .NET 10.

* **ImplicitUsings:** `enable`
  Common namespaces are included automatically, which reduces the need to write frequently used `using` statements manually

* **Nullable:** `enable`
  Nullable reference type checking is enabled, allowing the compiler to warn about possible null-related issues

These settings define the basic behavior and environment of the project
