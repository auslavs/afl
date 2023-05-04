#r "nuget: Fable.SimpleHttp, 3.5.0"
#r "nuget: FSharp.Data, 6.2.0"

open FSharp.Data

let [<Literal>] teams = "https://aflapi.afl.com.au/afl/v2/teams"

type Simple = JsonProvider<teams>
let simple = Simple.Parse(""" { "name":"Tomas", "age":4 } """)
