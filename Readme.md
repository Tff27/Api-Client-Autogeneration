Example of Client Generation with NSwag
============

![Build](https://github.com/Tff27/Api-Client-Autogeneration/actions/workflows/dotnet.yml/badge.svg)

This solution contains 3 projects:
* ClientGenerator - An API with the default WeatherForecastController and with automated swagger file generation on build;
* SDK - A library with the SDK generated on build with API swagger file;
* Client - A console app that uses the generated SDK;

## Main Goals
* Auto-generate an SDK for an application;
* Regenerate the client on API change;
* Use the generated SDK on an API client;

## Resources & Inspiration
* https://devblogs.microsoft.com/dotnet/generating-http-api-clients-using-visual-studio-connected-services/
* https://markheath.net/post/openapi-autogen-aspnetcore
* https://github.com/RicoSuter/NSwag/wiki/CSharpClientGeneratorSettings
