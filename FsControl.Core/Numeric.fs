#nowarn "77" 
// Warn FS0077 -> Member constraints with the name 'Abs' are given special status by the F# compiler as certain .NET types are implicitly augmented with this member. This may result in runtime failures if you attempt to invoke the member constraint from your own code.
// But the first Abs overload relies in the standard abs function which handle all those simulated cases.

namespace FsControl.Core.TypeMethods

open FsControl.Core.Internals
open FsControl.Core.Internals.Prelude
open System.Runtime.CompilerServices
open System.Runtime.InteropServices


type FromBigInt =
    inherit Default1
    static member inline FromBigInt (_:^R        ,_:Default4  ) = fun (x:bigint) -> Explicit.Invoke x         :^R
    static member inline FromBigInt (_:^R        ,_:Default3  ) = fun (x:bigint) -> Implicit.Invoke (int64 x) :^R
    static member inline FromBigInt (_:^R        ,_:Default2  ) = fun (x:bigint) -> Implicit.Invoke x         :^R
    static member inline FromBigInt (_:^R        ,_:Default1  ) = fun (x:bigint) -> (^R: (static member FromBigInt: _ -> ^R) x)
    static member inline FromBigInt (_:Default1  ,_:Default1  ) = fun (x:bigint) -> (^R: (static member FromBigInt: _ -> ^R) x)
    static member        FromBigInt (_:int32     ,_:FromBigInt) = fun (x:bigint) -> int             x
    static member        FromBigInt (_:int64     ,_:FromBigInt) = fun (x:bigint) -> int64           x
    static member        FromBigInt (_:nativeint ,_:FromBigInt) = fun (x:bigint) -> nativeint  (int x)
    static member        FromBigInt (_:unativeint,_:FromBigInt) = fun (x:bigint) -> unativeint (int x)
    static member        FromBigInt (_:bigint    ,_:FromBigInt) = fun (x:bigint) ->                 x
    static member        FromBigInt (_:float     ,_:FromBigInt) = fun (x:bigint) -> float           x
#if NOTNET35
    static member        FromBigInt (_:sbyte     ,_:FromBigInt) = fun (x:bigint) -> sbyte           x
    static member        FromBigInt (_:int16     ,_:FromBigInt) = fun (x:bigint) -> int16           x
    static member        FromBigInt (_:byte      ,_:FromBigInt) = fun (x:bigint) -> byte            x
    static member        FromBigInt (_:uint16    ,_:FromBigInt) = fun (x:bigint) -> uint16          x
    static member        FromBigInt (_:uint32    ,_:FromBigInt) = fun (x:bigint) -> uint32          x
    static member        FromBigInt (_:uint64    ,_:FromBigInt) = fun (x:bigint) -> uint64          x
    static member        FromBigInt (_:float32   ,_:FromBigInt) = fun (x:bigint) -> float32         x
    static member        FromBigInt (_:decimal   ,_:FromBigInt) = fun (x:bigint) -> decimal         x
#else
    static member        FromBigInt (_:sbyte     ,_:FromBigInt) = fun (x:bigint) -> sbyte      (int x)
    static member        FromBigInt (_:int16     ,_:FromBigInt) = fun (x:bigint) -> int16      (int x)
    static member        FromBigInt (_:byte      ,_:FromBigInt) = fun (x:bigint) -> byte       (int x)
    static member        FromBigInt (_:uint16    ,_:FromBigInt) = fun (x:bigint) -> uint16     (int x)
    static member        FromBigInt (_:uint32    ,_:FromBigInt) = fun (x:bigint) -> uint32     (int x)
    static member        FromBigInt (_:uint64    ,_:FromBigInt) = fun (x:bigint) -> uint64     (int64 x)
    static member        FromBigInt (_:float32   ,_:FromBigInt) = fun (x:bigint) -> float32    (int x)
    static member        FromBigInt (_:decimal   ,_:FromBigInt) = fun (x:bigint) -> decimal    (int x)
