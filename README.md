# Sweet

Syntactic sugar for .NET

## Install

You can install `Sweet` using NuGet:

```powershell
PM> Install-Package RuleSet
```

`Sweet` is a Portable Class Library which supports the following platforms:
- .NET 4.0 or later (incl. Mono)
- Xamarin.iOS
- Xamarin.Android
- Windows Store 8
- Windows Phone 8
- Silverlight 5

## Usage

Please refer to the wiki for [detailed documentation](https://github.com/jamesottaway/Sweet/wiki) on `Sweet`.

## Development

A copy of .NET or Mono is required to build the solution. You can install Mono
on OS X by running `brew bundle`, assuming you have Homebrew installed.

The supplied `Makefile` defines the following targets:
- `make clean`
- `make build`
- `make test`

## Contributing

If you have feature requests, or want to discuss a larger-than-usual patch
you'd like to contribute, please [open a new issue](https://github.com/jamesottaway/Sweet/issues/new).

If you'd like to make a contribution, please [fork Sweet](https://github.com/jamesottaway/Sweet/fork)
and [submit a pull request](https://github.com/jamesottaway/Sweet/pulls/new)
when you're ready.

After reviewing and accepting your pull request, I will bump the version and
release a new package to the official NuGet repository.
