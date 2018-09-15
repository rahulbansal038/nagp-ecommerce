using System;

namespace AmCart.Domain
{
    public interface IDomain
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        Guid Id { get; }
        
        /// <summary>
        /// Gets or sets the current state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        DomainStateType DomainState { get; set; }
    }
}
