# Fable Elmish Feliz Feliz.DaisyUI Vite App

This is a template Fable project for me which uses [Vite 3](https://fable.io/Fable.Lit/docs/hmr.html) so you can easily get started and add your own code progressively.

## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 6.0 or higher
* [node.js](https://nodejs.org)
* An F# editor like Visual Studio, Visual Studio Code with [Ionide](http://ionide.io/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

## Building and running the app

* Install dependencies: `npm install`
* Run the app: `npm start`
* Build the app for deployment: `npm run build`

Any modification you do to the F# code will be reflected in the web page after saving.

## Elmish book

Make sure to read the excellent [Elmish Book](https://zaid-ajaj.github.io/the-elmish-book/#/) by Zaid Ajaj.
I would like to personally thank Zaid for everything he has done for F# Community.

## Project structure

```
.
├── Nuget.Config
├── README.md
├── package-lock.json
├── package.json - JS dependencies
├── build - Ready to deploy files when you run `npm run build`
├── dist - Compiled JS from F# file
├── index.html - Main HTML file
├── vite.config.js - config for vite
├── tailwind.config.js - config for tailwind
├── public
│   ├── favicon.ico - Fable favicon
└── src
    ├── Main.fs - F# kickstarting elmish
    ├── Extensions.fs - F# helper functions from Feliz template
    ├── App.fs - F# sample Elmish with commands
    └── App.fsproj - F# project
```

## What's included:
* [Elmish](https://elmish.github.io/elmish/)
* [Feliz](https://zaid-ajaj.github.io/Feliz/#/)
* [Feliz.DaisyUI](https://dzoukr.github.io/Feliz.DaisyUI/#/)
* [Vite](https://vitejs.dev/)

Commands for that:
* femto install Fable.Elmish
* femto install Fable.Elmish.React
* femto install Feliz
* femto install Feliz.DaisyUI
* npm i -D vite