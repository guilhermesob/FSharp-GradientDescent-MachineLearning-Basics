let hypothesis (x: float) (theta: float[]) =
    let theta0 = theta.[0]
    let theta1 = theta.[1]
    theta0 + theta1 * x

let rmse (x: float[]) (y: float[]) (theta: float[]) =
    let predictions = x |> Array.map (hypothesis theta)
    let squaredErrors = x |> Array.zip y |> Array.map (fun (y, prediction) -> (y - prediction) ** 2.0)
    let meanSquaredError = squaredErrors |> Array.average
    sqrt meanSquaredError
