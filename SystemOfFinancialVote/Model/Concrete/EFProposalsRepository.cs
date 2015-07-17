using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
{
    public class EFProposalsRepository:IProposalsRepository
    {
        SystemOfFinancialContext _context=new SystemOfFinancialContext();

        public IQueryable<Proposal> Proposals
        {
            get { return _context.Proposals; }
        }

        public void AddProposals(Proposal proposal)
        {
            throw new NotImplementedException();
        }

        public Proposal RemoveProposal(int proposalId)
        {
            throw new NotImplementedException();
        }
    }
}