#endif

    static member inline Invoke (x:bigint)   :'Num    =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member FromBigInt: _*_ -> _) b, a)
        let inline call (a:'a) = fun (x:'x) -> call_2 (a, Unchecked.defaultof<'r>) x :'r
        call Unchecked.defaultof<FromBigInt> x

type FromInt64 =
    inherit Default1
    static member inline FromInt64 (_:^R        ,_:Default4  ) = fun (x:int64) -> Explicit.Invoke x            : ^R
    static member inline FromInt64 (_:^R        ,_:Default3  ) = fun (x:int64) -> FromBigInt.Invoke (bigint x) : ^R
    static member inline FromInt64 (_:^R        ,_:Default2  ) = fun (x:int64) -> Implicit.Invoke x            : ^R
    static member inline FromInt64 (_:^R        ,_:Default1  ) = fun (x:int64) -> (^R: (static member FromInt64: _ -> ^R) x)
    static member inline FromInt64 (_:Default1  ,_:Default1  ) = fun (x:int64) -> (^R: (static member FromInt64: _ -> ^R) x)
    static member        FromInt64 (_:int32     , _:FromInt64) = fun (x:int64) -> int32           x
    static member        FromInt64 (_:int64     , _:FromInt64) = fun (x:int64) ->                 x
    static member        FromInt64 (_:nativeint , _:FromInt64) = fun (x:int64) -> nativeint  (int x)
    static member        FromInt64 (_:unativeint, _:FromInt64) = fun (x:int64) -> unativeint (int x)
    static member        FromInt64 (_:bigint    , _:FromInt64) = fun (x:int64) -> bigint          x
    static member        FromInt64 (_:float     , _:FromInt64) = fun (x:int64) -> float           x
#if NOTNET35
    static member        FromInt64 (_:float32   , _:FromInt64) = fun (x:int64) -> float32         x
    static member        FromInt64 (_:decimal   , _:FromInt64) = fun (x:int64) -> decimal         x
    static member        FromInt64 (_:sbyte     , _:FromInt64) = fun (x:int64) -> sbyte           x
    static member        FromInt64 (_:int16     , _:FromInt64) = fun (x:int64) -> int16           x
    static member        FromInt64 (_:byte      , _:FromInt64) = fun (x:int64) -> byte            x
    static member        FromInt64 (_:uint16    , _:FromInt64) = fun (x:int64) -> uint16          x
    static member        FromInt64 (_:uint32    , _:FromInt64) = fun (x:int64) -> uint32          x
#else
    static member        FromInt64 (_:float32   , _:FromInt64) = fun (x:int64) -> float32    (int x)
    static member        FromInt64 (_:decimal   , _:FromInt64) = fun (x:int64) -> decimal    (int x)
    static member        FromInt64 (_:sbyte     , _:FromInt64) = fun (x:int64) -> sbyte      (int x)
    static member        FromInt64 (_:int16     , _:FromInt64) = fun (x:int64) -> int16      (int x)
    static member        FromInt64 (_:byte      , _:FromInt64) = fun (x:int64) -> byte       (int x)
    static member        FromInt64 (_:uint16    , _:FromInt64) = fun (x:int64) -> uint16     (int x)
    static member        FromInt64 (_:uint32    , _:FromInt64) = fun (x:int64) -> uint32     (int x)
#endif
    static member        FromInt64 (_:uint64    , _:FromInt64) = fun (x:int64) -> uint64          x

    static member inline Invoke (x:int64)   :'Num    =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member FromInt64: _*_ -> _) b, a)
        let inline call (a:'a) = fun (x:'x) -> call_2 (a, Unchecked.defaultof<'r>) x :'r
        call Unchecked.defaultof<FromInt64> x


type FromInt32 =
    inherit Default1
    static member inline FromInt32 (_:^R        ,_:Default4  ) = fun (x:int32) -> Explicit.Invoke x          : ^R
    static member inline FromInt32 (_:^R        ,_:Default3  ) = fun (x:int32) -> FromInt64.Invoke (int64 x) : ^R
    static member inline FromInt32 (_:^R        ,_:Default2  ) = fun (x:int32) -> Implicit.Invoke x          : ^R
    static member inline FromInt32 (_:^R        ,_:Default1  ) = fun (x:int32) -> (^R: (static member FromInt32: _ -> ^R) x)
    static member inline FromInt32 (_:Default1  ,_:Default1  ) = fun (x:int32) -> (^R: (static member FromInt32: _ -> ^R) x)
    static member        FromInt32 (_:int32     , _:FromInt32) = fun (x:int32) ->                 x
    static member        FromInt32 (_:int64     , _:FromInt32) = fun (x:int32) -> int64           x
    static member        FromInt32 (_:nativeint , _:FromInt32) = fun (x:int32) -> nativeint  (int x)
    static member        FromInt32 (_:unativeint, _:FromInt32) = fun (x:int32) -> unativeint (int x)
    static member        FromInt32 (_:bigint    , _:FromInt32) = fun (x:int32) -> bigint          x
    static member        FromInt32 (_:float     , _:FromInt32) = fun (x:int32) -> float           x
    static member        FromInt32 (_:sbyte     , _:FromInt32) = fun (x:int32) -> sbyte           x
    static member        FromInt32 (_:int16     , _:FromInt32) = fun (x:int32) -> int16           x
    static member        FromInt32 (_:byte      , _:FromInt32) = fun (x:int32) -> byte            x
    static member        FromInt32 (_:uint16    , _:FromInt32) = fun (x:int32) -> uint16          x
    static member        FromInt32 (_:uint32    , _:FromInt32) = fun (x:int32) -> uint32          x
    static member        FromInt32 (_:uint64    , _:FromInt32) = fun (x:int32) -> uint64          x
    static member        FromInt32 (_:float32   , _:FromInt32) = fun (x:int32) -> float32         x
    static member        FromInt32 (_:decimal   , _:FromInt32) = fun (x:int32) -> decimal         x

    static member inline Invoke (x:int32)   :'Num    =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member FromInt32: _*_ -> _) b, a)
        let inline call (a:'a) = fun (x:'x) -> call_2 (a, Unchecked.defaultof<'r>) x :'r
        call Unchecked.defaultof<FromInt32> x




type One =
    inherit Default1
    static member inline One (_:'t             ,_:Default1) = FromInt32.Invoke 1            :'t
    static member inline One (_:'t             ,_:One     ) = LanguagePrimitives.GenericOne :'t
    static member inline One (_:^t when ^t: null and ^t: struct, _:One) = id

    static member inline Invoke ()   :'Num    =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member One: _*_ -> _) b, a)
        let inline call (a:'a) = call_2 (a, Unchecked.defaultof<'r>) :'r
        call Unchecked.defaultof<One>

type Zero =
    inherit Default1
    static member inline Zero (_:'t             ,_:Default1) = FromInt32.Invoke 0             :'t
    static member inline Zero (_:'t             ,_:Zero    ) = LanguagePrimitives.GenericZero :'t
    static member inline Zero (_:^t when ^t: null and ^t: struct, _:Zero) = id

    static member inline Invoke ()   :'Num    =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member Zero: _*_ -> _) b, a)
        let inline call (a:'a) = call_2 (a, Unchecked.defaultof<'r>) :'r
        call Unchecked.defaultof<Zero>



type Abs =
    inherit Default1
    static member inline Abs (x:'t        , _:Default2) = (Explicit.Invoke ((^t ) : (static member Abs: ^t -> ^u) x)) :'t
    static member inline Abs (x:'t        , _:Default1) = (Implicit.Invoke ((^t ) : (static member Abs: ^t -> ^u) x)) :'t
    static member inline Abs (x:'t        , _:Abs) = abs x :'t
    static member inline Abs (x:Default1  , _:Abs) = fun (x) -> (^R: (static member Abs: _ -> ^R) x)

    static member inline Invoke (x:'Num) :'Num =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b ) : (static member Abs: ^b*_ -> ^t) b, a)
        call_2 (Unchecked.defaultof<Abs>, x)

type Abs' =
    inherit Abs
    static member        Abs (x:byte      , _:Abs') =     x
    static member        Abs (x:uint16    , _:Abs') =     x
    static member        Abs (x:uint32    , _:Abs') =     x
    static member        Abs (x:uint64    , _:Abs') =     x
    static member        Abs (x:unativeint, _:Abs') =     x

    static member inline Invoke (x:'Num) :'Num =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b ) : (static member Abs: ^b*_ -> ^t) b, a)
        call_2 (Unchecked.defaultof<Abs'>, x)



type Signum =
    inherit Default1
    static member inline Signum (x:'t        , _:Default2) =
        let zero = Zero.Invoke()
        if x = zero then zero
        else x / Abs.Invoke x :'t
    static member inline Signum (_:^t when ^t: null and ^t: struct, _:Default1) = id
    static member inline Signum (x:'t        , _:Default1) = FromInt32.Invoke (sign x) :'t

    static member inline Invoke (x:'Num) :'Num =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member Signum: _*_ -> _) b, a)
        call_2 (Unchecked.defaultof<Signum>, x)

type Signum' =
    inherit Signum
    static member        Signum (x:byte      , _:Signum') = if x = 0uy then 0uy else 1uy
    static member        Signum (x:uint16    , _:Signum') = if x = 0us then 0us else 1us
    static member        Signum (x:uint32    , _:Signum') = if x = 0u  then 0u  else 1u
    static member        Signum (x:uint64    , _:Signum') = if x = 0UL then 0UL else 1UL
    static member        Signum (x:unativeint, _:Signum') = if x = 0un then 0un else 1un

    static member inline Invoke (x:'Num) :'Num =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member Signum: _*_ -> _) b, a)
        call_2 (Unchecked.defaultof<Signum'>, x)


open FsControl.Core.Types

type TryNegate =
    static member inline TryNegate (_:^t when ^t: null and ^t: struct) = ()
    static member inline TryNegate (x:'t        ) = Choice1Of2 -x
    static member inline Invoke (x:'Num) :Choice<'Num,exn> =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member TryNegate: _ -> _) b)
        call_2 (Unchecked.defaultof<TryNegate>, x)

type TryNegate' =
    static member        TryNegate (x:byte      ) = if x = 0uy then Choice1Of2 x else Choice2Of2 Errors.exnNoSubtraction
    static member        TryNegate (x:uint16    ) = if x = 0us then Choice1Of2 x else Choice2Of2 Errors.exnNoSubtraction
    static member        TryNegate (x:uint32    ) = if x = 0u  then Choice1Of2 x else Choice2Of2 Errors.exnNoSubtraction
    static member        TryNegate (x:uint64    ) = if x = 0UL then Choice1Of2 x else Choice2Of2 Errors.exnNoSubtraction
    static member        TryNegate (x:unativeint) = if x = 0un then Choice1Of2 x else Choice2Of2 Errors.exnNoSubtraction
    static member inline Invoke (x:'Num) :Choice<'Num,exn> =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member TryNegate: _ -> _) b)
        call_2 (Unchecked.defaultof<TryNegate'>, x)


[<Extension; Sealed>]
type DivRem =
    inherit Default1
    static member inline DivRem (x:^t when ^t: null and ^t: struct, y:^t, thisclass:DivRem) = (x, y)
    [<Extension>]static member inline DivRem (D:'T, d:'T, [<Optional>]impl:Default1) = let q = D / d in q,  D - q * d
    [<Extension>]static member inline DivRem (D:'T, d:'T, [<Optional>]impl:DivRem  ) =
                    let mutable r = Unchecked.defaultof<'T>
                    (^T: (static member DivRem: _ * _ -> _ -> _) (D, d, &r)), r

    static member inline Invoke (D:'T) (d:'T) :'T*'T =
        let inline call_3 (a:^a, b:^b, c:^c) = ((^a or ^b or ^c) : (static member DivRem: _*_*_ -> _) b, c, a)
        let inline call (a:'a, b:'b, c:'c) = call_3 (a, b, c)
        call (Unchecked.defaultof<DivRem>, D, d)    



// Integral class ---------------------------------------------------------

[<Extension; Sealed>]
type ToBigInt =
    [<Extension>]static member        ToBigInt (x:sbyte     ) = bigint (int x)
    [<Extension>]static member        ToBigInt (x:int16     ) = bigint (int x)
    [<Extension>]static member        ToBigInt (x:int32     ) = bigint      x
    [<Extension>]static member        ToBigInt (x:int64     ) = bigint      x
    [<Extension>]static member        ToBigInt (x:nativeint ) = bigint (int x)
    [<Extension>]static member        ToBigInt (x:byte      ) = bigint (int x)
    [<Extension>]static member        ToBigInt (x:uint16    ) = bigint (int x)
    [<Extension>]static member        ToBigInt (x:unativeint) = bigint (int x)
    [<Extension>]static member        ToBigInt (x:bigint    ) =             x
#if NOTNET35
    [<Extension>]static member        ToBigInt (x:uint32    ) = bigint      x
    [<Extension>]static member        ToBigInt (x:uint64    ) = bigint      x
#else
    [<Extension>]static member        ToBigInt (x:uint32    ) = bigint (int x)
    [<Extension>]static member        ToBigInt (x:uint64    ) = bigint (int64 x)
#endif

    static member inline Invoke    (x:'Integral) :bigint =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member ToBigInt: _ -> _) b)
        call_2 (Unchecked.defaultof<ToBigInt>, x)


module internal Numerics =

    // Strict version of math operators
    let inline internal ( +.) (a:'Num) (b:'Num) :'Num = a + b
    let inline internal ( -.) (a:'Num) (b:'Num) :'Num = a - b
    let inline internal ( *.) (a:'Num) (b:'Num) :'Num = a * b

    let inline internal fromIntegral (x:'Integral) :'Num = (FromBigInt.Invoke << ToBigInt.Invoke) x

    let inline internal zero() = Zero.Invoke()
    let inline internal one()  = One.Invoke()





namespace FsControl.Core.TypeMethods

open Numerics
open FsControl.Core.Internals
open FsControl.Core.Internals.Prelude
open FsControl.Core.Types
open FsControl.Core.TypeMethods

open System.Runtime.CompilerServices
open System.Runtime.InteropServices




type Pi =
    inherit Default1
    static member inline Pi (_:^R      , _:Default3) = Implicit.Invoke 3.14159274f    :^R
    static member inline Pi (_:^R      , _:Default2) = Implicit.Invoke System.Math.PI :^R
    static member inline Pi (_:^R      , _:Default1) = (^R: (static member PI:  ^R) ())
    static member inline Pi (_:Default1, _:Default1) = (^R: (static member PI:  ^R) ())
    static member        Pi (_:float32 , _:Pi      ) = 3.14159274f
    static member        Pi (_:float   , _:Pi      ) = System.Math.PI
    static member        Pi (_:decimal , _:Pi      ) = 3.1415926535897932384626433833M

    static member inline Invoke() :'Floating =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member Pi: _*_ -> _) b, a)
        let inline call (a:'a) = call_2 (a, Unchecked.defaultof<'r>) :'r
        call Unchecked.defaultof<Pi>

type Subtract =
    static member inline Subtract (x, y) = x - y
    static member inline Subtract (x, y) =
            match ((^Num) : (static member TrySubtract: ^Num * ^Num -> Choice< ^Num, exn>) (x, y)) with
            | Choice1Of2 x -> x
            | Choice2Of2 e -> raise e

    static member        Subtract (x:byte      , y) = if y > x then raise Errors.exnNoSubtraction else (x-y) 
    static member        Subtract (x:uint16    , y) = if y > x then raise Errors.exnNoSubtraction else (x-y) 
    static member        Subtract (x:uint32    , y) = if y > x then raise Errors.exnNoSubtraction else (x-y) 
    static member        Subtract (x:uint64    , y) = if y > x then raise Errors.exnNoSubtraction else (x-y) 
    static member        Subtract (x:unativeint, y) = if y > x then raise Errors.exnNoSubtraction else (x-y) 

    static member inline Invoke    (x:'Num) (y:'Num)  : 'Num =
        let inline call_2 (a:^a, b:^b, c:^b) = ((^a or ^b) : (static member Subtract: _*_ -> _) b, c)
        call_2 (Unchecked.defaultof<Subtract>, x, y)

type TrySubtract =
    static member inline TrySubtract (x:'t  , y) = Choice1Of2 (x - y)
    static member inline TrySubtract (_:^t when ^t: null and ^t: struct, _:TrySubtract) = id

    static member        TrySubtract (x:byte      , y) = if y > x then Choice2Of2 Errors.exnNoSubtraction else Choice1Of2 (x-y) 
    static member        TrySubtract (x:uint16    , y) = if y > x then Choice2Of2 Errors.exnNoSubtraction else Choice1Of2 (x-y) 
    static member        TrySubtract (x:uint32    , y) = if y > x then Choice2Of2 Errors.exnNoSubtraction else Choice1Of2 (x-y) 
    static member        TrySubtract (x:uint64    , y) = if y > x then Choice2Of2 Errors.exnNoSubtraction else Choice1Of2 (x-y) 
    static member        TrySubtract (x:unativeint, y) = if y > x then Choice2Of2 Errors.exnNoSubtraction else Choice1Of2 (x-y) 

    static member inline Invoke    (x:'Num) (y:'Num)  : Choice<'Num, exn> =
        let inline call_2 (a:^a, b:^b, c:^b) = ((^a or ^b) : (static member TrySubtract: _*_ -> _) b, c)
        call_2 (Unchecked.defaultof<TrySubtract>, x, y)




type Divide =
    static member inline Divide (x, y) = let c = x / y in if c * y = x then c else raise Errors.exnNoDivision
    static member inline Divide (x, y) =
            match ((^Num) : (static member TryDivide: ^Num * ^Num -> Choice< ^Num, exn>) (x, y)) with
            | Choice1Of2 x -> x
            | Choice2Of2 e -> raise e
    static member        Divide (x:float  , y) = (/) x y
    static member        Divide (x:float32, y) = (/) x y
    static member inline Invoke    (x:'Num) (y:'Num) : 'Num =
        let inline call_2 (a:^a, b:^b, c:^b) = ((^a or ^b) : (static member Divide: _*_ -> _) b, c)
        call_2 (Unchecked.defaultof<Divide>, x, y)

type TryDivide =
    static member inline TryDivide (x, y) =
        if y = zero() then Choice2Of2 Errors.exnDivByZero
        else
            let c = x / y :'t
            if c * y = x then Choice1Of2 c
            else Choice2Of2 Errors.exnNoDivision
    static member inline TryDivide (_:^t when ^t: null and ^t: struct, _:Default1) = fun y -> Choice2Of2 null
    static member        TryDivide (x:float  , y) = Choice1Of2 (x / y)
    static member        TryDivide (x:float32, y) = Choice1Of2 (x / y)
    static member inline Invoke    (x:'Num) (y:'Num)  : Choice<'Num, exn> =
        let inline call_2 (a:^a, b:^b, c:^b) = ((^a or ^b) : (static member TryDivide: _*_ -> _) b, c)
        call_2 (Unchecked.defaultof<TryDivide>, x, y)



type TrySqrtRem =
    static member        TrySqrtRem (x:bigint    ) = x |> BigInteger.trySqrtRem
    static member        TrySqrtRem (x:int16     ) = if x < 0s then Choice2Of2 Errors.exnSqrtOfNegative else let c = x |> float |> sqrt |> int16 in Choice1Of2 (c, x - c*c)
    static member        TrySqrtRem (x:int32     ) = if x < 0  then Choice2Of2 Errors.exnSqrtOfNegative else let c = x |> float |> sqrt |> int   in Choice1Of2 (c, x - c*c)
    static member        TrySqrtRem (x:int64     ) = if x < 0L then Choice2Of2 Errors.exnSqrtOfNegative else let c = x |> float |> sqrt |> int64 in Choice1Of2 (c, x - c*c)
    static member        TrySqrtRem (x:sbyte     ) = if x < 0y then Choice2Of2 Errors.exnSqrtOfNegative else let c = x |> float |> sqrt |> sbyte in Choice1Of2 (c, x - c*c)
    static member        TrySqrtRem (x:uint16    ) = let c = x |> float |> sqrt |> uint16     in Choice1Of2 (c, x - c*c)
    static member        TrySqrtRem (x:uint32    ) = let c = x |> float |> sqrt |> uint32     in Choice1Of2 (c, x - c*c)
    static member        TrySqrtRem (x:uint64    ) = let c = x |> float |> sqrt |> uint64     in Choice1Of2 (c, x - c*c)
    static member        TrySqrtRem (x:nativeint ) = let c = x |> float |> sqrt |> nativeint  in Choice1Of2 (c, x - c*c)
    static member        TrySqrtRem (x:byte      ) = let c = x |> float |> sqrt |> byte       in Choice1Of2 (c, x - c*c)
    static member        TrySqrtRem (x:unativeint) = let c = x |> float |> sqrt |> unativeint in c, x - c*c

    static member inline Invoke    (x:'Integral) : Choice<'Integral*'Integral, exn> =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member TrySqrtRem: _ -> _) b)
        call_2 (Unchecked.defaultof<TrySqrtRem>, x)


type TrySqrt =
    static member inline Invoke    (x:'Integral) : Choice<'Integral, exn> =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member TrySqrt: _ -> _) b)
        call_2 (Unchecked.defaultof<TrySqrt>, x)

    static member inline TrySqrt (x:'T) = 
        try Choice1Of2 (sqrt x)
        with e -> Choice2Of2 e

    static member inline TrySqrt (x:'Z) = 
        if x < zero() then Choice2Of2 Errors.exnSqrtOfNegative 
        else 
            match TrySqrtRem.Invoke x with 
            | Choice1Of2 (c, r) -> if r = zero() then Choice1Of2 c else Choice2Of2 Errors.exnNoSqrt
            | Choice2Of2 x      -> Choice2Of2 x

    static member inline TrySqrt (x:'Rational) =
        if x < zero() then Choice2Of2 Errors.exnSqrtOfNegative else 
            let (n:'i, d:'i) = Rational.numerator x, Rational.denominator x
            let toRational (x:'i) = (ToBigInt.Invoke >> FromBigInt.Invoke) x  : 'Rational
            match TrySqrt.Invoke n, TrySqrt.Invoke d with
            | Choice1Of2 n, Choice1Of2 d -> Choice1Of2 (toRational n / toRational d)
            | _                          -> Choice2Of2  Errors.exnNoSqrt

    static member inline TrySqrt (x:float    ) = if x < 0.     then Choice2Of2 Errors.exnSqrtOfNegative else let c = sqrt x in         Choice1Of2 c //if Double.IsNaN c then Choice2Of2 exnNoSqrt else Choice1Of2 c
    static member inline TrySqrt (x:float32  ) = if x < 0.f    then Choice2Of2 Errors.exnSqrtOfNegative else let c = sqrt x in         Choice1Of2 c //if Single.IsNaN c then Choice2Of2 exnNoSqrt else Choice1Of2 c
    static member inline TrySqrt (x:decimal  ) = Decimal.trySqrt x

type Sqrt =
    inherit Default1
    static member inline Sqrt (x:^Num, _:Default2) =
            match ((^Num) : (static     member TrySqrt: ^Num -> Choice< ^Num, exn>) (x)) with
            | Choice1Of2 x -> x
            | Choice2Of2 e -> raise e

    static member inline Sqrt (x:'T, _:Default1) = sqrt x
    static member inline Sqrt (x:'Z, _:Default1) = 
        if x < Zero.Invoke() then raise Errors.exnSqrtOfNegative 
        else 
            match TrySqrtRem.Invoke x with 
            | Choice1Of2 (c, r) -> if r = Zero.Invoke() then c else raise Errors.exnNoSqrt
            | Choice2Of2 x      -> raise x

    static member inline Sqrt (x:float32, _:Sqrt) = sqrt x
    static member inline Sqrt (x:decimal, _:Sqrt) = x |> Decimal.trySqrt |> function Choice1Of2 x -> x | Choice2Of2 e ->  raise e

    static member inline Invoke    (x:'Integral) : 'Integral =
        let inline call_2 (t:^t, a:^a) = ((^t or ^a) : (static member Sqrt: _*_ -> _) a, t)
        call_2 (Unchecked.defaultof<Sqrt>, x)

type Sqrt with
    static member inline Sqrt (x:'Rational, _:Sqrt) =
        if x < Zero.Invoke() then raise Errors.exnSqrtOfNegative
        else 
            let (n:'i, d:'i) = Rational.numerator x, Rational.denominator x
            let toRational (x:'i) = (ToBigInt.Invoke >> FromBigInt.Invoke) x  : 'Rational
            let n, d =  Sqrt.Invoke n, Sqrt.Invoke d
            (toRational n / toRational d)




// Bounded class ----------------------------------------------------------

open System
// TODO: can we have a (working) default ? It's a field, maybe we should call to a property.

type MinValue =
    static member MinValue (_:unit          , _:MinValue) = ()
    static member MinValue (_:bool          , _:MinValue) = false
    static member MinValue (_:char          , _:MinValue) = Char.MinValue
    static member MinValue (_:byte          , _:MinValue) = Byte.MinValue
    static member MinValue (_:sbyte         , _:MinValue) = SByte.MinValue
    static member MinValue (_:float         , _:MinValue) = Double.MinValue
    static member MinValue (_:int16         , _:MinValue) = Int16.MinValue
    static member MinValue (_:int           , _:MinValue) = Int32.MinValue
    static member MinValue (_:int64         , _:MinValue) = Int64.MinValue
    static member MinValue (_:float32       , _:MinValue) = Single.MinValue
    static member MinValue (_:uint16        , _:MinValue) = UInt16.MinValue
    static member MinValue (_:uint32        , _:MinValue) = UInt32.MinValue
    static member MinValue (_:uint64        , _:MinValue) = UInt64.MinValue
    static member MinValue (_:decimal       , _:MinValue) = Decimal.MinValue
    static member MinValue (_:DateTime      , _:MinValue) = DateTime.MinValue
    static member MinValue (_:DateTimeOffset, _:MinValue) = DateTimeOffset.MinValue
    static member MinValue (_:TimeSpan      , _:MinValue) = TimeSpan.MinValue

    static member inline Invoke() =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member MinValue: _*_ -> _) b, a)
        let inline call (a:'a) = call_2 (a, Unchecked.defaultof<'r>) :'r
        call Unchecked.defaultof<MinValue>

    static member inline MinValue ((_:'a*'b                  ), _:MinValue) = (MinValue.Invoke(), MinValue.Invoke())
    static member inline MinValue ((_:'a*'b*'c               ), _:MinValue) = (MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke())
    static member inline MinValue ((_:'a*'b*'c*'d            ), _:MinValue) = (MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke())
    static member inline MinValue ((_:'a*'b*'c*'d*'e         ), _:MinValue) = (MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke())
    static member inline MinValue ((_:'a*'b*'c*'d*'e*'f      ), _:MinValue) = (MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke())
    static member inline MinValue ((_:'a*'b*'c*'d*'e*'f*'g   ), _:MinValue) = (MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke())
    static member inline MinValue ((_:'a*'b*'c*'d*'e*'f*'g*'h), _:MinValue) = (MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke(), MinValue.Invoke())

type MaxValue =
    static member MaxValue (_:unit          , _:MaxValue) = ()
    static member MaxValue (_:bool          , _:MaxValue) = true
    static member MaxValue (_:char          , _:MaxValue) = Char.MaxValue
    static member MaxValue (_:byte          , _:MaxValue) = Byte.MaxValue
    static member MaxValue (_:sbyte         , _:MaxValue) = SByte.MaxValue
    static member MaxValue (_:float         , _:MaxValue) = Double.MaxValue
    static member MaxValue (_:int16         , _:MaxValue) = Int16.MaxValue
    static member MaxValue (_:int           , _:MaxValue) = Int32.MaxValue
    static member MaxValue (_:int64         , _:MaxValue) = Int64.MaxValue
    static member MaxValue (_:float32       , _:MaxValue) = Single.MaxValue
    static member MaxValue (_:uint16        , _:MaxValue) = UInt16.MaxValue
    static member MaxValue (_:uint32        , _:MaxValue) = UInt32.MaxValue
    static member MaxValue (_:uint64        , _:MaxValue) = UInt64.MaxValue
    static member MaxValue (_:decimal       , _:MaxValue) = Decimal.MaxValue
    static member MaxValue (_:DateTime      , _:MaxValue) = DateTime.MaxValue
    static member MaxValue (_:DateTimeOffset, _:MaxValue) = DateTimeOffset.MaxValue
    static member MaxValue (_:TimeSpan      , _:MaxValue) = TimeSpan.MaxValue

    static member inline Invoke() =
        let inline call_2 (a:^a, b:^b) = ((^a or ^b) : (static member MaxValue: _*_ -> _) b, a)
        let inline call (a:'a) = call_2 (a, Unchecked.defaultof<'r>) :'r
        call Unchecked.defaultof<MaxValue>

    static member inline MaxValue ((_:'a*'b                  ), _:MaxValue) = (MaxValue.Invoke(), MaxValue.Invoke())
    static member inline MaxValue ((_:'a*'b*'c               ), _:MaxValue) = (MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke())
    static member inline MaxValue ((_:'a*'b*'c*'d            ), _:MaxValue) = (MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke())
    static member inline MaxValue ((_:'a*'b*'c*'d*'e         ), _:MaxValue) = (MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke())
    static member inline MaxValue ((_:'a*'b*'c*'d*'e*'f      ), _:MaxValue) = (MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke())
    static member inline MaxValue ((_:'a*'b*'c*'d*'e*'f*'g   ), _:MaxValue) = (MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke())
    static member inline MaxValue ((_:'a*'b*'c*'d*'e*'f*'g*'h), _:MaxValue) = (MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke(), MaxValue.Invoke())