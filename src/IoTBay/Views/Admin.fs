namespace IoTBay.Views

module Admin =
    open Giraffe.ViewEngine

    let index =
        let pageTitle = "Admin"

        [ h1 [] [ encodedText pageTitle ] ]
        |> Layout.layout pageTitle
