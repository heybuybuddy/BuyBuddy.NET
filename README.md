# BuyBuddy .NET Software Development Kit

Lead maintainer: [Buğra Ekuklu (Chatatata)](https://github.com/Chatatata).

## Abstract

The BuyBuddy .NET Software Development Kit makes your application integrate easily with BuyBuddy platform to create astonishing shopping experience.
This library provides a generic abstraction layer to access BuyBuddy platform in a modular way.

### Features
- **Platform management**: An object-oriented asynchronous abstraction of platform management to not deal with underlying HATEOAS API. Every single entity found in our platform can be managed with this library.
- **Simplified payments**: You might plug in your own payment system, or you can use existing ones found in APIs.
- **.NET Core support**: You can build cross-platform applications with this library, since it is compatible with **.NET Core**\* framework.
- **Windows 10 SDK compatible**: In order to unveil power of this SDK, you may use our seperate [Windows 10 SDK](https://github.com/heybuybuddy/BuyBuddy.Windows.SDK/), which provides straightforward implementations for *Windows Vault / Credentials Manager* etc.

## Installation

Our software development kit supports various installation methods.
You need to have **NuGet** installed on your computer.

### NuGet Package Manager

You can use package manager to install the package.

```cmd
PM> Install-Package BuyBuddy.SDK --version 0.0.1
```

### .NET CLI

You can install the package using `dotnet` binary.

```cmd
> dotnet add package BuyBuddy.SDK --version 0.0.1
```

### Paket CLI

**NuGet** also provides a way to use Paket CLI:

```cmd
paket add BuyBuddy.SDK --version 0.0.1
```

## Support

BuyBuddy engineering team is always ready to support you.

### Contributing

All contributions are welcomed, you may open issues or pull requests regarding bug (or bug fixes), new features, or improvements and clarifications in documentations.
We really try hard to make everything found (including HTTP web services) in our platform open source, hence we expect patience from you while everything is going to be eligible.

Finally, please read our [Code of Conduct](https://github.com/heybuybuddy/BuyBuddy.NET/blob/refactor/CODE_OF_CONDUCT.md).

### Running Unit Tests
1. Clone the repository to your local: `> git clone https://github.com/heybuybuddy/BuyBuddy.NET.git/`.
2. Open `BuyBuddy.NET.sln` *Visual Studio 2017* solution file.
3. Choose *Tests>Run>All Tests* from menu.

## License

MIT
