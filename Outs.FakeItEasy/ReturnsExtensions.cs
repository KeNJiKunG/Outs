using FakeItEasy;
using FakeItEasy.Configuration;
using FakeItEasy.Core;
using Outs.Core;

namespace Outs.FakeItEasy;

public static class ReturnsExtensions
{
    /// <inheritdoc cref="ReturnValueConfigurationExtensions.Returns{T}(IReturnValueConfiguration{T}, T)"/>
    /// <param name="result">The value of <paramref name="value"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>>
        Returns<T>(this IReturnValueArgumentValidationConfiguration<T> configuration, out T result, T value)
    {
        result = value;

        return configuration.Returns(value);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.Returns{T}(IReturnValueConfiguration{T}, T)"/>
    /// <param name="result">The value returns by <paramref name="valueFactory"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>>
        Returns<T>(this IReturnValueArgumentValidationConfiguration<T> configuration, out T result, Func<T> valueFactory)
    {
        var value = valueFactory();

        result = value;

        return configuration.Returns(value);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.Returns{T}(IReturnValueConfiguration{T}, T)"/>
    /// <param name="result">The value returns by <paramref name="valueFactory"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TTransformed>>
        Returns<T, TTransformed>(this IReturnValueArgumentValidationConfiguration<TTransformed> configuration, out T result, T value, Func<T, TTransformed> transform)
    {
        result = value;

        return configuration.Returns(transform(value));
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.Returns{T}(IReturnValueConfiguration{T}, T)"/>
    /// <param name="result">The value returns by <paramref name="valueFactory"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TTransformed>>
        Returns<T, TTransformed>(this IReturnValueArgumentValidationConfiguration<TTransformed> configuration, out T result, Func<T> valueFactory, Func<T, TTransformed> transform)
    {
        var value = valueFactory();

        result = value;

        return configuration.Returns(transform(value));
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.Returns{T}(IReturnValueConfiguration{Task{T}}, T)"/>
    /// <param name="result">The value of <paramref name="value"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        Returns<T>(this IReturnValueConfiguration<Task<T>> configuration, out T result, T value)
    {
        result = value;

        return configuration.Returns(value);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.Returns{T}(IReturnValueConfiguration{Task{T}}, T)"/>
    /// <param name="result">The value of <paramref name="value"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        Returns<T>(this IReturnValueConfiguration<Task<T>> configuration, out T result, Func<T> valueFactory)
    {
        var value = valueFactory();

        result = value;

        return configuration.Returns(value);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.Returns{T}(IReturnValueConfiguration{Task{T}}, T)"/>
    /// <param name="result">The value of <paramref name="value"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TTransformed>>>
        Returns<T, TTransformed>(this IReturnValueConfiguration<Task<TTransformed>> configuration, out T result, T value, Func<T, TTransformed> transform)
    {
        result = value;

        return configuration.Returns(transform(value));
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.Returns{T}(IReturnValueConfiguration{Task{T}}, T)"/>
    /// <param name="result">The value of <paramref name="value"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TTransformed>>>
        Returns<T, TTransformed>(this IReturnValueConfiguration<Task<TTransformed>> configuration, out T result, Func<T> valueFactory, Func<T, TTransformed> transform)
    {
        var value = valueFactory();

        result = value;

        return configuration.Returns(transform(value));
    }

    /// <inheritdoc cref="IReturnValueConfiguration{TMember}.ReturnsLazily(Func{IFakeObjectCall, TMember})"/>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>>
        ReturnsLazily<T>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<IFakeObjectCall, T> valueProducer)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((IFakeObjectCall fakeObjectCall) =>
        {
            var value = valueProducer(fakeObjectCall);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="IReturnValueConfiguration{TMember}.ReturnsLazily(Func{IFakeObjectCall, TMember})"/>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TTransformed>>
        ReturnsLazily<T, TTransformed>(this IReturnValueConfiguration<TTransformed> configuration, out Proxy<T> proxy, Func<IFakeObjectCall, T> valueProducer, Func<T, TTransformed> transform)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((IFakeObjectCall fakeObjectCall) =>
        {
            var value = valueProducer(fakeObjectCall);

            setter(value);

            return transform( value );
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{T}(IReturnValueConfiguration{T}, Func{T})"/>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>>
        ReturnsLazily<T>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<T> valueProducer)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily(() =>
        {
            var value = valueProducer();

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{T}(IReturnValueConfiguration{T}, Func{T})"/>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<TTransformed>>
        ReturnsLazily<T, TTransformed>(this IReturnValueConfiguration<TTransformed> configuration, out Proxy<T> proxy, Func<T> valueProducer, Func<T, TTransformed> transform)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily(() =>
        {
            var value = valueProducer();

            setter(value);

            return transform( value )!;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{T}(IReturnValueConfiguration{Task{T}}, Func{T})"/>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        ReturnsLazily<T>(this IReturnValueConfiguration<Task<T>> configuration, out Proxy<T> proxy, Func<T> valueProducer)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily(() =>
        {
            var value = valueProducer();

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{T}(IReturnValueConfiguration{Task{T}}, Func{T})"/>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<TTransformed>>>
        ReturnsLazily<T, TTransformed>(this IReturnValueConfiguration<Task<TTransformed>> configuration, out Proxy<T> proxy, Func<T> valueProducer, Func<T, TTransformed> transform)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily(() =>
        {
            var value = valueProducer();

            setter(value);

            return transform(value)!;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{T}, T[])"/>
    /// <param name="t1">The value returned by <paramref name="value1"/></param>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<T> configuration, out T t1, T value1)
    {
        t1 = value1;

        configuration.ReturnsNextFromSequence(value1);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{T}, T[])"/>
    /// <param name="t1">The value returned by <paramref name="value1"/></param>
    /// <param name="t2">The value returned by <paramref name="value2"/></param>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<T> configuration, out T t1, T value1, out T t2, T value2)
    {
        t1 = value1;
        t2 = value2;

        configuration.ReturnsNextFromSequence(value1, value2);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{T}, T[])"/>
    /// <param name="t1">The value returned by <paramref name="value1"/></param>
    /// <param name="t2">The value returned by <paramref name="value2"/></param>
    /// <param name="t3">The value returned by <paramref name="value3"/></param>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<T> configuration, out T t1, T value1, out T t2, T value2, out T t3, T value3)
    {
        t1 = value1;
        t2 = value2;
        t3 = value3;

        configuration.ReturnsNextFromSequence(value1, value2);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{T}, T[])"/>
    /// <param name="t1">The value returned by <paramref name="value1"/></param>
    /// <param name="t2">The value returned by <paramref name="value2"/></param>
    /// <param name="t3">The value returned by <paramref name="value3"/></param>
    /// <param name="t4">The value returned by <paramref name="value4"/></param>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<T> configuration, out T t1, T value1, out T t2, T value2, out T t3, T value3, out T t4, T value4)
    {
        t1 = value1;
        t2 = value2;
        t3 = value3;
        t4 = value4;

        configuration.ReturnsNextFromSequence(value1, value2, value3, value4);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{T}, T[])"/>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<T> configuration, Sequence<T> sequence)
    {
        configuration.ReturnsNextFromSequence(sequence.ToArray());
    }

        /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{T}, T[])"/>
    public static void ReturnsNextFromSequence<TIntermediate, TTransformed>(this IReturnValueConfiguration<TTransformed> configuration, Sequence<TIntermediate, TTransformed> sequence)
    {
        configuration.ReturnsNextFromSequence(sequence.ToArray());
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{Task{T}}, T[])"/>
    /// <param name="t1">The value returned by <paramref name="value1"/></param>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<Task<T>> configuration, out T t1, T value1)
    {
        t1 = value1;

        configuration.ReturnsNextFromSequence(value1);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{Task{T}}, T[])"/>
    /// <param name="t1">The value returned by <paramref name="value1"/></param>
    /// <param name="t2">The value returned by <paramref name="value2"/></param>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<Task<T>> configuration, out T t1, T value1, out T t2, T value2)
    {
        t1 = value1;
        t2 = value2;

        configuration.ReturnsNextFromSequence(value1, value2);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{Task{T}}, T[])"/>
    /// <param name="t1">The value returned by <paramref name="value1"/></param>
    /// <param name="t2">The value returned by <paramref name="value2"/></param>
    /// <param name="t3">The value returned by <paramref name="value3"/></param>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<Task<T>> configuration, out T t1, T value1, out T t2, T value2, out T t3, T value3)
    {
        t1 = value1;
        t2 = value2;
        t3 = value3;

        configuration.ReturnsNextFromSequence(value1, value2);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{Task{T}}, T[])"/>
    /// <param name="t1">The value returned by <paramref name="value1"/></param>
    /// <param name="t2">The value returned by <paramref name="value2"/></param>
    /// <param name="t3">The value returned by <paramref name="value3"/></param>
    /// <param name="t4">The value returned by <paramref name="value4"/></param>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<Task<T>> configuration, out T t1, T value1, out T t2, T value2, out T t3, T value3, out T t4, T value4)
    {
        t1 = value1;
        t2 = value2;
        t3 = value3;
        t4 = value4;

        configuration.ReturnsNextFromSequence(value1, value2, value3, value4);
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsNextFromSequence{T}(IReturnValueConfiguration{Task{T}}, T[])"/>
    /// <param name="sequence">Sequence of values</param>
    public static void ReturnsNextFromSequence<T>(this IReturnValueConfiguration<Task<T>> configuration, Sequence<T> sequence)
    {
        configuration.ReturnsNextFromSequence(sequence.values.ToArray());
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1}(IReturnValueConfiguration{TReturnType}, Func{T1, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>> ReturnsLazily<T, T1>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<T1, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1) =>
        {
            var value = valueProvider(t1);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>> ReturnsLazily<T, T1, T2>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<T1, T2, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2) =>
        {
            var value = valueProvider(t1, t2);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>> ReturnsLazily<T, T1, T2, T3>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3) =>
        {
            var value = valueProvider(t1, t2, t3);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>> ReturnsLazily<T, T1, T2, T3, T4>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4) =>
        {
            var value = valueProvider(t1, t2, t3, t4);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4, T5}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, T5, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>> ReturnsLazily<T, T1, T2, T3, T4, T5>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T5, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) =>
        {
            var value = valueProvider(t1, t2, t3, t4, t5);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4, T5, T6}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, T5, T6, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>> ReturnsLazily<T, T1, T2, T3, T4, T5, T6>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T5, T6, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) =>
        {
            var value = valueProvider(t1, t2, t3, t4, t5, t6);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4, T5, T6, T7}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, T5, T6, T7, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>> ReturnsLazily<T, T1, T2, T3, T4, T5, T6, T7>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T5, T6, T7, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) =>
        {
            var value = valueProvider(t1, t2, t3, t4, t5, t6, t7);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4, T5, T6, T7, T8}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, T5, T6, T7, T8, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<T>> ReturnsLazily<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IReturnValueConfiguration<T> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T5, T6, T7, T8, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) =>
        {
            var value = valueProvider(t1, t2, t3, t4, t5, t6, t7, t8);

            setter(value);

            return value;
        });
    }



    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1}(IReturnValueConfiguration{TReturnType}, Func{T1, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
    ReturnsLazily<T, T1>(this IReturnValueConfiguration<Task<T>> configuration, out Proxy<T> proxy, Func<T1, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1) =>
        {
            var value = valueProvider(t1);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        ReturnsLazily<T, T1, T2>(this IReturnValueConfiguration<Task<T>> configuration, out Proxy<T> proxy, Func<T1, T2, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2) =>
        {
            var value = valueProvider(t1, t2);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        ReturnsLazily<T, T1, T2, T3>(this IReturnValueConfiguration<Task<T>> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3) =>
        {
            var value = valueProvider(t1, t2, t3);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        ReturnsLazily<T, T1, T2, T3, T4>(this IReturnValueConfiguration<Task<T>> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4) =>
        {
            var value = valueProvider(t1, t2, t3, t4);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4, T5}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, T5, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        ReturnsLazily<T, T1, T2, T3, T4, T5>(this IReturnValueConfiguration<Task<T>> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T5, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) =>
        {
            var value = valueProvider(t1, t2, t3, t4, t5);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4, T5, T6}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, T5, T6, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        ReturnsLazily<T, T1, T2, T3, T4, T5, T6>(this IReturnValueConfiguration<Task<T>> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T5, T6, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) =>
        {
            var value = valueProvider(t1, t2, t3, t4, t5, t6);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4, T5, T6, T7}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, T5, T6, T7, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        ReturnsLazily<T, T1, T2, T3, T4, T5, T6, T7>(this IReturnValueConfiguration<Task<T>> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T5, T6, T7, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) =>
        {
            var value = valueProvider(t1, t2, t3, t4, t5, t6, t7);

            setter(value);

            return value;
        });
    }

    /// <inheritdoc cref="ReturnValueConfigurationExtensions.ReturnsLazily{TReturnType, T1, T2, T3, T4, T5, T6, T7, T8}(IReturnValueConfiguration{Task{TReturnType}}, Func{T1, T2, T3, T4, T5, T6, T7, T8, TReturnType})"/>>
    /// <param name="proxy">The value returned by <paramref name="valueProducer"/></param>
    public static IAfterCallConfiguredWithOutAndRefParametersConfiguration<IReturnValueConfiguration<Task<T>>>
        ReturnsLazily<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IReturnValueConfiguration<Task<T>> configuration, out Proxy<T> proxy, Func<T1, T2, T3, T4, T5, T6, T7, T8, T> valueProvider)
    {
        proxy = new Proxy<T>();

        Action<T> setter = proxy.SetValue;

        return configuration.ReturnsLazily((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) =>
        {
            var value = valueProvider(t1, t2, t3, t4, t5, t6, t7, t8);

            setter(value);

            return value;
        });
    }
}