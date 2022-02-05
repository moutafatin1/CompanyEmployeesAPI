
namespace Entities.Exceptions;

public sealed class IdsParamatersBadRequestException : BadRequestException
{
    public IdsParamatersBadRequestException() : base("Parameter ids is null")
    {

    }
}
