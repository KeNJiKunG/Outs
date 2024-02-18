# Outs.FakeItEasy
A library to make mocking with FakeItEasy a little bit easier to read.

```csharp
var shop = A.Fake<ICandyShop>();
OutA.CallTo(
    () => shop.GetTopSelltingCandy(),
    out var getTopSelltingCandySpy
)
    .Returns( 
        out var lollipop, A.Fake<ICandy>()
    );

var developer = new SweetTooth();
developer.BuyTastiestCandy( shop );

getTopSelltingCandySpy.MustHaveHappened();
A.CallTo( () => shop.BuyCandy( lollipop ) ).MustHaveHappened();
```

## TO BE IMPLEMENTED
```csharp
A.CallTo(
    out var shop, A.Fake<ICandyShop>(),
    (shop) => shop.GetTopSelltingCandy(),
    out var getTopSelltingCandySpy
)
    .Returns( 
        out var lollipop, A.Fake<ICandy>()
    );

var developer = new SweetTooth();
developer.BuyTastiestCandy( shop );

getTopSelltingCandySpy.MustHaveHappened();
A.CallTo( () => shop.BuyCandy( lollipop ) ).MustHaveHappened();
```

## Documentation

### Extensions

#### `CallTo` with spy.
- `OutA.CallTo( Expression<Func<TResult>> expr, out FakeItEasySpy spy )`
- `OutA.CallTo( Expression<Action> expr, out FakeItEasySpy spy )`

#### `Returns` with value.
- `Returns<T>( out T result, T value )`
- `Returns<Task<T>>( out T result, T value )`

#### `ReturnsLazily` with value.
- `ReturnsLazily<T>( out Proxy<T> proxy, Func<T> valueProvider )`
- `ReturnsLazily<Task<T>>( out Proxy<T> result, Func<T> valueProvider )`
- `ReturnsLazily<T>( out Proxy<T> proxy, Func<IFakeObjectCall, T> valueProvider )`
- `ReturnsLazily<Task<T>>( out Proxy<T> proxy, Func<IFakeObjectCall, T> valueProvider )`
- `ReturnsLazily<T, T1>( out Proxy<T> proxy, Func<T1, T> valueProvider )`
- `ReturnsLazily<Task<T>, T1>( out Proxy<T> proxy, Func<T1, T> valueProvider )`
- ... same methods provided up to 8 types.

#### `ReturnsNextFromSequence` with values.
- `ReturnsNextFromSequence<T>( out T t1, T value1 )`
- `ReturnsNextFromSequence<T>( out T t1, T value1, out T t2, T value2 )`
- `ReturnsNextFromSequence<T>( out T t1, T value1, out T t2, T value2, out T t3, T value3 )`
- `ReturnsNextFromSequence<T>( out T t1, T value1, out T t2, T value2, out T t3, T value3, out T4 t4, T value4 )`

#### `Throws` with exception value.
- `Throws( out TException exception, TException value )`
- `Throws( out Proxy<TException> proxy, Func<TException> valueProvider )`
- `Throws( out Proxy<TException> proxy, Func<IFakeObjectCall, TException> valueProvider )`
- `Throws<TException>( out Proxy<TException> proxy ) where TException : Exception, new()`
- `Throws<T1>( out Proxy<TException> proxy, Func<T1, TException> valueProvider )`
- ... same methods provided up to 8 types.

#### `ThrowsAsync` with exception value.
- `ThrowsAsync( out TException exception, TException value )`
- `ThrowsAsync<TResult>( out TException exception, TException value )`
- `ThrowsAsync( out Proxy<TException> proxy, Func<TException> valueProvider )`
- `ThrowsAsync<TResult>( out Proxy<TException> proxy, Func<TException> valueProvider )`
- `ThrowsAsync( out Proxy<TException> proxy, Func<IFakeObjectCall, TException> valueProvider )`
- `ThrowsAsync<TResult>( out Proxy<TException> proxy, Func<IFakeObjectCall, TException> valueProvider )`
- `ThrowsAsync<TException>( out Proxy<TException> proxy ) where TException : Exception, new()`
- `ThrowsAsync<T1>( out Proxy<TException> proxy, Func<T1, TException> valueProvider )`
- `ThrowsAsync<TResult, T1>( out Proxy<TException> proxy, Func<T1, TException> valueProvider )`
- ... same methods provided up to 8 types.

### Spy

A spy is to replace the repetitive call of `A.CallTo`.

- `A.CallTo( ... ).MustHaveHappend` => `spy.MustHaveHappened()`;

### Proxy
An object to trace the value in case of using `valueProvider`.

- `proxy.Value` Value of the tracked object.
- `proxy.IsValueSetted` Indicates weather value is set.