namespace IoTBay.Views

module Layout =
    open Giraffe.ViewEngine
    open IoTBay.Models

    let layout (content: XmlNode list) =
        html [] [
            head [] [
                title []  [ encodedText "IoTBayFSharp" ]
                link [ _rel  "stylesheet"
                       _type "text/css"
                       _href "/style.css" ]
            ]
            body [] content
        ]

    let partial () =
        h1 [] [ encodedText "IoTBayFSharp" ]

    let index (model : Message) =
        [
            partial()
            p [] [ encodedText model.Text ]
        ] |> layout


