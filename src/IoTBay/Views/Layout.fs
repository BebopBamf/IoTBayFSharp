namespace IoTBay.Views

module Layout =
    open Giraffe.ViewEngine

    let layout name (content: XmlNode list) =
        let headingTitle = $"IoTBay - %s{name}" |> encodedText
        let bodyContent = content @ [ script [ _src "/js/index.js" ] [] ]

        html [] [
            head [] [
                title [] [ headingTitle ]
                link [ _rel "stylesheet"
                       _type "text/css"
                       _href "/css/style.css" ]
            ]
            body [] bodyContent
        ]
