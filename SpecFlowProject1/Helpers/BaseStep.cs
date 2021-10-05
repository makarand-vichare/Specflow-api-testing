using System.Net.Http;

namespace SpecFlowProject1.Helpers
{
    public abstract class BaseStep
    {
        protected HttpClient GetHttpClient(bool attachUser)
        {
            if (attachUser)
            {
                return SpecFlowIoc.GetInstance<HttpClient>("httpClientWithUser1");
            }

            return SpecFlowIoc.GetInstance<HttpClient>("httpClientWithUser2");
        }
    }
}
