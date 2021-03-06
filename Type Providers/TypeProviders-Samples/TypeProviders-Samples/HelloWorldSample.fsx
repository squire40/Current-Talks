﻿#r "FSharp.Data.TypeProviders"
#r @"..\..\BasicTypeProvider\BasicTypeProvider\bin\Debug\BasicTypeProvider.dll"

open Microsoft.FSharp.Data.TypeProviders
open Samples.HelloWorldTypeProvider
open Samples.OneType

module OneTypeSample = 
    type name = OnePropertyType
    let getData = 
        name.Name

module HelloWorldSample = 
    let getData = 
        let thirtysix = Type36("36")
        let fortyfive = Type45("45")
        let twentytwo = Type22("twentytwo")
        let fortysix = Type46("FORTY-SIX")
        let nineteen = Type19("19")
        let ninetyeight = Type98("@halibut!")

        (thirtysix, fortyfive, twentytwo, fortysix, nineteen, ninetyeight)
