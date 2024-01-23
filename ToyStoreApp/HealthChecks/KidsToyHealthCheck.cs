using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ToyStore.HealthChecks
{
    public class KidsToyHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            // throw new NotImplementedException();

            var isHealthy = false;

            if (isHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy(" Yay! All the toys are happy and ready to play! "));
            }

            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, " Oh no! Some toys are not feeling well. Time to fix them! "));
        }
    }
}
