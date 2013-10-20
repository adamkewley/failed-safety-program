﻿namespace SafetyProgram.UI.ViewModels

open SafetyProgram.Core.Models
open SafetyProgram.UI.Views.ModelViews.ChemicalTableViews
open SafetyProgram.UI.ViewModels.ViewModelInterface

type ChemicalTableRibbonTabViewModel(model) = 

    let propertyChangedEvent = new Event<_,_>()
    let commandRequest = new Event<_>()
    let mutable currentModel = model

    let mutable search = ""
    let searchResult = Seq.empty    

    interface IViewModel<ChemicalTable> with
        member this.PushModel(newModel) = 
            currentModel <- newModel
        member this.CommandRequested = commandRequest.Publish            

    interface IChemicalTableRibbonViewModel with
        member this.Search 
            with get () = search
            and set value = search<-value
        member this.SearchResult = searchResult
        [<CLIEvent>]
        member this.PropertyChanged = propertyChangedEvent.Publish

    member this.Search 
            with get () = search
            and set value = search<-value
    member this.SearchResult = searchResult
    [<CLIEvent>]
    member this.PropertyChanged = propertyChangedEvent.Publish

