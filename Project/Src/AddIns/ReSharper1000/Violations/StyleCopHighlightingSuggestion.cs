// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StyleCopHighlightingSuggestion.cs" company="http://stylecop.codeplex.com">
//   MS-PL
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
// <summary>
//   Highlighting class for a StyleCop Violation set to severity level Suggestion.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace StyleCop.ReSharper1000.Violations
{
    using JetBrains.DocumentModel;
    using JetBrains.ReSharper.Feature.Services.Daemon;

    /// <summary>
    /// Highlighting class for a StyleCop Violation set to severity level Suggestion.
    /// </summary>
    [StaticSeverityHighlighting(ViolationSeverity, "StyleCop")]
    public class StyleCopHighlightingSuggestion : StyleCopHighlightingBase
    {
        /// <summary>
        /// The Violation severity.
        /// </summary>
        private const Severity ViolationSeverity = Severity.SUGGESTION;

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleCopHighlightingSuggestion"/> class.
        /// </summary>
        /// <param name="violationEventArgs">
        /// The <see cref="StyleCop.ViolationEventArgs"/> instance containing the event data.
        /// </param>
        /// <param name="documentRange">
        /// Range where the Violation happened.
        /// </param>
        public StyleCopHighlightingSuggestion(ViolationEventArgs violationEventArgs, DocumentRange documentRange)
            : base(violationEventArgs, documentRange)
        {
        }
    }
}