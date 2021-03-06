// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Graph;
    using Microsoft.Azure.Graph.RBAC;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request parameters for adding a member to a group.
    /// </summary>
    public partial class GroupAddMemberParameters
    {
        /// <summary>
        /// Initializes a new instance of the GroupAddMemberParameters class.
        /// </summary>
        public GroupAddMemberParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupAddMemberParameters class.
        /// </summary>
        /// <param name="url">A member object URL, such as
        /// "https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd",
        /// where "0b1f9851-1bf0-433f-aec3-cb9272f093dc" is the tenantId and
        /// "f260bbc4-c254-447b-94cf-293b5ec434dd" is the objectId of the
        /// member (user, application, servicePrincipal, group) to be
        /// added.</param>
        public GroupAddMemberParameters(string url)
        {
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a member object URL, such as
        /// "https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd",
        /// where "0b1f9851-1bf0-433f-aec3-cb9272f093dc" is the tenantId and
        /// "f260bbc4-c254-447b-94cf-293b5ec434dd" is the objectId of the
        /// member (user, application, servicePrincipal, group) to be added.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
