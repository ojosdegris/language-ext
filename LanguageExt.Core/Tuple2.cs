﻿using System;
using LanguageExt;
using static LanguageExt.Prelude;

public static class __Tuple2
{
    /// <summary>
    /// Append an extra item to the tuple
    /// </summary>
    public static Tuple<T1,T2,T3> Append<T1, T2, T3>(this Tuple<T1, T2> self, T3 third) =>
        Tuple(self.Item1,self.Item2, third);

    /// <summary>
    /// Sum
    /// </summary>
    public static int Sum(this Tuple<int, int> self) =>
        self.Item1 + self.Item2;

    /// <summary>
    /// Sum
    /// </summary>
    public static double Sum(this Tuple<double, double> self) =>
        self.Item1 + self.Item2;

    /// <summary>
    /// Sum
    /// </summary>
    public static float Sum(this Tuple<float, float> self) =>
        self.Item1 + self.Item2;

    /// <summary>
    /// Sum
    /// </summary>
    public static decimal Sum(this Tuple<decimal, decimal> self) =>
        self.Item1 + self.Item2;

    /// <summary>
    /// Map to R
    /// </summary>
    public static R Map<T1, T2, R>(this Tuple<T1, T2> self, Func<T1, T2, R> map) =>
        map(self.Item1, self.Item2);

    /// <summary>
    /// Map to tuple
    /// </summary>
    public static Tuple<R1, R2> Map<T1, T2, R1, R2>(this Tuple<T1, T2> self, Func<Tuple<T1, T2>, Tuple<R1, R2>> map) =>
        map(self);

    /// <summary>
    /// Bi-map to tuple
    /// </summary>
    public static Tuple<R1, R2> Map<T1, T2, R1, R2>(this Tuple<T1, T2> self, Func<T1, R1> firstMap, Func<T2, R2> secondMap) =>
        Tuple(firstMap(self.Item1),secondMap(self.Item2));

    /// <summary>
    /// First item-map to tuple
    /// </summary>
    public static Tuple<R1, T2> MapFirst<T1, T2, R1>(this Tuple<T1, T2> self, Func<T1, R1> firstMap) =>
        Tuple(firstMap(self.Item1), self.Item2);

    /// <summary>
    /// Second item-map to tuple
    /// </summary>
    public static Tuple<T1, R2> MapSecond<T1, T2, R2>(this Tuple<T1, T2> self, Func<T2, R2> secondMap) =>
        Tuple(self.Item1, secondMap(self.Item2));

    /// <summary>
    /// Map to tuple
    /// </summary>
    public static Tuple<R1, R2> Select<T1, T2, R1, R2>(this Tuple<T1, T2> self, Func<Tuple<T1, T2>, Tuple<R1, R2>> map) =>
        map(self);

    /// <summary>
    /// Iterate
    /// </summary>
    public static Unit Iter<T1, T2>(this Tuple<T1, T2> self, Action<T1, T2> func)
    {
        func(self.Item1, self.Item2);
        return Unit.Default;
    }

    /// <summary>
    /// Iterate
    /// </summary>
    public static Unit Iter<T1, T2>(this Tuple<T1, T2> self, Action<T1> first, Action<T2> second)
    {
        first(self.Item1);
        second(self.Item2);
        return Unit.Default;
    }
    
    /// <summary>
    /// Fold
    /// </summary>
    public static S Fold<T1, T2, S>(this Tuple<T1, T2> self, S state, Func<S,T1,T2,S> fold) =>
        fold(state,self.Item1,self.Item2);
    
    /// <summary>
    /// Bi-fold
    /// </summary>
    public static S Fold<T1, T2, S>(this Tuple<T1, T2> self, S state, Func<S,T1,S> firstFold, Func<S,T2,S> secondFold) =>
        secondFold(firstFold(state,self.Item1),self.Item2);

    /// <summary>
    /// Bi-fold
    /// </summary>
    public static S FoldBack<T1, T2, S>(this Tuple<T1, T2> self, S state, Func<S, T2, S> firstFold, Func<S, T1, S> secondFold) =>
        secondFold(firstFold(state, self.Item2), self.Item1);
}
