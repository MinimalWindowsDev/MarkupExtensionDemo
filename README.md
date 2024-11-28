# WPF Markup Extension Demo

A minimal example demonstrating how to use Markup Extensions to handle compile-time conditional XAML content in WPF applications.

## Overview

This project demonstrates how to:

- Create a custom Markup Extension for conditional XAML content
- Use preprocessor directives to control content at compile time
- Avoid XAML duplication and visibility bindings

## Core Feature

```xaml
<Button Content="{local:FeatureCondition
    WhenEnabled='New Content',
    WhenDisabled='Original Content'}" />
```

## Building

Build original version:

```batch
msbuild.exe MarkupExtensionDemo.csproj
```

Build with new feature enabled:

```batch
msbuild.exe MarkupExtensionDemo.csproj /p:DefineConstants="fix_issue_001"
```

## Requirements

- Visual Studio 2019
- .NET Framework
- WPF

## Notes

- Clean the solution between builds when switching preprocessor directives
- The example shows both simple text switching and a counter increment (by 1 or 2)
- Uses MarkupExtension for cleaner, more maintainable conditional XAML
