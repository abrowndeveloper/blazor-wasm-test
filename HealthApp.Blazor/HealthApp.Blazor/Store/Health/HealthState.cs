using Fluxor;

namespace HealthApp.Blazor.Store.Health
{
    [FeatureState]
    public record HealthState
    {
        public string FirstName { get; } = "";
        public string LastName { get; } = "";

        private HealthState() {}

        public HealthState
        (
            string firstName,
            string lastName
        )
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
