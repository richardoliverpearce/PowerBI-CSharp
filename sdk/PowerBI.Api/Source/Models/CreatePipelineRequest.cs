// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request to create a new deployment pipeline
    /// </summary>
    public partial class CreatePipelineRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreatePipelineRequest class.
        /// </summary>
        public CreatePipelineRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreatePipelineRequest class.
        /// </summary>
        /// <param name="displayName">The display name of the newly created
        /// deployment pipeline</param>
        /// <param name="description">The description of the newly created
        /// deployment pipeline</param>
        public CreatePipelineRequest(string displayName, string description = default(string))
        {
            DisplayName = displayName;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the newly created deployment
        /// pipeline
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the newly created deployment
        /// pipeline
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 256);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 1024)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 1024);
                }
            }
        }
    }
}
