
namespace Entities.Exceptions;

public class MaxAgeRangeBadRequestExeption : BadRequestException
{
    public MaxAgeRangeBadRequestExeption() : base("Max Age can't be less than min age.")
    {

    }
}
