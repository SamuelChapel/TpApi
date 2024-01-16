namespace TpApi.Business.Contracts.Exceptions;

public class BadRequestException(string? message) : Exception(message)
{
}
