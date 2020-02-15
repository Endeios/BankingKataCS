# Conclusion of the experiment:

Programming in C# can be pleasent, but it really needs the right tools
I have been told is much better than java, but is quite the same, not real differnce
it is true that the source is less verbose, but you still really need an editor
to be productive in the language. VS without resharper is quite unfriendly as user experience,
but I understand that is made also to allow the tooling all around.
VS Code is a little bit more pleasent if you come from the console world, and is much less
cluttered: I do prefer this small editor for these little programs. 

All in all, if one wants to develop in a sound way, the best is probably to just
buy the Rider and stick with that.

## For the  release of the product

Important pages for releaseing th prodcut targeting a framework
- [Target frameworks in SDK-style projects](https://docs.microsoft.com/en-us/dotnet/standard/frameworks)
- [.NET Core RID Catalog](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog)
- [.NET Core dependencies and requirements](https://docs.microsoft.com/en-us/dotnet/core/install/dependencies)
- [dotnet publish](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish?tabs=netcore21)
- [.NET Core application publishing overview](https://docs.microsoft.com/en-us/dotnet/core/deploying/#publish-runtime-dependent)
- [Target frameworks in SDK-style projects](https://docs.microsoft.com/en-us/dotnet/standard/frameworks)

```
dotnet publish BankKata --configuration Release --runtime linux-x64 --self-contained false --framework netcoreapp3.1
```
