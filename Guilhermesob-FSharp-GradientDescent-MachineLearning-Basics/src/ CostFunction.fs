module CostFunction

// Função de custo para uma regressão linear
// Calcula o erro quadrático médio (MSE) entre os valores previstos e os valores reais
let costFunction (x: float[]) (y: float[]) (theta: float[]) =
    let m = float x.Length
    let sum = x |> Array.mapi (fun i xi -> (Array.zip xi theta |> Array.sumBy (fun (x, t) -> x * t)) - y.[i]) |> Array.sumBy (fun x -> x ** 2.0)
    sum / (2.0 * m)

// Função de custo para uma regressão linear com múltiplas variáveis independentes
// Calcula o erro quadrático médio (MSE) entre os valores previstos e os valores reais
let costFunctionMultiple (x: float[][]) (y: float[]) (theta: float[]) =
    let m = float y.Length
    let sum = x |> Array.mapi (fun i xi -> (Array.zip xi theta |> Array.sumBy (fun (x, t) -> x * t)) - y.[i]) |> Array.sumBy (fun x -> x ** 2.0)
    sum / (2.0 * m)
