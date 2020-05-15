namespace Finance.Lib.Underlying

    
    [<AutoOpen>]
    module UnderlyingTypes =

        open System

        // INDEX

        type EquityUnderlying =
            | NKY
            | TPX
            | KOSPI2
            | HSCEI
            | HSI
            | AS51
            | SX5E
            | UKX
            | SPX
            | NDX
        
        type IndexName = {
            Bbg : EquityUnderlying                    
            Reuters : string }
            with
                member this.FullBbg = this.Bbg.ToString() + "Index"



        type RollRuleHoliday =
        | PreviousDay
        | PreviousWeek
        | NextWeek

        type RollRule =
        | HK
        | QuatSameWeekDay of DayOfWeek * int * RollRuleHoliday
        | MonthSameWeekDay of DayOfWeek * int * RollRuleHoliday
        
        //type IndexClose =
        //| NoClose
        //| IndexClose of Series<DateTime, float>
        
        
        
        //type FxTS = Series<DateTime,float>
        
        //type FxPairClose = {
        //    Data        : Series<DateTime, float>
        //    CloseUTC    : TimeSpan }
        
        //type FxPairData =
        //    | Close of FxPairClose
        //    | IntraDay of FxTS
        //    | CloseAndIntra of FxPairClose * FxTS
        
        // CURRENCY
        
        type Cur =
            | USD
            | AUD
            | NZD
            | EUR
            | JPY
            | GBP
            | CNH
            | SGD
            | CHF
            | CAD
            | KRW
            | HKD
        
        type FxPairUnderlying =
            | AUDUSD
            | NZDUSD
            | EURUSD
            | USDJPY
            | GBPUSD
            | USDCNH
            | USDSGD
            | USDCHF
            | GBPJPY
            | USDCAD
            | AUDJPY
            | EURJPY
            | EURAUD
            | EURGBP
            | GBPAUD
            | EURCAD
            | EURCHF
            | CHFJPY
        
        
        type FxPair = {
            Cur1     : Cur
            Cur2     : Cur
            Pair     : FxPairUnderlying
            Calendar : Calendar 
            }