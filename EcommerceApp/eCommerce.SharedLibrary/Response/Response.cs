namespace eCommerce.SharedLibrary.Response
{
    public record Response<T>(bool Flag = false, string Message = null!);

}
