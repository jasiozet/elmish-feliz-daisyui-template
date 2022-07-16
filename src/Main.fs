module Main

open Elmish
open Elmish.React


Fable.Core.JsInterop.importSideEffects "./index.css"

Program.mkProgram App.init App.update App.render
|> Program.withConsoleTrace
|> Program.withReactSynchronous "elmish-app"
|> Program.run