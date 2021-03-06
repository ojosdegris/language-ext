﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageExt
{
    public static partial class Prelude
    {
        public static NewType<T> bind<T>(NewType<T> value, Func<T, NewType<T>> bind) =>
            value.Bind(bind);

        public static Unit iter<T>(NewType<T> value, Action<T> f) =>
            value.Iter(f);

        public static int count<T>(NewType<T> value) =>
            1;

        public static int sum(NewType<int> value) =>
            value.Value;

        public static bool exists<T>(NewType<T> value, Func<T, bool> predicate) =>
            predicate(value.Value);

        public static bool forall<T>(NewType<T> value, Func<T, bool> predicate) =>
            predicate(value.Value);

        public static NewType<T> map<T>(NewType<T> value, Func<T, T> map) =>
            value.Map(map);

        public static S fold<T, S>(NewType<T> value, S state, Func<S, T, S> folder) =>
            value.Fold(state, folder);

        public static NewType<T> append<T>(NewType<T> value, NewType<T> rhs) =>
            value.Append(rhs);

        public static NewType<T> subtract<T>(NewType<T> value, NewType<T> rhs) =>
            value.Subtract(rhs);

        public static NewType<T> divide<T>(NewType<T> value, NewType<T> rhs) =>
            value.Divide(rhs);

        public static NewType<T> multiply<T>(NewType<T> value, NewType<T> rhs) =>
            value.Multiply(rhs);
    }
}
