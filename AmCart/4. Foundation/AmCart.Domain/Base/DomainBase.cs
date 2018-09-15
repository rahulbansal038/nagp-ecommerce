﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmCart.Domain
{
    public class DomainBase : IDomain
    {
        #region Ctor
        public DomainBase()
        {
            this.Id = Guid.NewGuid();
            this.ModifiedOn = DateTimeOffset.Now;
        }

        #endregion

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the created on date.
        /// </summary>
        /// <value>
        /// The created on date.
        /// </value>
        public DateTimeOffset CreatedOn { get; set; }

        /// <summary>
        /// Gets the modified on date.
        /// </summary>
        /// <value>
        /// The modified on date.
        /// </value>
        public DateTimeOffset ModifiedOn { get; set; }

        /// <summary>
        /// Gets the created by user identifier.
        /// </summary>
        /// <value>
        /// The created by user identifier.
        /// </value>
        public Guid CreatedBy { get; private set; }

        /// <summary>
        /// Gets the modified by user identifier.
        /// </summary>
        /// <value>
        /// The modified by user identifier.
        /// </value>
        public Guid ModifiedBy { get; set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        [ConcurrencyCheck]
        [Timestamp]
        public byte[] Version { get; set; }

        /// <summary>
        /// Gets or sets the row version.
        /// </summary>
        /// <value>The row version.</value>
        //[ConcurrencyCheck]
        //[Timestamp]
        //public byte[] RowVersion { get; set; }

        /// <summary>
        /// Gets or sets the state of the entity.
        /// </summary>
        /// <value>The state of the entity.</value>
        [NotMapped]
        public DomainStateType DomainState { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is deleted.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is deleted; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the IsActive.
        /// </summary>
        /// <value>The IsActive.</value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Determines whether the specified object is valid.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>
        /// A collection that holds failed-validation information.
        /// </returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            IEnumerable<ValidationResult> validationResults = this.Validate();

            if (validationResults == null)
            {
                switch (this.DomainState)
                {
                    case DomainStateType.Added:
                        validationResults = this.OnValidateWhileCreate();
                        break;
                    case DomainStateType.Modified:
                        validationResults = this.OnValidateWhileUpdate();
                        break;
                    case DomainStateType.Deleted:
                        validationResults = this.OnValidateWhileDelete();
                        break;

                }
            }

            return validationResults;
        }

        /// <summary>
        /// Called when [validate while create].
        /// </summary>
        /// <returns></returns>
        /// <devnote>Not an abstract method since child entities may not have any validation to do.</devnote>
        protected virtual IEnumerable<ValidationResult> OnValidateWhileCreate()
        {
            return null;
        }

        /// <summary>
        /// Called when [validate while update].
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerable<ValidationResult> OnValidateWhileUpdate()
        {
            return null;
        }

        /// <summary>
        /// Called when [validate while delete].
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerable<ValidationResult> OnValidateWhileDelete()
        {
            return null;
        }

        /// <summary>
        /// Called when [validate always].
        /// </summary>
        /// <returns></returns>
        private IEnumerable<ValidationResult> Validate()
        {
            //todo: validation logic which must run in all cases on common properties
            return null;
        }
    }
}
