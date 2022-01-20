using Fluxor;

namespace HealthApp.Blazor.Store.Health
{
    public static class Reducers
    {
        [ReducerMethod]
        public static HealthState HandleSetFirstNameAction(HealthState state, SetFirstNameAction action) =>
          new HealthState(action.FirstName, state.LastName);
    }
}
