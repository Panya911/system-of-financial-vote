using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.Abstract
{
    public interface IProposalsRepository
    {
        IQueryable<Proposal> Proposals { get; }
        
        void AddProposals(Proposal proposal);
        Proposal RemoveProposal(int proposalId);
    }
}
