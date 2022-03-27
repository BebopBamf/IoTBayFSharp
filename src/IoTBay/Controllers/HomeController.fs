namespace IoTBay.Controllers

module HomeController =
    open Giraffe
    open IoTBay.Views.Home

    let indexController: HttpHandler = htmlView index

    let homeRouter: HttpHandler = route "/" >=> indexController
