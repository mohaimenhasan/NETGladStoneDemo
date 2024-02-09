using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

namespace MohaimensCoolExtensionEntry
{
    /// <summary>
    /// Extension entrypoint for the VisualStudio.Extensibility extension.
    /// </summary>
    [VisualStudioContribution]
    internal class ExtensionEntrypoint : Extension
    {
        /// <inheritdoc/>
        public override ExtensionConfiguration ExtensionConfiguration => new()
        {
            Metadata = new(
                    id: "MohaimensCoolExtensionEntry.7e282802-599a-4816-93f6-28501d650d00",
                    version: this.ExtensionAssemblyVersion,
                    publisherName: "Mohaimen",
                    displayName: "MohaimensCoolExtensionEntry",
                    description: "Mohaimens version of the Visual Studio Extensibility demo"),
        };

        /// <inheritdoc />
        protected override void InitializeServices(IServiceCollection serviceCollection)
        {
            base.InitializeServices(serviceCollection);

            // You can configure dependency injection here by adding services to the serviceCollection.
        }
    }
}
