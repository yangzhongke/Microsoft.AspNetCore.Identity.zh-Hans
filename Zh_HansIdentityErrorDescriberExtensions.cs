using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Identity
{
    public static class Zh_HansIdentityErrorDescriberExtensions
    {
        public static IdentityBuilder AddZh_HansIdentityErrorDescriber(this IdentityBuilder builder)
        {
            return builder.AddErrorDescriber<Zh_HansIdentityErrorDescriber>();
        }
    }
}
