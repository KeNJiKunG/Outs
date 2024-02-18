using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using FakeItEasy.Configuration;
using Outs.Core;
using Base = FakeItEasy.A;

namespace Outs.FakeItEasy;

public class OutA
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IReturnValueArgumentValidationConfiguration<TResult> CallTo<TResult>(Expression<Func<TResult>> expr) => Base.CallTo(expr);

    public static IReturnValueArgumentValidationConfiguration<TResult> CallTo<TResult>(Expression<Func<TResult>> expr, out FakeItEasySpy spy)
    {
        spy = new FakeItEasyFuncExpressionSpy<TResult>(expr);

        return Base.CallTo(expr);
    }

    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // public static void CallTo(object fake) => Base.CallTo(fake);

    // public static IAnyCallConfigurationWithNoReturnTypeSpecified CallTO(object fake, out FakeItEasyObjectSpy spy)
    // {

    //     spy = new FakeItEasyObjectSpy(fake);

    //     return Base.CallTo(fake);
    // }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CallTo(Expression<Action> expr) => Base.CallTo(expr);

    public static IVoidArgumentValidationConfiguration CallTO(Expression<Action> expr, out FakeItEasyActionExpressionSpy spy)
    {
        spy = new FakeItEasyActionExpressionSpy(expr);

        return Base.CallTo(expr);
    }

    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // public static void CallTo(object fake, global::FakeItEasy.EventAction eventAction) => Base.CallTo(fake, eventAction);

    // public static IAnyCallConfigurationWithVoidReturnType CallTO(object fake, out FakeItEasyObjectSpy spy, global::FakeItEasy.EventAction eventAction)
    // {
    //     spy = new FakeItEasyObjectSpy(fake);

    //     return Base.CallTo(fake, eventAction);
    // }
}
