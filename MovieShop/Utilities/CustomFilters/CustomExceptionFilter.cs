using Microsoft.AspNetCore.Mvc.Filters;

namespace MovieShop.Utilities.CustomFilters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly ILogger logger;

        public CustomExceptionFilter(ILoggerFactory logger)
        {
            this.logger = logger.CreateLogger<CustomExceptionFilter>();
        }

        public void OnException(ExceptionContext context)
        {
            logger.LogError(context.Exception.Message);
        }
    }
}
