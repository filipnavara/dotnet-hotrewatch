# dotnet-hotrewatch

## Installation

Run `dotnet tool install -g dotnet-hotrewatch --version "*-*"`.

If you are on Apple Silicon you may receive an error `zsh: killed     dotnet-hotrewatch`. To workaround that run `codesign -s "-" ~/.dotnet/tools/dotnet-hotrewatch` after the installation. This is a bug in the .NET SDK that will hopefully get fixed soon.

## Usage

See [the original usage documentation](https://github.com/filipnavara/dotnet-hotrewatch/blob/main/dotnet-watch/README.md). The main difference is that you need to use `dotnet-hotrewatch <arguments>` instead of `dotnet watch <arguments>`.
