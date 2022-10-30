using Fathy.Common.Startup;

namespace Portfolio.Utilities;

public static class ErrorsList
{
    public static Error BlobNotFound(string name) => new(StatusCodes.Status404NotFound, nameof(BlobNotFound),
        $"There is no file with this name {name}.");
}