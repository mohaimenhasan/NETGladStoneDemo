using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using System.Diagnostics;

namespace MohaimensCoolExtensionEntry
{
    /// <summary>
    /// MohaimenCustomCommand handler.
    /// </summary>
    [VisualStudioContribution]
    internal class MohaimenCustomCommand : Command
    {
        private readonly TraceSource logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="MohaimenCustomCommand"/> class.
        /// </summary>
        /// <param name="traceSource">Trace source instance to utilize.</param>
        public MohaimenCustomCommand(TraceSource traceSource)
        {
            // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
            // other services here as well.
            this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        }

        /// <inheritdoc />
        public override CommandConfiguration CommandConfiguration => new("%MohaimensCoolExtensionEntry.MohaimenCustomCommand.DisplayName%")
        {
            // Use this object initializer to set optional parameters for the command. The required parameter,
            // displayName, is set above. DisplayName is localized and references an entry in .vsextension\string-resources.json.
            Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
            Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
        };

        /// <inheritdoc />
        public override Task InitializeAsync(CancellationToken cancellationToken)
        {
            // Use InitializeAsync for any one-time setup or initialization.
            return base.InitializeAsync(cancellationToken);
        }

        /// <inheritdoc />
        public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
        {
            await this.Extensibility.Shell().ShowPromptAsync("Hello from Mohaimen Extension!", 
                PromptOptions.OK,
                cancellationToken);
        }
    }
}
