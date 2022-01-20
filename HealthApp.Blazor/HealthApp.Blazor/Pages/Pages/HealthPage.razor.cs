using Fluxor;
using Microsoft.AspNetCore.Components;
using HealthApp.Blazor.Store.Health;

namespace HealthApp.Blazor.Pages.Pages
{
    public partial class HealthPage
    {
        [Inject]
        private IState<HealthState>? HealthState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private void SetFirstName(ChangeEventArgs changeEvent)
        {
            var action = new SetFirstNameAction(changeEvent.Value?.ToString() ?? "");

            Dispatcher.Dispatch(action);
        }
    }
}
