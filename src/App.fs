module App

open Feliz
open Feliz.DaisyUI
open Feliz.UseElmish
open Elmish

type State = { count: int }

type Msg =
  | Increment
  | Decrement

let update (msg: Msg) (state: State) : State * Cmd<Msg> =
  match msg with
  | Increment -> { state with count = state.count + 1 }, Cmd.none
  | Decrement -> { state with count = state.count - 1 }, Cmd.none
  
let init () = { count = 0 }, Cmd.none

let clickableButton isPrimary (text: string) onClick =
  Daisy.button.button [
    button.outline
    if isPrimary then button.primary
    button.lg
    prop.text text
    prop.onClick (onClick)
  ]

[<ReactComponent>]
let Component () =
  let state, dispatch = React.useElmish(init, update, [||])
  
  Html.div [
    Html.h1 (state.count |> string)

    Html.div [
      clickableButton true "Increment" (fun _ -> dispatch Increment)
      clickableButton true "Increment" (fun _ -> dispatch Decrement)
    ]
  ]