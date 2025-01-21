using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications;
public class DeveloperWithAddressSpecification : BaseSpecifcation<Developer>
{
    public DeveloperWithAddressSpecification(int years) : base(x => x.EstimatedIncome > years)
    {
        AddInclude(x => x.Address!);
    }
}