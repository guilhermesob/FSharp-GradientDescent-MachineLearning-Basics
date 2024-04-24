module CostFunctionTests

open NUnit.Framework
open FsUnit

open CostFunction

[<TestFixture>]
type ``Cost Function Tests``() =

    [<Test>]
    member this.``Cost function should return correct value for simple dataset``() =
        let x = [|1.0; 2.0; 3.0; 4.0; 5.0|]
        let y = [|2.0; 3.0; 4.0; 5.0; 6.0|]
        let theta = [|0.0; 0.0|] // Coeficientes inicializados com zero

        let cost = costFunction x y theta

        // Verificar se o valor de custo é aproximadamente 5.0, que é o valor esperado para este conjunto de dados
        cost |> should be (within 0.01) 5.0
