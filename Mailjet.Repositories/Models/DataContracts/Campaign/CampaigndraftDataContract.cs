using Mailjet.Client;
using Mailjet.Repositories.Models.MailJet.DataContracts.Base;
using System.Runtime.Serialization;

namespace Mailjet.Repositories.Models.DataContracts.Campaign
{
    [DataContract]
    public class CampaigndraftDataContract : PagingRequestBaseDataContract
    {
        [DataMember]
        public string AXFractionName { get; set; }
        [DataMember]
        public string AXTesting { get; set; }
        [DataMember]
        public string Campaign { get; set; }
        [DataMember]
        public string ContactsListID { get; set; }
        [DataMember]
        public string CreatedAt { get; set; }
        [DataMember]
        public string Current { get; set; }
        [DataMember]
        public string DeliveredAt { get; set; }
        [DataMember]
        public string EditMode { get; set; }
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string IsStarred { get; set; }
        [DataMember]
        public string IsTextPartIncluded { get; set; }
        [DataMember]
        public string Locale { get; set; }
        [DataMember]
        public string ModifiedAt { get; set; }
        [DataMember]
        public string Preset { get; set; }
        [DataMember]
        public string ReplyEmail { get; set; }
        [DataMember]
        public string Segmentation { get; set; }
        [DataMember]
        public string Sender { get; set; }
        [DataMember]
        public string SenderEmail { get; set; }
        [DataMember]
        public string SenderName { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Template { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Url { get; set; }
        [DataMember]
        public string Used { get; set; }
        [DataMember]
        public string IsArchived { get; set; }
        [DataMember]
        public string IsCampaign { get; set; }
        [DataMember]
        public string IsDeleted { get; set; }
        [DataMember]
        public string IsHandled { get; set; }
        [DataMember]
        public string Modified { get; set; }
        [DataMember]
        public string NewsLetterTemplate { get; set; }
    }
}

