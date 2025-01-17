﻿using Mailjet.Repositories.Interfaces.Bases;
using Mailjet.Repositories.Models.DataContracts.Contact;
using Mailjet.Repositories.Models.MailJet;
using Mailjet.Repositories.Models.MailJet.DataContracts;
using Mailjet.Repositories.Models.MailJet.DataContracts.Base;
using Mailjet.Repositories.Models.MailJet.DataContracts.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mailjet.Repositories.Interfaces
{
    public interface IContactRepository : IRepositoryCreate<ContactDataContract, ContactCreateDataContract>,
        IRepositoryRead<ContactDataContract, Int64>,
        IRepositoryRead<ContactDataContract, String>,
        IRepositoryList<ContactDataContract, PagingRequestBaseDataContract>,
        IRepositoryUpdate<ContactDataContract>, 
        IRepositoryDelete<ContactDataContract, Int64>
    {
        IList<ContactDataContract> ListByContacsList(long iD);
  
    }
}