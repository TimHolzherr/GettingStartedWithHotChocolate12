public class AuthorNotFoundException : DomainException
{
    public AuthorNotFoundException() { }

    public AuthorNotFoundException(string? message) : base(message) { }

    public AuthorNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }
}

public class DomainException : Exception
{
    public DomainException() { }

    public DomainException(string? message) : base(message) { }

    public DomainException(string? message, Exception? innerException) : base(message, innerException) { }
}