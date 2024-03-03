using System.Linq;

namespace Outs.FakeItEasy;

public class Sequence {

    public static Sequence<T> Add<T>(out T result, T value)
    {
        result = value;

        return new Sequence<T>( value );
    }

    public static Sequence<T> Add<T>(T value) {
        return new Sequence<T>( value );
    }

    public static Sequence<TIntermediate, TTransformed> WithTransfomer<TIntermediate, TTransformed>( Func<TIntermediate, TTransformed> transform ) {
        return new Sequence<TIntermediate, TTransformed>( null, transform );
    }
}

public class Sequence<T> {
    internal List<T> values;

    internal Sequence( T value ) {
        this.values = new List<T>() {  value};
    }

    public Sequence<T> Add(T value) {
        this.values.Add( value );

        return this;
    }

    public Sequence<T> Add(out T result, T value) {
        result = value;

        this.values.Add( result );

        return this;
    }

    public Sequence<T> Add( Func<T> valueFactory) {
        var result = valueFactory();

        this.values.Add( result );

        return this;
    }

    public Sequence<T> Add(out T result, Func<T> valueFactory) {
        result = valueFactory();

        this.values.Add( result );

        return this;
    }

    public Sequence<T> Add<TIntermediate>(out TIntermediate result, Func<TIntermediate> valueFactory, Func<TIntermediate, T> transform) {
        result = valueFactory();

        this.values.Add( transform( result ) );

        return this;
    }

    public Sequence<T> Add<TIntermediate>(Func<TIntermediate> valueFactory, Func<TIntermediate, T> transform) {
        var result = valueFactory();

        this.values.Add( transform( result ) );

        return this;
    }

    public Sequence<T, TTransformed> WithTransfomer<TTransformed>( Func<T, TTransformed> transform ) {
        return new  Sequence<T, TTransformed> ( this.values, transform );
    }

    public T[] ToArray() {
        return this.values.ToArray();
    }
}

public class Sequence<TIntermediate, TTransformed> {
    internal List<TIntermediate> values;
    private Func<TIntermediate, TTransformed> transformer;

    internal Sequence( List<TIntermediate>? values, Func<TIntermediate, TTransformed> transform) {
        this.values = values ?? new List<TIntermediate>();
        this.transformer = transform;
    }


    public Sequence<TIntermediate, TTransformed> Add(TIntermediate value) {
        this.values.Add( value );

        return this;
    }

    public Sequence<TIntermediate, TTransformed> Add(out TIntermediate result, TIntermediate value) {
        result = value;

        this.values.Add( result );

        return this;
    }

    public Sequence<TIntermediate, TTransformed> Add( Func<TIntermediate> valueFactory) {
        var result = valueFactory();

        this.values.Add( result );

        return this;
    }

    public Sequence<TIntermediate, TTransformed> Add(out TIntermediate result, Func<TIntermediate> valueFactory) {
        result = valueFactory();

        this.values.Add( result );

        return this;
    }

    public TTransformed[] ToArray() {
        return this.values.Select( this.transformer ).ToArray();
    }
}
