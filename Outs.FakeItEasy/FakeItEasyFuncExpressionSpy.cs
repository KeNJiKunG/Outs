using System.Linq.Expressions;
using FakeItEasy;
using FakeItEasy.Configuration;

namespace Outs;

public class FakeItEasyFuncExpressionSpy<TResult> : FakeItEasySpy
{
    private readonly Expression<Func<TResult>> expr;

    internal FakeItEasyFuncExpressionSpy(Expression<Func<TResult>> expr)
    {
        this.expr = expr;
    }

    public override UnorderedCallAssertion MustHaveHappened() => A.CallTo(this.expr).MustHaveHappened();
    public override UnorderedCallAssertion MustHaveHappened(int numberOfTimes, Times timesOption) => A.CallTo(this.expr).MustHaveHappened(numberOfTimes, timesOption);
    // publoverride ic void Throws<T>( Func<T, Exception> exceptionFactory ) => A.CallTo(this.expr).Throws(exceptionFactory);
    public override UnorderedCallAssertion MustHaveHappenedANumberOfTimesMatching(Expression<Func<int, bool>> predicate) => A.CallTo(this.expr).MustHaveHappenedANumberOfTimesMatching(predicate);
    public override UnorderedCallAssertion MustHaveHappenedOnceExactly() => A.CallTo(this.expr).MustHaveHappenedOnceExactly();
    public override UnorderedCallAssertion MustHaveHappenedOnceOrLess() => A.CallTo(this.expr).MustHaveHappenedOnceOrLess();
    public override UnorderedCallAssertion MustHaveHappenedOnceOrMore() => A.CallTo(this.expr).MustHaveHappenedOnceOrMore();
    public override UnorderedCallAssertion MustHaveHappenedTwiceExactly() => A.CallTo(this.expr).MustHaveHappenedTwiceExactly();
    public override UnorderedCallAssertion MustHaveHappenedTwiceOrLess() => A.CallTo(this.expr).MustHaveHappenedTwiceOrLess();
    public override UnorderedCallAssertion MustHaveHappenedTwiceOrMore() => A.CallTo(this.expr).MustHaveHappenedTwiceOrMore();
    public override void MustNotHaveHappened() => A.CallTo(this.expr).MustNotHaveHappened();
}