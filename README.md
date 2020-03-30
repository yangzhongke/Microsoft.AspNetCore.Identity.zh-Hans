# Microsoft.AspNetCore.Identity.zh-Hans
Chinese version of IdentityError of asp.net core identity. 此程序包包含 ASP.NET Core  Identity 的简体中文附属程序集。
把报错信息显示为中文

```
Install-Package ZackYang.Microsoft.AspNetCore.Identity.zh-Hans
```
and add follwing code in Startup.cs
```
services.AddZh_HansIdentityErrorDescriber();
```
