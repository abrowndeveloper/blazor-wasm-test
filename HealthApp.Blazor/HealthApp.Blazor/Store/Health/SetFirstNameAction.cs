namespace HealthApp.Blazor.Store.Health
{
    public readonly record struct SetFirstNameAction
    {
        public string FirstName { get; } = "";

        public SetFirstNameAction(string firstName)
        {
            FirstName = firstName;
        }
    }
}
