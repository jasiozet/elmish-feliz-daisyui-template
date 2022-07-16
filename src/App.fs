module App

open Feliz
open Feliz.DaisyUI
open Elmish

type State = { count: int }

type Msg =
  | Increment
  | Decrement
  | IncrementDelayed

let update (msg: Msg) (state: State) : State * Cmd<Msg> =
  match msg with
  | Increment -> { state with count = state.count + 1 }, Cmd.none
  | Decrement -> { state with count = state.count - 1 }, Cmd.none
  | IncrementDelayed ->
    let bumpAfter2sec =
      async {
        do! Async.Sleep 2000
        return Increment
      }
    state, Cmd.OfAsync.result bumpAfter2sec

let init () = { count = 0 }, Cmd.none

let clickableButton isPrimary (text: string) onClick =
  Daisy.button.button [
    button.outline
    if isPrimary then button.primary
    button.lg
    prop.text text
    prop.onClick (onClick)
  ]

let render (state: State) (dispatch: Msg -> unit) =
  Html.div [
    Html.h1 (state.count |> string)

    Html.div [
      clickableButton true "Increment" (fun _ -> dispatch Increment)
      clickableButton true "Increment" (fun _ -> dispatch Decrement)
      clickableButton true "Increment after 2 sec" (fun _ -> dispatch IncrementDelayed)
    ]
  ]