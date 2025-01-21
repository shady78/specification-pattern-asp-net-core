using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications;
public class DeveloperByIncomeSpecification : BaseSpecifcation<Developer>
{
    public DeveloperByIncomeSpecification()
    {
        AddOrderByDescending(x => x.EstimatedIncome!);
    }
}