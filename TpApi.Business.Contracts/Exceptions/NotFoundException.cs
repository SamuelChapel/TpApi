namespace TpApi.Business.Contracts.Exceptions;

public class NotFoundException(string? message) : Exception(message)
{
}
