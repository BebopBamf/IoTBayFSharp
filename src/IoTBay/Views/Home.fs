namespace IoTBay.Views

module Home =
    open Giraffe.ViewEngine
    open Layout

    let index =
        [ h1 [] [
              encodedText "IoTBay Online Store"
          ] ]
        |> layout "Home"
