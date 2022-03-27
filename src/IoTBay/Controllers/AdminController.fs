namespace IoTBay.Controllers

module AdminController =
    open Giraffe
    open IoTBay.Views.Admin

    let indexController: HttpHandler = htmlView index

    let adminRouter: HttpHandler = route "/admin" >=> indexController
