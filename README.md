# AutoMapperSlim

`AutoMapperSlim` is a lightweight and easy-to-use alternative mapping library for .NET projects, enabling property-based object-to-object mapping without the overhead of full-scale mappers like AutoMapper.

## ✨ Features

- Reflection-based property mapping
- Generic `Map<TSource, TDestination>()` method
- Collection mapping support with `ICollection`
- Simple integration with Dependency Injection (DI) via `IServiceCollection` extension

---
- `Dependency Injection`
```bash
builder.Services.AddAutoMapperSlimServices();
```bash

## 🔧 Installation

### 1. Add via NuGet

Using CLI:

```bash
dotnet add package AutoMapperSlim
