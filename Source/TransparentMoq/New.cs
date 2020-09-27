// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mock.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Moq
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;
    using Moq.Language;
    using Moq.Language.Flow;

    public static class New
    {
        public static T Mock<T>()
            where T : class
        {
            return new Mock<T>().Object;
        }

        public static T Mock<T>(MockBehavior mockBehavior)
            where T : class
        {
            return new Mock<T>(mockBehavior).Object;
        }

        public static T Mock<T>(params object[] args)
            where T : class
        {
            return new Mock<T>(args).Object;
        }

        public static T Mock<T>(MockBehavior mockBehavior, params object[] args)
            where T : class
        {
            return new Mock<T>(mockBehavior, args).Object;
        }

        public static T Mock<T>(Expression<Func<T>> newExpression, MockBehavior behavior = MockBehavior.Default)
            where T : class
        {
            return new Mock<T>(newExpression, behavior).Object;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mock<T> GetMock<T>(this T mocked)
            where T : class
        {
            return Moq.Mock.Get(mocked);
        }

        public static ISetup<T> Setup<T>(this T mocked, Expression<Action<T>> expression)
            where T : class
        {
            return mocked.GetMock().Setup(expression);
        }

        public static ISetup<T, TResult> Setup<T, TResult>(this T mocked, Expression<Func<T, TResult>> expression)
            where T : class
        {
            return mocked.GetMock().Setup(expression);
        }

        public static ISetupGetter<T, TProperty> SetupGet<T, TProperty>(this T mocked, Expression<Func<T, TProperty>> expression)
            where T : class
        {
            return mocked.GetMock().SetupGet(expression);
        }

        public static ISetupSetter<T, TProperty> SetupSet<T, TProperty>(this T mocked, Action<T> setterExpression)
            where T : class
        {
            return mocked.GetMock().SetupSet<TProperty>(setterExpression);
        }

        public static ISetup<T> SetupSet<T>(this T mocked, Action<T> setterExpression)
            where T : class
        {
            return mocked.GetMock().SetupSet(setterExpression);
        }

        public static ISetup<T> SetupAdd<T>(this T mocked, Action<T> addExpression)
            where T : class
        {
            return mocked.GetMock().SetupAdd(addExpression);
        }

        public static ISetup<T> SetupRemove<T>(this T mocked, Action<T> removeExpression)
            where T : class
        {
            return mocked.GetMock().SetupRemove(removeExpression);
        }

        public static Mock<T> SetupProperty<T, TProperty>(this T mocked, Expression<Func<T, TProperty>> property)
            where T : class
        {
            return mocked.GetMock().SetupProperty(property);
        }

        public static Mock<T> SetupProperty<T, TProperty>(this T mocked, Expression<Func<T, TProperty>> property, TProperty initialValue)
            where T : class
        {
            return mocked.GetMock().SetupProperty(property, initialValue);
        }

        public static Mock<T> SetupAllProperties<T>(this T mocked)
            where T : class
        {
            return mocked.GetMock().SetupAllProperties();
        }

        public static ISetupSequentialResult<TResult> SetupSequence<T, TResult>(this T mocked, Expression<Func<T, TResult>> expression)
            where T : class
        {
            return mocked.GetMock().SetupSequence(expression);
        }

        public static ISetupSequentialAction SetupSequence<T>(this T mocked, Expression<Action<T>> expression)
            where T : class
        {
            return mocked.GetMock().SetupSequence(expression);
        }

        public static ISetupConditionResult<T> When<T>(this T mocked, Func<bool> condition)
            where T : class
        {
            return mocked.GetMock().When(condition);
        }

        public static void Verify<T>(this T mocked, Expression<Action<T>> expression)
            where T : class
        {
            mocked.GetMock().Verify(expression);
        }

        public static void Verify<T>(this T mocked, Expression<Action<T>> expression, Times times)
            where T : class
        {
            mocked.GetMock().Verify(expression, times);
        }

        public static void Verify<T>(this T mocked, Expression<Action<T>> expression, Func<Times> times)
            where T : class
        {
            mocked.GetMock().Verify(expression, times);
        }

        public static void Verify<T>(this T mocked, Expression<Action<T>> expression, string failMessage)
            where T : class
        {
            mocked.GetMock().Verify(expression, failMessage);
        }

        public static void Verify<T>(this T mocked, Expression<Action<T>> expression, Times times, string failMessage)
            where T : class
        {
            mocked.GetMock().Verify(expression, times, failMessage);
        }

        public static void Verify<T>(this T mocked, Expression<Action<T>> expression, Func<Times> times, string failMessage)
            where T : class
        {
            mocked.GetMock().Verify(expression, times, failMessage);
        }

        public static void Verify<T, TResult>(this T mocked, Expression<Func<T, TResult>> expression)
            where T : class
        {
            mocked.GetMock().Verify(expression);
        }

        public static void Verify<T, TResult>(this T mocked, Expression<Func<T, TResult>> expression, Times times)
            where T : class
        {
            mocked.GetMock().Verify(expression, times);
        }

        public static void Verify<T, TResult>(this T mocked, Expression<Func<T, TResult>> expression, Func<Times> times)
            where T : class
        {
            mocked.GetMock().Verify(expression, times);
        }

        public static void Verify<T, TResult>(this T mocked, Expression<Func<T, TResult>> expression, string failMessage)
            where T : class
        {
            mocked.GetMock().Verify(expression, failMessage);
        }

        public static void Verify<T, TResult>(this T mocked, Expression<Func<T, TResult>> expression, Times times, string failMessage)
            where T : class
        {
            mocked.GetMock().Verify(expression, times, failMessage);
        }

        public static void VerifyGet<T, TProperty>(this T mocked, Expression<Func<T, TProperty>> expression)
            where T : class
        {
            mocked.GetMock().VerifyGet(expression);
        }

        public static void VerifyGet<T, TProperty>(this T mocked, Expression<Func<T, TProperty>> expression, Times times)
            where T : class
        {
            mocked.GetMock().VerifyGet(expression, times);
        }

        public static void VerifyGet<T, TProperty>(this T mocked, Expression<Func<T, TProperty>> expression, Func<Times> times)
            where T : class
        {
            mocked.GetMock().VerifyGet(expression, times);
        }

        public static void VerifyGet<T, TProperty>(this T mocked, Expression<Func<T, TProperty>> expression, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifyGet(expression, failMessage);
        }

        public static void VerifyGet<T, TProperty>(this T mocked, Expression<Func<T, TProperty>> expression, Times times, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifyGet(expression, times, failMessage);
        }

        public static void VerifyGet<T, TProperty>(this T mocked, Expression<Func<T, TProperty>> expression, Func<Times> times, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifyGet(expression, times(), failMessage);
        }

        public static void VerifySet<T>(this T mocked, Action<T> setterExpression)
            where T : class
        {
            mocked.GetMock().VerifySet(setterExpression);
        }

        public static void VerifySet<T>(this T mocked, Action<T> setterExpression, Times times)
            where T : class
        {
            mocked.GetMock().VerifySet(setterExpression, times);
        }

        public static void VerifySet<T>(this T mocked, Action<T> setterExpression, Func<Times> times)
            where T : class
        {
            mocked.GetMock().VerifySet(setterExpression, times);
        }

        public static void VerifySet<T>(this T mocked, Action<T> setterExpression, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifySet(setterExpression, failMessage);
        }

        public static void VerifySet<T>(this T mocked, Action<T> setterExpression, Times times, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifySet(setterExpression, times, failMessage);
        }

        public static void VerifySet<T>(this T mocked, Action<T> setterExpression, Func<Times> times, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifySet(setterExpression, times, failMessage);
        }

        public static void VerifyAdd<T>(this T mocked, Action<T> addExpression)
            where T : class
        {
            mocked.GetMock().VerifyAdd(addExpression);
        }

        public static void VerifyAdd<T>(this T mocked, Action<T> addExpression, Times times)
            where T : class
        {
            mocked.GetMock().VerifyAdd(addExpression, times);
        }

        public static void VerifyAdd<T>(this T mocked, Action<T> addExpression, Func<Times> times)
            where T : class
        {
            mocked.GetMock().VerifyAdd(addExpression, times);
        }

        public static void VerifyAdd<T>(this T mocked, Action<T> addExpression, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifyAdd(addExpression, failMessage);
        }

        public static void VerifyAdd<T>(this T mocked, Action<T> addExpression, Times times, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifyAdd(addExpression, times, failMessage);
        }

        public static void VerifyAdd<T>(this T mocked, Action<T> addExpression, Func<Times> times, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifyAdd(addExpression, times, failMessage);
        }

        public static void VerifyRemove<T>(this T mocked, Action<T> removeExpression)
            where T : class
        {
            mocked.GetMock().VerifyRemove(removeExpression);
        }

        public static void VerifyRemove<T>(this T mocked, Action<T> removeExpression, Times times)
            where T : class
        {
            mocked.GetMock().VerifyRemove(removeExpression, times);
        }

        public static void VerifyRemove<T>(this T mocked, Action<T> removeExpression, Func<Times> times)
            where T : class
        {
            mocked.GetMock().VerifyRemove(removeExpression, times);
        }

        public static void VerifyRemove<T>(this T mocked, Action<T> removeExpression, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifyRemove(removeExpression, failMessage);
        }

        public static void VerifyRemove<T>(this T mocked, Action<T> removeExpression, Times times, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifyRemove(removeExpression, times, failMessage);
        }

        public static void VerifyRemove<T>(this T mocked, Action<T> removeExpression, Func<Times> times, string failMessage)
            where T : class
        {
            mocked.GetMock().VerifyRemove(removeExpression, times, failMessage);
        }

        public static void VerifyNoOtherCalls<T>(this T mocked)
            where T : class
        {
            mocked.GetMock().VerifyNoOtherCalls();
        }

        public static void Raise<T>(this T mocked, Action<T> eventExpression, EventArgs args)
            where T : class
        {
            mocked.GetMock().Raise(eventExpression, args);
        }

        public static void Raise<T>(this T mocked, Action<T> eventExpression, params object[] args)
            where T : class
        {
            mocked.GetMock().Raise(eventExpression, args);
        }
    }
}