using System.Linq.Expressions;
using FakeItEasy;
using FakeItEasy.Configuration;

namespace Outs;

public class FakeItEasyObjectSpy : FakeItEasySpy
{
    private readonly object fake;

    internal FakeItEasyObjectSpy(object fake)
    {
        this.fake = fake;
    }

    public override UnorderedCallAssertion MustHaveHappened() => A.CallTo(this.fake).MustHaveHappened();
    public override UnorderedCallAssertion MustHaveHappened(int numberOfTimes, Times timesOption) => A.CallTo(this.fake).MustHaveHappened(numberOfTimes, timesOption);
    // pub override ic void Throws<T>( Func<T, Exception> exceptionFactory ) => A.CallTo(this.fake).Throws(exceptionFactory);
    public override UnorderedCallAssertion MustHaveHappenedANumberOfTimesMatching(Expression<Func<int, bool>> predicate) => A.CallTo(this.fake).MustHaveHappenedANumberOfTimesMatching(predicate);
    public override UnorderedCallAssertion MustHaveHappenedOnceExactly() => A.CallTo(this.fake).MustHaveHappenedOnceExactly();
    public override UnorderedCallAssertion MustHaveHappenedOnceOrLess() => A.CallTo(this.fake).MustHaveHappenedOnceOrLess();
    public override UnorderedCallAssertion MustHaveHappenedOnceOrMore() => A.CallTo(this.fake).MustHaveHappenedOnceOrMore();
    public override UnorderedCallAssertion MustHaveHappenedTwiceExactly() => A.CallTo(this.fake).MustHaveHappenedTwiceExactly();
    public override UnorderedCallAssertion MustHaveHappenedTwiceOrLess() => A.CallTo(this.fake).MustHaveHappenedTwiceOrLess();
    public override UnorderedCallAssertion MustHaveHappenedTwiceOrMore() => A.CallTo(this.fake).MustHaveHappenedTwiceOrMore();
    public override void MustNotHaveHappened() => A.CallTo(this.fake).MustNotHaveHappened();
}