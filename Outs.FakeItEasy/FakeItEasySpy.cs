using System.Linq.Expressions;
using FakeItEasy;
using FakeItEasy.Configuration;

namespace Outs;

public abstract class FakeItEasySpy : Outs.Core.Spy
{
    public abstract UnorderedCallAssertion MustHaveHappened();
    public abstract UnorderedCallAssertion MustHaveHappened(int numberOfTimes, Times timesOption);
    // pub abstract ic void Throws<T>( Func<T, Exception> exceptionFactory );
    public abstract UnorderedCallAssertion MustHaveHappenedANumberOfTimesMatching(Expression<Func<int, bool>> predicate);
    public abstract UnorderedCallAssertion MustHaveHappenedOnceExactly();
    public abstract UnorderedCallAssertion MustHaveHappenedOnceOrLess();
    public abstract UnorderedCallAssertion MustHaveHappenedOnceOrMore();
    public abstract UnorderedCallAssertion MustHaveHappenedTwiceExactly();
    public abstract UnorderedCallAssertion MustHaveHappenedTwiceOrLess();
    public abstract UnorderedCallAssertion MustHaveHappenedTwiceOrMore();
    public abstract void MustNotHaveHappened();
}