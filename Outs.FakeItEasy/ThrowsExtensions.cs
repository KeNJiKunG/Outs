using FakeItEasy;
using FakeItEasy.Configuration;
using FakeItEasy.Core;
using Outs.Core;

namespace Outs.FakeItEasy;

public static class ThrowsExtensions
{
    /// <inheritdoc cref="ExceptionThrowerConfigurationExtensions.Throws{TInterface}(IExceptionThrowerConfiguration{TInterface}, Exception)"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out TException exception,
            TException value
    )
        where TException : Exception
    {
        exception = value;

        return configuration.Throws(value);
    }

    /// <inheritdoc cref="ExceptionThrowerConfigurationExtensions.Throws{TInterface}(IExceptionThrowerConfiguration{TInterface}, Func{Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws(() =>
        {
            var exception = valueProvider();

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="IExceptionThrowerConfiguration{TInterface}.Throws(Func{IFakeObjectCall, Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<IFakeObjectCall, TException> exceptionFactory
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws((IFakeObjectCall fakeObjectCall) =>
        {
            var exception = exceptionFactory(fakeObjectCall);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="IExceptionThrowerConfiguration{TInterface}.Throws{T1}(Func{T1, Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException, T1>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<T1, TException> exceptionFactory
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws((T1 t1) =>
        {
            var exception = exceptionFactory(t1);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="IExceptionThrowerConfiguration{TInterface}.Throws{T1, T2}(Func{T1, T2, Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException, T1, T2>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, TException> exceptionFactory
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws((T1 t1, T2 t2) =>
        {
            var exception = exceptionFactory(t1, t2);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="IExceptionThrowerConfiguration{TInterface}.Throws{T1, T2, T3}(Func{T1, T2, T3, Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException, T1, T2, T3>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, TException> exceptionFactory
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws((T1 t1, T2 t2, T3 t3) =>
        {
            var exception = exceptionFactory(t1, t2, t3);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="IExceptionThrowerConfiguration{TInterface}.Throws{T1, T2, T3, T4}(Func{T1, T2, T3, T4, Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException, T1, T2, T3, T4>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, TException> exceptionFactory
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws((T1 t1, T2 t2, T3 t3, T4 t4) =>
        {
            var exception = exceptionFactory(t1, t2, t3, t4);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="IExceptionThrowerConfiguration{TInterface}.Throws{T1, T2, T3, T4, T5}(Func{T1, T2, T3, T4, T5, Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException, T1, T2, T3, T4, T5>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, TException> exceptionFactory
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) =>
        {
            var exception = exceptionFactory(t1, t2, t3, t4, t5);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="IExceptionThrowerConfiguration{TInterface}.Throws{T1, T2, T3, T4, T5, T6}(Func{T1, T2, T3, T4, T5, T6, Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException, T1, T2, T3, T4, T5, T6>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, T6, TException> exceptionFactory
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) =>
        {
            var exception = exceptionFactory(t1, t2, t3, t4, t5, t6);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="IExceptionThrowerConfiguration{TInterface}.Throws{T1, T2, T3, T4, T5, T6, T7}(Func{T1, T2, T3, T4, T5, T6, T7, Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException, T1, T2, T3, T4, T5, T6, T7>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, T6, T7, TException> exceptionFactory
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) =>
        {
            var exception = exceptionFactory(t1, t2, t3, t4, t5, t6, t7);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="IExceptionThrowerConfiguration{TInterface}.Throws{T1, T2, T3, T4, T5, T6, T7, T8}(Func{T1, T2, T3, T4, T5, T6, T7, T8, Exception})"/>
    public static IAfterCallConfiguredConfiguration<TInterface>
        Throws<TInterface, TException, T1, T2, T3, T4, T5, T6, T7, T8>(
            this IExceptionThrowerConfiguration<TInterface> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TException> exceptionFactory
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return configuration.Throws((T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) =>
        {
            var exception = exceptionFactory(t1, t2, t3, t4, t5, t6, t7, t8);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync(IReturnValueConfiguration{Task}, Exception)"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out TException exception,
            TException value
    )
        where TException : Exception
    {
        exception = value;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, value);
    }


    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync(IReturnValueConfiguration{Task}, Func{Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, () =>
        {
            var exception = valueProvider();

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync(IReturnValueConfiguration{Task}, Func{IFakeObjectCall, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<IFakeObjectCall, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (IFakeObjectCall fakeObjectCall) =>
        {
            var exception = valueProvider(fakeObjectCall);

            setter(exception);

            return exception;
        });
    }


    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T}(IReturnValueConfiguration{Task{T}}, Func{IFakeObjectCall, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<IFakeObjectCall, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (IFakeObjectCall fakeObjectCall) =>
        {
            var exception = valueProvider(fakeObjectCall);

            setter(exception);

            return exception;
        });
    }


    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T}(IReturnValueConfiguration{Task{T}}, Exception)"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out TException exception,
            TException value
    )
        where TException : Exception
    {
        exception = value;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, value);
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T}(IReturnValueConfiguration{Task{T}}, Func{Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, () =>
        {
            var exception = valueProvider();

            setter(exception);

            return exception;
        });
    }


    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T, T1}(IReturnValueConfiguration{Task{T}}, Func{T1, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, T1, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<T1, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1) =>
        {
            var exception = valueProvider(t1);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T, T1, T2}(IReturnValueConfiguration{Task{T}}, Func{T1, T2, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, T1, T2, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2) =>
        {
            var exception = valueProvider(t1, t2);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T, T1, T2, T3}(IReturnValueConfiguration{Task{T}}, Func{T1, T2, T3, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, T1, T2, T3, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3) =>
        {
            var exception = valueProvider(t1, t2, t3);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T, T1, T2, T3, T4}(IReturnValueConfiguration{Task{T}}, Func{T1, T2, T3, T4, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, T1, T2, T3, T4, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4) =>
        {
            var exception = valueProvider(t1, t2, t3, t4);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T, T1, T2, T3, T4, T5}(IReturnValueConfiguration{Task{T}}, Func{T1, T2, T3, T4, T5, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, T1, T2, T3, T4, T5, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) =>
        {
            var exception = valueProvider(t1, t2, t3, t4, t5);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T, T1, T2, T3, T4, T5, T6}(IReturnValueConfiguration{Task{T}}, Func{T1, T2, T3, T4, T5, T6, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, T1, T2, T3, T4, T5, T6, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, T6, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) =>
        {
            var exception = valueProvider(t1, t2, t3, t4, t5, t6);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T, T1, T2, T3, T4, T5, T6, T7}(IReturnValueConfiguration{Task{T}}, Func{T1, T2, T3, T4, T5, T6, T7, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, T1, T2, T3, T4, T5, T6, T7, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, T6, T7, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) =>
        {
            var exception = valueProvider(t1, t2, t3, t4, t5, t6, t7);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T, T1, T2, T3, T4, T5, T6, T7, T8}(IReturnValueConfiguration{Task{T}}, Func{T1, T2, T3, T4, T5, T6, T7, T8, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task<T>>>
        ThrowsAsync<T, T1, T2, T3, T4, T5, T6, T7, T8, TException>(
            this IReturnValueConfiguration<Task<T>> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) =>
        {
            var exception = valueProvider(t1, t2, t3, t4, t5, t6, t7, t8);

            setter(exception);

            return exception;
        });
    }


    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T1}(IReturnValueConfiguration{Task}, Func{T1, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T1, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<T1, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1) =>
        {
            var exception = valueProvider(t1);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T1, T2}(IReturnValueConfiguration{Task}, Func{T1, T2, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T1, T2, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2) =>
        {
            var exception = valueProvider(t1, t2);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T1, T2, T3}(IReturnValueConfiguration{Task}, Func{T1, T2, T3, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T1, T2, T3, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3) =>
        {
            var exception = valueProvider(t1, t2, t3);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T1, T2, T3, T4}(IReturnValueConfiguration{Task}, Func{T1, T2, T3, T4, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T1, T2, T3, T4, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4) =>
        {
            var exception = valueProvider(t1, t2, t3, t4);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T1, T2, T3, T4, T5}(IReturnValueConfiguration{Task}, Func{T1, T2, T3, T4, T5, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T1, T2, T3, T4, T5, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) =>
        {
            var exception = valueProvider(t1, t2, t3, t4, t5);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T1, T2, T3, T4, T5, T6}(IReturnValueConfiguration{Task}, Func{T1, T2, T3, T4, T5, T6, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T1, T2, T3, T4, T5, T6, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, T6, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) =>
        {
            var exception = valueProvider(t1, t2, t3, t4, t5, t6);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T1, T2, T3, T4, T5, T6, T7}(IReturnValueConfiguration{Task}, Func{T1, T2, T3, T4, T5, T6, T7, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T1, T2, T3, T4, T5, T6, T7, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, T6, T7, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) =>
        {
            var exception = valueProvider(t1, t2, t3, t4, t5, t6, t7);

            setter(exception);

            return exception;
        });
    }

    /// <inheritdoc cref="AsyncReturnValueConfigurationExtensions.ThrowsAsync{T1, T2, T3, T4, T5, T6, T7, T8}(IReturnValueConfiguration{Task}, Func{T1, T2, T3, T4, T5, T6, T7, T8, Exception})"/>
    public static IAfterCallConfiguredConfiguration<IReturnValueConfiguration<Task>>
        ThrowsAsync<T1, T2, T3, T4, T5, T6, T7, T8, TException>(
            this IReturnValueConfiguration<Task> configuration,
            out Proxy<TException> proxy,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TException> valueProvider
    )
        where TException : Exception
    {
        proxy = new Proxy<TException>();

        var setter = proxy.SetValue;

        return AsyncReturnValueConfigurationExtensions.ThrowsAsync(configuration, (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) =>
        {
            var exception = valueProvider(t1, t2, t3, t4, t5, t6, t7, t8);

            setter(exception);

            return exception;
        });
    }
}